# **Export Transit Screenline Results**
This tool is used to aggregate transit volumes for a specified line filter based on a given screenline aggregation file. *For auto volumes, please see 'Export Screenline Results' tool.*

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
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Transit" -> "Export Transit Screenline Results"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Countpost Attribute
Select the link attribute that contains the countpost ID numbers.

### Alternate Countpost Attribute
(Optional) The alternate link attribute that contains countpost ID numbers for multiple posts per link.

### Count Pedestrians instead of transit
Check the box to count pedestrian volume (volax) instead of transit volume (voltr).

### Line Filter Expression
Write the expression in the correct EMME format to filter transit lines. Default is All.

### Representative Hour Factor
The representative hour factor for the screenlines. Default is 2.04.

### Screenline Definitions File
Select "Browse..." to navigate to the location of the screenline definition file (\*.csv).

### Export File
Select "Browse..." to navigate to the target folder to store the output CSVs.



## **Using the Tool with XTMF**
The tool is called "ExportTransitScreenlines".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Alternate Countpost Attribute Flag
(Optional) The ID of an alternate link extra attribute containing countpost ids if two countposts share a link.

### Countpost Attribute Flag
The ID of a link extra attribute containing countpost ids (need to include the '@' symbol, e.g., *@stn1*). 

### Export Pedestrians
Select *TRUE* to count pedestrian volume (volax) rather than transit volume (voltr).

### Line Filter Expression
Write the expression to filter transit lines. Default is All.

### Representative Hour Factor
Default is 2.04.

### Scenario Number
The number of the Emme scenario to execute against.

### Save To
Select the location to store the CSV results.

### Screenline Definitions
Select the location of the screenline definition file.






