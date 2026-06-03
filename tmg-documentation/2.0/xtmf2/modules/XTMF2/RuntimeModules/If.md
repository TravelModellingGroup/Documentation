# If

Provides a way to conditionally execute.  If the condition is true or false different functions will be invoked.  
Use `IfWithContextA/F` if you need the context passed into the condition as well as the true or false paths.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `IfA` | `BaseAction` | `If.cs` |
| `IfA<Context>` | `BaseAction<Context>` | `If.cs` |
| `IfF<Context,Return>` | `BaseFunction<Context,Return>` | `If.cs` |
| `IfF<Return>` | `BaseFunction<Return>` | `If.cs` |
| `IfWithContextA<Context>` | `BaseAction<Context>` | `If.cs` |
| `IfWithContextF<Context, Return>` | `BaseFunction<Context, Return>` | `If.cs` |

## IfA

Base type: `BaseAction`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `If True` | `IAction?` | `false` | The logic to invoke if true |
| `If False` | `IAction?` | `false` | The logic to invoke if false |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Condition` | `IFunction<bool>?` | `true` | `true` | The condition to invoke to see if the true or false path is taken. |

## IfA<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `If True` | `IAction<Context>?` | `false` | The logic to invoke if true |
| `If False` | `IAction<Context>?` | `false` | The logic to invoke if false |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Condition` | `IFunction<bool>?` | `true` | `true` | The condition to invoke to see if the true or false path is taken. |

## IfF<Context,Return>

Base type: `BaseFunction<Context,Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `If True` | `IFunction<Context, Return>?` | `true` | The logic to invoke if true |
| `If False` | `IFunction<Context, Return>?` | `true` | The logic to invoke if false |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Condition` | `IFunction<bool>?` | `true` | `true` | The condition to invoke to see if the true or false path is taken. |

## IfF<Return>

Base type: `BaseFunction<Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `If True` | `IFunction<Return>?` | `true` | The logic to invoke if true |
| `If False` | `IFunction<Return>?` | `true` | The logic to invoke if false |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Condition` | `IFunction<bool>?` | `true` | `true` | The condition to invoke to see if the true or false path is taken. |

## IfWithContextA<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `If True` | `IAction<Context>?` | `false` | The logic to invoke if true |
| `If False` | `IAction<Context>?` | `false` | The logic to invoke if false |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Condition` | `IFunction<Context, bool>?` | `true` | `true` | The condition to invoke to see if the true or false path is taken. |

## IfWithContextF<Context, Return>

Base type: `BaseFunction<Context, Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `If True` | `IFunction<Context, Return>?` | `true` | The logic to invoke if true |
| `If False` | `IFunction<Context, Return>?` | `true` | The logic to invoke if false |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Condition` | `IFunction<Context, bool>?` | `true` | `true` | The condition to invoke to see if the true or false path is taken. |
