# Create Segments and Series

This module allows you to create or update new Demand Segments, Demand Time Series,
and Standard Time Series.

## Submodules

| Submodule Name | Type | Description |
|----------------|------|-------------|
|Segments|`DemandSegmentInfo[]`| The demand segments to create or update.|
|Demand Time Series|`DemandTimeSeriesInfo[]`|The demand time series to create or update|
|Standard Time Series|`StandardTimeSeriesInfo[]`|The standard time series to create or update|

## StandardTimeSeriesInfo

Contains the information required to create or update a Standard Time Series.

| Parameter Name | Type | Description |
|----------------|------|-------------|
|Name|`string`| The name of the Standard Time Series.|

## DemandTimeSeriesInfo

Contains the information required to create or update a Demand Time Series.

| Parameter Name | Type | Description |
|----------------|------|-------------|
|Code|`string`| The Code for the Demand Time Series.|
|Name|`string`| The Name of the Demand Time Series.|
|Standard Time Series Name|`string`| The name of the Standard Time Series this demand time series will use.|

## DemandSegmentInfo

Contains the information required to create or update a Demand Segment.

| Parameter Name | Type | Description |
|----------------|------|-------------|
|Code|`string`| The Code for the Demand Segment.|
|Name|`string`| The Name of the Demand Segment.|
|Mode Code|`string`| The code for the mode that will use this demand segment.|
|Demand Time Series Code|`string`| The code of the Demand Time Series to use.|
