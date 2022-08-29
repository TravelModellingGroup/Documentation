# **Export Network Package**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Export Network Package in XTMF1/TMGToolbox1.

The Export Network Package Exports all scenario data files (modes, vehicles, nodes, links, transit lines, link shape, and turns) to a compressed network package file (\*.nwp). Descriptions that are empty, have single quotes, or double quotes will be replaced by 'No Description', grave accents (`), and spaces.".

## **Using the Tool with Modeller**

`ExportNetworkPackage` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Export" -> "Export Network Package". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Export/export_network_package.py).

## **Using the Tool with XTMF2**

> [!CAUTION] > **NOTE TMG Modeller**: Update (and delete this warning) the location where Export Network Package tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ExportNetworkPackage` tool can be set by the users. This tool is called `ExportNetworkPackage`. In **XTMF2**, it is available to add within a model system under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `ExportNetworkPackage` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "export_file": "OutputTestFiles/exportedNWP.nwp",
    "scenario_number": 1,
    "extra_attributes": "all",
    "export_all_flag": True,
    "export_meta_data": "",
}

export_network_package = _MODELLER.tool("tmg2.Export.export_network_package")
export_network_package(parameters)
```

### Module Parameter Explanation: "Export Network Package"

| Parameter `type`          | Explanation                                                                      |
| :------------------------ | :------------------------------------------------------------------------------- |
| Scenario Number `integer` | The scenario number of export the matrix from.                                   |
| Attributes `string`       | A comma separated list of attributes to load. Enter 'all' to get all attributes. |
| Save To `string`          | The location to write the file.                                                  |
| Export All Flag `boolean` | Export all extra attributes?                                                     |
| Export Meta Data `string` | Export Comments                                                                  |
