# **Export Binary Matrix**
> [!NOTE]
>This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Export Binary Matrix in XTMF1/TMGToolbox1.

The Export Binary Matrix tool allows XTMF to be able to Export Binary Matrix within an EMME Databank in the new binary format. To use this tool requires providing type of matrix and matrix number to export (see parameter explanation below)

## **Using the Tool with Modeller**
`ExportBinaryMatrix` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Export" -> "Export Binary Matrix". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Export/export_binary_matrix.py).

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Export Binary Matrix tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ExportBinaryMatrix` tool can be set by the users. This tool is called `ExportBinaryMatrix`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can call the `ExportBinaryMatrix` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "matrix_type": 4,
    "matrix_number": 1,
    "file_location": "test_matrix.mtx",
    "scenario_number": 1,
}
export_matrix = _MODELLER.tool("tmg2.Export.export_binary_matrix")
export_matrix(parameters)
```

### Module Parameter Explanation: "Export Binary Matrix"

|Parameter `type`|Explanation|
| :----------------------------- | :---------------------------------------------- |
| Scenario Number `integer` |The scenario number of export the matrix from.|
| Matrix Number `integer` |The matrix number to export. e.g. 10|
| Matrix Type `integer` |The matrix type to export. [1=ms, 2=mo, 3=md, 4=mf] For instance, setting matrix type to 4 exports "mf"|
| File Location `string` |The location to write the file.|
