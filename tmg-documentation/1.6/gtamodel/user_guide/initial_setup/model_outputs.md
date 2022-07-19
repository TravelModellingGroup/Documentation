# Model Outputs

Modelling travel demand allows us to forecast alternative scenarios.

The planning agencies typically extract out the following types of data:
1. Mode share/split
1. Public transit ridership
1. Vehicle Kilometres Travelled (VTKs)
1. Road congestion

In this document we will cover the outputs for a standard GTAModel V4 model system.  Your
model system provider might include additional outputs, or perhaps remove some.  If
you have received your model system from someone outside of TMG, please consult their
User's Guide for anything not found here.

## Overview

To extract out this data the base models will output the following:

1. Assigned Networks - Network Packages (NWP) files for each time period containing the final assigned road and transit scenarios.
1. Demand - For each time period a set of [MTX](../file_formats/emme_binary_matrix.md) matrices
1. LOS Matrices - For each time period a set of [MTX](../file_formats/emme_binary_matrix.md) matrices
1. [Microsimulation Results](../file_formats/microsim.md) - A set of CSV files that give the low level details from TASHA
    for Households, Persons, Trips, Mode Choice, Station Choice, and linkages between driver and passenger.
1. Screenlines
1. StationAccess - For each time period and station the number of people using the station and the total capacity of the drive access station.

## Assigned Networks

In the assigned networks output directory you will find nine network package files.  Each time
period will have both a Road and Transit NWP file available except for overnight which will only have a road assignment.
These network package files can then be used for post-processing for customized analyses.  To use a NWP you can use the
TMGToolbox, contained in XTMF's Modules directory, from EMME modeller and run the tool Import Network Package.

## Demand

The demand folder contains the demand going into their respective assignments.  For auto assignment there is demand
for auto passenger, light, medium, and heavy trucks.  This demand is in peak-hour PCU units.  For PCUs they are
1, 1, 1.75, 2.5, respectively for auto, light, medium and heavy trucks respectively.  The transit demand is stored in
peak-period numbers.  Each demand matrix is prefixed with the time period's 2 letter code.

In V4.2, you will also find an Airport directory.  This will contain for each time period the demand, that has already been added
to the other demand matrices, of different types of demand.

* NBR - Non-Business Resident
* NBV - Non-Business Visitor
* BR - Business Resident
* BV - Business Visitor

For a more detailed explanation of the airport model click [here](../../model_design/airport_model.md).

## LOS Matrices

This directory contains origin to destination matrices containing travel time and cost information generated for the final iteration.
The directory is broken down by the five time periods and each contain:

* acost - The cost it takes to travel between zones, this includes tolls and gas costs in base year dollars.
* aivtt - The auto in vehicle travel times in minutes.
* atoll - The tolls paid to travel between zones in base year dollars.
* tfare - The transit fares paid to travel between zones in in base year dollars.
* tivtt - The transit in-vehicle travel times in minutes.
* tptt - The perceived transit travel times between zones.  You can think of this as utils normalized in minutes.
* twait - The amount of time spent waiting between zones in minutes.
* twalk - The amount of time spent walking between zones in minutes.

## Microsim Results

This directory contains the microsim data from the model run.  You can find detailed information about
this dataset [here](../file_formats/microsim.md).

## Screenlines

This folder contains counts for screenlines and stations for each time period. For the files `AM.csv`, `MD.csv`, `PM.csv`, and `EV.csv` you will
have a CSV file with columns in order:

* Screenline - The name of the screenline that is being reported.
* nStations - The number of count stations contained in the network for this screenline.
* nMissing - The number of countposts for the screenline that was not found in the network.
* AutoVolume - The total PCUs that cross the screenline.
* AdditionalVolume - The total of the additional demand (in PCUs) crossing the screenline.

The rest of the files contain count post results stored in CSV files with two columns:

* Countpost - The unique numerical identifier that describes a countpost with a pariticular direction.
* Auto Volume - The counts stored in PCU units for that countpost.

Each auto class, Auto, Light, Medium, Heavy have their counts in their own files stored by time period.


## Station Access

The station access folder contains four files, one for each time period, containing the amount of
parking space demand there is for each station zone.

* Zone - The zone number used for the station in the network.
* Factor - The demand divided by the capacity.
* Demand - The number of cars the simulation wants to park at the station.
* Capacity - The total number of parking spots for the station.

> [!NOTE]
> The parking capacity model uses a soft cap so you will likely find some stations that have a factor
> over one.


## Next Steps

Now that we have an understanding of how GTAModel's outputs work we recommend going [back to the overview](../overview.md) and seeing what you want to explore next.
In most cases you will need to start [preparing new scenarios](../overview.md#creating-alternative-scenarios).  Alternatively you might be more interested in learning
how to [program modules to integrate into GTAModel](../overview.md#integrating-custom-code).
