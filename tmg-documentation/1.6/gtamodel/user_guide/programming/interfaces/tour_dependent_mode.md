# ITourDependentMode

The `ITourDependentMode` interface is based on the [ITashaMode](tasha_mode.md) interface
however it also includes an additional method `CalculateTourDependentUtility` which
allows you to compute an additional systematic utility given the complete trip chain.
This is used for GTAModel's Drive Access Transit mode as in order to chose which
station they will drive to depends on two different trips.

## Methods

### CalculateTourDependentUtility

```cs
/// <summary>
/// Calculates the tour dependent portion of the utility for the trip
/// </summary>
/// <param name="chain">The trip chain to evaluate</param>
/// <param name="tripIndex">The index in the chain that we are computing</param>
/// <param name="dependentUtility">The utility to add to the independent portion of the utility</param>
/// <param name="onSelection">A function that can act on the trip chain.  This will be executed before passenger mode is evaluated.</param>
/// <returns>True if the tour is feasible</returns>
bool CalculateTourDependentUtility(ITripChain chain, int tripIndex, out float dependentUtility, out Action<Random, ITripChain> onSelection);
```

## Example Code

For our example we will create a new bike mode where the utility of using the bike depends on how far away from home you are.

```cs
using System;
using XTMF;
using Tasha.Common;
using TMG;

namespace Example
{
    [ModuleInformation(Description = "This mode applies a cost for how long the tour is in addition to a standard bike mode.")]
    public sealed class BikeExample : ITourDependentMode
    {
        [RunParameter("BetaTourTime", -0.1f, "The utility applied to the tour")]
        public float BetaTourTime;

        [RunParameter("BetaDistanceTravelled", -0.01f, "The utility of distance travelled using this mode per KM.")]
        public float BetaDistanceTravelled;

        public bool CalculateTourDependentUtility(ITripChain chain, int tripIndex, out float dependentUtility, out Action<Random, ITripChain> onSelection)
        {
            var tripChainLength = chain.Trips[chain.Trips.Count - 1].ActivityStartTime - chain.Trips[0].TripStartTime;
            if (IsFirstTrip(chain, tripIndex))
            {
                dependentUtility = tripChainLength.ToMinutes() * BetaTourTime;
            }
            else
            {
                dependentUtility = 0.0f;
            }
            onSelection = null;
            return true;
        }

        private bool IsFirstTrip(ITripChain chain, int currentTripIndex)
        {
            for (int i = 0; i < currentTripIndex; i++)
            {
                if (chain.Trips[i].Mode == this)
                {
                    return false;
                }
            }
            return true;
        }

        /* ITashaMode Implementation */

        [RootModule]
        public ITravelDemandModel Root;

        public string NetworkType { get; set; }

        public bool NonPersonalVehicle => true;

        public float CurrentlyFeasible { get; set; } = 1.0f;

        [DoNotAutomate]
        public IVehicleType RequiresVehicle => null;

        [RunParameter("Mode Name", "BikeExample", "The name of this mode.")]
        public string ModeName { get; set; }

        [RunParameter("Variance Scale", 1.0f, "The scale for variance used for variance testing.")]
        public double VarianceScale { get; set; }

        public float CalculateV(IZone origin, IZone destination, Time time)
        {
            return BetaDistanceTravelled * (Root.ZoneSystem.Distances[origin.ZoneNumber, destination.ZoneNumber] / 1000.0f);
        }

        public double CalculateV(ITrip trip)
        {
            return CalculateV(trip.OriginalZone, trip.DestinationZone, trip.ActivityStartTime);
        }

        public float Cost(IZone origin, IZone destination, Time time)
        {
            return 0f;
        }

        public bool Feasible(IZone origin, IZone destination, Time time)
        {
            return true;
        }

        public bool Feasible(ITrip trip)
        {
            return true;
        }

        public bool Feasible(ITripChain chain)
        {
            return true;
        }

        public Time TravelTime(IZone origin, IZone destination, Time time)
        {
            float averageSpeed = 15.0f * 1000.0f / 60.0f;
            float distance = Root.ZoneSystem.Distances[origin.ZoneNumber, destination.ZoneNumber] / 1000.0f;
            // Assume that we are travelling at 15km/h
            return Time.FromMinutes(distance / averageSpeed);
        }

        /* Below is the standard XTMF IModule interface implementation */

        public string Name { get; set; }

        public float Progress { get; set; }

        public bool RuntimeValidation(ref string error)
        {
            return true;
        }

        public Tuple<byte, byte, byte> ProgressColour { get { return new Tuple<byte, byte, byte>(50, 150, 50); } }
    }
}
```
