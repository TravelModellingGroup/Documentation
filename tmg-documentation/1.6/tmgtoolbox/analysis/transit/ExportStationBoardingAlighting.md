# **Export Station Boarding Alighting**
This tool is used to extract total boardings and alightings for a list of nodes defined in a CSV file.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Transit" -> "Export Station Boarding Alighting"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Report File
Select "Browse..." to navigate to the target folder to store the CSV results.

### Station Node File
Station node file should contain two columns: *node_id* and *label*, where *label* can be customized for the node in the output.


## **Using the Tool with XTMF**
The tool is called "ExportStationBoardingsAlightings".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Scenario Number
The number of the Emme scenario to execute against.

### Results File
Select the location to save the CSV results.

### Station Node File
Select the station node file, which should contain two columns: *node_id* and *label*, where *label* can be customized for the node in the output.


