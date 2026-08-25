# Create User Attribute

Create the user attribute if it does not exist.

If an attribute with the given name already exists on the given network object type it is
left untouched, making this module safe to run repeatedly.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `CreateUserAttribute` | `BaseAction<VisumInstance>` | `Create/CreateUserAttribute.cs` |

## CreateUserAttribute

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Attribute Name` | `IFunction<string>` | `true` | `AttributeName` | The name of the attribute to create. |
| `Network Object Type` | `IFunction<NetworkObjectType>` | `true` | `Node` | The of network object to create the attribute for. |
| `Attribute Type` | `IFunction<AttributeTypes>` | `true` | `Float` | The type of the attribute to create. |

> [!NOTE]
> `Attribute Name` must be non-blank, otherwise the module will fail validation.
