# **Extract Link Transfer**
This tool is used to extract the volume transit passengers using the pair(s) of links.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Extract Link Transfer"

### Base Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### File Name
Specify the output file (*.csv) to store results.

### Demand File
Choose the demand matrix to use. Tool will determine matrix analyzed in assignment if you select *None*.

### Peak Hour Factor
Specify the value by which to divide the transit volumes. 

### List of Link Pairs
Choose the set of link pairs to be examined using the required syntax.
> **Syntax**: </br>
> *[Label] : [Link #1] : [Link #2] : [Line #1] : [Line #2]* </br>
For example, *[sample]:[1000,1001]:[line=T506Ab]* </br>

Please note the line filters are optional, may use all possible lines by leaving them out. Links should be expressed in the form of *' i,j '*. Lines should be expressed as full filter expressions. Link pairs should be seperated using new lines or semicolons.

### Use links of same geometry
Check the box to include links in the hypernetwork with the same shape.


## **Using the Tool with XTMF**
The tool is called "ExtractLinkTransfers".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Demand Matrix
Choose the demand matrix to use for analysis. A value of '0' will cause the tool to search for the demand matrix used in the most recent assignment.

### Hypernetwork
Default is FALSE. Set this to TRUE to include links in the hypernetwork with the same shape.

### Link Set
Choose the set of link pairs to be examined using the required syntax: **[Label] : [Link 1] : [Link 2]**. For example, **[sample]:[1000,1001]**.
Links should be expressed in the form of *' i,j '*. Link pairs should be seperated by semicolons.

### Peak Period Factor
Specify the value by which to divide the transit volumes. 

### Scenario Number
Select the scenario to read the information from.

### Save To
Specify the output file (*.csv) to store results.
