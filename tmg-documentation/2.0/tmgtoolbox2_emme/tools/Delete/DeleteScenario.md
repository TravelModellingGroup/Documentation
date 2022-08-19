# **Delete Scenario**
> [!NOTE]
>This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Delete Scenario in XTMF1/TMGToolbox1.

The Delete Scenario tool will allow XTMF to be able to delete a scenario within an EMME Databank.

## **Using the Tool with Modeller**
`DeleteScenario` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Delete" -> "Delete Scenario". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Delete/delete_scenario.py).

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Delete Scenario tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `DeleteScenario` tool can be set by the users. This tool is called `DeleteScenario`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can call the `DeleteScenario` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "scenario": 1,
}

delete_scenario = _MODELLER.tool("tmg2.Delete.delete_scenario")
delete_scenario(parameters)
```

### Module Parameter Explanation: "Delete Scenario"

|Parameter `type`|Explanation|
| :----------------------------- | :------------------------- |
|Scenario `integer` |The EMME scenario to delete.|
