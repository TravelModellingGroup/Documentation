# **Calculate Hypernetwork Size**
This tool is used to estimate the number of **links** and **nodes** required for a fare-based transit network (FBTN) before actually editing the network, since the FBTN is quite large and in some cases can exceed the current size of the databank. 

> Note: the number of nodes reported is calculated accurately, however the number of links is estimated. Trial runs indicate that the number of links is over-estimated by less than 1%.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Network Editing" -> "Transit Fare Hypernetworks" -> "Calculate Hypernetwork Size"

### Base Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Fare Schema File
Browse the fare schema file (*.XML) that will be used to generate the FBTN for check. The files that have been referenced by the fare schema can be checked if they are in the same folder (e.g., York Region Zones).

## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.