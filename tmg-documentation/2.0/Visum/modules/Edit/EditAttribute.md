# Edit Attribute

Executes an EditAttribute procedure on the current VISUM instance.

This module applies a VISUM formula to every network object of the given type and stores
the result into the named attribute.  A filter file can optionally be loaded before the
procedure runs, which combined with `Only Active` lets the formula be applied to a subset
of the network.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `EditAttribute` | `BaseAction<VisumInstance>` | `Edit/EditAttribute.cs` |

## EditAttribute

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Filter File` | `IFunction<string>?` | `false` | A filter file to load before running the edit attribute. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Formula` | `IFunction<string>` | `true` | `` | The formula to apply. |
| `Network Object Type` | `IFunction<string>` | `true` | `LINK` | The name of the network object. |
| `Result Attribute Name` | `IFunction<string>` | `true` | `` | The name of the attribute to store the result into. |
| `Only Active` | `IFunction<bool>` | `true` | `false` | Should we assign to all network objects of the type or only the active ones? |

> [!NOTE]
> `Formula`, `Network Object Type`, and `Result Attribute Name` must all be non-blank,
> otherwise the module will fail validation.
