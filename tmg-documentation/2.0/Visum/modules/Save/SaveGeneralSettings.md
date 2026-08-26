# Save General Settings

This module saves the General Procedure Settings from the current instance to a given file.

The file produced can be read back with
[Load General Settings](../Load/LoadGeneralSettings.md).

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `SaveGeneralSettings` | `BaseAction<VisumInstance>` | `Save/SaveGeneralSettings.cs` |

## SaveGeneralSettings

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Save To` | `IFunction<string>` | `true` | `` | The file path to save the general settings to. |
