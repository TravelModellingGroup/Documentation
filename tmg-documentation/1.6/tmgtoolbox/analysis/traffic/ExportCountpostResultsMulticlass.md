# **Export Countpost Results (Multiclass)**
This tool allows the exporting of traffic assignment results on links flagged with a countpost number.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Traffic" -> "Export Countpost Results Multiclass"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Countpost Attribute
Select the link attribute that contains the countpost ID numbers.

### Alternate Countpost Attribute
(Optional) The alternate link attribute that contains countpost ID numbers for multiple posts per link.

### Volume Attribute to Use
(Optional) For extraction of a specific classes volume only.

### File with the Posts to Sum
(Optional) If more than one link has the same count post number, the default behaviour is to take the maximum volume of all the links. Use this file to specify the countposts that should be summed in order to obtain the correct volume for the station.

### Export File
Select "Browse..." to navigate to the target folder to store the output CSVs.


## **Using the Tool with XTMF**
The tool is called "ExportCountpostResultsMulticlass".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Alternate Countpost Attribute Flag
(Optional) The ID of an alternate link extra attribute containing countpost ids if two countposts share a link.

### Countpost Attribute Flag
The ID of a link extra attribute containing countpost ids (need to include the '@' symbol, e.g., *@stn1*). 

### Scenario Number
The number of the Emme scenario to execute against.

### Traffic Class Volume Attribute
(Optional) For extraction of a specific classes volume only.

### Save To
Select the location to store the CSV results.

### Sum Post File
A link to the CSV file which contains countposts that will need to be summed, rather than taking the max. A header is included.
