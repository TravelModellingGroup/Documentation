# **Create Station Access File**
This tool is used to identify the zones that are within a user-specified distance from subway or GO train stations. 
> * Subway stations are identified as stops of lines with mode = 'm'.
> * GO stations can be identified in two ways:
>   * Station centroids: identified by a node selector expression
>   * Stops of lines with mode = 'r'.

The ouput table is saved as a CSV file with three columns: *Zone*, *NearSubway*, and *NearGO*. The first column identifies the zone, the second column indicates whether a zone is within the radius of a subway station (value = 1) or not (value = 0), and the third column indicates whether a zone is within the radius of a GO Train station (value = 1) or not (value = 0). Zones not in the radius of either are not listed.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Transit" -> "Create Station Access File"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Search Radius
Specify the search radius in coordinate units (m). Default is 1km (1000m).

### Output File
Select "Browse..." to navigate to the target folder to store the CSV results.

### GO Station Selector
(Optional) Write a zone filter expression to select GO Station centroids. For example, *i = 7000,8000*. If ommitted, this tool will use GO rail line stops.


## **Using the Tool with XTMF**
The tool is called "GetStationAccessFile".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Export File
Select the location to store the CSV results.

### Go Station Selector
(Optional) Write a zone filter expression to select GO Station centroids. For example, *i = 7000,8000*. If ommitted, this tool will use GO rail line stops.

### Scenario Number
The number of the Emme scenario to execute against.

### Search Radius
Specify the search radius in coordinate units (m). Default is 1km (1000m).



