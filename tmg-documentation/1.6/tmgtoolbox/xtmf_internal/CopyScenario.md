# **Copy Scenario**
This tool allows XTMF to copy a scenario within an EMME Databank.

## **Using the Tool with Modeller**
`CopyScenario` tool is not callable from Modeller. It is intended only to be called from XTMF.

The tool can be found in "TMG Toolbox" -> "XTMF Internal" -> "Copy Scenario". 

## **Using the Tool with XTMF**
The tool is called "CopyScenario". In XTMF, it is available to add under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

### Base Scenario
This refers to the scenario to copy from. The base scenario is of type Integer. 

### Destination Scenario
An integer which represents the scenario to copy to.

### Copy Assignments
The parameter copies the results from an assignment. Copy Assinment is of type Boolean.
