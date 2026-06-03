# Cache

Provides a way to keep the result of a function unless unloaded by an event.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `Cache<T>` | `BaseFunction<T>, IDisposable` | `Cache.cs` |

## Cache<T>

Base type: `BaseFunction<T>, IDisposable`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Source` | `IFunction<T>?` | `true` | Get the cached data |
| `Force Update` | `IEvent?` | `false` | Invoke to force an update |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |
