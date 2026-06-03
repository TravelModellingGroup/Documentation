# Combine Context From No Context

Combines the contexts as derived from First and Second and invokes To Invoke with the combined context.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `CombineContexF<Context1, Context2, Return>` | `BaseFunction<Context1, Return>` | `CombineContext.cs` |
| `CombineContextA<Context1, Context2>` | `BaseAction<Context1>` | `CombineContext.cs` |
| `CombineContextAFromContext<Context1, Context2>` | `BaseAction<Context1>` | `CombineContext.cs` |
| `CombineContextAFromNoContext<Context1, Context2>` | `BaseAction` | `CombineContext.cs` |
| `CombineContextFFromContext<Context1, Context2, Return>` | `BaseFunction<Context1, Return>` | `CombineContext.cs` |
| `CombineContextFFromNoContext<Context1, Context2, Return>` | `BaseFunction<Return>` | `CombineContext.cs` |

## CombineContexF<Context1, Context2, Return>

Base type: `BaseFunction<Context1, Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Second` | `IFunction<Context2>?` | `true` | The second context to use. |
| `To Invoke` | `IFunction<(Context1, Context2), Return>?` | `true` | The module to invoke with the combined context. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## CombineContextA<Context1, Context2>

Base type: `BaseAction<Context1>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Second` | `IFunction<Context2>?` | `true` | The second context to use. |
| `To Invoke` | `IAction<(Context1, Context2)>?` | `true` | The module to invoke with the combined context. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## CombineContextAFromContext<Context1, Context2>

Base type: `BaseAction<Context1>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Second` | `IFunction<Context1, Context2>?` | `true` | The second context to use. |
| `To Invoke` | `IAction<(Context1, Context2)>?` | `true` | The module to invoke with the combined context. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## CombineContextAFromNoContext<Context1, Context2>

Base type: `BaseAction`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `First` | `IFunction<Context1>?` | `true` | The first context to use. |
| `Second` | `IFunction<Context2>?` | `true` | The second context to use. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## CombineContextFFromContext<Context1, Context2, Return>

Base type: `BaseFunction<Context1, Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Second` | `IFunction<Context1, Context2>?` | `true` | The second context to use. |
| `To Invoke` | `IFunction<(Context1, Context2), Return>?` | `true` | The module to invoke with the combined context. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## CombineContextFFromNoContext<Context1, Context2, Return>

Base type: `BaseFunction<Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `First` | `IFunction<Context1>?` | `true` | The first context to use. |
| `Second` | `IFunction<Context2>?` | `true` | The second context to use. |
| `To Invoke` | `IFunction<(Context1, Context2), Return>?` | `true` | The module to invoke with the combined context. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |
