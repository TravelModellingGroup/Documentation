# Import Matrix To Visum

Store the given matrix into a Visum Instance.

If a matrix with the given number already exists it is renamed and flagged as a demand
matrix before its values are overwritten; otherwise a new demand matrix is created.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `ImportMatrixToVisum` | `BaseAction<VisumInstance>` | `Import/ImportMatrixToVisumTool.cs` |

## ImportMatrixToVisum

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Matrix Number` | `IFunction<int>` | `true` | `0` | The matrix number to store into. |
| `Matrix Name` | `IFunction<string>` | `true` | `` | The name to associate with the matrix. |
| `Matrix` | `IFunction<Matrix>` | `true` | `` | The matrix to store into Visum. |

> [!NOTE]
> `Matrix Name` must be non-blank, otherwise the module will fail validation.
