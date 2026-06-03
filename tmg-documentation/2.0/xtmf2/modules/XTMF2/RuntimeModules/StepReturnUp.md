# Step Return Up

Converts the result of a function to the expected type from the calling module.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `StepActionUp<Original, ConvertTo>` | `BaseAction<Original>` | `StepUp.cs` |
| `StepReturnUp<Original, ConvertTo, Context>` | `BaseFunction<Context, ConvertTo>` | `StepUp.cs` |
| `StepReturnUp<Original, ConvertTo>` | `BaseFunction<ConvertTo>` | `StepUp.cs` |

## StepActionUp<Original, ConvertTo>

Base type: `BaseAction<Original>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `ToInvoke` | `IAction<ConvertTo>?` | `true` | Invoke with converted context |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## StepReturnUp<Original, ConvertTo, Context>

Base type: `BaseFunction<Context, ConvertTo>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `ToInvoke` | `IFunction<Context, Original>?` | `true` | Invoke with converted context |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## StepReturnUp<Original, ConvertTo>

Base type: `BaseFunction<ConvertTo>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `ToInvoke` | `IFunction<Original>?` | `true` | Invoke with converted context |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |
