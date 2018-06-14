# Fare Schema File Specification

The new TMG implementation uses a fare schema file, implemented in Extensible Markup Language (XML). XML is a widely-used, hierarchical format which is human-readable. The fare schema file specification prescribes 3 collections of items necessary for generating the hyper-network : <groups>, <zones>, and <fare_rules>.

## Groups

Contains a list of transit line groupings. Conceptually, these groupings can be distinct transit agencies (e.g., TTC, GO Transit), but could also be distinct sub-groups of one agency (e.g. TTC Regular vs. TTC Downtown Express). It is important that ALL transit lines belong to a group to ensure proper behaviour when modelling transit. Also important to note is that each group will become its own “layer” in the hyper network generation procedure. Fewer groups reduces the size of the hyper network which, in trials, have surpassed maximum size allowed by the standard Emme license.

Each group element contains a set of transit line selector expressions (used by Emme’s Network Calculator) to select its lines. Groups are processed IN ORDER, so if a line meets the criteria for multiple groups, it will be assigned to the LAST group in the schema file. Each group must have a unique ID.

```xml
<group id="TTC Regular">
    <selection>line=T_____</selection>
</group>
<group id="TTC DT Express">
    <selection>line=T14___</selection>
</group>
```

## Station Groups (Station Centroids / Psuedozones)

An optional list of station group elements. Each station group element associates a set of network zone centroids with a line group. When doing so, “initial boarding” fare rules will be applied to links going from a station centroid directly to a stop of the associated line group. In this manner, trips departing from station centroids / psuedozones (which are often used in models to permit park-and-ride to transit) will accrue the correct initial boarding fare.

Each element has two attributes: for and selection. The former attribute associates the element with a line group; while the second selects which zones belong to the group. Note that each centroid can only be associated with a single line group; nodes selected more than once will be associated with the last station group loaded.

```xml
<station_group for="GO Transit" selection="i=9700,9800"/>
```

## Zones

An optional element containing a list of fare zones and a list of shapefiles. Each node in the network can be assigned to a single zone. If a node meets the requirements for multiple zones it will be assigned to the LAST zone in the schema file (similar to groups). Each zone must have a unique ID.

Two different types of fare zones are supported: node_selection and from_shapefile.  Node selection zones apply a set of node selector expressions (used by Emme’s Network Calculator). Zones loaded from shapefile reference an FID (feature ID) in one of the included shapefile elements. 

```xml
<shapefile id="1" path="D:/Workspace/08 GTAModel V4/Data/Fares/York_Region_Zones.shp" />
    
    <zone id="Toronto" type="node_selection">
    	<node_selector>i=10000,20000</node_selector>
    </zone>
    <zone id="York 1" type="from_shapefile">
    	<from_shapefile id="1" FID="1" />
    </zone>

```

## Fare Rules

Contains a list of fare rules to be applied to the hyper network once it has been generated. Each fare rule element has an associated cost and type, and sub-elements to determine which links or segments it applied to.

During processing, fare rules are applied in order; with each fare rule’s cost being added to its selected links or transit segments. This is an important distinction, as it allows fare rule costs to be negative, so long as the resulting summed value is greater than zero. 

For example, Hamilton Street Railway (HSR) has an initial fare of $1.65 , with a special “co-fare” of $0.50 to GO Transit, which discounts the initial fare when riders transfer to GO train stations using HSR. To model this, two fare rules are required:

* A fare of $1.65 applied to all links incoming to HSR’s “layer” of the transit network.
* A negative fare of $1.15 applied to links transferring from HSR to GO and from GO to HSR.

So, when egressing from GO to HSR, the on-link fare is $1.65 - $1.15 = $0.50, which is the appropriate co-fare. In the other direction, the discount is actually applied to the access-link to GO Transit, which uses an initial fare of $3.55. This works out to be $3.55 - $1.15 = $2.40; which is the resulting discount for transferring to GO. 

### Initial Boarding Rule (group, [in_zone])

Initial boarding rules have their cost applied to all LINKS inbound to the layer of the specified group. This rule can be further restricted to applying only to links starting from a specified ZONE.

