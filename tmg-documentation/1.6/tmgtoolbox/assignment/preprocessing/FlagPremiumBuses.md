# **Flag Premium Buses**
This tool is used to flag certain premium bus lines by assigning '1' to the line's extra attribute '@lflag'. The extra attribute *@lflag* will be initialized to 0 first.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Assignment" -> "Preprocessing" -> "Flag Premium Buses"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Flag GO Bus Lines
Check the box to flag GO bus lines. All lines with the mode 'g' will be flagged.

### Flag Premium TTC Bus Lines
Check the box to flag TTC premium bus lines. All lines with the mode 'p' will be flagged.

### Flag VIVA Bus Lines
Check the box to flag VIVA bus lines. All lines with the ID starting with 'YV' will be flagged.

### Flag ZUM Bus Lines (under construction)
DO NOT USE. Flagging of ZUM lines is currently unsupported.


## **Using the Tool with XTMF**
The tool is called "FlagPremiumBuses". It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### GO Bus Lines
Set as TRUE to flag GO bus lines. All lines with the mode 'g' will be flagged.

### Flag Premium TTC Bus Lines
Set as TRUE to flag TTC premium bus lines. All lines with the mode 'p' will be flagged.

### Scenario Number
Select the scenario to execute against. Only one scenario at a time can be selected.

### Flag VIVA Bus Lines
Set as TRUE to flag VIVA bus lines. All lines with the ID starting with 'YV' will be flagged.

### Flag ZUM Bus Lines (under construction)
DO NOT USE. Flagging of ZUM lines is currently unsupported. 
