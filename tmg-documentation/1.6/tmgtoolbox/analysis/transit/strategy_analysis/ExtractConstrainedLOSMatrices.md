# **Extract Constrained LOS Matrices**
This tool is used to extract LOS matrices of average in-vehicle/walking/waiting/boarding time and cost from a fare-based transit assignment. The LOS matrices will also be multiplied by a feasibility matrix (where 0 = infeasible and 1 = feasible).

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Extract Constrained LOS Matrices"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Run Title
Enter the title for this run. Maximum 25 characters.

### Modes
Select the mode(s) for extractrion. Only *Transit* and *Auxiliary Transit* modes from the chosen scenario will be visible.

### Feasibility Parameters
#### Walk/Wait/Total Time Cutoff
Set the cutoff time for walking, waiting and total travel time. Default is 40, 40, and 150 minutes.
#### Fare Perception
To quantify the perception of fare. Enter '0' to disable fare-based impedances.

### Result Matrices
Choose the existing or next available matrix to store the outputs. Select 'None' for redundant results.

## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.