```xml
<fare cost="1.98" type="initial_boarding">
    <group>TTC Regular</group>
</fare>

<fare cost="0.15" type="initial_boarding">
    <group>TTC Regular</group>
    <in_zone>York 1</in_zone>
</fare>
```

### Transfer (from_group, to_group, [bidirectional= False])

Transfer rules have their cost applied to all LINKS connecting one group’s layer to another’s. By default, this rule is applied one-way (to links ‘from’ to ‘to’) but can also be set to bidirectional (also applied to links ‘to’ to ‘from’).

```xml
<fare cost="-2.23" type="transfer">
	<from_group>HSR</from_group>
	<to_group>Burlington Transit</to_group>
</fare>

<fare cost="-1.28" type="transfer">
	<from_group>MiWay</from_group>
	<to_group>GO Transit</to_group>
	<bidirectional>True</bidirectional>
</fare>
```

### Zone Crossing Rule (group, from_zone, to_zone, [bidirectional= False])

Zone crossing rules have their cost applied to all SEGMENTS whose i-node belong to the specified from-zone and whose j-node belong to the specified to-zone, for the specified group. Like transfer rules, they too can be applied in a bidirectional fashion.

```xml

<fare cost="2.13" type="zone_crossing">
    <group>TTC Regular</group>
    <from_zone>Toronto</from_zone>
    <to_zone>York 1</to_zone>
</fare>

<fare cost="1.00" type="zone_crossing">
	<group>YRT</group>
	<from_zone>York 1</from_zone>
	<to_zone>York 2</to_zone>
	<bidirectional>True</bidirectional>
</fare>


```

### Distance In-Vehicle Rule (group)

Distance in-vehicle rules have their cost applied to all SEGMENTS belonging to their specified group. This cost is multiplied by the segment LENGTH attribute (inherited from the segment’s link) – in other words, the cost attribute is specified in $ per km.

```xml

<fare cost="0.0825" type="distance_in_vehicle">
    <group>GO Transit</group>
</fare>

```

# Usage and Performance

This section will cover how to use the above specification to generate new fare scenarios, as well as how to use the FBTN to run transit assignments. 

## Constructing New Fare Scenarios

The fare rule types specified in the Fare Schema File (FSF) can be combined to generate flexible fare scenarios to test. Fare costs are applied to two types of network elements – Links and Transit Segments – saved into user-specified Extra Attributes. Rules in the FSF are applied sequentially and additively; if a link or transit segment meets the criteria for multiple rules, the resulting value will be the sum of the costs. See Section 3.3 for an example of how these rules can be set up.

Internally, the tool indexes Links and Segments while creating the FBTN. Links are indexed into a table whose rows and columns correspond to the group number (where 0 represents the base network). For example, if the TTC is group 1, then the grid at [0, 1] contain all of the links from the base network to the TTC virtual layer. A similar table indexes Segments based on which zones they cross.

This framework leaves room for future extensibility, should new fare rule types be required.

## Limitations

There are limits to the types of fare rules that can be expressed using the above framework. Rules that are time-dynamic, that require information about the time that has elapsed since the beginning of a path, are not possible to model within Emme’s time-static framework. Rules which apply to different classes of passenger (e.g. student and/or senior fares) are not supported by this framework, although it might be possible to model using multiple Emme assignments. Finally, rules which require origin-to-destination information, or access-point-to-egress-point (e.g. GO transit fare zones) are not possible to model without access to the path-building algorithm, which Emme does not provide. However the last rules can be approximated using either in-vehicle distance or using zone-crossing rules.

## Transit Assignment

The generated FBTN is compatible with Emme Transit Assignment tools (Standard, Extended, Congested, etc.), although the Standard Transit Assignment cannot be used to run fare-based transit assignment (FBTA). It is easy enough to configure the Extended Transit Assignment tool (and the others) to run an FBTA: Use the Link Extra Attribute containing transfer fares and an Auxiliary transit cost (with the appropriate perception factor), and use the Transit Segment Extra Attribute containing in-vehicle fares as an In-vehicle cost (with the appropriate perception factor). See Figure 1 below for an example.