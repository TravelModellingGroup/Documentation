# Adding a New Drive Access Station

In order to create a new access station in the model you will need to follow the following steps.  Each access station model is expected to have a unique zone number in the range 9000-9999.  It is possible to define a different node range for access stations however the model system has been configured for this range by default.  The following instructions are for model systems that are not multi-run configured.  To add a new access station to in a multi-run configuration you will need to follow the same changes except targeting the correct forecasting directory.  These directories will be described in another section.

## Add Station to Zones.csv

Inside of the folder “ZoneData” there is a file called “Zones.csv” which contains information about each zone in the model.  Station zones should have the planning district of 0, and be supplied with the correct spatial coordinates to match the network model.

## Add Station to StationCapacity.csv

Inside of the folder “Stations” you will need to edit the file “StationCapacity.csv”.  Inside of it you will need to add to the first column the new zone number, and in the second the parking capacity for that station.