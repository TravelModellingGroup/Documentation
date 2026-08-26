# Calculate Road LoS

Generates the level of service matrices for the given types. Will fail if there is no road assignment previously.

This module must be run after an [Assign Road](../Assign/AssignRoad.md) module so that
skim matrices can be produced from the resulting assignment.  Each matrix to produce is
described by a `PrT LoS Export` sub-module, which can optionally rename and re-code the
generated matrix.  When a matrix is renamed, any existing matrix already using that name
is deleted first.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `CalculateRoadLoS` | `BaseAction<VisumInstance>` | `Calculate/CalculateRoadLoS.cs` |
| `CalculateRoadLoS.PrTLoSExport` | `IModule` | `Calculate/CalculateRoadLoS.cs` |

## CalculateRoadLoS

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Segment` | `IFunction<DemandSegmentForAssignment>` | `true` | The demand segment to calculate PrT for. |
| `To Export` | `PrTLoSExport[]` | `true` | The types of matrices to export. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Search Criterion` | `IFunction<PrTLoSSearchCriterion>` | `true` | `Impedance` | The search criterion to use for the matrix. |

## CalculateRoadLoS.PrTLoSExport

Base type: `IModule`

Defines a PrT LoS matrix to export.

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `PrT Matrix Type` | `IFunction<PrTLosTypes>` | `true` | `TCur` | The type of matrix to compute from the previous road assignment. |
| `Matrix Code` | `IFunction<string>` | `true` | `` | If non-blank the matrix's code will be reassigned to the specified code. |
| `Matrix Name` | `IFunction<string>` | `true` | `` | If non-blank the matrix will be renamed to the specified name. |
