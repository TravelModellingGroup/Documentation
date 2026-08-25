# Load General Settings

This module loads the General Procedure Settings from a given file into the current instance.

Use this together with [Save General Settings](../Save/SaveGeneralSettings.md) to move a
set of procedure settings between VISUM instances or model runs.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `LoadGeneralSettings` | `BaseAction<VisumInstance>` | `Load/LoadGeneralSettings.cs` |

## LoadGeneralSettings

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `File Path` | `IFunction<string>` | `true` | `` | The location of the general settings file to load. |
| `Check Exists At Validation` | `IFunction<bool>` | `true` | `true` | Whether to check if the file exists during validation. |
