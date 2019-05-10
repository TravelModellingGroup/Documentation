
# Assign V4 Boarding Penalties
Assigns line-specific boarding penalties (which will be stored in UT3) based on specified line groupings.
## Opening the Tool with Modeller
The tool is found in "TMG Toolbox" -> "Assignment" -> "Preprocessing" -> "Assign V4 Boarding Penalty"
## Using the Tool with Modeller
### Scenarios
Choose the scenarios in which the specified boarding penalties should be applied. Note: More than one scenario can be selected.
### Line Group Boarding Penalties
List of filters and boarding penalties for line groups. 

Syntax: [label (line group name)] : [network selector expression] : [boarding penalty] : [IVTT Perception Factor] ... 

Separate (label-filter-penalty) groups with a comma or new line. 

Note that order matters, since penalties are applied sequentially.

## Using the Tool with XTMF

The tool is called "AssignBoardingPenalties". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun.

### Scenario Numbers
In the main tool Parameters, the scenario numbers can be specified. More than one scenario can be specified here, separated by commas.

### Boarding Penalties
Boarding Penalties can be added one by one under the "Boarding Penalties" module. For each 
#### In Vehicle Time Perception
The in vehicle time perception for the lines that are selected by the "Line Filter" and/or the "Mode Filter".
#### Label
This describes what the penalty is being applied for
#### Line Filter and Mode Filter
The filters that will be used to select the group of lines that will have the penalty and In Vehicle Time Perception applied to them. Only one of these filters are required. Use "_" as a character wildcard in the "Line Filter".
#### Penalty
The boarding penalty that will be applied to the lines selected by the two filters.



