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


![alt text](images/boarding_alighting.drawio.svg "Export Boarding and Alighting Flowchart")


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
import ExportBoardingAndAlighting as export_a_b
"""
    sample inputs.csv
        id, station_desc
        100, Keele
        322, Union
"""
parameters = {
    "scenario_number": 2,
    "input_file": "inputs.csv",
    "export_file": "stops.csv",
}
export_a_b.run(parameters)
```
### Module Parameter Explanation: "Assign Traffic"
|Parameter `type`|Explanation|
| :------------------- | :------------------- |
|Scenario Number `integer`|The scenario number to execute against|
|Input File `string`|CSV file path containing id of stop of interest and description of stop (eg. station_desc), if available, to read from|
|Scenario Number `string`|CSV file path right output to. The output has the following header `"node_id", "boardings", "alightings", "x", "y", "station"`|
