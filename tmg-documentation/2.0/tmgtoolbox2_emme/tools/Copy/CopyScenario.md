# **Copy Scenario**
> [!NOTE]
>This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Copy Scenario in XTMF1/TMGToolbox1.

The Copy Scenario tool allows XTMF to be able to copy scenario within an EMME Databank.

## **Using the Tool with Modeller**
`CopyScenario` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Copy" -> "Copy Scenario". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Copy/copy_scenario.py).

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Copy Scenario tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `CopyScenario` tool can be set by the users. This tool is called `CopyScenario`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can call the `CopyScenario` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "from_scenario": 1,
    "to_scenario": 2,
    "copy_strategy": False
}

copy_scenario = _MODELLER.tool("tmg2.Copy.copy_scenario")
copy_scenario(parameters)
```

### Module Parameter Explanation: "Copy Scenario"

|Parameter `type`|Explanation|
| :----------------------------- | :---------------------------------------------- |
|From Scenario `integer` |The EMME scenario to copy from.|
|To Scenario `integer` |The EMME scenario to copy to..|
|Copy Strategy `boolean` |Should assignment strategies also be copied?|
