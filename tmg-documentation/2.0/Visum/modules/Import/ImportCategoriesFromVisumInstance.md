# ImportCategoriesFromVisumInstance

Imports categories from a Visum instance.

This module reads the zone system out of the VISUM instance it is given and builds the
XTMF2 `Categories` that describe it.  The zone coordinates can optionally be captured at
the same time by attaching the `X` and `Y` sub-modules, each of which receives a `Vector`
indexed by the returned categories.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `ImportCategoriesFromVisumInstance` | `BaseFunction<VisumInstance, Categories>` | `Import/ImportCategoriesFromVisumInstance.cs` |

## ImportCategoriesFromVisumInstance

Base type: `BaseFunction<VisumInstance, Categories>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `X` | `ISetableValue<Vector>?` | `false` | The X coordinate of the zone |
| `Y` | `ISetableValue<Vector>?` | `false` | The Y coordinate of the zone |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |
