# **GTFS Stops to Emme Node File**
This tool is used to generate a mapping file that shows the GTFS Stop IDs and their corresponding Node IDs in the EMME network, which is also known as the **Stop-to-Node** file used in the [Generate Transit Lines from GTFS](../GTFS_utilities/GenerateTransitLinesfromGTFS.md) tool.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Network Editing" -> "GTFS Utilities" -> "GTFS EMME Node Map"

### Stops file 
Select the stops input file, which can be in either ***.txt** format (e.g., *stops.txt* file from the GTFS feed) or ***.shp** format (e.g., *stops.shp* file).

### Map file to export
Select "Browse..." to navigate to the location of the output folder and specify the file name to store the output mapping file (*.csv).

> Note: the output file contains six columns, 
> including stopID, emmeID, stop x, stop y, node x, node y. 
> Only the first two columns are needed for the **Stop-to-Node** file. 

## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.

