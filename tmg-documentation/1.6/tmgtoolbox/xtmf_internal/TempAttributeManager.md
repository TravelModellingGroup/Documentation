# **Temp Attribute Manager**
This tool creates an extra attribute context-manager equivalent for XTMF. `TempAttributeManager` is a low-level tool. 

Latest version of this tool includes the ability to:

> only optionally reset the values to their default
>
>in 0.0.2+

## **Using the Tool with Modeller**
`TempAttributeManager` tool is not callable from Modeller. It is intended only to be called from XTMF.

The tool can be found in "TMG Toolbox" -> "XTMF Internal" -> "Extra Attribute Context Manager". 

## **Using the Tool with XTMF**
The tool is called "ExtraAttributeContextManager". In XTMF, it is available to add under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## Module Parameters - "ExtraAttributeContextManager"

### Delete Flag
Tf set to true, this module will delete the attributes after running. Otherwise, this module will just ensure that the attributes exist and are initialized.

### Reset To Default
Reset the attributes to their default values if they already exist.

### Scenario
The number of the Emme scenario.

## Sub-Module Parameters - "ExtraAttributeContextManager" -> "Extra Attribute Data"

### Default
The default value for the extra attribute.

### Domain
Extra attribute domain (type). Accepted values are NODE, LINK, TURN, TRANSIT_LINE, or TRANSIT_SEGMENT.

### id
The 6-character ID string of the extra attribute, including the '@' symbol.