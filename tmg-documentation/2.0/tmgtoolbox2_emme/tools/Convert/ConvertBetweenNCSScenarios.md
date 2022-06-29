# **Convert Between NCS Scenarios**
> [!NOTE]
>This tool works with Emme version 4.5.1+, XTMF2.

The `ConvertBetweenNCSScenarios` converts a network within an EMME scenario of interest from one Network Coding Standard (NCS) to another. As at the time of building this tool, the NCS 2022 was the highest standard. A reference to the latest NCS22 can be downloaded from the TMG website here [here.](https://tmg.utoronto.ca/wp-content/uploads/2022/05/NCS22_Final_Mar-25-22.pdf) and the latest conversion done with this tool was from [NCS16](https://tmg.utoronto.ca/files/coding_standards/2016_Network_Coding_Standard.pdf) to [NCS22](https://tmg.utoronto.ca/wp-content/uploads/2022/05/NCS22_Final_Mar-25-22.pdf)


Assumptions in the `ConvertBetweenNCSScenarios` tool include:
  > * User to provide all need CSV input files
  > * File's columns/row must match the format specified in the this documentation for this tool to work without issues. 
  > * For every new network that a user wants to convert, user has to provide the corresponding input files for that network.

## **Tool Flow**
To run the this tool, parameters can be provided by the modeller through the XTMF2 GUI or as python API call. THe tool begins by reading and getting the Emme network from the scenario specified. After the `ConvertBetweenNCSScenarios` tool reads all the input files files provided, it begins by updating zone centroid numbers, mode code definitions, extra attributes, transit vehicle definitions, lane capacity, and then finishes updating transit line codes.

Finally, the tool copies the sceanrio, with all the new updates into a clean scenario specified by the user before run.


## **Using the Tool with Modeller**
`ConvertBetweenNCSScenarios` tool has a GUI version that runs in Emme Modeller and can be found in "TMG Toolbox 2" -> "Convert" -> "Convert Between NCS Scenarios". You can find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Convert/convert_between_ncs_scenarios.py).

## **Using the Tool with XTMF2**
Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ConvertBetweenNCSScenarios` tool can be set by the users. This tool is called `ConvertBetweenNCSScenarios`. In **XTMF2**, it is available to add within a model system under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## **Using the Tool from an External Python API Call**
You can also call the `ConvertBetweenNCSScenarios` tool by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
parameters = {
    "old_ncs_scenario": 0,
    "new_ncs_scenario": 2,
    "station_centroid_file": "station_centriods.csv",
    "zone_centroid_file": "zone_centriods.csv",
    "mode_code_definitions": "mode_code_definitions.csv",
    "link_attributes": "link_attributes.csv"
    "transit_vehicle_definitions": "transit_vehicles.csv",
    "lane_capacities": "lane_capacities.csv",
    "transit_line_codes": "transit_line_codes.csv",
    "skip_missing_transit_lines": False,
}
convert_ncs_scenario = _MODELLER.tool("tmg2.Convert.convert_between_ncs_scenarios")
convert_ncs_scenario(parameters)
```

### Module Parameter Explanation: "Convert Between NCS Scenarios"

|Parameter `type`|Explanation `column/field header of csv file`|
| :----------------------------- | :---------------------------------------------- |
|Old NCS Scenario `integer` | This is the original network scenario |
|New NCS Scenario `integer` | The location where the converted scenario will be stored in |
|Station Centroid File `string` | Csv file with the station centroid data. `station`, `external_zone`, `centroid_old`, `centroid_new`|
|Zone Centroid File `string` | Csv file of zone centroids. `region`, `from_NCS16`, `to_NCS16`, `from_NCS22`, `to_NCS22` |
|Mode Code Definition File `string` |Csv file of mode definitions. `description`, `type`, `mode_old`, `mode_new`|
|Link Attributes File `string` | Csv file of link attributes. `link_attribute`, `description`|
|Transit Vehicle Definition File `string` | Csv file of traffic vehicles. `Description`, `Old_Code`, `Old_Mode`, `Old_Seat`, `Old_Total`, `old_cap`, `Old_Auto`, `old_equi`, `New_Code`, `New_Mode`, `New_Seat`, `New_Total`, `New_cap`, `New_Auto`, `New_equi`|
|Lane Capacities File `string` | Csv file of lane capacities. `vdf_old`, `new_lane_capacity`  |
|Transit Line File `string` | Csv file of the transit lines. `old_ncs_line_code`, `new_ncs_line_code`|
|Skip Missing Transit Lines `boolean` | Boolean value to determine if user should skip missing transit lines. Default is False. In Emme Modeller, click checkbox to select True so missing transit lines are skipped|






