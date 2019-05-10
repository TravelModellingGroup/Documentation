
# **Create Zone Adjacency Matrix**
This tool uses a zone boundary shapefile to create a full matrix of zone adjacencies (with 1 indicating that two zones are adjacent). Works by drawing a buffer around each zone boundary and testing for the intersection. Any zone touching at a corner will be considered adjacent. A zone is always adjacent to itself.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Create Zone Adjacency Matrix"

### Scenario
Select the scenario to execute against. Default is the primary scenario.

### Zone Adjacency Matrix
Select an existing matrix or "next available matrix" to store the results. Note: if an existing matrix is selected, it will be overwritten.

### Zone Boundary File
Select "Browse..." to navigate to the location of the shapefile (*.shp) that is to be imported. 

### Name of Zone ID Field
The header of the column in the shapefile that contains the Zone ID.

### Buffer Size
Set the size of the buffer to test for the intersection. Default is 20.


## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.

