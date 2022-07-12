# Model Outputs

## GTAModel V4 Outputs

Modelling travel demand allows us to forecast alternative scenarios.

The planning agencies typically extract out the following types of data:
1. Mode share/split
1. Public transit ridership
1. Vehicle Kilometres Travelled (VTKs)
1. Road congestion

## Overview

To extract out this data the base models will output the following:

1. Assigned Networks - Network Packages (NWP) files for each time period containing the final assigned road and transit scenarios.
1. Demand - For each time period a set of [MTX](../file_formats/emme_binary_matrix.md) matrices
1. LOS Matrices - For each time period a set of [MTX](../file_formats/emme_binary_matrix.md) matrices
1. [Microsimulation Results](../file_formats/microsim.md) - A set of CSV files that give the low level details from TASHA
    for Households, Persons, Trips, Mode Choice, Station Choice, and linkedages between driver and passenger.
1. Screenlines
1. StationAccess - For each time period and station the number of people using the station and the total capacity of the drive access station.

## Assigned Networks

## Demand

## LOS Matrices

## Microsim Results

## Screenlines

## Station Access

## Next Steps

Now that we have an understanding of how GTAModel's outputs work we recommend going [back to the overview](../overview.md) and seeing what you want to explore next.
In most cases you will need to start [preparing new scenarios](../overview.md#creating-alternative-scenarios).  Alternatively you might be more interested in learning
how to [program modules to integrate into GTAModel](../overview.md#integrating-custom-code).