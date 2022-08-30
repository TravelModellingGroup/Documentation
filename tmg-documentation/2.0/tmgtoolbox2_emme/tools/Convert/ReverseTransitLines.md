# **Reverse Transit Lines**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Reverse Transit Lines in XTMF1/TMGToolbox1.

The Reverse Transit Lines reverses the itineraries of a subset of transit lines. It will try to preserve the line ID of the original line by appending or modifying the final character. Reports to the Logbook which new lines are reversed copies of which other lines.

## **Using the Tool with Modeller**

`ReverseTransitLines` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Convert" -> "Reverse Transit Lines". You can find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Convert/reverse_transit_lines.py).

## **Using the Tool with XTMF2**

> [!CAUTION] > **NOTE TMG Modeller**: Update (and delete this warning) the location where Reverse Transit Lines tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ReverseTransitLines` tool can be set by the users. This tool is called `ReverseTransitLines`. In **XTMF2**, it is available to add within a model system under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `ReverseTransitLines` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
 parameters = {
    "line_selector_expression": 3,
    "scenario_number": "mode=r",
}

reverse_transit_lines = _MODELLER.tool("tmg2.Convert.reverse_transit_lines")
reverse_transit_lines(parameters)
```

### Module Parameter Explanation: "Reverse Transit Lines"

| Parameter `type`                  | Explanation                                                       |
| :-------------------------------- | :---------------------------------------------------------------- |
| Scenario Number `integer`         | Scenario number containing network to rotate                      |
| Line Selector Expression `string` | Write a network calculator expression to select lines to reverse. |
