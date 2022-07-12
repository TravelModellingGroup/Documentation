# Parking

Starting in `GTAModel V4.2` the parking costs have been separated from the [Network Scenario](network.md).

## Contained Files

The scenario contains a single file, `ParkingCosts.csv`.  This file contains the following eight columns in order:

* ZoneNumber - The TAZ that this row represents.
* StartOfDay - Time time of day, in minutes from midnight, that the "daytime" starts.
* DailyHourly - The cost per hour that will be charged during the "daytime".
* DailyMax - The maximum price that a person can pay during the "daytime".
* StartOfNight - The start time, in minutes from midnight, of when "nighttime" starts.
* NightlyHourly - The cost per hour that will be charged during the "nighttime".
* NightlyMax - The maximum price that a person can apy during the "nighttime".
* FullDayMax - The maximum price that a person can pay during regardless of time period.

>[!Tip]
> Make sure that all of your costs are inflated/deflated to your model's base year dollars.

All TAZ that are not defined as assumed to have no parking costs.

## Creating a New Scenario

TODO:
