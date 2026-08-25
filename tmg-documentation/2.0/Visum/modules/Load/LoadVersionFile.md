# Load Version File

Tell the Visum instance to load the given version file.

Use this module to replace the network held by an already running VISUM instance.  To
load a version file at the point the instance is created, use the `Version File`
sub-module of [Load Visum Instance](LoadVisumInstance.md) instead.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `LoadVersionFile` | `BaseAction<VisumInstance>` | `Load/LoadVersionFile.cs` |

## LoadVersionFile

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `File To Load` | `IFunction<string>` | `true` | `` | The version file for the Visum instance to load. |

> [!NOTE]
> `File To Load` must be non-blank, otherwise the module will fail validation.
