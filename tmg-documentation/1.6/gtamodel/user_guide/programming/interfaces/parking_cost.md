# IParkingCost

This interface is extended to implement a
new model for computing parking costs given the gap between two activities.

## Methods

Below are the functions that will need to be implemented to build functional
parking cost model.

### ComputeParkingCost

The following two methods will need to be implemented to building a parking
cost model.  In most implemetnations you will see that the
first method will just do a lookup in the zone in the zone system and call
the second with its flat zone number (the index in the zone array with the zone).

```cs
float ComputeParkingCost(Time parkingStart, Time parkingEnd, IZone zone);

float ComputeParkingCost(Time parkingStart, Time parkingEnd, int flatZone);
```

### GiveData

This method is called to get a reference to the parking cost model.  Typically
this returns a reference to the current parking cost model.

```cs
IParkingCost GiveData();
```

### LoadData

This method is called if `Loaded` is false.  It is designed to
load cached data.

```cs
void LoadData();
```

### Loaded

This property is used to see if the parking cost model has already been loaded.
If this is False then modules using this will be required to call the
`LoadData` method before calling its methods.

```cs
bool Loaded {get;}
```

### UnloadData

This method is called when the model needs to release its cached data.

```cs
void UnloadData();
```

## Example Module

In the following gives a simple example module with a constant price per hour.

```cs
using XTMF;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "An example parking cost module implementation")]
    public sealed class MyParkingCost : IParkingCost
    {
        [RootModule]
        public ITravelDemandModel Root;

        [RunParameter("Cost Per Hour", 2.0f, "The price per hour to apply to all zones.")]
        public float CostPerHour;

        public bool Loaded {get; private set;} = true;

        public void LoadData()
        {
            // Load any data we need to cache here
        }
    
        public float ComputeParkingCost(Time parkingStart, Time parkingEnd, IZone zone)
        {
            return ComputeParkingCost(parkingStart, parkingEnd,
                Root.ZoneSystem.ZoneArray.GetFlatIndex(zone.ZoneNumber));
        }

        public float ComputeParkingCost(Time parkingStart, Time parkingEnd, int flatZone)
        {
            return (parkingEnd - parkingStart).ToMinutes() / 60.0f * CostPerHour;
        }

        public IParkingCost GiveData()
        {
            return this;
        }

        public void UnloadData()
        {
            // Unload any cached data here
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
