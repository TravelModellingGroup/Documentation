# **Export Partition Average Matrix**
This tool allows the exporting of a result matrix (e.g., travel times), averaged over a given zone partition for a given matrix (e.g., demand). Zone groups with a zero summed weight will be averaged equally over all zones. 
> Note: Temporary storage requirements are 3 matrices. 


## **Using the tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Export Partition Average Matrix"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Matrix to Aggregate
Select a result matrix to be aggregated (Full Matrix only).

### Weighting Matrix
Select the weighting matrix (Full Matrix only).

### Zone Partition
Select the zone partition group. If none exists, the user may initial a zone group in "Emme Standard Toolbox" -> " Data Management" -> "Zone Partition" -> Initialize Zone Partition"

### Matrix Export
Select "Browse..." to navigate to the location that the user wants to save the outputs.


## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.
