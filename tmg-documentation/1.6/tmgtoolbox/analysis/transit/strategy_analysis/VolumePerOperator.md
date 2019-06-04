# **Volume Per Operator**
This tool is used to calculate the ridership for different operators.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Volume Per Operator". **However**, no customazation is allowed in Emme Modeller. Recommend to use XTMF instead.


## **Using the Tool with XTMF**
The tool is called "RidershipCounts".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Scenario Numbers
Specify a scenario number or a comma-separated list of scenario numbers to execute against.

### Operators To Consider
Specify the transit operator(s) to be considered.
#### Custom Filter (Optional)
Enter a user-specified filter to apply to the network.
#### Label
The label for this specific transit operator. 
#### Line Filter
Enter a appropriate line filter for lines with this operator.
#### Mode Filter
Enter a appropriate mode filter for this operator.

### Ridership Results
Choose the location to store the output file (*.csv).

