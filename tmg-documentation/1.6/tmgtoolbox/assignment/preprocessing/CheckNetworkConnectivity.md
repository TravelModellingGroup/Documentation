# **Check Network Connectivity**
This tool is used to check the nodes with connectivity issues by running an auto and/or transit assignment. For given nodes, this tool will identify *fountain* nodes (that go out), *sink* nodes (that only come in), and *orphan* nodes (that neither come in nor go out). Islands are not identified. 

> Temporary storage requirements: 
> * One scenario (to preserve existing assignment results, if needed)
> * One matrix for transit times
> * One matrix for each auto mode selected


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Assignment" -> "Preprocessing" -> "Check Network Connectivity"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Select Auto Mode(s)
Select the auto mode(s) to be checked with. Leave blank to skip the checking of auto connectivity.

### Select Transit Mode(s)
Select the transit mode(s) to be checked with. Leave blank to skip the checking of transit connectivity.

### Preserve existing assignment results?
Checked the box to preserve existing assignment results (a temperorary scenario space will be needed).


## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.