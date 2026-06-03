# Directory Path

Provides the ability to specify a directory path recursively.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `DirectoryPath` | `BaseFunction<string>` | `DirectoryPath.cs` |

## DirectoryPath

Base type: `BaseFunction<string>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Parent` | `DirectoryPath?` | `false` | Optional parent directory |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Name` | `IFunction<string>?` | `` | `directoryName` | The path to add to the Parent path |
