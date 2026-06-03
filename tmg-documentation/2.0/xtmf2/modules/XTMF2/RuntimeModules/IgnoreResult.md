# Ignore Result

Ignore the result of a function call.  This allows you to call functions from an action.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `IgnoreResult<Context, FuncReturn>` | `BaseAction<Context>` | `Ignore.cs` |
| `IgnoreResult<FuncReturn>` | `BaseAction` | `Ignore.cs` |

## IgnoreResult<Context, FuncReturn>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Ignore` | `IFunction<Context, FuncReturn>?` | `true` | The module to ignore the results of. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## IgnoreResult<FuncReturn>

Base type: `BaseAction`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Ignore` | `IFunction<FuncReturn>?` | `true` | The module to ignore the results of. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |
