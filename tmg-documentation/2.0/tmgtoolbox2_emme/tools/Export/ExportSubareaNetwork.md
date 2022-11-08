# **Export Subarea Network**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2.

The Export Subarea Network exports the road network for a subarea as defined by the node attribute containing the subarea definition. For each class, the `ExportSubareaNetwork` tool extracts:

* the traversal demand matrices, 
* link volumes
* turn volumes 
* transit network (optional)
* traffic and transit traversal demand matrices  (optional)

Latest version of this tool includes the ability to:
  > * Optionally, use a polygon shapefile to create the node extra attribute that defines the subarea. There are various ways to create/define a subarea. If the subarea is already defined, set the Create Nflag From Shapefile  to False.


## **Using the Tool with Modeller**

TMG's `ExportSubareaNetwork` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call. However, INRO has a version of this tool in its Emme Standard Toolbox. To use this version in the Modeller, navigate to "Subarea" -> "Subarea".

The TMG tool can be found in "TMG Toolbox 2" -> "Export" -> "Export Subarea Network". You can find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/1760d274282f35803fe7fb9784b511b6a8f5eb41/TMG.EMME/TMGToolbox2/src/Export/export_subarea.py).

## **Using the Tool with XTMF2**

> [!CAUTION] > **NOTE TMG Modeller**: Update (and delete this warning) the location where Export Subarea Network tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ExportSubareaNetwork` tool can be set by the users. This tool is called `ExportSubareaNetwork`. In **XTMF2**, it is available to add within a model system under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `ExportSubareaNetwork` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "extract_transit": True,
    "i_subarea_link_selection": "i=21,24 or i=27 or i=31,34",
    "j_subarea_link_selection": "j=21,24 or j=27 or j=31,34",
    "scenario_number": 3,
    "shape_file_location": "TestFiles/subarea_border.shp",
    "subarea_output_folder": "TestFiles\\Subarea",
    "create_nflag_from_shapefile": True,
    "create_gate_attribute": True,
    "subarea_node_attribute": "@nflag",
    "subarea_gate_attribute": "@gate",
    "background_transit": True,
    "br_gap": 0,
    "iterations": 4,
    "norm_gap": 0,
    "performance_flag": True,
    "r_gap": 0,
    "run_title": "road assignment",
    "sola_flag": True,
    "mixed_use_ttf_ranges": [{"start": 3, "stop": 128}],
    "traffic_classes": [
        {
            "name": "traffic class 1",
            "mode": "c",
            "demand_matrix": "mf10",
            "time_matrix": "mf0",
            "cost_matrix": "mf4",
            "toll_matrix": "mf0",
            "peak_hour_factor": 1,
            "volume_attribute": "@auto_volume1",
            "link_toll_attribute": " @toll",
            "toll_weight": 1,
            "link_cost": 0,
        }
    ],
}

export_subarea_network = _MODELLER.tool("tmg2.Export.export_subarea_network")
export_subarea_network(parameters)
```

### Module Parameter Explanation: "Export Subarea Network"

| Parameter `type`| Explanation|
| :------------------- | :------------------- |
|Extract Transit `boolean`|Set this to TRUE to export the subarea transit |
|I Subarea Link Selection  `string`|The outgoing connectors used to tag the centroids within the subarea. results are stored in the gate link attribute specified eg. "i=21,24 or i=27 or i=31,34"|
|J Subarea Link Selection  `string`| The incoming connectors used to tag the centroids within the subarea. results are stored in the gate link attribute specified eg. "j=21,24 or j=27 or j=31,34"|
|Subarea Output Folder  `string`| Folder directory to write output of the subarea database|
|Subarea Node Attribute  `string`| The node attribute that will be used to define the subarea.|
|Subarea Gate Attribute  `string`| The link extra attribute that defines your gate numbers |
|Create Gate Attribute `boolean`|Set this to TRUE to create gate labels for your network. NOTE: i & j link selections must be defined|
|Background Transit `boolean`|Set this to FALSE to not assign transit vehicles on the roads.|
|Best Relative Gap `float`|The minimum gap required to terminate the algorithm.| 
|Iterations `integer`|The maximum number of iterations to run.|
|Normalized Gap `float`|The minimum gap required to terminate the algorithm.|
|Performance Mode `boolean`|Set this to FALSE to leave a free core for other work, recommended leaving set to TRUE.|
|Relative Gap `float`|The minimum gap required to terminate the algorithm. |
|Run Title `string`|The name of the run to appear in the logbook|
|Scenario Number `integer`|The scenario number to execute against|
|Mixed Used TTF Ranged `range set`|The TTFs where transit vehicles will occupy some capacity on links. The ranges are inclusive.|

### Sub-Module Parameter Explanation:  "Subarea Node Attribute Definition - Shape File"
|Parameter  `type`|Explanation|
| :------------------- | :------------------- |
|Shape file Location  `string`| The shapefile name containing  the boundary of the subarea polygon|
|Create Nflag From Shapefile  `boolean`| set to False if subarea node attribute  is already defined in the network|

### Sub-Module Parameter Explanation:  "Traffic Classes"
|Parameter  `type`|Explanation|
| :------------------- | :------------------- |
|Cost Matrix `string`|The matrix number e.g. "mf4" to save the total cost into.|
|Demand Matrix `string`|The id of the demand matrix to use.|
|LinkCost `float`|The penalty in minutes per dollar to apply when traversing a link.|
|Mode `string`|The mode for this class.|
|Time Matrix `string`|The matrix number to save in vehicle travel times.|
|Toll Matrix `string`|The matrix to save the toll costs into.|
|Toll Weight `string`|to be updated.|
|TollAttributeID `string`|The attribute containing the road tolls for this class of vehicle.|
|VolumeAttribute `string`|The name of the attribute to save the volumes into (or None for no saving).|
|Peak Hour Factor `float`|A factor to apply to the demand in order to build a representative hour.|
