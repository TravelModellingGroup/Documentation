# Parking

Starting in `GTAModel V4.2` the parking costs have been separated from the [Network Scenario](network.md).

> [!Tip]
> In GTAModel V4 input data is organized into the _Scenario folders_ with the following structure,
> _Scenario-Directory_/_RunYear_/_ScenarioName_.

## Contained Files

The scenario contains a single file, `ParkingCosts.csv`.  This file contains the following eight columns in order:

* ZoneNumber - The TAZ that this row represents.
* StartOfDay - Time time of day, in minutes from midnight, that the "daytime" starts.
* DailyHourly - The cost per hour that will be charged during the "daytime".
* DailyMax - The maximum price that a person can pay during the "daytime".
* StartOfNight - The start time, in minutes from midnight, of when "nighttime" starts.
* NightlyHourly - The cost per hour that will be charged during the "nighttime".
* NightlyMax - The maximum price that a person can pay during the "nighttime".
* FullDayMax - The maximum price that a person can pay during regardless of time period.

>[!Tip]
> Make sure that all of your costs are inflated/deflated to your model's base year dollars.

All TAZ that are not defined as assumed to have no parking costs.

## Creating a New Scenario

To create a new scenario, make a copy of the scenario you wish to start from.  When editing the `ParkingCosts.csv` go to the TAZ that you wish to alter
the time periods or the prices during them.  When entering in your policy make sure to deflate the currency to match your model's base year.  For
models based on GTAModel V4.0 that would be 2011, and for V4.1, and V4.2, 2016.
