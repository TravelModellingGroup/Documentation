# Load Visum Instance

This module is used for loading a new instance of VISUM.

This is the root module for working with VISUM from XTMF2; the `VisumInstance` that it
returns is the context passed to every other module in this library.  A version file can
optionally be loaded as part of creating the instance.  The instance is disposed when the
module is disposed, and a previously created instance is disposed before a new one is
created.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `LoadVisumInstance` | `BaseFunction<VisumInstance>, IDisposable` | `Load/LoadVisumInstance.cs` |

## LoadVisumInstance

Base type: `BaseFunction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Version File` | `IFunction<string>?` | `false` | An optional version file that we can load when creating the instance. |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `VISUM Version` | `IFunction<VisumVersion>` | `true` | `2024` | The VISUM major version to activate (supported: 2024, 2026). |

> [!NOTE]
> This module's `DocumentationLink` in TMG.Visum currently points at
> `modules/Import/LoadVisumInstance.html` even though the module lives under `Load`.
> Until that is corrected in the source, following the documentation link from XTMF2 will
> not reach this page.
