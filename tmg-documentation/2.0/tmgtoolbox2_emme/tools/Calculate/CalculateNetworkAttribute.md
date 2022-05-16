# **Calculate Network Attribute**
> [!NOTE]
>This tool works with Emme version 4.5.1+, XTMF2, and produces results similar to the Network Calculator Tool in XTMF1/TMGToolbox1.
>In TMGToolbox1 this tool is similar to Network Calculator tool.

The Calculate Network Attribute tool queries and modifies most node, link, turn, transit line, vehicle, and segment attributes using algebraic expressions. `CalculateNetworkAttribute` also allows result to be saved in an attribute.

## **Tool Flowchart**
To run the this tool, parameters can be provided by the modeller through the XTMF2 GUI or as python API call.

## **Using the Tool with Modeller**
`CalculateNetworkAttribute` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Calculate" -> "Calculate Network Attribute". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Calculate.calculate_network_attribute.py).

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Calculate Network Attribute tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `CalculateNetworkAttribute` tool can be set by the users. This tool is called `CalculateNetworkAttribute`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can call the `CalculateNetworkAttribute` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "scenario_number": 1,
    "domain": 0,
    "expression": "sqrt((xi - xj) ^ 2 +...- yj) ^ 2)",
    "node_selection": None,
    "link_selection": "all",
    "transit_line_selection": None,
    "result": None,
}

network_attribute_calculator = _MODELLER.tool("tmg2.Calculate.calculate_network_attribute")
network_attribute_calculator(parameters)
```

### Module Parameter Explanation: "Calculate Network Attribute"

| Parameter `type`| Explanation |
| :------------------- | :----------------------- |
| Scenario Number `integer` | Emme Scenario Number to execute tool against|
| Domain `integer` | What Emme domain type is the result? Options: <span style="color:blue">`Link`, `Node`, `Transit_Line`, `Transit_Segment`</span>  |
| Expression `string` | What is the expression you want to compute? |
| Node Selection `string` | What specific nodes would you like to include in the calculation? <span style="color:blue">`Default=all`</span> |
| Link Selection `string` | What specific links would you like to include in the calculation? <span style="color:blue">`Default=all`</span> |
| Transit Line Selection `string` | What specific transit lines would you like to include in the calculation? <span style="color:blue">`Default=all`</span> |
| Result `string` | The attribute to save the result into, leave blank to not save. |
