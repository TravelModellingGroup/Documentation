# **Multi Class Road Assignment**
This tool executes a multi-class road assignment which allows for the generalized penalty of road tolls.. `MultiClassRoadAssignment` is a toll-based road assignemnt tool. 

Latest version of this tool includes the ability to:

>increase resolution of analysis by adding link volume attributes
>
>allow for multi-threaded matrix calculation in 4.2.1+


## **Using the Tool with Modeller**
`MultiClassRoadAssignment` tool is not callable from Modeller. It is intended only to be called from XTMF.

The tool can be found in "TMG Toolbox" -> "XTMF Internal" -> "Multi Class Road Assignment". 


## **Using the Tool with XTMF**
The tool is called "MultiClassRoadAssignment". In XTMF, it is available to add under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## Module Parameters - "MultiClassRoadAssignment"

### Background Transit
Set this to FALSE to not assign transite vehicles ont he roads. 

### Best Relative Gap
The minimum gap required to terminate the algorithm.

### Iterations
The maximum number of iterations to run.

### Normalized Gap
The minimum gap required to terminate the algorithm.

### Peak Hour Factor
A factor to apply to the demand in order to build a representative hour.

### Performance Mode
Set this to FALSE to leave a free core for other work, recommended to leave set to TRUE.

### Relative Gap
The minimum gap required to terminate the algorithm. 

### Run TItle
The name of the run to appear in the logbook

### Scenario Number
The scenario number to execute against

## Sub-Module Parameters - MultiClassRoadAssignment -> Class

### Cost Matrix
The matrix number to save the total cost into. 

### Demand Matrix
The id of the demand matrix to use.

### LinkCost
The penalty in minutes per dollar to apply when traversing a link.

### Mode
The mode for this class. 

### Time Matrix
The matrix number to save in vehicle travel times.

### Toll Matrix
The matrix to save the toll costs into.

### Toll Weight
to be updated. 

### TollAttributeID
The attribute containing the road tolls for this class of vehicle.

### VolumeAttribute
The name of the attribute to save the volumes into (or None for no saving).

## Sub-Module Parameters - MultiClassRoadAssignment -> Classes -> Analysis

### Aggregation Matrix
The matrix number to store the results into. 

### Attribute ID
The attribute to use for analysis.

### Lower Bound for Path Selector
The number to use for the lower bound in path selection, or None if using all paths

### Multiply Path Proportion By Analyzed Demand
Choose whether to multiply the path proportion by the analyzed demand. 

### Multiply Path Proportion By Path Value
Choose whether to multiply the path proportion by the path value.

### Operator
The operator to use to aggregate the matrix. Example: '+' for emissions, 'max' for select link analysis. 

Full list of operators that can be used: `***+, -, *, /, %, .max., .min.***`

### Paths to Select
The paths that will be used for analysis.

### Upper Bound for Path Selector
The number to use for the upper bound in path selection, or None if using all paths.
