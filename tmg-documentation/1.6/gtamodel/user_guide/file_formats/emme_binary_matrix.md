# EMME Binary Matrix (.mtx)

## Overview

The .mtx file format is used in GTAModel V4 to store matrix data
in a compact form that is extremely quick to write and load.
Additionally, the format also contains a copy of the zone system
allowing it to be checked first before loading in order to weed out
a large number of potential errors.

The TMGToolbox contains two tools that allow for the
[importing](https://github.com/TravelModellingGroup/TMGToolbox/blob/dev-1.6/TMGToolbox/src/input_output/import_binary_matrix.py)
and 
[exporting](https://github.com/TravelModellingGroup/TMGToolbox/blob/dev-1.6/TMGToolbox/src/input_output/export_binary_matrix.py)
 of these files to and from EMME.

## File Specification

| Component    |   DataType |   Description    |
|--------------|------------|------------------|
| Magic Number | uint32 | 0xC4D4F1B2 |
| Version Number | int32 | 1      |
| Type         | int32 | float32 = 1, float64 = 2, int32 = 3, int64 = 4  |
| Dimensions | int32 | Scalar = 0, Vector = 1, Matrix = 2 |
| IndexSize | int32 | The size per dimension of the Vector.  A matrix will have 2 values.|
| Zone Number | int32 | For each dimension an index size worth of zone numbers |
| Raw Data | Depends on Type | One value per expected cell |

