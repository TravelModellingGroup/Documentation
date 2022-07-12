# Stations

A station scenario is setup to specify how much parking is available at a transit station.  For a parson to drive or get driven to or from the station
in GTAModel that station is required to have its parking defined in this file, and that parking capacity must be greater than zero.

## Contained Files

Each scenario contains a single file called `StationCapacity.csv`.  This file is a simple CSV file containing two columns ZoneNumber, and Capacity.

## Creating a New Scenario

In order to create a new access station in the model you will need to follow the following steps.  Each access station model is expected to have a unique zone number in the range 9000-9999.  It is possible to define a different node range for access stations however the model system has been configured for this range by default.  The following instructions are for model systems that are not multi-run configured.  To add a new access station to in a multi-run configuration you will need to follow the same changes except targeting the correct forecasting directory.  These directories will be described in another section.

### Add Station to to the Zone System

`GTAModel V4.1+`: To add a new zone to the zone system simply edit your `BaseNetwork.nwp` in your [Scenario-Network](network.md) to include the new zone.

`GTAModel V4.0`: Inside of the folder “ZoneData” there is a file called “Zones.csv” which contains information about each zone in the model. 
Station zones should have the planning district of 0, and be supplied with the correct spatial coordinates to match the network model.

### Add Station to StationCapacity.csv

Now that we have added the new station to the zone system, we are now able to include it as an option for Drive-Access-Transit, Passenger-Access-Transit, and Passenger-Egress-Transit.
To do this clone the scenario you wish to base your new scenario from and copy it into the correct year's directory. Next, edit the file “StationCapacity.csv”. 
Inside of it you will need to add to the first column the new zone number, and in the second the parking capacity for that station.  To allow a station to be selected it will require
a parking capacity greater than zero.

>[!Warning]
> Make sure to not add a third column accidently or some versions of GTAModel may not load the file correctly!

