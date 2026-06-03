# Fail

Crash the model run with a message.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `FailA` | `BaseAction` | `Fail.cs` |
| `FailA<Context>` | `BaseAction<Context>` | `Fail.cs` |
| `FailF<Context, Return>` | `BaseFunction<Context, Return>` | `Fail.cs` |
| `FailF<Return>` | `BaseFunction<Return>` | `Fail.cs` |
| `FailWithContextA<Context>` | `BaseAction<Context>` | `Fail.cs` |
| `FailWithContextF<Context, Return>` | `BaseFunction<Context, Return>` | `Fail.cs` |

## FailA

Base type: `BaseAction`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<string>?` | `` | `Invalid state!` | The message to fail with. |

## FailA<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<string>?` | `` | `Invalid state!` | The message to fail with. |

## FailF<Context, Return>

Base type: `BaseFunction<Context, Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<string>?` | `` | `Invalid state!` | The message to fail with. |

## FailF<Return>

Base type: `BaseFunction<Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<string>?` | `` | `Invalid state!` | The message to fail with. |

## FailWithContextA<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<Context, string>?` | `` | `Invalid state!` | The message to fail with. |

## FailWithContextF<Context, Return>

Base type: `BaseFunction<Context, Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<Context, string>?` | `` | `Invalid state!` | The message to fail with. |
