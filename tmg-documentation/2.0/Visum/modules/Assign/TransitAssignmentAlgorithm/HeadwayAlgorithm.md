# Headway Algorithm

Provides parameters to control the Headway PutAssignment algorithm.

Provide this module to an [Assign Transit](../AssignTransit.md) module's `Assignment
Algorithm` sub-module to run the assignment using VISUM's headway based (timetable-free)
public transport assignment.  The impedance parameters below define the perceived journey
time function used to evaluate connections.  Optionally one or more `STSU Class`
sub-modules can be supplied to apply Surface Transit Speed Updating to the transit lines
selected by each class.

> [!NOTE]
> Several of this module's impedance parameters have no description in the source code.
> The descriptions below are derived from the corresponding VISUM headway impedance
> settings and should be reviewed against the PTV VISUM manual before being relied upon.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `HeadwayAlgorithm` | `TransitAssignmentAlgorithmModule` | `Assign/TransitAssignmentAlgorithm/HeadwayAlgorithm.cs` |
| `HeadwayAlgorithm.STSUClass` | `IModule` | `Assign/TransitAssignmentAlgorithm/HeadwayAlgorithm.cs` |

## HeadwayAlgorithm

Base type: `TransitAssignmentAlgorithmModule`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Surface Transit Speed Updating` | `STSUClass[]` | `false` | The different surface transit speed updating classes. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Access Time Value` | `IFunction<float>` | `true` | `1.0` | The weight applied to access time when computing the perceived journey time. |
| `Boarding Penalty PuT Attribute` | `IFunction<string>` | `true` | `` | The name of the attribute holding the boarding penalty to apply to public transit boardings. |
| `Boarding Penalty PuT Aux Attribute` | `IFunction<string>` | `true` | `` | The name of the attribute holding the boarding penalty to apply to public transit auxiliary (walk) connections. |
| `Egress Time Value` | `IFunction<float>` | `true` | `1.0` | The weight applied to egress time when computing the perceived journey time. |
| `Fare Point Value` | `IFunction<float>` | `true` | `0.0` | The weight applied to each fare point when computing the perceived journey time. |
| `In Vehicle Time Value` | `IFunction<float>` | `true` | `1.0` | The weight applied to in-vehicle time when computing the perceived journey time. |
| `In Vehicle Time Weight Attribute` | `IFunction<string>` | `true` | `` | The name of the attribute providing a per-object multiplier applied to in-vehicle time. Leave blank to apply no additional weighting. |
| `Mean Delay Attribute` | `IFunction<string>` | `true` | `` | The name of the attribute providing the mean delay to apply when boarding. Leave blank to apply no delay. |
| `Number Of Transfers Value` | `IFunction<float>` | `true` | `0.0` | The penalty, in perceived minutes, applied for each transfer taken. |
| `Origin Wait Time Value` | `IFunction<float>` | `true` | `1.0` | The weight applied to the initial wait time at the origin stop. |
| `Perceived Journey Time Value` | `IFunction<float>` | `true` | `1.0` | The weight applied to the overall perceived journey time. |
| `Public Transit Auxiliary Time Value` | `IFunction<float>` | `true` | `1.0` | The weight applied to time spent on public transit auxiliary (walk) connections. |
| `Transfer Wait Time Value` | `IFunction<float>` | `true` | `1.0` | The weight applied to time spent waiting at a transfer. |
| `Transfer Wait Time Weight Attribute` | `IFunction<string>` | `true` | `` | The name of the attribute providing a per-object multiplier applied to transfer wait time. Leave blank to apply no additional weighting. |
| `Use Fare Model` | `IFunction<bool>` | `true` | `true` | Should the fare model be included when computing impedance? |
| `Walk Time Value` | `IFunction<float>` | `true` | `1.0` | The weight applied to walk time when computing the perceived journey time. |
| `Assignment Start Day Index` | `IFunction<int>` | `true` | `1` | The index of the day that the assignment's time interval starts on. |
| `Assignment Start Time` | `IFunction<TimeOnly>` | `true` | `00:00:00` | The time of day that the assignment's time interval starts at. |
| `Assignment End Day Index` | `IFunction<int>` | `true` | `2` | The index of the day that the assignment's time interval ends on. |
| `Assignment End Time` | `IFunction<TimeOnly>` | `true` | `00:00:00` | The time of day that the assignment's time interval ends at. |
| `Share Lower Bounds` | `IFunction<float>` | `true` | `0.05` | The minimum share of demand a connection must attract before it is discarded. |
| `Share Upper Bounds` | `IFunction<float>` | `true` | `0.99` | The cumulative share of demand to cover before no further connections are considered. |
| `Use Stored Headways` | `IFunction<bool>` | `true` | `false` | Use the headways stored in the HeadwayAttribute instead of computing it. |
| `Headway Attribute` | `IFunction<string>` | `true` | `` | An attribute for either saving headways to, or to read from. |
| `Passenger Information` | `IFunction<HeadwayImpedanceParameters.HeadwayStrategy>` | `true` | `CompleteInformation` | Which passenger information option should we use? |
| `Precise Method Up To` | `IFunction<int>` | `true` | `30` | The number of alternatives when using information before falling back to the approximation algorithm. |
| `Approximation Iterations` | `IFunction<int>` | `true` | `100` | The number of iterations to use when running the approximation algorithm if there are too many alternative paths. |

> [!NOTE]
> If `Use Stored Headways` is set then `Headway Attribute` must also be set, otherwise the
> module will fail validation.

## HeadwayAlgorithm.STSUClass

Base type: `IModule`

A module that describes how to update the speed of transit lines.

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Auto Demand Segment` | `IFunction<string>` | `true` | `C` | The demand segment that is used for STSU to base its times off of. |
| `Boarding Duration` | `IFunction<float>` | `true` | `1.9577` | The boarding duration in seconds per passenger to apply. |
| `Alighting Duration` | `IFunction<float>` | `true` | `1.1219` | The alighting duration in seconds per passenger to apply. |
| `Default Duration` | `IFunction<float>` | `true` | `7.4331` | The default duration in seconds per stop to apply. |
| `Transit Auto Correlation` | `IFunction<float>` | `true` | `1` | The multiplier to auto time to use to find transit time. |
| `Default EROW Speed` | `IFunction<float>` | `true` | `20.0` | The speed that transit lines will travel at that belong to this STSU Class. |
| `Attribute For Bus Facility` | `IFunction<string>` | `true` | `` | The name of the boolean Links attribute in Visum that indicated whether the link has an exclusive bus facility. Can be empty if no such attribute exists; in this case new links open only to buses must be used. |
| `Filter File` | `IFunction<string>` | `true` | `` | The filter used to select lines to apply the calculation to. |

> [!NOTE]
> `Default EROW Speed` must be greater than zero, and `Default Duration`, `Boarding
> Duration`, and `Alighting Duration` must all be at least zero, otherwise the module
> will fail validation.
