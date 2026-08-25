# Export Attribute Where Set

This attribute will export the results of another attribute where the condition attribute is non-zero or non-empty. The attribute will be saved in a CSV file with two columns, the first with the condition variable's value, the second with the exported attribute associated with it. Both attributes need to be in the same domain.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `ExportAttributeWhereSet` | `BaseAction<VisumInstance>` | `Export/ExportAttributeWhereSet.cs` |
| `ExportAttributeWhereSet.Attribute` | `IModule` | `Export/ExportAttributeWhereSet.cs` |

## ExportAttributeWhereSet

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Export Attributes` | `Attribute[]` | `true` | The name of the attributes to export. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Condition Attribute` | `IFunction<string>` | `true` | `` | The name of the attribute to use as the condition. |
| `Network Object Type` | `IFunction<NetworkObjectType>` | `true` | `Link` | The type of network object of the condition and export attribute. |
| `Save To` | `IFunction<string>` | `true` | `` | The location to save the attribute to. |

> [!NOTE]
> `Condition Attribute` and `Save To` must both be non-blank, otherwise the module will
> fail validation.

## ExportAttributeWhereSet.Attribute

Base type: `IModule`

A simple module to provide the name of an attribute to use for an algorithm.

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Attribute Name` | `IFunction<string>` | `true` | `` | The name of the attribute to export. |
