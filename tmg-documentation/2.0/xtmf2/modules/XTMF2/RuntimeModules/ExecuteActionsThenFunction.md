# Execute Actions Then Function

Allows you to execute actions before calling a function.  This allows you to 

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `ExecuteActionsThenFunction<Return>` | `BaseFunction<Return>` | `ExecuteActionsThenFunction.cs` |

## ExecuteActionsThenFunction<Return>

Base type: `BaseFunction<Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Invoke First` | `IAction[]?` | `` | Actions to invoke before invoking the function. |
| `End With` | `IFunction<Return>?` | `true` | The function to invoke and return the value of. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Invoke Actions in Parallel` | `IFunction<bool>?` | `` | `false` | Should the actions be invoked in parallel? |
