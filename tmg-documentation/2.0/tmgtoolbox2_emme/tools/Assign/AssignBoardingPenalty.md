# **Assign Boarding Penalty**
> [!NOTE]
>This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Assign Boarding Penalty in XTMF1/TMGToolbox1.

The Assign Boarding Penalty tool Assigns line-specific boarding penalties (stored in UT3) based on specified groupings, for transit assignment estimation. Latest version of the `AssignBoardingPenalty` includes:
* >  Ability to set IVTT perception factor
* >  Ability to set Transfer boarding penalties

## **Using the Tool with Modeller**
`AssignBoardingPenalty` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Assign" -> "Assign Boarding Penalty". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Assign/assign_boarding_penalty.py).

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Assign Boarding Penalty tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `AssignBoardingPenalty` tool can be set by the users. This tool is called `AssignBoardingPenalty`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can call the `AssignBoardingPenalty` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "scenario_numbers": [1, 2],
    "penalty_filter_string": [
        {
            "label": "GO Train",
            "filter": "mode=r",
            "initial": 1,
            "transfer": 1,
            "ivttPerception": 1,
        }
    ],
}
assign_boarding_penalty = _MODELLER.tool("tmg2.Assign.assign_boarding_penalty")
assign_boarding_penalty(parameters)
```

### Module Parameter Explanation: "Assign Boarding Penalty"

|Parameter `type`|Explanation|
| :----------------------------- | :---------------------------------------------- |
| Scenario Numbers  `integer` | A list of scenario numbers to assign boarding penalty to.|

### Module Parameter Explanation: "Assign Boarding Penalty - Penalty Filter String"

|Parameter `type`|Explanation|
| :----------------------------- | :---------------------------------------------- |
| Label `string` | The line group name e.g. GO Train.|
| Filter `string` | The network selector expression |
| Initial `float` | The number representing the initial boarding penalty |
| Transfer `float` | The number representing the transfer boarding penalty |
| IvttPerception `float` | The number representing the IVTT perception Factor |