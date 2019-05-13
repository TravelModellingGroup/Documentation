# **Export Screenline Results**
This tool aggregates link auto volumes based on a given screenline aggregation file and exports the results. Both auto volume (volau) and additional volume (volad) are considered. *For transit volumes, please see 'Export Screenline Results' tool.*
> A *screenline* is defined as a collection of count stations, while a *count station* is encoded in a link extra attribute. A count station can belong to one or more screenlines. 
>
> The *screenline definition file* structure assumes a header line followed by lines. For example,
> 
> |Screenline GID | Station GID|
|------------ | -------------|
|T1001I | 100002 |
|T1001I | 100012 |
|T1001I | 100022 |
|T1001O | 100004 |
|T1001O | 100014 |
|T1001O | 100024 |



## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Traffic" -> "Export Screenline Results"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Countpost Attribute
Select the link attribute that contains the countpost ID numbers.

### Alternate Countpost Attribute
(Optional) The alternate link attribute that contains countpost ID numbers for multiple posts per link.

### Screenline Definitions File
Select "Browse..." to navigate to the location of the screenline definition file (\*.csv).

### Export File
Select "Browse..." to navigate to the target folder to store the output CSVs.


## **Using the Tool with XTMF**
The tool is called "ExportScreenlineResults".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Alternate Countpost Attribute Flag
(Optional) The ID of an alternate link extra attribute containing countpost ids if two countposts share a link.

### Countpost Attribute Flag
The ID of a link extra attribute containing countpost ids (need to include the '@' symbol, e.g., *@stn1*). 

### Scenario Number
The number of the Emme scenario to execute against.

### Save To
Select the location to store the CSV results.

### Screenline Definitions
Select the location of the screenline definition file.



