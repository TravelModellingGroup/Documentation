# **Filter GTFS For Service Id And Routes**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Clean GTFS in XTMF1/TMGToolbox1.

The Filter GTFS For Service Id And Routes exports network data from an EMME scenario to a specified shape file..

## **Using the Tool with Modeller**

`FilterGTFSForServiceIdAndRoutes` Cleans a set of GTFS files by service ID. Filters all GTFS files except for routes, calendar, and shapes.

The TMG tool can be found in "TMG Toolbox 2" -> "Filter" -> "Filter GTFS For Service Id And Routes". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Filter/filter_gtfs_for_service_id_and_routes.py).

## **Using the Tool with XTMF2**

> [!CAUTION] > **NOTE TMG Modeller**: Update (and delete this warning) the location where Filter GTFS For Service Id And Routes tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `FilterGTFSForServiceIdAndRoutes` tool can be set by the users. This tool is called `FilterGTFSForServiceIdAndRoutes`. In **XTMF2**, it is available to add within a model system under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `FilterGTFSForServiceIdAndRoutes` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "gtfs_folder": "TestFiles/FrabtiztownGTFS",
    "service_id": "FrabtiztownTransit,
    "routes_file": "",
}

filter_gtfs_for_service_id_and_routes = _MODELLER.tool("tmg2.Export.filter_gtfs_for_service_id_and_routes")
filter_gtfs_for_service_id_and_routes(parameters)
```

### Module Parameter Explanation: "Filter GTFS For Service Id And Routes"

| Parameter `type`          | Explanation                                              |
| :------------------------ | :------------------------------------------------------- |
| GTFS Folder `string` | The location of the GTFS directory to be cleaned   |
| Service ID `string`          | Comma-separated list of Service IDs from the calendar.txt file|
| Updated Routes File `string`    | Optional Filtered Routes|
