# **Assign Traffic**
> [!NOTE]
>This tool works with Emme version 4.5.1+, XTMF2, and produces results similar to the Multi Class Road Assigntment tool in XTMF1/TMGToolbox1.

The Assign Traffic tool executes a multi-class road assignment which allows for the generalized penalty of road tolls. `AssignTraffic` is a toll-based road assignemnt tool.

Latest version of this tool includes the ability to:
  > * Increase resolution of analysis by adding link volume attributes
  > * Allow for multi-threaded matrix calculation in 4.2.1+
  > * Receive JSON object parameters from XTMF2
  > * Receive JSON file parameters from Python API call

## **Using the Tool with Modeller**
`AssignTraffic` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Assign" -> "Assign Traffic". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Assign/assign_traffic.py).  

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update the location where tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `AssignTraffic` tool can be set by the users. This tool is called `AssignTraffic`. In XTMF2, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an external Python API call**
You can call the `AssignTraffic` via by call the python API. Below is a script sample.

**script example**
```python
import AssignTraffic as assignTransit
parameters = {
    "background_transit": True,
    "br_gap": 0,
    "iterations": 100,
    "norm_gap": 0,
    "performance_flag": True,
    "r_gap": 0,
    "run_title": "road assignment",
    "scenario_number": 1,
    "sola_flag": True,
    "traffic_classes": [
        {
            "name": "traffic class 1",
            "mode": "c",
            "demand_matrix": "mf10",
            "time_matrix": "mf0",
            "cost_matrix": "mf4",
            "toll_matrix": "mf0",
            "peak_hour_factor": 1,
            "volume_attribute": "@auto_volume1",
            "link_toll_attribute": " @toll",
            "toll_weight": 1,
            "link_cost": 0,
            "path_analyses": [
                {
                    "attribute_id": "1",
                    "aggregation_matrix": "",
                    "aggregation_operator": "max",
                    "lower_bound": "7",
                    "upper_bound": "7",
                    "path_selection": "all",
                    "multiply_path_prop_by_demand": "7",
                    "multiply_path_prop_by_value": "7",
                    "analysis_attributes": "",
                    "analysis_attributes_matrix": "mf0",
                }
            ],
        }
    ],
}
assignTransit(parameters) 
```
### Module Parameter Explanation: "Assign Traffic"
|Parameter|Explanation|
| :------------------- | :------------------- |
|Background Transit|Set this to FALSE to not assign transite vehicles on the roads.|
|Best Relative Gap|The minimum gap required to terminate the algorithm.| 
|Iterations|The maximum number of iterations to run.|
|Normalized Gap|The minimum gap required to terminate the algorithm.|
|Peak Hour Factor|A factor to apply to the demand in order to build a representative hour.|
|Performance Mode|Set this to FALSE to leave a free core for other work, recommended to leave set to TRUE.|
|Relative Gap|The minimum gap required to terminate the algorithm. |
|Run TItle|The name of the run to appear in the logbook|
|Scenario Number|The scenario number to execute against|
### Sub-Module Parameter Explanation:  "Traffic Classes"
|Parameter|Explanation|
| :------------------- | :------------------- |
|Cost Matrix|The matrix number to save the total cost into.|
|Demand Matrix|The id of the demand matrix to use.|
|LinkCost|The penalty in minutes per dollar to apply when traversing a link.|
|Mode|The mode for this class.|
|Time Matrix|The matrix number to save in vehicle travel times.|
|Toll Matrix|The matrix to save the toll costs into.|
|Toll Weight|to be updated.|
|TollAttributeID|The attribute containing the road tolls for this class of vehicle.|
|VolumeAttribute|The name of the attribute to save the volumes into (or None for no saving).|
### Sub-Module Parameter Explanation: "Traffic Classes -> Path Analysis"
|Parameter|Explanation|
| :------------------- | :------------------- |
|Aggregation Matrix|The matrix number to store the results into.|
|Attribute ID|The attribute to use for analysis.|
|Lower Bound for Path Selector|The number to use for the lower bound in path selection, or None if using all paths|
|Multiply Path Proportion By Analyzed Demand|Choose whether to multiply the path proportion by the analyzed demand.|
|Multiply Path Proportion By Path Value|Choose whether to multiply the path proportion by the path value.|
|Operator|The operator to use to aggregate the matrix. Example: '+' for emissions, 'max' for select link analysis. `Full list of operators that can be used: +, -, *, /, %, .max., .min.`|
|Paths to Select|The paths that will be used for analysis.|
|Upper Bound for Path Selector|The number to use for the upper bound in path selection, or None if using all paths.|
