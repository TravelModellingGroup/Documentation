# **Convert GTFS Stops To Shapefile**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Convert GTFS Stops To Shapefile in XTMF1/TMGToolbox1.

The Convert GTFS Stops To Shapefile converts the `stops.txt` file to a shapefile, flagging which modes it serves as well.

## **Using the Tool with Modeller**

`ConvertGTFSStopsToShapefile` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Convert" -> "Convert GTFS Stops To Shapefile". You can find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Convert/convert_gtfs_stops_to_shapefile.py).

## **Using the Tool with XTMF2**

> [!CAUTION] 
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Convert GTFS 
> Stops To Shapefile tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ConvertGTFSStopsToShapefile` tool can be set by the users. This tool is called `ConvertGTFSStopsToShapefile`. In **XTMF2**, it is available to add within a model system under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `ConvertGTFSStopsToShapefile` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
 parameters = {
    "gtfs_folder": "TestFiles/FrabtiztownGTFS",
    "shapefile_name": "OutputTestFiles/FrabtiztownStopShp",
}

convert_gtfs_stops_to_shapefile = _MODELLER.tool("tmg2.Convert.convert_gtfs_stops_to_shapefile")
convert_gtfs_stops_to_shapefile(parameters)
```

### Module Parameter Explanation: "Convert GTFS Stops To Shapefile"

| Parameter `type`        | Explanation                                      |
| :---------------------- | :----------------------------------------------- |
| GTFS Folder `string`    | The GTFS folder that contains the stops.txt file |
| Shapefile Name `string` | The name of the shapefile for export.            |
