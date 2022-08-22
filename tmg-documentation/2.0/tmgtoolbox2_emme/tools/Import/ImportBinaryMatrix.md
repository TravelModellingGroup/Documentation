# **Import Binary Matrix**
> [!NOTE]
>This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Import Binary Matrix in XTMF1/TMGToolbox1.

The Import Binary Matrix tool allows XTMF to be able to Import Binary Matrix into an EMME Databank in the new binary format. To use this tool requires specifying the file location, type of matrix and matrix number to be imported (see parameter explanation below)

## **Using the Tool with Modeller**
`ImportBinaryMatrix` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Import" -> "Import Binary Matrix". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Import/import_binary_matrix.py).

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Import Binary Matrix tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ImportBinaryMatrix` tool can be set by the users. This tool is called `ImportBinaryMatrix`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can call the `ImportBinaryMatrix` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "matrix_type": 4,
    "matrix_number": 1,
    "file_location": "test_matrix.mtx",
    "scenario_number": 1,
    "matrix_description": "test description",
}
import_matrix = _MODELLER.tool("tmg2.Import.import_binary_matrix")
import_matrix(parameters)
```

### Module Parameter Explanation: "Import Binary Matrix"

|Parameter `type`|Explanation|
| :----------------------------- | :---------------------------------------------- |
| Scenario Number `integer` |The number of the scenario that this matrix is for.|
| Matrix Number `integer` |The matrix number to import this matrix to.t. e.g. 10|
| Matrix Type `integer` |The matrix type to import. [1=ms, 2=mo, 3=md, 4=mf] For instance, setting matrix type to 4 imports "mf"|
| File Location `string` |The location of the matrix file to import.|
| Description `string` |The description to apply to the matrix.|
