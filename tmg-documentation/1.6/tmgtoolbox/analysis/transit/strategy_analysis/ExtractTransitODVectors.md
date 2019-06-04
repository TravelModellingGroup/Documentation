# **Extract Transit OD Vectors**
This tool constructs origin and destination vectors for combined walk-access and drive-access transit trips for a user-specified group of transit lines.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Tranist" -> "Strategy Analysis" -> "Extract Transit OD Vectors"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Line Filter Expression
Specify the transit lines to be included in the analysis.

### Line OD Matrix
Choose an existing or use next available FULL matrix (mf) to store the OD demand using the user-specified transit lines.

### Aggregate Origin Vector
Choose an existing or use next available ORIGIN matrix (mo) to store the summed demand going through the user-specified transit lines.

### Aggregate Destination Vector
Choose an existing or use next available DESTINATION matrix (md) to store the summed demand going through the user-specified transit lines.

### Auto OD Matrix
Specify the auto demand matrix to yield origin and destination drive-access-transit demands.


## **Using the Tool with XTMF**
The tool is called "ExtractTransitODVectors".  It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Aggregation Destination Matrix Number
Enter the number of an existing DESTINATION matrix to store the summed demand going through the user-specified transit lines.

### Aggregation Origin Matrix Number
Enter the number of an existing ORIGIN matrix to store the summed demand going through the user-specified transit lines.

### Auto OD Matrix Number
Enter the number of the auto demand matrix to yield origin and destination drive-access-transit demands.

### Line Filter Expression
Specify the transit lines to be included in the analysis.

### Line OD Matrix Number
Enter the number of an existing FULL matrix to store the OD demand using the user-specified transit lines.

### Scenario Number
Select the scenario to execute against. 

### Station Centroids
Specify the range of zone centroid IDs that are access stations (e.g., 9000-9999).

### Zone Centroids
Specify the range of zone centroid IDs that are regular TAZ zones to get the ODs for (e.g., 1-8999).
