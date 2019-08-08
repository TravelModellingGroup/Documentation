# **Check Network Integrity**
This tool is used to check a network for potential data problems as listed below, which may result in road and transit assignment issues (e.g., infinite loops).

1. Non-existant function reference (links, turns, segments)
1. VDF = 0 for auto links
1. Lanes = 0 for auto links
1. UL2 (speed) = 0 for auto links
1. UL3 (capacity) = 0 for auto links
1. Speed = 0 for transit lines
1. US1 (segment speed) = 0 for transit segments with TTF = 1


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Assignment" -> "Preprocessing" -> "Check Network Integrity"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Attribute Flags (Optional)
Use an extra attribute to flag the elements with errors (extra attribute value = 1 if the element has errors, 0 otherwise).

#### Link flag attribute
Specifiy the extra attribute to be used for identifying the links with errors. Choose None to skip.
#### Transit Line flag attribute
Specifiy the extra attribute to be used for identifying the transit lines with errors. Choose None to skip.
#### Transit Segment flag attribute
Specifiy the extra attribute to be used for identifying the transit segments with errors. Choose None to skip.

## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.