# Ignore Context

Ignore the context of a function call.  This allows you to call functions that don't require a context.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `IgnoreContext<Context,Return>` | `BaseFunction<Context,Return>` | `Ignore.cs` |
| `IgnoreContext<Context>` | `BaseAction<Context>` | `Ignore.cs` |

## IgnoreContext<Context,Return>

Base type: `BaseFunction<Context,Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Ignore` | `IFunction<Return>?` | `true` | The module to invoke ignoring context. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## IgnoreContext<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Ignore` | `IAction?` | `true` | The module to invoke ignoring context. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |
