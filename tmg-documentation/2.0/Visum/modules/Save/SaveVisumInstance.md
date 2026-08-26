# Save Visum Instance

Save the current Visum instance to a file.

This writes the network currently held by the VISUM instance out as a version file.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `SaveVisumInstance` | `BaseAction<VisumInstance>` | `Save/SaveVisumInstance.cs` |

## SaveVisumInstance

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Save To` | `IFunction<string>` | `true` | `` | The path to save the Visum instance to. |

> [!NOTE]
> `Save To` must be non-blank, otherwise the module will fail validation.
