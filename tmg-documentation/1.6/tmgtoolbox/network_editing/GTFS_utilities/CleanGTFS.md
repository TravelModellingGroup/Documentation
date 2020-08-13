# **Clean GTFS Folder**
This tool is used to filter a set of GTFS files by service ID(s). Four new *.csv files will be generated with a suffix ("file.updated"):
* stop_times
* stops
* shapes
* trips

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Network Editing" -> "GTFS Utilities" -> "Clean GTFS"

### GTFS Folder
Select the folder that conatins the GTFS feed files.

### Service ID(s)
List the service ID(s) that need to be kept in the updated GTFS files. Use comma to separate. The service ID(s) should be consistent with those in the *calendar.txt* file.

### (Optional) Filtered Routes
Select the comma-separated route file (*.txt or *.csv) which contains the route(s) that need to be kept in the updtaed GTFS files. This file should follow the same format as the original "routes.txt" file.

## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.

  