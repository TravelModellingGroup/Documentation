# Export Binary Matrix
This tool allows the exporting of matrices from Emme in a binary format. For example, when Auto Travel Times need to be taken from an Emme matrix and used in other software, like XTMF.
>If a matrix is needed to be exported into a CSV file, it might be more expedient to use the standard Emme Tool which can be found in "Emme Standard Toolbox" -> "Data Management" -> "Matrix" -> "Export matrix data to CSV". However keep in mind that a csv file can use double the hard drive space when compared to a binary matrix format. 


## Opening the Tool with Modeller
The tool can be found in "TMG Toolbox" -> "Input Output" -> "Export Binary Matrix"
## Using the Tool with Modeller
### Matrix to Export
Select the matrix that needs to be exported. Note: only one matrix at a time can be exported.
### Export File
Select "Browse..." to navigate to the location of the exported matrix
### Scenario
If there are different zone systems within the Emme Project, select the Scenario which contains the zone system that is to be used for the exported matrix.

## Using the Tool with XTMF
The tool is called "ExportBinaryMatrixFromEmme". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun. 

### Matrix Number
The Emme matrix number to export in the binary format
### Matrix Type
The type of matrix that is being exported. 1 for SCALAR, 2 for ORIGIN, 3 for DESTINATION, 4 for FULL.
### Scenario
When scenarios have different zone system, this allows the user to select which zone system to export the matrix in.
### Filepath
This allows the user to select where the Matrix will be saved by adding the appropriate module and then selecting the file location.




