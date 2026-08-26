# Export Line Boardings

Export line boardings from the current VISUM instance to a CSV file.

The generated file contains a header row followed by one row per transit line, with the
columns `LineName` and `Boardings`.  A transit assignment must have been run beforehand
for the boardings to be meaningful.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `ExportLineBoardings` | `BaseAction<VisumInstance>` | `Export/ExportLineBoardings.cs` |

## ExportLineBoardings

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Save To` | `IFunction<string>` | `true` | `` | The location to save the line boardings to. |

> [!NOTE]
> `Save To` must be non-blank, otherwise the module will fail validation.
