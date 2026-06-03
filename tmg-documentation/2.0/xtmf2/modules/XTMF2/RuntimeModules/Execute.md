# Execute

Provides a way to execute a series of actions in order, optionally in parallel or with multiple iterations.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `Execute` | `BaseAction` | `Execute.cs` |
| `Execute<Context>` | `BaseAction<Context>` | `Execute.cs` |

## Execute

Base type: `BaseAction`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Current Iteration` | `ISetableValue<int>?` | `false` | Place to store the current iteration |
| `To Execute` | `IAction[]?` | `` | The modules in order to execute |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Parallel Execution` | `IFunction<bool>?` | `false` | `false` |  |
| `Iterations` | `IFunction<int>?` | `false` | `1` |  |

## Execute<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Current Iteration` | `ISetableValue<int>?` | `false` | Place to store the current iteration |
| `To Execute` | `IAction<Context>[]?` | `` | The modules in order to execute |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Parallel Execution` | `IFunction<bool>?` | `false` | `false` |  |
| `Iterations` | `IFunction<int>?` | `false` | `1` |  |
