# LUCE Algorithm

Use the Equilibrium assignment LUCE.

Provide this module to an [Assign Road](../AssignRoad.md) module's `Road Assignment
Algorithm` sub-module to run the assignment using VISUM's LUCE (Linear User Cost
Equilibrium) procedure.  This is the algorithm that [Assign Road](../AssignRoad.md) falls
back to when no `Road Assignment Algorithm` sub-module is provided.  The parameters below
are the stability criteria shared by all of the equilibrium based algorithms; the
assignment stops once any of them is satisfied.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `LUCEAlgorithm` | `EquilibriumAlgorithmRoot` | `Assign/RoadAlgorithms/EquilibriumAlgorithms.cs` |

## LUCEAlgorithm

Base type: `EquilibriumAlgorithmRoot`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Maximum Iterations` | `IFunction<int>` | `true` | `100` | The maximum number of iterations to use when balancing the road assignment. |
| `Max Gap` | `IFunction<float>` | `true` | `0.01` | The value is the weighted volume difference between the vehicle impedance of the network of the current iteration and the hypothetical vehicle impedance. |
| `Max Relative Link Impedance` | `IFunction<float>` | `true` | `0.01` | The maximum impedance on the link before we stop iterating. |
