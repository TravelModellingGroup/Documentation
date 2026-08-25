# Assign Road

Run a road assignment.

This module executes a private transport (PrT) assignment against the VISUM instance
that it is given.  The demand segments to assign are provided as sub-modules, and the
algorithm used to solve the assignment can optionally be selected.  If no algorithm is
provided the `LUCE Algorithm` will be used with its default settings.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `AssignRoad` | `BaseAction<VisumInstance>` | `Assign/AssignRoad.cs` |

## AssignRoad

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Demand Segments` | `IFunction<DemandSegmentForAssignment>[]` | `true` | The demand segments to execute in the road assignment. |
| `Road Assignment Algorithm` | `IFunction<RoadAssignmentAlgorithmModule>?` | `false` | Optionally specify the road assignment algorithm to use. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |
