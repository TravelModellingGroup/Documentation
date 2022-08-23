# **Rotate Network**
> [!NOTE]
>This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Rotate Network in XTMF1/TMGToolbox1.

The Rotate Network tool Rotates & translates network based on two corresponding links. Select the node ids of a link in the network you want to rotate and translate, and then enter in the coordinates of the exact same link in your reference network. 

> [!CAUTION]
> **Warning**: This tool makes irreversible changes to your scenario! make sure you copy before running.

## **Using the Tool with Modeller**
`RotateNetwork` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Convert" -> "Rotate Network". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Convert/rotate_network.py).

## **Using the Tool with XTMF2**
> [!CAUTION]
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Rotate Network tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `RotateNetwork` tool can be set by the users. This tool is called `RotateNetwork`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can call the `RotateNetwork` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "scenario_number": 2,
    "reference_link_i_node": 10048,
    "reference_link_j_node": 11,
    "corresponding_x_0": 511713.7,
    "corresponding_y_0": 9161352,
    "corresponding_x_1": 511722.1,
    "corresponding_y_1": 9161122,
}
rotate_network = _MODELLER.tool("tmg2.Convert.rotate_network")
rotate_network(parameters)
```

### Module Parameter Explanation: "Rotate Network"

|Parameter `type`|Explanation|
| :----------------------------- | :---------------------------------------------- |
| Scenario Number `integer` | Scenario number containing network to rotate |
| Reference Link I Node `integer` | I-node of link from network to rotate |
| Reference Link J Node `integer` | J-node of link from network to rotate |
| Corresponding X0 `float` | Corresponding xi coordinate of I-node |
| Corresponding Y0 `float` | Corresponding yi coordinate of I-node |
| Corresponding X1 `float` | Corresponding xi coordinate of J-node |
| CorrespondingY 1 `float` | Corresponding yi coordinate of J-node |