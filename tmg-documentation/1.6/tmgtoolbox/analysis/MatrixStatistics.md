
# **Matrix Statistics**
This tool is used to compute aggregate statistics for a given matrix using *numpy*, including average, median, standard deviation, and a histogram of values. Users can also specify an optional matrix of weights, and the tool will also compute the weighted average, standard deviation, and histogram values.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Matrix Statistics"

### Value Matrix
Select the matrix to be computed statistics for. (Full matrix only)

### Weighting Matrix (Optional)
Select the matrix of weights or None.

### Report File (Optional)
Select "Browse..." to navigate to the location of (*.txt) file to store the outputs. This is optional as users may always refer to Logbook for the results.

### Scenario (Optional)
Only required if scenarios have different zone systems.

### Filters
#### def OriginFilter(p)
Enter a Python expression. Include the return statement. For example, *return p < 9000*.
#### def DestinationFilter(q)
Enter a Python expression. Include the return statement.

### Histogram
Enter the *Min*, *Max*, and *Step Size* for the histogram.


## **Using the Tool with XTMF**
The tool is called "MatrixAnalysis". It is available to add under *GTAModel System* > *Post Run* or *Travel Demand Model* > *To Execute*.

### Third Normalized Form
Select *TRUE* to save the data in third normalized form, otherwise, it will be saved as a matrix.

### Aggregation File
Select the file that contains the *Zone to Aggregation* mapping.

### Aggregation to Apply
Choose the aggregation function (Average or Sum) to apply.

### Analysis Target
(Optional) The analysis target must be a type of SparseTwinIndex.

### Output File
Select the location to store the analysis results.
