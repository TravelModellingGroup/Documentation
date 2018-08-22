# Multi-Run Forecasting Configuration

In addition to the regular GTAModel V4.0 model system configuration there is another common configuration that allows the batch execution of different scenarios.  Utilizing TMG’s multi-run framework the model system will execute the runs specified in an XML file.  This XML file lets you change parameters on the fly, interact with the model system’s resources, and copy files among other things.  A full documentation of its capabilities is included in XTMF’s documentation.  The following will show how it has been used in previous work with GTAModel V4.

## Example Multi-Run Configuration File

```xml
    <Root>
        <copy Origin="../../V4Input/Multi-RunV4Analysis.xml" Destination="Multi-Run.xml" />
        <changelinkedparameter Name="AM Airport Arrivals" Value="1" />
        <changelinkedparameter Name="MD Airport Arrivals" Value="2" />
        <changelinkedparameter Name="PM Airport Arrivals" Value="3" />
        <changelinkedparameter Name="EV Airport Arrivals" Value="4" />
        <changelinkedparameter Name="AM Departures" Value="5" />
        <changelinkedparameter Name="MD Departures" Value="6" />
        <changelinkedparameter Name="PM Departures" Value="7" />
        <changelinkedparameter Name="EV Departures" Value="8" />

    <run Name="Base:" RunAs="Base">
        <copy Origin="../../../Scenarios/Network Scenarios/Base" Destination="Network Scenario" />
        <copy Origin="../../../Scenarios/Network Scenarios/Base/Fares.xml" Destination="../../../V4Input/Transit Fares/LastScenarioFares.xml" />
        <copy Origin="../../../Scenarios/Forecast-Stations/Base" Destination="../../../V4Input" />
        <copy Origin="../../../Scenarios/Forecasts-Employment/Base" Destination="../../../V4Input" />
        <copy Origin="../../../Scenarios/Forecasts-Population/Base" Destination="../../../V4Input" />
    </run>
    <unload Path="Resources" />

        <changelinkedparameter Name="AM Airport Arrivals" Value="100" />
        <changelinkedparameter Name="MD Airport Arrivals" Value="200" />
        <changelinkedparameter Name="PM Airport Arrivals" Value="300" />
        <changelinkedparameter Name="EV Airport Arrivals" Value="400" />
        <changelinkedparameter Name="AM Departures" Value="500" />
        <changelinkedparameter Name="MD Departures" Value="600" />
        <changelinkedparameter Name="PM Departures" Value="700" />
        <changelinkedparameter Name="EV Departures" Value="800" />


    <run Name="Future:" RunAs="Future">
        <copy Origin="../../../Scenarios/Network Scenarios/Future" Destination="Network Scenario" />
        <copy Origin="../../../Scenarios/Network Scenarios/ Future /Fares.xml" Destination="../../../V4Input/Transit Fares/LastScenarioFares.xml" />
        <copy Origin="../../../Scenarios/Forecast-Stations/Future " Destination="../../../V4Input" />
        <copy Origin="../../../Scenarios/Forecasts-Employment/Future " Destination="../../../V4Input" />
        <copy Origin="../../../Scenarios/Forecasts-Population/Future " Destination="../../../V4Input" />
    </run>
    <unload Path="Resources" />
    </Root>
```