# Demand Segment For Assignment

Contains the information for setting up the demand segment that will be assigned.

This module pairs an existing VISUM demand segment with the matrix that holds its demand.
When it is invoked the named matrix is looked up in the VISUM instance and flagged as a
demand matrix before being attached to the demand segment.  It is used by
[Assign Road](../Assign/AssignRoad.md), [Assign Transit](../Assign/AssignTransit.md), and
[Calculate Road LoS](../Calculate/CalculateRoadLoS.md).

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `DemandSegmentForAssignment` | `BaseFunction<DemandSegmentForAssignment>` | `Common/DemandSegmentForAssignment.cs` |

## DemandSegmentForAssignment

Base type: `BaseFunction<DemandSegmentForAssignment>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Code` | `IFunction<string>` | `true` | `C` | The code for the demand segment. |
| `Demand Matrix` | `IFunction<string>` | `true` | `` | The name of the matrix that will be used for demand. |
