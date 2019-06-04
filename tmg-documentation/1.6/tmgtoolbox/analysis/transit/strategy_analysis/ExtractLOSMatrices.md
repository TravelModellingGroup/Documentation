# **Extract LOS Matrices**
This tool extracts the average in-vehicle, walking, waiting, and boarding time matrices from a strategy-based transit assignment.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Extract LOS Matrices"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Modes
Select the mode(s) used in the assignment. Only *Transit* and *Auxiliary Transit* modes from the chosen scenario will be visible.

### IVTT/Walk/Wait/Boarding Matrix
Choose an existing matrix to store the outputs, or Select 'None' to store in a new matrix.


## **Using the Tool with XTMF**
The tool is called "ExtractTransitTravelTimes".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Boarding/IVTT/Wait/Walk Matrix Number
Specify the number of the FULL matrix to store average total boarding/in-vehicle/waiting/walking times. Walking time only applies to auxiliary transit modes.

### Modes
Select the *Transit* and *Auxiliary Transit* mode(s) for extractrion. This should be a list of single-character modes used in the assignment where no space is needed between each mode. 

### Scenario Number
Select the scenario with transit assignment results to analyze.