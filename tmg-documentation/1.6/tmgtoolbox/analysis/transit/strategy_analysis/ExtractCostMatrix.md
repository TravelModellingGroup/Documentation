# **Extract Cost Matrix**
This tool is used to extract the average total cost matrix from a fare-based transit assignment (FBTA). In default, the operator-access fares are stored on walk links in *'@tfare'*, and in-line or zonal fares are stored in *'us3'*.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Extract Cost Matrix"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Result Matrix
Choose an existing matrix to store the outputs, or Select 'None' to store in a new matrix.


## **Using the Tool with XTMF**
The tool is called "ExtractCostMatrix".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Matrix Result Number
Choose an existing Full matrix to store the outputs.

### Scenario Number
Select the scenario with FBTA results to analyze.



