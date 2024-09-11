# Calculate Road LoS

## Introduction

Generates the level of service matrices for the given types.
This module will fail if there is no road assignment previously.

## Submodules

| Submodule Name | Type | Description                            |
|-------|---------------|----------------------------------------|
|Segment|`DemandSegmentForAssignment`| The demand segment to calculate PrT for.|
|ToExport|`PrTLoSExport[]`| The types of matrices to export. |


## PrTLoSExport

This module lets you specify which type of matrix you want to export from the previous road assignment.

### PrTLoSExport Parameters

|Parameter Name | Type | Description                             |
|-------|---------------|----------------------------------------|
|Matrix Code|`string`| If non-blank the matrix's code will be reassigned to the specified code.|
|Matrix Name|`string`| If non-blank the matrix will be renamed to the specified name.|
|Type|`PrTLoSTypes`| The type of matrix to compute from the previous road assignment.|

### PrTLoSTypes
        
* T0 - The initial travel time.
* TCur - The assigned travel time.
* V0 - The initial speed.
* VCur - The assigned speed.
* Impedance - The utility of the path.
* TripDistance - The on road distance travelled.
* DirectDistance - The straight line distance between the origin and destination.
* AddValue1 - A custom value along links, unused by the model.
* AddValue2 - A custom value along links, unused by the model.
* AddValue3 - A custom value along links, unused by the model.
* AddValueTSys - A custom value along links, unused by the model.
* Toll - The tolls incurred along the path.
* UserDefined - A custom value along links, unused by the model.

