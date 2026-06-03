# Report Invocation

Reports to XTMF that the model system has run through this point.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `ReportActionInvocation` | `BaseAction` | `ReportInvocation.cs` |
| `ReportActionInvocation<Context>` | `BaseAction<Context>` | `ReportInvocation.cs` |
| `ReportActionInvocationWithContext<Context>` | `BaseAction<Context>` | `ReportInvocation.cs` |
| `ReportFunctionInvocation<Context, Return>` | `BaseFunction<Context, Return>` | `ReportInvocation.cs` |
| `ReportFunctionInvocation<Return>` | `BaseFunction<Return>` | `ReportInvocation.cs` |

## ReportActionInvocation

Base type: `BaseAction`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Invoke` | `IAction?` | `true` | Invoke after signalling context |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<string>?` | `` | `Got here` | The message to report to XTMF |

## ReportActionInvocation<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Invoke` | `IAction<Context>?` | `true` | Invoke after signalling context |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<string>?` | `` | `Got here` | The message to report to XTMF |

## ReportActionInvocationWithContext<Context>

Base type: `BaseAction<Context>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Invoke` | `IAction<Context>?` | `true` | Invoke after signalling context |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<Context, string>?` | `` | `Got here` | The message to report to XTMF |

## ReportFunctionInvocation<Context, Return>

Base type: `BaseFunction<Context, Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Invoke` | `IFunction<Context, Return>?` | `true` | Invoke after signalling context |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<string>?` | `` | `Got here` | The message to report to XTMF |

## ReportFunctionInvocation<Return>

Base type: `BaseFunction<Return>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `To Invoke` | `IFunction<Return>?` | `true` | Invoke after signalling context |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Message` | `IFunction<string>?` | `` | `Got here` | The message to report to XTMF |
