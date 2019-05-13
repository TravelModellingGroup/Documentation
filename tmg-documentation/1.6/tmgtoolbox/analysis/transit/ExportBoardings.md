# **Export Boardings**
This tool is used to extract total boardings for each transit line as a CSV file. Optionally, lines can be aggregated using an external file.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Export Boardings"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Report File
Select "Browse..." to navigate to the target folder to store the CSV results.

### Line Aggregation File
(Optional) Aggregation file contains two columns with **no** headers, matching transit 
line IDs to their aliases or groups in another data source (e.g., TTS line IDs). The 
first column must be Emme transit line IDs. Errors will be skipped.

### Write Individual Routes
Write individual routes that are not found in the aggregation file. This is the default behaviour if no aggregation file is specified.

### Report Errors to the Logbook
Report in the Logbook if there are lines referenced in the aggregation file but are not in the network.


## **Using the Tool with XTMF**
The tool is called "ExportTransitBoardings".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Scenario
The number of the Emme scenario to execute against.

### Write Individual Routes
Report separately the individual routes that are not found in the aggregation file. Default is *TRUE* if no aggregation file is specified.

### Line Aggregation File
(Optional) Aggregation file should contain two columns with **no** headers, matching transit 
line IDs to their aliases or groups in another data source (e.g., TTS line IDs). The 
first column must be Emme transit line IDs. Errors will be skipped.

### Report File
Select the target folder to store the CSV results.
