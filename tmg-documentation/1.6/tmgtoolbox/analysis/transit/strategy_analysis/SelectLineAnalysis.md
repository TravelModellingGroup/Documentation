# **Select Line Analysis**
This tool is used to extract the matrices of average in-vehicle/walking/waiting/boarding time and cost from a strategy-based transit assignment. 

The transit lines being considered should be flagged by attribute '**@lflag**'. The network must have transfer fares stored in '**@tfare**' and in-line fares stored in '**us3**' for cost calculation.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Select Line Analysis"

### ANALYSIS OPTIONS
#### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.
#### Modes
Select the mode(s) for extractrion. Only *Transit* and *Auxiliary Transit* modes from the chosen scenario will be visible.
#### Fare Perception
Quantify the perception of fare in the assignment. Enter '0' to disable recovery of walk times and IVTTs.

### FEASIBILITY PARAMETERS
Set the cutoff time for walking, waiting, and total travel time in minutes (e.g., 40, 40, and 150 respectively. 

### RESULTS 
Choose an existing matrix to store the IVTT/Walk/Wait/Boarding/Cost outputs.

## **Using the Tool with XTMF**
The tool is called "SelectLineAnalyses".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Boarding/Cost/IVTT/Wait/Walk Matrix Number
Specify the number of the FULL matrix to store average total boarding/in-vehicle/waiting/walking times and cost. Enter '0' to disable the saving of the matrix.

### Fare Perception
Quantify the perception of fare in the assignment. Enter '0' to disable recovery of walk times and IVTTs.

### Modes
Select the *Transit* and *Auxiliary Transit* mode(s) for extractrion. This should be a list of single-character modes used in the assignment where no space is needed between each mode. 

### Scenario Number
Select the scenario with transit assignment (or FBTA) results to analyze.

### Total/Wait/Walk Time Cutoff
Set the cutoff time of walking, waiting and total travel time for feasiblity. Default is 40, 40, and 150 minutes respectively.