# Assign Transit

Run a transit assignment.

This module executes a public transport (PuT) assignment against the VISUM instance that
it is given.  The demand segments to assign are provided as sub-modules along with the
transit assignment algorithm to use.  Optionally a set of level of service (LoS) matrices
can be generated as part of the assignment; each generated matrix can be renamed and
re-coded through the `LoS Matrix` sub-module.  When more than one demand segment is
assigned, the demand segment's code is appended to the name and code of each generated
matrix.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `AssignTransit` | `BaseAction<VisumInstance>` | `Assign/AssignTransit.cs` |
| `AssignTransit.LosMatrix` | `IModule` | `Assign/AssignTransit.cs` |

## AssignTransit

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Demand Segments` | `IFunction<DemandSegmentForAssignment>[]` | `true` | The demand segments to execute in the transit assignment. |
| `LoS To Generate` | `LosMatrix[]` | `false` | The different types of LoS to generate. |
| `Assignment Algorithm` | `IFunction<TransitAssignmentAlgorithmModule>` | `true` | The algorithm to use for the transit assignment. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Iterations` | `IFunction<int>` | `true` | `1` | The number of times to execute the transit assignment, used for Surface-Transit Speed Updating. |

## AssignTransit.LosMatrix

Base type: `IModule`

The level of service matrices to generate.

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `LoS Type` | `IFunction<PutLoSTypes>` | `true` | `PerceivedJourneyTime` | The type of matrix to calculate. |
| `Matrix Code` | `IFunction<string>` | `true` | `` | The code to assign to the matrix. |
| `Matrix Name` | `IFunction<string>` | `true` | `` | The name to assign to the matrix. |
