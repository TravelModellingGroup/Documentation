# Load Matrix From Visum

Loads the given matrix number from the Visum instance.  The module
returns an `IDataSource<SparseTwinIndex<float>>`.  You can use
this module in most places that are expecting a matrix within
GTAModel.

## SubModules

| SubModule Name | Type | Description                            |
|-------|---------------|----------------------------------------|
|ToSave| `IDataSource<VisumInstance>`| The instance of VISUM to load the matrix from. |

## Parameters

| Parameter Name | Type | Description                            |
|-------|---------------|----------------------------------------|
| Matrix Number | `int` | The number of the matrix to store to. |
