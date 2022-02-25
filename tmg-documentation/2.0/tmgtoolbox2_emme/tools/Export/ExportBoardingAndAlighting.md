# **Export Boarding And Alighting**
> [!NOTE]
>This tool works with Emme version 4.5.1+ and XTMF2.

The Export Boarding And Alighting tool extracts total number of boardings and alightings on each transit stop.  `ExportBoardingAndAlighting` is a tool that is used to process Assigned Networks coming out of a GTAModel run.

Latest version of this tool includes the ability to:
  > * Receive JSON object parameters from XTMF2 containing location to input files, output files, and EMME scenario containing assigned network (from GTAModel) to process
  > * Receive JSON file parameters from Python API call containing location to input files, output files, and EMME scenario containing assigned network (from GTAModel) to process (see parameter Script Example below)
  > * The input file is a comma-separated values (CSV) file containing id of stop of interest and description of stop (eg. station name), if available

## **Tool Flow**
To run the this tool, parameters can be provided by the user through the XTMF2 GUI or as python API call. 

> [!IMPORTANT]
>This tool only works if scenario has transit result.

<figure>
    <img src="images/boarding_alighting.drawio.svg"
         alt="Export Boarding and Alighting Flowchart">
    <figcaption>Figure 1: Export Boarding and Alighting Flowchart</figcaption>
</figure>

## **Using the Tool with Modeller**
`ExportBoardingAndAlighting` tool is not callable from Emme Modeller. It is intended and only to be called from XTMF2 or via a python API call.

The tool can be found in "TMG Toolbox 2" -> "Export" -> "Export Boarding And Alighting". You can
find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Export/export_boarding_and_alighting.py).

## **Using the Tool with XTMF2**
Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ExportBoardingAndAlighting` tool can be set by the users. This tool is called `ExportBoardingAndAlighting`. In **XTMF2**, it is available to add within a model system.

## **Using the Tool from an External Python API Call**
You can call the `ExportBoardingAndAlighting` by calling the python API. Below is a script sample.

**Script Example**
```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
"""
    sample inputs.csv
        id, station_desc
        100, Keele
        322, Union
"""
parameters = {
    "scenario_number": 5,
    "input_file": "node_of_interest.csv",
    "export_file": "stops_boarding_alightings_PM.csv",
    "use_input_file": False
}
export_board_and_alight = _MODELLER.tool("tmg2.Export.export_boarding_and_alighting")
export_board_and_alight(parameters)
```
### Module Parameter Explanation: "Assign Traffic"
|Parameter `type`|Explanation|
| :------------------- | :------------------- |
|Scenario Number `integer`|The scenario number to execute against|
|Input File `string`|CSV file path containing id of stop of interest and description of stop (eg. station_desc), if available, to read from|
|Output File `string`|CSV file path right output to. The output has the following header `"node_id", "boardings", "alightings", "x", "y", "station"`|
|Use Input File `boolean`|Set to `true` if you have your node ids of interest or `false` if you want the tool to use the nodes of interest from network in specified scenario|
