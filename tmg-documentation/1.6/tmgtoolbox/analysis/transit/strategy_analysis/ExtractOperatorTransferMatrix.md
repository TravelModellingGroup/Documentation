# **Extract Operator Transfer Matrix**
This tool is used to extract a matrix of passenger volumes transferring from and to each operator, including initial boardings, final alightings and total walk-all-way volumes. 

Summing over each column is equivalent to aggregating the boardings for each operator, but only if each line has a non-zero group number (i.e. full coverage). Each operator (or line group) is identified numerically based on several pre-set schemes (e.g. 1 for the first group, 2 for the second). 
> The **0th 'group'** is special. The 0th row corresponds to initial boardings, and the 0th column to final alightings. The cell [0,0] contains the total walk-all-way volumes for the scenario. 

> **Walk-all-way Matrix**: the fraction of trips walking all-way for each OD pair. The user may aggregate this matrix based on an existing Zone Partition. 

Temporary storage requirements are as following: 
1. One full matrix
2. Two transit segment attributes
3. One transit line attribute (if using a pre-built grouping scheme)

**Performance note for Emme 4.1 and newer**: when analyzing the results of a congested transit assignment, this tool will automatically blend the results over all iterations in order to keep the results consistent with those saved to the network. This is a slow operation so please allow for additional run time when analyzing many iterations.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Extract Operator Transfer Matrix"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Demand to Analyze
Choose the demand matrix to use for analysis. If set to NONE, the tool will search for the demand matrix used in the most recent assignment.

### Class Name (Optional)
Choose the name of the assignment class to analyze. This is only required if a multiclass transit assignment has been run (Emme 4.1 and newer).

### TRANSFER MATRIX
#### Export Transfer Matrix?
Uncheck the box if the user only need the walk-all-way matrix. Default is checked (TRUE).
#### Line Group / Grouping Scheme
Select a pre-built option or an existing transit line attribute with group codes.
#### Transit Matrix File
Specify the output file (*.csv) to store the transfer matrix.

### WALK-ALL-WAY MATRIX
#### Export walk-all-way matrix?
Check the box to export walk-all-way matrix. Default is unchecked (FALSE).
#### Aggregation Partition (Optional)
Specify the zone partition for the aggregation of walk-all-way matrix. Select NONE if not needed.
#### Walk-all-way Matrix File
Specify the output file (*.csv) to store the walk-all-way matrix.


## **Using the Tool with XTMF**
The tool is called "ExportOperatorTransferMatrix".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Aggregation Partition for the Walk-all-way matrix
Specify the zone partition for the aggregation of walk-all-way matrix. Select NONE if not required.

### Export Transfer Matrix Flag
Default is TRUE. Select FALSE if the user does not need the transfer matrix output.

### Export Walk-all-way Matrix Flag
Default is FALSE. Select TRUE if the user needs the walk-all-way matrix output.

### Line Group Option or Attribute ID
Specify a pre-built option or an existing transit line attribute with group codes.

### Scenario Number
Select the scenario to execute against. 

### Transfer Matrix File
Specify the location to store the transfer matrix.

### Walk-all-way Matrix File
Specify the location to store the walk-all-way matrix.

