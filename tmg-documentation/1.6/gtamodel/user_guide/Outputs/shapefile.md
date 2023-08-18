# ShapeFile

At the end of a GTAModel run you might have some ShapeFiles
for the network generated.  This format is useful if you
plan on sharing the results with other people who do
not have access to your network assignment software.

> [!Note] 
> In this documentation we will cover the ShapeFile outputs
> from a standard EMME based GTAModel V4.  Not all GTAModel
> model systems will generate ShapeFiles, but when they
> do it will be like this.

## Format

Each "ShapeFile" is composed of multiple files.

| Extension | Description |
|-----------|-------------|
| .cpg      | Specifies the code page for the `.dbf` file. |
| .dbf      | Data for each geometry object defined in the ShapeFile.  You can open this file in Excel. |
| .prj      | A file containing a reference to the projection system the geometry object data is in. |
| .shp      | Contains the definitions for the geometry objects, such as points, lines, or polygons. |
| .shx      | Provides indexing information allowing for GIS programs to quickly find the location of geometry objects in the `.shp` file. |

For more information on ShapeFiles, you can [read here](https://en.wikipedia.org/wiki/Shapefile).

## Scenario Numbers

When reading these files the scenario numbers can differ however, the
standard configuration is that:

| Scenario Number | Description |
|-----------------|-------------|
|1| The BaseNetwork, loaded from NWP with changes that affect all time periods. |
|10| AM Uncleaned Network |
|11| AM Cleaned Network |
|12| AM Transit Hypernetwork |
|20| MD Uncleaned Network |
|21| MD Cleaned Network |
|22| MD Transit Hypernetwork|
|30| PM Uncleaned Network|
|31| PM Cleaned Network  |
|32| PM Transit Hypernetwork|
|40| EV Uncleaned Network|
|41| EV Cleaned Network |
|42| EV Transit Hypernetwork|
|49| ON Uncleaned Network|
|50| ON Cleaned Network|

Where:

A cleaned network has nodes removed to help reduce the network size where possible
A cleaned network also has transit lines with no service in the time period removed.

A Hyper-Network is our representation of the network where each transit agency has
been lifted into a different plane and transfer links have been added between the
planes in order to facilitate transfers and our logic for applying fare policy.

## Files

Each scenario directory will contain the following ShapeFiles:

* emme_links - Contains information for the roads, links, that go between nodes.
* emme_nodes - Contains information about points that outline roads and Traffic Analysis Zone centroids.
* emme_tlines - Contains information about whole transit lines.  For segment level data use tsegs.
* emme_tsegs - Contains information about individual transit line segments.

The files can contain additional attributes starting with the `@` symbol.  These properties are often model specific.

`PCU` refers to Passenger Car Equivalent Units.

### emme_links

| Field Name | Description |
|------------|-------------|
| ID         | A `string` in the format `{inode}-{jnode}` |
| INODE      | The id number of the node where the link starts from. |
| JNODE      | The id number of the node where the link goes to. |
| LENGTH     | The length of the link in KMs.  This does not have to be the same as the shape length. |
| TYPE       | By convention a 3 digit number where the region id is the first digit and the planning district are the next two. |
| MODES      | The different auto and transit modes that are allowed on the link.  To know what the modes mean, please refer to your network coding guide. |
| LANES      | A floating point number containing the number of lanes available for auto traffic. |
| VDF        | A number to make reference to the volume-delay-function used to compute the travel time of a road given congestion. |
| DATA1	     | This is the same as `UL1`. |
| DATA2	     | This is the same as `UL2`. |
| DATA3	     | This is the same as `UL3`. |
| VOLAX	     | This is the auxiliary transit volume (people walking) on the link. |
| VOLAU	     | This is the total passenger car equivalent units (PCUs) on the link during the hour. |
| VOLAD	     | This is used for auxiliary demand applied to the link.  This is unused in GTAModel. |
| TIMAU	     | The number of minutes for an road vehicle to traverse the link. |
| @auto_volu | The number of autos traversing the link in the hour. |
| @heavy_vol | The PCUs of volume used by heavy truck.  In standard GTAModel 1 heavy truck is 2.5 PCUs. |
| @lkcap	 | The lane capacity of the link in PCU per hour. |
| @lkspd     | The speed in km/h for the link. |
| @medium_vo | The volume of medium trucks on the link in PCUs. In GTAModel 1 medium truck is 1.75 PCUs. |
| @ramp_toll | The toll to enter the ramp for the toll highway for a passenger car. |
| @ramp_tol0 | The toll to enter the ramp for the toll highway for a light truck. |
| @ramp_tol1 | The toll to enter the ramp for the toll highway for a medium truck.|
| @ramp_tol2 | The toll to enter the ramp for the toll highway for a heavy truck.|
| @stn1	     | A reference to the count station id for the road, 0 if there is none. |
| @stn2	     | A second reference to an additional count station id for the link, 0 if there is none. |
| @toll	     | This is used for the road tolls for GTAModel V4.0 for an auto to pass through the link in Base Year $. |
| @toll_auto | The amount of money it costs to cross the link for an auto passenger vehicle in Base Year $. |
| @toll_heav | The amount of money it costs to cross the link for a heavy truck in Base Year $. |
| @toll_ligh | The amount of money it costs to cross the link for a light or medium truck in Base Year $. |
| @walkp	 | The factor to apply to walk time to generate the perceived walk time on links. |
| @z407	     | The index to the toll to apply for traversing a link. |
| @z407ramp  | The index to the toll to apply for entering a ramp. |

### emme_nodes

| Field Name | Description |
|------------|-------------|
|ID          | A unique number for identifying the node. |
|X           | The x-coordinate of the node in metres using UTM. |
|Y           | The y-coordinate of the node in metres using UTM. |
|DATA1       | The same as `ui1`, unused in GTAModel. |
|DATA2       | The same as `ui2`, unused in GTAModel. |
|DATA3	     | The same as `ui3`, unused in GTAModel. |
|ISZONE	     | 1 if the node represents a traffic analysis zone, 0 otherwise. |
|ISINTERSEC	 | 1 if the node has intersection data, 0 otherwise. |
|LABEL	     | A string that can be used to document the node.  Unused directly in GTAModel. |
|INBOAI	     | The number of initial boardings at node. |
|FIALII	     | The number of final alightings at node. |
|@gofz	     | GO Rail fare zone index. |
|@stationla	 | Station Label |
|@stop       | 1 if there is a transit stop at this location, 0 otherwise. |
|@transfer   | 1 if the link is only used for transit transfers. |


### emme_tlines

| Field Name | Description |
|------------|-------------|
|ID          | A unique name for the transit line. |
|MODE        | The transit mode that the transit line uses. |
|VEHICLE     | The index to the vehicle that the transit line uses. |
|HEADWAY     | The time between runs of the transit line. |
|SPEED       | The average speed of the transit line, **unused in GTAModel V4.1+**. |
|DESC        | A short description for the transit line. |
|NUM_SEGS    | The number of transit segments that compose the line. |
|LAYOVER_TI  | The time a vehicle waits at the end of the line. **Unused in GTAModel**. |
|DATA1       | The same as `ut1`. |
|DATA2       | The same as `ut2`. |
|DATA3       | The same as `ut3`. |
|@doors      | The number of doors for vehicles in the transit lines, 0 resolves to 2.|
|@ehdw       | The effective headway of the line.  How long does a person actually wait, in minutes. |
            
### emme_tsegs

| Field Name | Description |
|------------|-------------|
|SEG_ID      | The segment's id in the format `{Line_Id}-{iNode}-{jNode}`.|
|LINE_ID     | The id for the transit line that the segment belongs to. |
|SEG_NUM     | The ordered index of the transit segment within the transit line. |
|INODE       | The node that the transit segment starts at. |
|JNODE       | The node that the transit segment ends at. |
|DWELL_TIME  | The amount of time that the transit vehicle spends boarding and alighting passengers. |
|TTF         | An index into the 'transit time function' that is used for computing the time it takes to traverse the link.  Does not include dwell time. |
|DWT_IS_FAC  |  |
|CAN_ALIGHT  | Can passengers alight at the end of the segment? |
|CAN_BOARD   | Can passengers board at the end of the segment? |
|DATA1       | The same as `us1`. |
|DATA2       | The same as `us2`. |
|DATA3       | The same as `us3`. |
|VOLTR       | The number of passengers travelling on the transit line through the segment. |
|TIMTR       | The time, in minutes, it takes to traverse the segment. |
|BOARD       | The number of people who board the vehicle. |
|@alighting  | The number of people who alight from the vehicle. |
|@boardings  | The number of people who board the vehicle.  This will be the same as BOARD. |
|@ccost      | The cost, in in-vehicle-minute utilities, of crowding. |
|@erow_spee  | The exclusive-right-of-way speed of the vehicle to use, 0 if default or not a erow segment. |
|@sfare      | The fare for traversing the segment. |
|@tstop      | The number of transit stops that will be used to traverse the segment. This might be greater than one if not all stops are modelled. |
