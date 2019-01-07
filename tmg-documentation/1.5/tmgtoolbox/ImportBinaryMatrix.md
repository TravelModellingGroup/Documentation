
# Import Binary Matrix
This is used to import a matrix with a binary format into Emme for use within Desktop and Modeller.
> If a matrix that needs to be imported uses the CSV format, please use the following tool "Emme Standard Toolbox" -> "Data Management" -> "Matrix" -> "Import matrix data from CSV". 


## Opening the Tool with Modeller
The tool can be found in "TMG Toolbox" -> "Input Output" -> "Import Binary Matrix"
## Using the Tool with Modeller
### Import File
Select "Browse..." to navigate to the location of the matrix that is to be imported. 
### Matrix
Select an existing matrix that will be used to store the imported matrix. Note: If a matrix number is not on this list, it will likely need to be initialized. To initialize a matrix, please use the following tool "Emme Standard Toolbox" -> "Data Management" -> "Matrix" -> "Initialize matrix".

### Scenario
If there are different zone systems within the Emme Project, select the Scenario which contains the zone system that corresponds to the matrix zone system.

## Using the Tool with XTMF
The tool is called "ImportBinaryMatrixIntoEmme". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun.

### Description
The description of the matrix. This will be shown in the Emme Project when looking up the matrix
### Matrix Number
The number of the imported matrix. This can be a an existing matrix (in which case it will be overwritten) or it can be a new matrix which will be automatically created.
### Matrix Type
The type of matrix that is being imported. 1 for SCALAR, 2 for ORIGIN, 3 for DESTINATION, 4 for FULL.
### Scenario
The scenario which has the same zone system that is present in the imported matrix.
### Matrix File
The location of the matrix that is to be imported is specified here using the appropriate module and then selecting the file location..

