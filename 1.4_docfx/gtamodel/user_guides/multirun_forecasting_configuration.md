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

Above we have a configuration that will evaluate two scenarios, Base and Future.  The first instruction will copy the multi-run parameters into the run directory.

```xml
<copy Origin="../../V4Input/Multi-RunV4Analysis.xml" Destination="Multi-Run.xml" />
```

The next set of instructions will update the airport model parameters to have the given year’s expected airport volumes.  For this example we have made up some numbers.

```xml
<changelinkedparameter Name="AM Airport Arrivals" Value="1" />
<changelinkedparameter Name="MD Airport Arrivals" Value="2" />
<changelinkedparameter Name="PM Airport Arrivals" Value="3" />
<changelinkedparameter Name="EV Airport Arrivals" Value="4" />
<changelinkedparameter Name="AM Departures" Value="5" />
<changelinkedparameter Name="MD Departures" Value="6" />
<changelinkedparameter Name="PM Departures" Value="7" />
<changelinkedparameter Name="EV Departures" Value="8" />
```

After all of the parameters have been setup we are going to define a run for the Base scenario.

```xml
<run Name="Base:" RunAs="Base">
```

This line sets up the run with the name ‘Base:’.  We currently add a ‘:’ in order to format the run status better, this name will not be used anywhere.  The RunAs attribute will be used to define the name of the directory inside of the main run directory to save the output.  All file path references from this point on will be relative to this directory.

```xml
<copy Origin="../../../Scenarios/Network Scenarios/Base" Destination="Network Scenario" />
<copy Origin="../../../Scenarios/Network Scenarios/Base/Fares.xml" Destination="../../../V4Input/Transit Fares/LastScenarioFares.xml" />
```

These copy instructions will copy in the wanted network scenario for the run and load in the file for generating the transit fare-based hyper-networks.

```xml
    <copy Origin="../../../Scenarios/Forecasts-Stations/Base" Destination="../../../V4Input" />
    <copy Origin="../../../Scenarios/Forecasts-Employment/Base" Destination="../../../V4Input" />
    <copy Origin="../../../Scenarios/Forecasts-Population/Base" Destination="../../../V4Input" />
```

These next copies load in the station capacities, employment information, and population data for the base scenario.  In our experience separating these three pieces separately helps deal with ranged land use forecast years and where different station configurations could occur.  If you have different possible station locations, all of them should be added in as different zones in the network and inside of the station capacity file set to a 0 capacity to disable them.

```xml
</run>
<unload Path="Resources" />

```

This next part defines the end of the run’s instructions.  The model then will finish executing before unloading the model’s resources, reading it for the next scenario.

Each run repeats with the same logic for each run.  You can switch the airport model values between runs as we have shown in our example.  

```xml
</Root>
```

Once all of the runs have been specified the above end tag is required to be XML compliant.

## Multi-Run Forecast Data File System

In our example run configuration we copied in data using the following lines:

```xml
    <copy Origin="../../../Scenarios/Forecasts-Stations/Base" Destination="../../../V4Input" />
    <copy Origin="../../../Scenarios/Forecasts-Employment/Base" Destination="../../../V4Input" />
    <copy Origin="../../../Scenarios/Forecasts-Population/Base" Destination="../../../V4Input" />

```



Each of these copies will take the data inside of that forecast and replace the data currently in V4Input.  In order for this to work properly a mirrored directory structure is required within each of these folders reflecting the subdirectories in V4Input.  The following table lists all of the files that we change between runs.