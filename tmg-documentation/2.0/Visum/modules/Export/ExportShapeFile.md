# Export Shape File

Export the currently loaded network to ShapeFile. The default set of attributes for the given type will be exported. If you want to include additional attributes you will need to include them as an 'Extra Attribute'.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `ExportShapeFile` | `BaseAction<VisumInstance>` | `Export/ExportShapeFile.cs` |
| `ExportShapeFile.ExtraAttribute` | `IModule` | `Export/ExportShapeFile.cs` |

## ExportShapeFile

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Extra Attributes` | `ExtraAttribute[]` | `false` | Optional extra attributes to include. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Data Type` | `IFunction<ShapeFileType>` | `true` | `Link` | The type of data to export from the current VISUM network. |
| `Save To` | `IFunction<string>` | `true` | `` | The root name of the ShapeFile to save to. |
| `Exclusively Extra Attributes` | `IFunction<bool>` | `true` | `true` | Should we only export the specified extra attributes? If false all attributes specified in the network object type's list view will be exported. |

> [!NOTE]
> `Save To` must be non-blank, `Data Type` must be a valid ShapeFile type, and if
> `Exclusively Extra Attributes` is set then at least one `Extra Attributes` sub-module
> must be provided, otherwise the module will fail validation.

## ExportShapeFile.ExtraAttribute

Base type: `IModule`

Represents an extra attribute to export to the shape file.

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Attribute Name` | `IFunction<string>` | `true` | `` | The name of the attribute to use. |
