# **Export Network Shapefile**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Export Network Shapefile in XTMF1/TMGToolbox1.

The Export Network Shapefile exports network data from an EMME scenario to a specified shape file..

## **Using the Tool with Modeller**

`ExportNetworkShapefile` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Export" -> "Export Network Shapefile". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Export/export_network_shapefile.py).

## **Using the Tool with XTMF2**

> [!CAUTION] > **NOTE TMG Modeller**: Update (and delete this warning) the location where Export Network Shapefile tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ExportNetworkShapefile` tool can be set by the users. This tool is called `ExportNetworkShapefile`. In **XTMF2**, it is available to add within a model system under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `ExportNetworkShapefile` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "export_file": "OutputTestFiles/exportedNWP.nwp",
    "scenario_number": 1,
    "export_path": "OutputTestFiles/exportedSHP_m.shp",
    "transit_shapes": "SEGMENTS",
}

export_network_shapefile = _MODELLER.tool("tmg2.Export.export_network_shapefile")
export_network_shapefile(parameters)
```

### Module Parameter Explanation: "Export Network Shapefile"

| Parameter `type`          | Explanation                                              |
| :------------------------ | :------------------------------------------------------- |
| Scenario Number `integer` | The scenario number containing network to export.        |
| Save To `string`          | The location to write the file.                          |
| TransitShapes `string`    | Type of geometry or transit shape to export e.g. SEGMENT |
