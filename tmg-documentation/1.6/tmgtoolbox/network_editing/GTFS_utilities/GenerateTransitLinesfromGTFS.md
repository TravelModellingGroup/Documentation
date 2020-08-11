# **Generate Transit Line Itineraries From GTFS**
This tool is used to generate transit line itineraries from GTFS data. It is assumed that most GTFS are matched to a network node and unmatched stops will be ignored.

The *'routes'* file of the GTFS feed must define two additional columns: 
- **emme_id**: the Emme transit line id (up to the first 5 characters)
- **emme_vehicle**: the Emme vehicle number used by the line
- (Optional) **emme_descr**: the Emme description of the lines  

> Note: if both *'routes.txt'* and *'routes.csv'* are defined in the GTFS folder, the CSV file will be used.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Network Editing" -> "GTFS Utilities" -> "Generate Transit Lines from GTFS"

### Base Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Maximum Inter-stop Links
Specify the maximum number of links between stops. Lines requiring paths longer than the maximum will not be added but will be reported in the logbook.

### Link Priority Attribute
Select the factor to be applied to link speeds. 
> It is recommended to use an attribute with a default value of 1.0 instead of 0.0.

### GTFS Folder
Select the folder that conatins the GTFS feed files.

### Stop-to-Node File
Select the *.csv file that contains Stop IDs and the corresponding Emme Node IDs. The default file format assumes that the first column is *Stop ID* and the second column is *Node ID*. More information on how to generate the Stop-to-Node file can be found [here](../GTFSEmmeNodeMap.md).

### TOOL OUTPUTS

#### New Scenario
Select the scenario ID to publish the new network.

#### New Scenario Title
Specify the title of the new scenario.

#### Transit Service Table
Select "Browse..." to navigate to the location of the output folder and specify the file name to store the output service table file (*.csv).

#### Mapping file 
Select "Browse..." to navigate to the location of the output folder and specify the file name to store the *.csv file that maps between EMME ID and GTFS Trip ID.

#### Publish network
Check the box the publish the network to the new scenario. Leave unchecked for debugging. Default is checked.

## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.