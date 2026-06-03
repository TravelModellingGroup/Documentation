# Write to Log

Writes the provided mess to the log and then invokes the next step.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `WriteToLogA` | `BaseAction` | `WriteToLog.cs` |
| `WriteToLogA<Context>` | `BaseAction<Context>` | `WriteToLog.cs` |
| `WriteToLogBasedOnContextA<Context>` | `BaseAction<Context>` | `WriteToLog.cs` |
| `WriteToLogBasedOnContextF<Context, Return>` | `BaseFunction<Context, Return>` | `WriteToLog.cs` |
| `WriteToLogF<Context, Return>` | `BaseFunction<Context, Return>` | `WriteToLog.cs` |
| `WriteToLogF<Return>` | `BaseFunction<Return>` | `WriteToLog.cs` |

## WriteToLogA

Base type: `BaseAction`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Log` | `IAction?` | `true` | The log that will be written to. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## WriteToLogA<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Log` | `IAction<Context>?` | `true` | The log that will be written to. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## WriteToLogBasedOnContextA<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## WriteToLogBasedOnContextF<Context, Return>

Base type: `BaseFunction<Context, Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## WriteToLogF<Context, Return>

Base type: `BaseFunction<Context, Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## WriteToLogF<Return>

Base type: `BaseFunction<Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |
