# ITashaRuntime

This interface is used for implementing the logic
of running a TASHA based model.  The interface allows for
the scheduler and mode choice to be able to share common resources.

This interface inherits the `TMG.ITravelDemandModel` and `TMG.IResourceSource`
interfaces. `TMG.ITravelDemandModel` in turn inherits `XTMF.IModelSystemTemplate`.

## Methods for ITravelDemandModel

The ITravelDemandModel interface is shared with simpler four step models.  It
provides child modules access to network level data (times, costs) for the
auto and transit networks as well as the ZoneSystem that is being used.

### NetworkData

Provides a list of different network data entities that can be bound to
for child modules.

```cs
/// <summary>
/// The network level data that will be used in this model
/// </summary>
IList<INetworkData> NetworkData { get; }
```

### ZoneSystem

This provides child modules access to the run's zone system.

```cs
/// <summary>
/// The zone system that will be used in the model
/// </summary>
IZoneSystem ZoneSystem { get; }
```

## Methods for IResourceSource

The IResourceSource is used to share data between modules, allowing
them to use the name of an IResource to bind between data sources.

### Resources

This property provides access to the different data Resources that TASHA has.
Typically you will have some matrices for PoRPoW / PoRPoS, your EMME Databank controllers,
and your freight models defined within these resources amoung other things.

```cs
/// <summary>
/// Provides access to all of the model system's resources
/// </summary>
List<IResource> Resources { get; }
```

## Methods for IModelSystemTemplate

These methods are used by XTMF to support the starting point
of a model system.

### InputBaseDirectory

This property methods is used by XTMF for allowing child modules to find the
directory that input files are expected to start from.  This allows
those modules to use relative paths from this point.  This allows
the user to only edit this one path when the input directory is moved or
when setting up the model system on a new computer.

```cs
/// <summary>
/// The base directory for input
/// (Should be a relative path so that XMTF can put it inside of the project)
/// </summary>
string InputBaseDirectory { get; set; }
```

### OutputBaseDirectory

This property is depricated in the current convention.  We recommend setting this
property to return the current working directory.

```cs
/// <summary>
/// The base directory for output
/// (Should be a relative path so that XMTF can put it inside of the project)
/// </summary>
string OutputBaseDirectory { get; set; }
```

### ExitRequest

This method is called when the user presses the stop button in the XTMF.GUI.
It should return true if the model system has accepted the exit request, false otherwise.

```cs
/// <summary>
/// Setting this flag will request that the model system template will exit prematurely
/// </summary>
/// <returns>True if this model system template supports exiting (and will exit), false otherwise.</returns>
bool ExitRequest();
```

## Methods for ISelfContainedModule

This interface is used for many modules for XTMF that do not require anything besides a point to start.

### Start

This method is invoked when the module should execute.

```cs
void Start();
```

## Methods for ITashaRuntime

### AllModes

This list is requested by child modules that need to get access to all modes.
This would include the AutoMode, Other Modes, and Shared Modes.

```cs
[DoNotAutomate]
List<ITashaMode> AllModes { get; }
```

### AutoMode

This mode represents a drive all way auto mode.  It is used by the scheduler to get
the travel times between zones when working with activity episodes.

```cs
[SubModelInformation( Description = "The Auto mode to use for Tasha", Required = true )]
ITashaMode AutoMode { get; set; }
```

### AutoType

This property represents the type of vehicle that the auto mode will use.

```cs
[SubModelInformation( Description = "The type of vehicle used for auto trips", Required = true )]
IVehicleType AutoType { get; set; }
```

### EndOfDay

This gives a representation for the end of day, for TASHA that is expected to be 28:00.

```cs
Time EndOfDay { get; set; }
```

### HouseholdLoader

This module will be used to load in the households to process through the scheduler and mode choice.

```cs
[SubModelInformation( Description = "The model that will load our household", Required = true )]
IDataLoader<ITashaHousehold> HouseholdLoader { get; set; }
```

### TotalIterations

This gives the total number of iterations that the TASHA algorithm will execute before
ending.

```cs
int TotalIterations { get; set; }
```

### ModeChoice

This module gets called with the household after the scheduler has finished processing.

```cs
[SubModelInformation( Description = "The ModeChoice Module", Required = false )]
ITashaModeChoice ModeChoice { get; set; }
```

### NonSharedModes

This returns back a list of all of the modes that are not shared (Passenger/Rideshare).

```cs
List<ITashaMode> NonSharedModes { get; set; }
```

### OtherModes

This list of modes contains all of the modes that are not shared and are not the auto mode.

```cs
[SubModelInformation( Description = "A collection of modes other than shared modes and auto", Required = false )]
List<ITashaMode> OtherModes { get; set; }
```


### Parallel

This returns true if households are being processed in parallel, false if in serial.

```cs
bool Parallel { get; set; }
```

### PostHousehold

These modules will be executed in order after both the scheduler and mode choice have finished processing the household.
Modules in this list need to be thread-safe as households are typically processed in parallel.

```cs
[SubModelInformation( Description = "A collection of modules to run after the household has finished", Required = false )]
List<IPostHousehold> PostHousehold { get; set; }
```

### PostIteration

These modules will be executed in order after all households have been processed for the iteration.

```cs
[SubModelInformation( Description = "A collection of modules to run after an iteration is complete", Required = false )]
List<IPostIteration> PostIteration { get; set; }
```

### PostRun

These modules will be executed in order after all of TASHA's iterations have completed.

```cs
[SubModelInformation( Description = "A Collection of models that will run before the Tasha Method.", Required = false )]
List<ISelfContainedModule> PostRun { get; set; }
```

### PostScheduler

These modules will be executed in order after the scheduler has finished processing the household
but before the mode choice has run.  Modules running in this interface will need to be thread-safe
as households are often processed in parallel.

```cs
[SubModelInformation( Description = "A collection of modules to run after the scheduler has finished", Required = false )]
List<IPostScheduler> PostScheduler { get; set; }
```

### PreIteration

These modules will be executed in order before the households start processing.

```cs
[SubModelInformation( Description = "A Collection of models that will run before the Tasha Method.", Required = false )]
List<IPreIteration> PreIteration { get; set; }
```

### PreRun

These modules will be executed in order before the TASHA starts running, but after the zone system has been loaded.

```cs
[SubModelInformation( Description = "A Collection of models that will run before the Tasha Method.", Required = false )]
List<ISelfContainedModule> PreRun { get; set; }
```

### RandomSeed

This is a number used to create random number generators.  It is recommended to
not use this number directly but combine it with another number as a starting point for the
generator.

```cs
int RandomSeed { get; set; }
```

### SharedModes

This list of modes contain the modes that are shared across multiple household members.
Traditionally this would contain one for the passenger and one for rideshare mode.

```cs
[SubModelInformation( Description = "A collection of modes that can be shared.", Required = false )]
List<ISharedMode> SharedModes { get; set; }
```

### StartOfDay

This stores the start of the simulation day, typically for TASHA this is 4:00.

```cs
Time StartOfDay { get; set; }
```

### VehicleTypes

This contains a list of all of the vehicle types that are required
outside of the `AutoType` vehicle.

```cs
[SubModelInformation( Description = "A collection of modes other than shared modes and auto", Required = false )]
List<IVehicleType> VehicleTypes { get; set; }
```

### CreateTrip

This creates a new trip object for the given chain.

```cs
ITrip CreateTrip(ITripChain chain, IZone originalZone, IZone destinationZone, Activity purpose, Time startTime);
```

### GetIndexOfMode

This returns the index of the given mode relative to the `AllModes` list.

```cs
int GetIndexOfMode(ITashaMode mode);
```
