# Create Segments and Series

This module allows you to create or update new Demand Segments, Demand Time Series, and Standard Time Series.

The sub-modules are processed in a fixed order: standard time series first, then demand
time series, then demand segments.  This means a demand time series may reference a
standard time series created by the same module, and a demand segment may reference a
demand time series created by the same module.  If an object with the given code already
exists it is updated rather than recreated.

> [!NOTE]
> The `Standard Time Series Info`, `Demand Time Series Info`, and `Demand Segment Info`
> sub-modules describe objects that must be resolvable within the VISUM instance.  A
> demand segment will fail at runtime if the mode code or demand time series code it
> references does not exist.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `CreateSegmentsAndSeries` | `BaseAction<VisumInstance>` | `Create/CreateSegmentsAndSeries.cs` |
| `CreateSegmentsAndSeries.StandardTimeSeriesInfo` | `IModule` | `Create/CreateSegmentsAndSeries.cs` |
| `CreateSegmentsAndSeries.DemandTimeSeriesInfo` | `IModule` | `Create/CreateSegmentsAndSeries.cs` |
| `CreateSegmentsAndSeries.DemandSegmentInfo` | `IModule` | `Create/CreateSegmentsAndSeries.cs` |

## CreateSegmentsAndSeries

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| `Standard Time Series` | `StandardTimeSeriesInfo[]` | `false` | The standard time series to create or update |
| `Demand Time Series` | `DemandTimeSeriesInfo[]` | `false` | The demand time series to create or update |
| `Demand Segments` | `DemandSegmentInfo[]` | `false` | The demand segments to create or update |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| - | - | - | - | - |

## CreateSegmentsAndSeries.StandardTimeSeriesInfo

Base type: `IModule`

Contains the information required to create or update a Standard Time Series.

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Name` | `IFunction<string>` | `true` | `Default` | The name for the Standard Time Series. |

## CreateSegmentsAndSeries.DemandTimeSeriesInfo

Base type: `IModule`

Contains the information required to create or update a Demand Time Series.

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Code` | `string` | `true` | `Default` | The Code for the Demand Time Series. |
| `Name` | `string` | `true` | `Default` | The name for the Demand Time Series. |
| `Standard Time Series Name` | `string` | `true` | `Default` | The name of the Standard Time Series this demand time series will use. |

## CreateSegmentsAndSeries.DemandSegmentInfo

Base type: `IModule`

Contains the information required to create or update a Demand Segment.

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Code` | `string` | `true` | `C` | The code for the demand segment. |
| `Name` | `string` | `true` | `C` | The name for the demand segment. |
| `Mode Code` | `string` | `true` | `C` | The code for the mode that will use this demand segment. |
| `Demand Time Series Code` | `string` | `true` | `Default` | The code of the Demand Time Series to use. |
