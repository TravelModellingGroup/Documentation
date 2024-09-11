# Assign Transit Tool

## Introduction

This tool is designed to execute a transit assignment in VISUM against the currently loaded instance.

## Parameters

| Parameter Name | Type | Description                            |
|-------|---------------|----------------------------------------|
| Auto Demand Segment | `string` | The name of the demand segment to use for auto speeds when doing Surface Transit Speed Updating. |
| Iterations | `int` | The number of times to execute the transit assignment, used for Surface-Transit Speed Updating. |

## SubModules

| SubModule Name | Type | Description                            |
|-------|---------------|----------------------------------------|
|DemandSegments| `DemandSegmentForAssignment[]`| The demand segments to execute in the transit assignment. |
|LoSToGenerate| `LosMatrix[]` | The different types of LoS to generate for each demand class. |
|AssignmentAlgorithm| `TransitAssignmentAlgorithmModule[]`| The algorithm to use for the transit assignment.|


## Assignment Algorithms

Currently there is only one option for the transit
assignment algorithm, the `HeadwayAlgorithm`.

### Headway Algorithm

The headway algorithm module contains all of the parameters required to do a standard
transit assignment where the demand is coming in from a standard matrix.

#### Parameters

| Parameter Name | Type | Description                            |
|-------|---------------|----------------------------------------|
|AccessTimeVal|`float`| A weighting factor to apply to the time it takes to walk from the origin to the first transit boarding.|
|BoardingPenaltyPuTAttribute|`string`| An optional attribute name to use to get a boarding penalty when boarding a new vehicle.|
|EgressTimeVal|`float`| A weighting factor to apply to the time it takes to walk from the last transit alighting to the destination.|
|FarePointVal|`float`| A weighting applied to either the fare values or the fair points to convert it to minutes per monetary unit. |
|InVehicleTimeVal|`float`| A weighting factor to apply to in-vehicle time.  This is typically kept at 1. |
|InVehicleTimeWeightAttribute|`string`| An optional attribute to specify the in-vehicle weights by segment. |
|MeanDelayAttribute|`string`| An optional attribute to specify how long someone is expected to wait within the headway before a vehicle will arrive.  This would normally be 0.5, or half the headway. |
|NumberOfTransfersValue|`float` | A penalty, in seconds, that will be applied for each vehicle that is taken along a path. |
|OriginWaitTimeValue|`float`| A weighting factor that is applied to the first wait time along the journey. |
|PerceivedJourneyTimeValue|`float`| An additional weighting factor that is applied to the travel component of the journey to compute utility.  This does not include fare. |
|PublicTransitAuxiliaryTimeValue|`float`| A weighting factor when taking auxiliary transit. |
|TransferWaitTimeValue|`float`| A weighting factor applied to the wait time for boardings after the first. |
|TransferWaitTimeWeightAttribute|`string`| An optional attribute to use for weighting the boardings after the first one. |
|UseFareModel|`bool`| Set to true to use fare values instead of fare points. |
|WalkTimeValue|`float`| A weighting factor applied to the walk time outside of the initial access walk and the egress walk legs. |
|Assignment Start Day Index|`int`| If the network has multiple days, the date index to use for the start time. |
|Assignment Start Time| `TimeOnly` | The time of day to start the simulation. |
|Assignment End Day Index|`int`| If the network has multiple days, the date index to use for the end time. |
|Assignment End Time| `TimeOnly` | The time of day to end the simulation. |
|Share Lower Bounds| `float` | The point in which we will stop exploring low probability paths. |
|Share Upper Bounds| `float` | The point in which we will stop exploring high probability paths. |
|Use Stored Headways | `bool` | Use the headways stored in the HeadwayAttribute instead of computing it. |
|Headway Attribute | `string` | The attribute to use, or store to, for the headway. |
|Passenger Information | `HeadwayStrategy` | The different assumptions for what information is available to the passenger. |
|PreciseMethodUpTo| `int` | The number of alternatives when using information before falling back to the approximation algorithm. |
|Approximation Iterations | `int` | The number of iterations to use when running the approximation algorithm if there are too many alternative paths. |



##### Headway Strategy

* OptimalStrategy - The passenger takes the first line to arrive in the set of alternatives.
* ConstantHeadways - This is the same as OptimalStrategy however instead of using the journey times, the headways are assumed to be constant.
* CompleteInformation - The passenger has complete information about the precise departure times at all times.

#### Surface Transit Speed Updating


|Parameter Name | Type | Description                            |
|-------|---------------|----------------------------------------|
|Auto Demand Segment | `string` | The name of the demand segment to use for auto speeds when doing Surface Transit Speed Updating. |
|Boarding Duration | `float` | The boarding duration in seconds per passenger to apply. |
|Alighting Duration |`float`| The alighting duration in seconds per passenger to apply. |
|Default Duration| `float` | The time it takes, in seconds, a vehicle to stop. |
|Transit Auto Correlation | `float` | The factor applied to the auto travel time to compute the vehicle travel time across the same link. |
|DefaultEROWSpeed|`float` | The default speed for the vehicle to use when traversing a link if autos are not available on it. |

