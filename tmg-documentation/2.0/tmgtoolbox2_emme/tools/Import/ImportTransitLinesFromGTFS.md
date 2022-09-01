# **Import Transit Lines From Gtfs**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Generate Transit Lines From Gtfs in XTMF1/TMGToolbox1.

The Import Transit Lines From Gtfs imports transit line ITINERARIES ONLY from GTFS data. Assumes that most GTFS stop are matched to a group ID (GID) and each GID is matched to a network node. Both tables are inputs for this tool.

Additionally, the 'routes' file of the GTFS feed must define two additional columns: 'emme_id' (defining up to the first 5 characters of the Emme transit line id), and 'emme_vehicle' (defining the Emme vehicle number used by the line). For convenience, if both 'routes.txt' and 'routes.csv' are defined, the CSV file will be used (since this is likely to be edited using Excel).
    
During the map-matching process, this tool will attempt to find the shortest path between two nodes in an itinerary, up to a maximum of 10 links. Any line requiring a path of more than 5 links will be flagged for review. Lines requiring longer paths will not be added at all (but will be reported in the logbook).

## **Using the Tool with Modeller**

TMG's `ImportTransitLinesFromGtfs` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call. However, INRO has a tool called Import from GTFS, which can be found within the EMME Modeller at Data management -> Network -> Transit -> Import from GTFS.

The TMG tool can be found in "TMG Toolbox 2" -> "Import" -> "Import Transit Lines From Gtfs". You can find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Import/import_transit_lines_from_gtfs.py).

## **Using the Tool with XTMF2**

> [!CAUTION] > **NOTE TMG Modeller**: Update (and delete this warning) the location where Import Transit Lines From Gtfs tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ImportTransitLinesFromGtfs` tool can be set by the users. This tool is called `ImportTransitLinesFromGtfs`. In **XTMF2**, it is available to add within a model system under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `ImportTransitLinesFromGtfs` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "scenario_id": 1,
    "max_non_stop_nodes": 15,
    "link_priority_attribute": "",
    "gtfs_folder": "TestFiles/FrabtiztownGTFS",
    "stop_to_node_file": "TestFiles/FrabtiztownGTFS/stop_to_node.csv",
    "new_scenario_id": 2,
    "new_scenario_title": "Test Transit Network",
    "service_table_file": "ServiceTable",
    "mapping_file": "mapping",
    "publish_flag": True,
}

import_transit_lines_from_gtfs = _MODELLER.tool("tmg2.Import.import_transit_lines_from_gtfs")
import_transit_lines_from_gtfs(parameters)
```

### Module Parameter Explanation: "Import Transit Lines From Gtfs"

| Parameter `type`        | Explanation                                      |
| :---------------------- | :----------------------------------------------- |
| Base Scenario `integer`    | The scenario to execute against |
| MaxNonStopNodes `integer` | Lines requiring links more than the maximum will not be added. |
| Link Priority Attribute Id `string` |The factor to be applied to link speeds. |
| Gtfs Folder `string` | The folder that conatins the GTFS feed files. |
| Stop To Node File `string` | The csv file that contains Stop IDs and the corresponding Emme Node IDs. |
| NewScenarioId `integer` | The scenario ID to publish the new network. |
| NewScenarioTitle `string` | The title of the new scenario." |
| LineServiceTableFile `string` |The file name to store the output service table file. |
| Mapping File Name `string` | The file name to store the output that maps between EMME ID and GTFS Trip ID. |
| Publish Flag `boolean` | Set as True to publish the network to the new scenario. |




