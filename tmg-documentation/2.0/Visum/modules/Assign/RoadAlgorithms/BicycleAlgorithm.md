# Bicycle Algorithm

Use the Visum Bicycle assignment with reasonable default values.

Provide this module to an [Assign Road](../AssignRoad.md) module's `Road Assignment
Algorithm` sub-module to run the assignment using VISUM's bicycle assignment procedure.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `BicycleAlgorithm` | `RoadAssignmentAlgorithmModule` | `Assign/RoadAlgorithms/BicycleAlgorithm.cs` |

## BicycleAlgorithm

Base type: `RoadAssignmentAlgorithmModule`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Search Iterations` | `IFunction<int>` | `true` | `10` | Number of extra search iterations. |
| `Choice Model` | `IFunction<BicycleAssignment.BicycleChoiceModel>` | `true` | `Logit` | Type of choice model to use. Reasonable default settings will be used for each. |
| `Beta` | `IFunction<double>` | `true` | `0.25` | For Logit or BoxCox model, parameter that multiplies the impedance before exponentiation. |
