# Transit Fares

These scenarios allow you to change the public transit fare policy.  This scenario is used in order
to create a transit hyper-network used for fare based congested transit assignment.


> [!Tip]
> In GTAModel V4 input data is organized into the _Scenario folders_ with the following structure,
> _Scenario-Directory_/_RunYear_/_ScenarioName_.

## Contained Files


* Fare Rules.xml
* York_Region_Zones
    * York_Region_Zones.dbf
    * York_Region_Zones.prj
    * York_Region_Zones.sbn
    * York_Region_Zones.sbx
    * York_Region_Zones.shp
    * York_Region_Zones.shx

### Fare Rules.xml

This [Fare Rules.xml file](../file_formats/fare_schema_file_specification.md) contains a
set of policies that allows you to generate costs for:

* Initial Boarding
* Transfers
* Zone Crossings
* In-Vehicle Distances

### York_Region_Zones

This [shapefile](https://en.wikipedia.org/wiki/Shapefile) provides the boundaries for the 
three fare zones for York Region.  This file is references in the standard 2011 and 2016
`Fare Rules.xml` files from TMG.

## Creating a New Scenario

To create a new scenario the first thing you would do is clone an existing scenario, preferably
from the same year that you are wanting to simulate, and then edit the `Fare Rules.xml` file.

The changes that you would make are going to be very specific to the scenario at hand, but for
an example let's reduce the price of the DRT by 10%.

Below is the V4.2 2016 definition for DRT.  We have an initial boarding cost of $2.06 (in 2016$).

```xml
    <!-- Durham Transit -->
    <fare cost="2.06" type="initial_boarding">
    	<group>DRT</group>
    </fare>
	<fare cost="-1.41" type="transfer">
		<from_group>DRT</from_group>
		<to_group>GO Transit</to_group>
		<bidirectional>True</bidirectional>
	</fare>
```

Reducing the initial boarding by 10% we would get:

```xml
    <!-- Durham Transit -->
    <fare cost="1.854" type="initial_boarding">
    	<group>DRT</group>
    </fare>
	<fare cost="-1.41" type="transfer">
		<from_group>DRT</from_group>
		<to_group>GO Transit</to_group>
		<bidirectional>True</bidirectional>
	</fare>
```

This however leaves open the question about how we would deal with transfers to and from GO Rail.
With the reduced fare price, we often scale back the discount by the same ratio.

```xml
    <!-- Durham Transit -->
    <fare cost="1.854" type="initial_boarding">
    	<group>DRT</group>
    </fare>
	<fare cost="-1.269" type="transfer">
		<from_group>DRT</from_group>
		<to_group>GO Transit</to_group>
		<bidirectional>True</bidirectional>
	</fare>
```


When building your fare policy, you will need to make sure that there are no links with
negative costs.  **If the network does end up with negative costs the model system will crash.**

> [!Warning]
> Your model is calibrated to a base year.  All costs going into this file need to be inflated/deflated
> into those base year dollars!
