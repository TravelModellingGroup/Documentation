# **Extract Feasibility Matrix**
This tool is used to extract a feasibility matrix (where 1 is feasible and 0 is infeasible) based on cut-off values for walking, waiting, and total times.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Extract Feasibility Matrix"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Modes
Select the mode(s) for extractrion. Only *Transit* and *Auxiliary Transit* modes from the chosen scenario will be visible.

### Result Matrix
Choose an existing matrix to store the outputs, or Select 'None' to store in a new matrix.

### Parameters
Set the cutoff time in minutes for *walking*, *waiting* and *total* (wait+walk+ivtt) travel time. 


## **Using the Tool with XTMF**
The tool is called "ExtractFeasibilityMatrix".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Matrix Result Number
Choose an existing Full matrix to store the feasiblity outputs.

### Modes
Select the *Transit* and *Auxiliary Transit* mode(s) for extractrion. This should be a list of single-character modes where no space is needed between each mode. 

### Scenario Number
Select the scenario with transit assignment results to analyze.

### Total/Wait/Walk Time Cutoff
Set the cutoff threshold of *total* (wait+walk+ivtt), *waiting*, *walking* time in minutes. Default is 150/40/40 minutes respectively.

