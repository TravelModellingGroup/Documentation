# Export Matrix as Data Source

Load the given matrix by name from the VISUM instance. The result of this
module is an `IDataSource<SparseTwinIndex<float>>` in memory that can
be stored in a resource or used in other modules.

## Parameters

| Parameter Name | Type | Description |
|----------------|------|-------------|
|Matrix Name|`string`| The name of the matrix to export.|

## Submodules

| Submodule Name | Type | Description |
|----------------|------|-------------|
|Instance|`VISUM`| The VISUM instance to export the matrix from.|

