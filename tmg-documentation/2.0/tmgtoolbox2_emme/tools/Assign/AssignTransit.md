# **Assign Transit**
> [!NOTE]
>This tool works with Emme version 4.5.1+, XTMF2, and produces results similar to the TMG Transit Assignment Tool in XTMF1/TMGToolbox1.

The Assign Transit tool runs a multi-class transit assignment which executes a congested transit assignment procedure for the GTAModel V4.0. `AssignTransit` also allows for surface transit speed updating.

Hard-coded assumptions in the `AssignTransit` tool include:
  > * Boarding penalties are assumed stored in UT3. 
  > * The congestion term is stored in US3.
  > * In-vehicle time perception is 1.0
  > * All available transit modes are used.

## **Using the Tool with Modeller**
`AssignTransit` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Assign" -> "Assign Transit". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Assign/assign_transit.py).

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Assign Transit tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `AssignTransit` tool can be set by the users. This tool is called `AssignTransit`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can call the `AssignTransit` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "calculate_congested_ivtt_flag": True,
    "node_logit_scale": True,
    "effective_headway_attribute": "@ehdw1",
    "effective_headway_slope": 0.165,
    "headway_fraction_attribute": "@frac1",
    "iterations": 100,
    "norm_gap": 0,
    "rel_gap": 0,
    "scenario_number": 1,
    "walk_speed": 0,
    "transit_classes": [
        {
            "name": "transit_class_name",
            "board_penalty_matrix": "mf0",
            "board_penalty_perception": 1,
            "congestion_matrix": "mf0",
            "demand_matrix": "mf0",
            "fare_matrix": "mf0",
            "fare_perception": 35,
            "in_vehicle_time_matrix": "mf0",
            "impedance_matrix": "mf0",
            "link_fare_attribute_id": "@lfare",
            "mode": "*",
            "perceived_travel_time_matrix": "mf0",
            "segment_fare_attribute": "@sfare",
            "wait_time_perception": 0,
            "wait_time_matrix": "mf0",
            "walk_time_perception_attribute": "@walkp",
            "walk_time_matrix": "mf0",
            "walk_perceptions": [
                {
                    "filter": "i=10000,20000 or j=1...7000,98000",
                    "walk_perception_value": 1.8,
                }
            ],
        }
    ],
    "surface_transit_speeds": [
        {
            "alighting_duration": 1.1219,
            "boarding_duration": 1.9577,
            "default_duration": 7.4331,
            "global_erow_speed": 35,
            "line_filter_expression": "",
            "mode_filter_expression": "b",
            "transit_auto_correlation": 1.612,
        }
    ],
    "ttf_definitions": [
        {"congestion_exponent": 5.972385, "congestion_perception": 1, "ttf": 1},
        {"congestion_exponent": 6.72, "congestion_perception": 2, "ttf": 2}
    ],
    "congestion_exponent": "",
    "assignment_period": 0,
    "name_string": "",
    "congested_assignment": True,
    "csvfile": "",
    "origin_distribution_logit_scale": 0,
    "walk_distribution_logit_scale": 3,
    "surface_transit_speed": True,
    "walk_all_way_flag": False,
    "xrow_ttf_range": "",
}
assign_transit = _MODELLER.tool("tmg2.Assign.assign_transit")
assign_transit(parameters)
```