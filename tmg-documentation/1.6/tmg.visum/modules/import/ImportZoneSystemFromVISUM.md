# Import Zone System From VISUM

Load in the zone system from the given VISUM instance.

## Parameters

| Parameter Name | Type | Description |
|----------------|------|-------------|
|Keep Loaded|`bool`| If true, the zone system will only be loaded once.|

## Submodules

| Submodule Name | Type | Description |
|----------------|------|-------------|
|VisumInstance|`VISUM`| The VISUM instance to import the zone system from.|
|Planning Districts|`IDataSource<SparseArray<float>>`| The location to save the planning districts to.|
|Regions|`IDataSource<SparseArray<float>>`| The location to save the regions to.|
|Population|`IDataSource<SparseArray<float>>`| The location to save the population to.|
|CustomDistances|`IDataSource<SparseTwinIndex<float>>`| The location read the custom distances from (metres).|

