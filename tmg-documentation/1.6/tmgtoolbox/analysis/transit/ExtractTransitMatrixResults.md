# **Extract Transit Matrix Results**
This module specifies a particular matrix extraction to perform on a single-class or multi-class transit assignment.


## **Using the Tool with Modeller**
The tool is not callable from Emme Modeller. Please use XTMF.


## **Using the Tool with XTMF**
The tool is called "ExtractTransitMatrixResults".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Scenario Number
The number of the Emme scenario to execute against.

### Extractions
The extractions to perform.

### Analysis Type
Select one of the five types of analysis: 1. Distance, 2. Actual Cost, 3. Actual Time, 4. Perceived Cost, or 5. Perceived Time.

### Class Name
Specify the name of the class to extract. Leave blank for a single class assignment.

### Matrix Number
Select the matrix to save the results into (Full Matrix Only).

### Modes
Specify the mode(s) to do the extraction for. Enter '*' for *ALL* modes. 