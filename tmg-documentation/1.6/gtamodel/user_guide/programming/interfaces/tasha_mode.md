# ITashaMode

This interface is extended to implement a new mode that can be chosen by TASHA.  This interface
inherits a from the `IMode` interface, which in turn implements the `IModeChoiceNode`,
used for GTAModel V2.  Some of the calls have been deprecated and replaced with newer interfaces
that support the `ITrip` interface instead of just taking in multiple zones.


## Methods from IMode

These are the methods that `ITashaMode` has inherited from the `TMG.IMode` interface which in
turn inherits IModeChoiceNode. While some of these methods are redundant they are required
to be implemented for backwards comparability.

### NetworkType

This gives which network level of service data that the mode will be using.  This string
should match the parameter `Network Name` for one of the 

```cs
/// <summary>
/// Get the type (name) of the network type to store the information in
/// </summary>
string NetworkType { get; }
```

### NonPersonalVehicle

This property is called to check if the mode uses a personal vehicle. If `RequiresVehicle`
is not null, then set this to true, false otherwise.

```cs
/// <summary>
/// Gets if this mode does not use a personal vehicle
/// </summary>
bool NonPersonalVehicle { get; }
```

### Cost

This method is called to test how expensive it is to go between the two zones.

```cs
/// <summary>
/// How much does it cost to go between the zones?
/// </summary>
/// <param name="origin">Where to start from</param>
/// <param name="destination">Where to go to</param>
/// <param name="time">The time to get the cost for</param>
/// <returns>Cost of going between the zones</returns>
float Cost(IZone origin, IZone destination, Time time);
```

### TravelTime

This method is called to test how long it takes to go between the two zones.  GTAModel
will call the TravelTime variant which instead uses the ITrip interface.

```cs
/// <summary>
/// Get how long it will take to get between zones
/// </summary>
/// <param name="origin">The zone to start from</param>
/// <param name="destination">The zone to go to</param>
/// <param name="time">The time of the day in (hhmm.ss)</param>
/// <returns>Travel time in minutes between the zones, Not a Number if it is not possible</returns>
Time TravelTime(IZone origin, IZone destination, Time time);
```

## Methods for IModeChoiceNode

### CurrentlyFeasible

*This is not used for GTAModel, you can set this to 1.*

```cs
/// <summary>
/// What percentage of the population can currently use this?
/// </summary>
float CurrentlyFeasible { get; set; }
```

### ModeName

The name of the mode. GTAModel uses this instead of the Name coming from XTMF's `IModule` interface
when referring to modes in parameters.

```cs
/// <summary>
/// The name of the mode category.
/// This can be used for applying additional factors to their variables
/// </summary>
string ModeName { get; }
```

### CalculateV

Calculate the systematic utility for travelling between the two zones.  *This
call is not used for GTAModel.*

```cs
/// <summary>
///
/// </summary>
/// <param name="origin"></param>
/// <param name="destination"></param>
/// <param name="time"></param>
/// <returns></returns>
float CalculateV(IZone origin, IZone destination, Time time);
```

### Feasible

Checks to see if the mode is allowed to be used for going between the two zones.
*This call is not used in GTAModel.*

```cs
/// <summary>
/// See if this node is feasible
/// </summary>
/// <param name="origin">The starting zone</param>
/// <param name="destination">The destination zone</param>
/// <param name="time">The starting time of day</param>
/// <returns></returns>
bool Feasible(IZone origin, IZone destination, Time time);
```

## Methods From ITashaMode

### CalculateV

This method is invoked when TASHA needs to compute the systematic utility for a trip.
The result should be in utils without the random term added.

```cs
/// <summary>
/// Calculates the V for the given trip using this mode
/// </summary>
/// <param name="trip">The trip to calculate for</param>
/// <returns>The V for this trip</returns>
double CalculateV(ITrip trip);
```


### Feasible

These methods are used to see if the mode is available for the given trip or the
given trip chain.  The trip version should only take into consider the individual
trip.  The ITripChain version is used to analyze the full tour.  For example
the Auto mode in GTAMdodel checks that the vehicle makes it along the tour
and back home at its end.

```cs
/// <summary>
/// Check to see if this mode is feasible for the given trip
/// </summary>
/// <param name="trip">The trip to check if we can possibly be used for</param>
/// <returns>If trip is feasible</returns>
bool Feasible(ITrip trip);

/// <summary>
/// Checks to see if this trip chain as a whole is feasible.
/// </summary>
/// <remarks>
/// This is used for modes like Train access, where you need to egress to the same station
/// so you can pick back up your car.
/// </remarks>
/// <param name="tripChain">The trip chain to validate</param>
/// <returns>If this trip chain is feasible according to this mode</returns>
bool Feasible(ITripChain tripChain);
```

### RequiresVehicle

If this is set to none, then tours that use this mode will not be required to use
the given vehicle type.

```cs
/// <summary>
/// Which Vehicle [if any] does this mode require
/// </summary>
IVehicleType RequiresVehicle { get; }
```


### VarianceScale

The variable will be used as the standard deviation for the normal distribution when
computing the trip's utility.

```cs
double VarianceScale { get; set; }
```



## Example Code

You can go [here](../examples/new_mode.md) for a full example of how to create a new mode for GTAModel.
