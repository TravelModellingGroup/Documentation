# Import Matrix To Visum

Takes a matrix currently loaded in memory and stores it into a Matrix
within Visum given an associated number.  If the matrix does not
exist it will be created.

## SubModules

| SubModule Name | Type | Description                            |
|-------|---------------|----------------------------------------|
|ToSave| `IDataSource<SparseTwinindex<float>`| The matrix to store into Visum. |
|Visum|`IDataSource<VisumInstance>`| The VISUM instance to import the matrix to.|

## Parameters

| Parameter Name | Type | Description                            |
|-------|---------------|----------------------------------------|
| Matrix Name | `string`| The name to associate with the matrix. |
| Matrix Number | `int` | The number of the matrix to store to. |
