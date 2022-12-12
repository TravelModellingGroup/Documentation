# **ExportMatching Emme Nodes For Gtfs Stops**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG GTFS to Emme Map in XTMF1/TMGToolbox1.

The ExportMatching Emme Nodes For Gtfs Stops takes the stops.txt file or a shapefile to create a mapping file that shows the node in
the EMME network which it corresponds to.

## **Using the Tool with Modeller**

TMG's `ExportMatchingEmmeNodesForGtfsStops` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or
via a python API call. However, INRO has a tool called Import from GTFS, which can be found within the EMME Modeller at Data management
-> Network -> Transit -> Export to GTFS.

The TMG tool can be found in "TMG Toolbox 2" -> "Import" -> "ExportMatching Emme Nodes For Gtfs Stops". You can find the code for this
tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Export/export_matching_emme_nodes_for_gtfs_stops.py).

## **Using the Tool with XTMF2**

> [!CAUTION] 
> **NOTE TMG Modeller**: Update (and delete this warning) the location where ExportMatching Emme Nodes For Gtfs 
> Stops tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ExportMatchingEmmeNodesForGtfsStops` tool can be set by the users
. This tool is called `ExportMatchingEmmeNodesForGtfsStops`. In **XTMF2**, it is available to add within a model system
under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `ExportMatchingEmmeNodesForGtfsStops` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "input_stop_file": "TestFiles/FrabtiztownGTFS/stops.txt",
    "output_mapping_file": "OutputTestFiles/stop_to_node.csv",
}

export_matching_emme_nodes_for_gtfs_stops = _MODELLER.tool("tmg2.Export.export_matching_emme_nodes_for_gtfs_stops")
export_matching_emme_nodes_for_gtfs_stops(parameters)
```

### Module Parameter Explanation: "ExportMatching Emme Nodes For Gtfs Stops"

| Parameter `type`        | Explanation                                      |
| :---------------------- | :----------------------------------------------- |
| Stops Input File `string` | The stops input file in txt or shp format. |
| Output File `string` | The output mapping file. |