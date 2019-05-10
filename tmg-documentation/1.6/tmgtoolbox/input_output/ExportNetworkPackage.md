# **Export Network Package**
The export network package allows the user to export a scenario in a compact file. This makes use of the NWP format, the same format that is used in the Import Network Package tool
> An NWP file is a zip file that contains all the information in an Emme Network including the results of an assignment. It does not contain the strategies used in the transit assignment however.  NWP files can be "unzipped" using a software package like "7zip" or even windows (by changing the extension from ".nwp" to ".zip". After unzipping, the individual files can be examined or even modified according to the end users goals. The files can be then be "zipped" again and the extension changed back to ".nwp" for use in the tool. Manually editing the files in this manner is only recommended for advanced users.
> An NWP file at minimum contains the following:
> version.txt
> info.txt
> base.211
> functions.411
> modes.201
> shapes.251
> transit.221
> turns.231
> vehicles.202
> 
> The following are extra attribute related files which are optional
> exatts.241
> exatt_transit_lines.241
> exatt_segments.241
> exatt_nodes.241
> exatt_links.241
> 
> The following are assignment results related files which are optional
> aux_transit_results.csv
> link_results.csv
> segment_results.csv
> turn_results.csv


## **Using the Tool with Modeller**
The tool be found in "TMG Toolbox" -> "Input Output" -> "Export Network Package"
### Scenario
The scenario that you wish to export is specified here. Only one scenario can be exported at one time

### File Name
The Exported NWP file name and file location is to be provided here. Press "Browse" to navigate to the place that you wish to save the NWP

### Dealing with Extra Attributes
There are two ways to deal with Extra Attributes. One can export all of them by selecting the "Export all extra attributes?" box or individual Extra Attributes can be selected using the "Extra Attributes" search box. It is generally a good idea to only export the attributes you will need to make it a cleaner network. 


## **Using the Tool with XTMF**
The tool is called "ExportNetworkPackage". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun

### Attributes to Export
A list of extra attribute IDs to include in the NWP file (including the '@' symbol).  If you enter in 'All' all attributes will be exported."

### Scenario
The Emme scenario to export

### Export File
The location where the exported network package will be saved should be specified here by adding the appropriate module and then selecting the file location.










