# Network Package (*.nwp) File Format

The network package format is a compressed file with .NWP extension, stores all network elements and information in an Emme scenario. Elements of a network such as modes, nodes and links, turns, transit vehicles, lines, and segments from the Emme database are stored in this format. 

> [!NOTE]
>The NWP file does not contain the strategies used in the transit assignment.

The `NWP` file also ensures that the database attributes, relational integrity, hierarchy, and organization in the network are maintained.


## **Network Attributes**
The `NWP` file can contain three types of network attributes as defined within the Emme database namely:

* Standard attributes - predefined attributes eg. link length
* Extra attributes - user defined attributes eg. @toll, @gate, etc.
* Network assignment result attributes - automatically written to the network after a network assignment is completed, e.g. transit volumes on line segments, auto volumes on turns, etc.

## **File Specification**
`NWP` files can be "unzipped" using a software package like "7zip" or even windows (by changing the extension from ".nwp" to ".zip". After unzipping, the individual files can be examined or even modified according to the end users goals. The files can be then be "zipped" again and the extension changed back to ".nwp" for use in the tool. 

> [!CAUTION]
> Manually editing the files in this manner is only recommended for advanced users. 

An `NWP` file at minimum contains the following: 
> * version.txt 
> * info.txt 
> * base.211 
> * functions.411 
> * modes.201 
> * shapes.251 
> * transit.221 
> * turns.231 
> * vehicles.202

The following if available are the assignment results related files
> * aux_transit_results.csv
> * link_results.csv
> * segment_results.csv
> * turn_results.csv

## **Exporting the Network Package File**
`NWP` files can be exported from a scenario using XTMF1 and Emme Modeller, see [documentation](https://tmg.utoronto.ca/doc/1.6/tmgtoolbox/input_output/ExportNetworkPackage.html)

Codes used to export .NWP files from an Emme scenario can be found [here](https://github.com/TravelModellingGroup/TMGToolbox/blob/dev/TMGToolbox/src/input_output/export_network_package.py).

## **Importing the Network Package File**
`NWP` files can be imported into an Emme scenario via XTMF1 and Emme Modeller, see [documentation](https://tmg.utoronto.ca/doc/1.6/tmgtoolbox/input_output/ImportNetworkPackage.html)

The code used to import .NWP files into an Emme scenario can be found [here](https://github.com/TravelModellingGroup/TMGToolbox/blob/dev/TMGToolbox/src/input_output/import_network_update.py).

