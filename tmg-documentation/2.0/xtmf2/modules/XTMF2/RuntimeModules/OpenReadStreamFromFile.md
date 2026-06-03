# Open Read Stream From File

Provides the ability to read a file from the path given to it via the context.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `OpenReadStreamFromFile` | `BaseFunction<ReadStream>` | `OpenReadStreamFromFile.cs` |

## OpenReadStreamFromFile

Base type: `BaseFunction<ReadStream>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `File Path` | `IFunction<string>?` | `true` | `` | The path to the file to load. |
| `Check File Exists At Run Start` | `IFunction<bool>?` | `true` | `true` | True if the file should be checked at runtime to ensure that it exists. |
