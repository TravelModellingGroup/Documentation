# **Export Countpost Results**
This tool allows the exporting of traffic assignment results on links flagged with a countpost number.

> A *count station* is encoded in a link extra attribute, and a *screenline* is defined as a collection of count stations. A count station can belong to one or more screenlines. 


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Traffic" -> "Export Countpost Results"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Countpost Attribute
Select the link attribute that contains the countpost ID numbers.

### Alternate Countpost Attribute
(Optional) The alternate link attribute that contains countpost ID numbers for multiple posts per link.

### Export File
Select "Browse..." to navigate to the target folder to store the output CSVs.


## **Using the Tool with XTMF**
The tool is called "ExportCountpostResults".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Alternate Countpost Attribute Flag
(Optional) The ID of an alternate link extra attribute containing countpost ids if two countposts share a link.

### Countpost Attribute Flag
The ID of a link extra attribute containing countpost ids (need to include the '@' symbol, e.g., *@stn1*). 

### Scenario Number
The number of the Emme scenario to execute against.

### Save To
Select the location to store the CSV results.
