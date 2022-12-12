# Network Package (*.nwp) File Format

The network package format is a compressed file with .NWP extension, stores all network elements and information in an Emme scenario. Elements of a network such as modes, nodes and links, turns, transit vehicles, lines, and segments from the Emme database are stored in this format. 

> [!NOTE]
>The NWP file does not contain the strategies used in the transit assignment.

The `NWP` file also ensures that the database attributes, relational integrity, hierarchy, and organization in the network are maintained.


## **Network Attributes**
The `NWP` file can contain three types of network attributes as defined within the Emme database namely:

* Standard attributes - predefined attributes eg. link length
* Extra attributes - user defined attributes eg. @toll, @gate, etc.
* Network assignment result attributes - automatically written to the network after a network assignment is completed, e.g. transit volumes on line segments, auto volumes on turns, etc.

## **Exporting the Network Package File**
`NWP` files can be exported from a scenario using XTMF1 and Emme Modeller, see [documentation](https://tmg.utoronto.ca/doc/1.6/tmgtoolbox/input_output/ExportNetworkPackage.html)

Codes used to export .NWP files from an Emme scenario can be found [here](https://github.com/TravelModellingGroup/TMGToolbox/blob/dev/TMGToolbox/src/input_output/export_network_package.py).

## **Importing the Network Package File**
`NWP` files can be imported into an Emme scenario via XTMF1 and Emme Modeller, see [documentation](https://tmg.utoronto.ca/doc/1.6/tmgtoolbox/input_output/ImportNetworkPackage.html)

The code used to import .NWP files into an Emme scenario can be found [here](https://github.com/TravelModellingGroup/TMGToolbox/blob/dev/TMGToolbox/src/input_output/import_network_update.py).

## **File Specification**
`NWP` files can be "unzipped" using a software package like "7zip" or even windows
(by changing the extension from ".nwp" to ".zip". After unzipping, the individual files
can be examined or even modified according to the end user's goals. The files can be then
be "zipped" again and the extension changed back to ".nwp" for use in the tool. 

> [!CAUTION]
> Manually editing the files in this manner is only recommended for advanced users. 

An `NWP` file at minimum contains the following: 
* aux_transit_results.csv - optional
* base.211 
* exatt_links.241 - optional
* exatt_nodes.241 - optional
* exatt_segments.241 - optional
* exatt_transit_lines.241 - optional
* exatts.241 - optional
* functions.411 
* info.txt 
* link_results.csv - optional
* modes.201 
* segment_results.csv - optional
* shapes.251 
* transit.221 
* turns.231 
* turn_results.csv - optional
* vehicles.202
* version.txt 

For all of the non-extra attribute numbered file extensions they share a common file format.
They are all UTF-8 text files where the first letter of the line gives it meaning.

* c - This line is a comment and you can ignore the rest of the line
* t - The line sets what type of data that follows.
* a - Add data, the columns of which depends on what type of data that is being loaded
* a\* - Add zone centroid.
* m - modify
* d - delete
* r - Remove assigned values for link vertices for the given link.

### aux_transit_results.csv

This optional file is only included in NWP's that contain the results of a transit assignment.  This
CSV file comes with three columns in the given order:

* `i` - The origin node number of the link
* `j` - The destination node number of the link
* `aux_transit_volume` - The amount of people walking on that link

### base.211

The base.211 contains the nodes and links of the network.  

For lines representing nodes it the following columns:
* `Node` - The number of the node, if the second character of the line is `*` then it is a centroid.
* `X-coord` - The X coordinate in UTM
* `Y-coord` - The Y coordinate in UTM
* `Data1` - Internally called ui1, this is not used in GTAModel
* `Data2` - Internally called ui2, this is not used in GTAModel
* `Data3` - Internally called ui3, this is not used in GTAModel
* `Label` - Optional text documentation for the node

For lines representing links it has the following columns:
* `From` - The node number the link originates from.
* `To` - The node number the link terminates at.
* `Length` - The length of the link, in KMs.  This does not have to be the same as the straight line
    distance between the origin and destination nodes.
* `Modes` - The list of auto and transit modes that are allowed to take this link.
* `Typ` - The 'Type' of the link.  We code this where the first 
    digit is the region number, and the last two are the planning district.
* `Lan` - The number of lanes for the link.
* `VDF` - The volume-delay-function index to use when doing road assignment.
* `Data1` - `ul1` Unused in GTAModel.
* `Data2` - `ul2` GTAModel uses this for the free flow speed of the road.
* `Data3` - `ul3` GTAModel uses this for the link's hourly capacity per lane.

For this file whitespace separates the columns.


```
t nodes
c   Node          X-coord          Y-coord   Data1   Data2   Data3 Label
a*     1           636296          4836132       0       0       0 0001
```

```
t links
c   From     To  Length Modes        Typ Lan VDF   Data1   Data2   Data3
a      1  10202 .231191 chijfedHIJKv 101 2.0  90       0      40    9999
```

### exatt_links.241

This file contains the extra attributes for the network's links.  As with all extra attribute
files the particular columns in this file will depend on how your network/model has been setup.
In all cases though, the first two columns will be `inode` and `jnode` giving us the node numbers
for the beginning and end of the link. The remaining columns contain all of the
exported extra attribute values.

For this file columns are separated by commas.

Below is an example row from a GTAModel run:

```
   inode,   jnode, @checked,@gas_cost,@gas_perception,   @lfare,@link_cost,   @lkcap,   @lkspd,@ramp_toll,    @stn1,    @stn2,    @toll,@toll_perception,@toll_zone_1,@toll_zone_2,   @walkp,    @z407,@z407ramp,@ramp_toll_auto,@ramp_toll_light,@ramp_toll_heavy,@toll_zone_1_auto,@toll_zone_1_light,@toll_zone_1_heavy,@toll_zone_2_auto,@toll_zone_2_light,@toll_zone_2_heavy,@toll_auto,@toll_light,@toll_heavy,@auto_volume,@light_volume,@medium_volume,@heavy_volume
       1,   10202,0,0,0,0,0,9999,40,0,0,0,0,0,0,0,3.967,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7.904747,0.06545971,0.1845006,0.02531471
```

### exatt_nodes.241

This file contains the extra attributes for the network's nodes. As with all extra attribute
files the particular columns in this file will depend on how your network/model has been setup.
In all cases though, the first column will be `inode` giving us the node number that these
attributes represent.

For this file columns are separated by commas.

Below is an example row from a GTAModel run:

```
   inode,    @frac,    @gofz,   @hfrac,@stationlabel,    @stop,@transfer
       1,0,0,0.5,0,0,0
```

### exatt_segments.241

This file contains the extra attributes for the network's transit segments.  As with all extra attribute
files the particular columns in this file will depend on how your network/model has been setup.
In all cases though, the first three columns will be `line`, `inode` and `jnode`
giving us the name of the transit line and, node numbers for the beginning and end of the link.
The name of the transit line will be surrounded by single quotes e.g. `'lineName'`.
The remaining columns contain all the exported extra attribute values.


For this file columns are separated by commas.

Below is an example row from a GTAModel run.

```
    line,   inode,   jnode,loop_idx,@erow_speed,   @sfare,   @tstop,@boardings,@alightings,   @ccost
'B001Aa',  110474,  108900,       1,0,0,1,3.300489,0,0.220854
```

### exatt_transit_lines.241

This file contains the extra attributes for the network's transit lines.  As with all extra attribute
files the particular columns in this file will depend on how your network/model has been setup.
In all cases though, the first column will be `line` giving us the name of the transit line.
The name of the transit line will be surrounded by single quotes e.g. `'lineName'`.
The remaining columns contain all the exported extra attribute values.


For this file columns are separated by commas.

Below is an example row from a GTAModel run.

```
    line,   @doors,    @ehdw,@shape_id
'B001Aa',0,17.475,10178
```

### exatts.241

This file, unless the rest of the files starting with exatt, defines the names of all of the extra attributes.  This is done
by enumerating the extra attributes, one per line, with three columns `name`, `type`, and `default`.  There is also a fourth column
that is not named that contains a description for the extra attribute.

* `name` - The name of the extra attribute, no quotes.
* `type` - The type of the extra attribute (`NODE`, `LINK`,`TRANSIT_LINE`, or `TRANSIT_SEGMENT`) without quotes.
* `default` - The default value (floating point number) to assign to the extra attribute.
* (unnamed) - A description, surrounded by quotes, for the extra attribute

For this file columns are separated by commas.

Below is an example row from a GTAModel run:

```
@stationlabel,NODE,0.0,'Station Centroid Label'
```

### functions.411

This file contains all of the volume-delay-functions and transit-segment-time functions. For information about
the format of the volume-delay-functions please consult your EMME documentation. Before any functions can be
defined the line `t functions` must be read in so EMME knows to expect functions.  For GTAModel's specification
the following terms are used:

* `ul2` - The free flow road speed.
* `volau` - The volume on the road link in passenger car equivalent units (PCUs).
* `volad` - Additional volume applied to the link.  GTAModel assumes this is zero.
* `el1` - This will be assigned to the public transit volume running on the link stored in PCUs.
* `lanes` - The number of lanes on the link.
* `ul3` - The capacity per hour per lane of the link.
* `us1` - The speed of the transit vehicle for the particular transit segment.
* `speed` - The assigned transit line speed, one value per line.

Below is an example where the volume-delay-function 11 is assigned.

```
a fd11 =(length * 60 / ul2) * ((1 + put((volau + volad + el1) / (lanes * ul3))
         ^ 6) * (get(1) .le. 1) + (6 * get(1) - 4) * (get(1) .gt. 1))
```

Below is an example of TTF1 being assigned:

```
a ft1  =(length * 60 / us1)
```

### info.txt

This file provides additional information about the NWP.  It contains four lines.
The first line is a user-set description of the network package.
The second line is the file-path of the "emmebank" file that contained the scenario.
The third line is the name of the scenario that the NWP was exported from.
The fourth line is a time-stamp of when it was exported.

### link_results.csv

This file is only generated if the network has had a road assignment executed on it.  It contains results from that assignment,
in particular the `volau`, `volad`, and the auto travel times for each link.  The file has five column `i`, `j`, `auto_volume`,
`additional_volume`, and `auto_time`. The volumes are in passenger car equivalent units (PCUs), and the time is in minutes. `i`
and `j` are the origin and destination nodes respectively.

For this file columns are separated by commas.

### modes.201

This file stores the auto and transit modes that are used in the network.

* `id` - The single character code used for this mode.
* `description` - The name of the mode surrounded by single quotes.
* `mode_type` - (1: Auto Mode, 2: Transit, 3:auxiliary Transit, 4:Auxilalry Auto)
* `colour` - Only used for auto modes or auxiliary transit, not used by GTAModel.
* `cost_time_coeff` - Only used for auto modes or auxiliary transit, not used by GTAModel.
* `cost_distance_coeff` - Only used for auto modes or auxiliary transit, not used by GTAModel.
* `energy_time_coeff` - Only used for auto modes or auxiliary transit, not used by GTAModel.
* `energy_distance_coeff` - Only used for auto modes or auxiliary transit, not used by GTAModel.
* `speed_factor` - Only used for auxiliary transit, the walking speed in KM/h.

For this file columns are separated by whitespace.

Below is an example of the Auto, auxiliary Auto, Transit, and auxiliary transit mode types respectively:

```
a c 'car'      1   1   0.00   0.00   0.00   0.00
a h 'HOV2+'    4   1
a b 'Bus'      2   1
a w 'Walk'     3   1   0.00   0.00   0.00   0.00          4.0
```

### segment_results.csv

This optional file contains the results for each transit segment for scenarios that have completed a transit assignment.  

* `line` - The name of the transit line, no quotes.
* `i` - The node number of where the transit segment starts.
* `j` - The node number of where the transit segment ends.
* `loop` - The 1-indexes number of times that the transit line has passed this link.
* `transit_boardings` - The number of passengers that board the transit vehicle at the i-node of this segment.
* `transit_time` - The time it takes for the transit vehicle to cross the segment.
* `transit_volume` - The total number of transit rides that cross this transit segment.


### shapes.251

This file contains vertices that allow modifying a link's shape. 
This file starts off with some commenting, and then is followed by the command
`t linkvertices` to let EMME know that the following commands will operate on vertices.
Before assigning values to each node a remove command is issued using 
the `r` command followed by the link's origin and destination node numbers separated
by a space. The for each vertex along the link
a row is added using the `a` command followed by the link's origin and destination
node numbers, the 1-indexed index for this vertex, and the X and Y positions to set
for this point.  All columns are separated by spaces.

Below is an example of a line with 4 vertices:

```
r 10003 10021
a 10003 10021 1 618529.2793299129 4829038.890250599
a 10003 10021 2 618733.692422647 4829107.15724172
a 10003 10021 3 618895.0067818061 4829161.03072789
a 10003 10021 4 619215.6329387979 4829268.10891315
```

### transit.221

This file contains the definition for all transit lines and transit segments. It starts
off with the command `t lines` to let EMME know that we are going to be interacting
with the transit lines.

The loading of transit lines is then done in two steps.  The first line adds in
line level information with the columns:

* `Line` - The name of the transit line with single quotes around it e.g. `'B001Aa'`.
* `Mod` - The mode the transit line uses.
* `Veh` - The index in the vehicle table that the line uses.
* `Headwy` - The line's headway in minutes.
* `Speed` - The average speed of the transit line.
* `Description` - A description, with single quotes around it, usually containing the line's name.
* `Data1` - `ut1`, a user defined value that is not currently used in GTAModel.
* `Data2` - `ut2`, a user defined value that is not currently used in GTAModel.
* `Data3` - `ut3`, a user defined value that is not currently used in GTAModel.

```
a'B001Aa' b  12  22.50  18.65 'Queen A'                 0      9      9
```

This entry for the line is then immediately followed by a new line with the text `  path=no` (two spaces in front)
and is then followed by an entry to for each transit segment record with an example below:

```
   110474      dwt=+0.22   ttf=4      us1=30.019   us2=1   us3=0
```

Note that there are three spaces before the first column.  The first column is the index of the origin node index
for the transit segment. The second is the dwell time for the link.  If the dwell time starts with a `+` then people are 
allowed to board at that location.  If the dwell time starts with a `#` then it is does not allow boarding or alighting.

The final row for the segment information only contains the last origin node number, and the amount of time that each bus will spend for
a layover.  An example is below, note that there are three spaces before the origin node number as the rest of the segments:

```
    110469        lay=0.00
```

### turn_results.csv

This file contains will be generated if the exported scenario has a road assignment completed.  It contains the information
about the volume of passenger car equivalent units that take the turn.

* i - The node number for the node where the vehicle comes from going to the intersection.
* j - The node number where the intersection is.
* k - The node number where the turn goes to.
* auto_volume - The auto volume in passenger car equivalent units (PCUs) that take this turn.
* additional_volume - The additional volume in passenger car equivalent units (PCUs) that take this turn, GTAModel does not use this.
* auto_time - 0 if the turn is allowed, -1 if the turn is not allowed.

### turns.231

This file contains the definition of turns in the network.
 
* `At` - The node number for the node where the vehicle comes from going to the intersection.
* `From` - The node number where the intersection is.
* `To` - The node number where the turn goes to.
* `TPF` - The turning penalty function to use.  0 if there is no penalty, -1 if there are no turns allowed, and 
* `Data1` - `up1`, a user defined value that is not currently used in GTAModel.
* `Data2` - `up2`, a user defined value that is not currently used in GTAModel.
* `Data3` - `up3`, a user defined value that is not currently used in GTAModel.

Below is an example row:

```
a  10005  12235  12235     0      0      0      0
```

### vehicles.202

This file contains the list of all transit vehicles in the network.

* `id` - The index to use for this transit vehicle.
* `description` - A description of the vehicle surrounded with single quotes.
* `mode` - The single letter code for the mode that will use this vehicle.
* `fleet_size` - The number of vehicles of this type that will be in the network, GTAModel does not use this.
* `seated_capacity` - The number of people that can sit in the vehicle, GTAModel does not use this.
* `total_capacity` - The total number of people that can be in the vehicle.
* `cost_time_coeff` - Not used by GTAModel.
* `cost_distance_coeff` - Not used by GTAModel.
* `energy_time_coeff` - Not used by GTAModel.
* `energy_distance_coeff` - Not used by GTAModel.
* `auto_equivalent` - This value will set how many passenger car equivalent units (PCUs) that this vehicle will remove
    of road capacity during road assignment per run.

Below is an example row:

```
a  17 'GoBus'    g    999    55    55   0.00   0.00   0.00   0.00   2.50
```

### version.txt

The version file is a standard UTF-8 text file with two lines.  The first line contains the NWP format version number.
The second line contains the version of EMME that was used to export the NWP, for example `Emme 4.4.2.0 (64-bit)`.