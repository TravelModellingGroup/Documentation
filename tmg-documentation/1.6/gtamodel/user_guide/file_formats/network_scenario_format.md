# Network Scenario Format

## Base Network (.nwp)
This EMME network package file is used in GTAModel V4 to import a base network, which is based on the 2016 Network Coding Standard with 2016 data. It takes into consideration the freight mode (e.g., freight and auto only zone centroid connectors, lane capacity), and it does not include the Gormley Go Station.

The base network will serve as a "Base Scenario" to create time period specific networks (AM, MD, PM, EV, ON) using the [Full Network Set Generator](https://tmg.utoronto.ca/doc/1.6/gtamodel/model_design/full_network_generator.html), and these networks will be cleaned for use in auto and transit assignments.

> More information about how to use the Full Network Set Geneator tool, please refer to the [Toolbox Page](https://tmg.utoronto.ca/doc/1.6/tmgtoolbox/network_editing/FullNetworkSetGenerator.html)

## Batch Line Edit (.csv)
This file allows the user to make changes to particular lines as specified by the filter. It needs to contain at least three columns as following:
- filter
- x_hdwchange (x = scenario number, e.g., 10)
- x_spdchange (x = scenario number, e.g., 10)

Additional headway and speed pairs can be added for more scenarios, such as the example below:

|filter|10_hdwchange|10_spdchange|20_hdwchange|20_spdchange|
|--------|--------|--------|--------|--------|
|line=T501|1|1|0.5|1|


## Aggregation (.csv)
This file is the Transit Aggregation Selection Table, which contains the transit lines and how the headway is to be calculated for each line if a Transit Service Table file is used for that line. It contains two columns:
- emme_id: this is the id of the transit line in Emme
- agg_type: this is the headway calculation method. It can either be '**naive**' or '**average**'

Example:

|emme_id|agg_type|
|-------|--------|
|T501|naive|

**Naive** vs **Average** headway calculation method: <BR/>
An example line "T501" has 3 departures in the AM period (6 a.m. to 9 a.m.) at 8:01, 8:11, and 8:31. The **naive** aggregation approach would simply take the number of departures in a time period. For line "T501" the naive aggregation approach would say that 3 hour AM period means 180 minutes. 180/3 = 60 minute headways. On the other hand, the **average** aggregation method looks at the time in between departures and takes the average of that time. For line "T501", the average approach would say that the time in between departures is 10 and 20 mins, the average of which is 15 minutes. The headway is then imputed as 15 minutes.


## Alt File (.csv)
This file is the Transit Alternative Table, which contains information for the transit lines that do not have any entries in the Transit Service Table; otherwise, these transit lines will not be present in the time periods that will be generated. If a line exists in both Alt File and Service Table, the information in Alt File will rule. It needs to contain at least three columns as following:

- emme_id: the id of the transit line in EMME
- xxxx_hdw: the headway column corresponding to the time period starting with "xxxx" in a "hhmm" format. For example, "0600_hdw" column will contain the headways for the time period starting at 6:00 AM.
- xxxx_spd: the speed column corresponding to the time period starting with "xxxx" in a "hhmm" format. For example, "0600_spd" column will contain the speeds for the time period starting at 6:00 AM.

Additional xxxx_hdw and xxxx_spd columns should be specified for all time periods that need to be modified, such as the example below:

|emme_id|0600_hdw|0600_spd|0900_hdw|0900_spd|
|--------|--------|--------|--------|--------|
|T501|10|50|5|50|


## Service Table (.csv)
This Transit Service Table file contains trip starts and trip ends for transit lines. It contains three columns as following:

- emme_id: the id of the transit line in EMME
- trip_depart: the departure time of the trip from the initial stop in a hh:mm format
- trip_arrive: the arrival time of the trip to the final destination in a hh:mm format

Example:

|emme_id|trip_depart|trip_arrive|
|--------|--------|--------|
|T501|5:55:00|6:55:00|
|T501|6:10:00|7:10:00|

> [!WARNING] If a transit line has no definition in both of the **Service Table** nor the **Alt File**, it will be removed from the network by the [Full Network Set Generating](https://tmg.utoronto.ca/doc/1.6/gtamodel/model_design/full_network_generator.html) tool.

## Parking Costs (.csv)
This file contains the hourly capacity-weighted average parking cost for each destination zone using a 500m buffer in calculation. It is part of the `GTAModel starting in V4.1`, which contains two columns as following:

- Zone#: the ID of the zone 
- Parking Cost: the average hourly parking cost corresponding to the zone

Example:

|Zone#|Parking Cost|
|--------|--------|--------|
|1|3|
|2|1.5|


## Shortest Path (.mtx)
This optional file is a EMME binary matrix that is used to specify the distance between zones `starting in GTAModel V4.1`. It stores the OD shortest network distance (static, not the fastest path) in the unit of meters. 

Example:

|p/q/[val]|1|2|3|
|--------|--------|--------|--------|
|1|0|1126.6|1475.4|
|2|1126.6|0|1037.0|
|3|1475.4|1037.0|0|

