# Assign Road Tool

## Introduction

This tool is designed to execute a road assignment in VISUM against the currently loaded instance.
Different algorithms can be selected for doing the assignment as required.

* BiConjugateFrankWolfeAlgorithm
* EquilibriumAlgorithm
* LUCEAlgorithm

You can read more about these different algorithms in the VISUM documentation.

## Parameters

| Parameter Name | Type | Description                            |
|-------|---------------|----------------------------------------|
| Maximum Iterations | `int` | The maximum number of loops that the road assignment will use. |
| Max Gap | `float` | The value is the weighted volume difference between the vehicle impedance of the network of the current iteration and the hypothetical vehicle impedance. |


## SubModules

| SubModule Name | Type | Description                            |
|-------|---------------|----------------------------------------|
|DemandSegments| `DemandSegmentForAssignment[]`| The demand segments to execute in the road assignment. |
|RoadAssignmentAlgorithm| `RoadAssignmentAlgorithmModule`| Optionally specify the road assignment algorithm to use. |

Note: If you don't specify the RoadAssignmentAlgorithm, the default algorithm that will be used is `LUCEAssignment`.

## Road Algorithms

At this time there are no additional
parameters that can be set for the road assignment
depending on the algorithm used.  If that changes
this documentation will be updated with them.

