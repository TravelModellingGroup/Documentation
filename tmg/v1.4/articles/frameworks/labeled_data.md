# Labeled Data

## Loading Data

Data can be loaded from CSV files in the format of (Data Name, Value) using the LabeledDataFromCSV module.  For now the rest of the infrastructure assumes that the data is in System.Single format, so for now it is best to use that to fill in the free generic type.

## Aggregation

The module AggregateLabeledDataToShape takes in two LabeledData<float> sources and produces a new LabeledData<float> structure.  The ‘Data To Aggregate’ data source provides the values that will be aggregated into the new shape.  ‘Fit To Shape’ provides the shape that the ‘Data To Aggregate; will be mapped into.  ‘Data Map’ provides the location to the map file.  The map file is a CSV file in the format (Destination Label, Origin Label, Amount).  The amount is a number typically between 0 and 1 which acts as a multiplier for how much of the original data should be added into the destination label.

## Integrating into ODMath

ConvertLabeledDataToSparseArray provides the functionality to convert labeled data into a sparse array so that it can be used in ODMath.  The labels are sorted in alphabetic order and then ordered in the sparse array from index 0 to index n-1 where n is the size of the data.  This guarantees that two LabelData objects with the same labels will always map to the same Sparse Array shape, so math can be done predictably.
