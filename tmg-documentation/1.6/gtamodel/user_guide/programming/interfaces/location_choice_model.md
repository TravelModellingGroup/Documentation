# ILocationChoiceModel

Using this interface, you can implement a new location choice model for TASHA. T
his module is responsible for picking discrete the destinations for other,
market, and work-based-business activities when constructing the schedule.

## Methods

Below are the functions that will need to be implemented to build functional
location choice model.

### GetLocationHomeBased

This method is no longer supported for GTAModel V4.0+.

```cs
public IZone GetLocationHomeBased(Activity activity, IZone zone, Random random)
{
    throw new NotImplementedException("This method is no longer supported for V4.0+");
}

public IZone GetLocationHomeBased(IEpisode episode, ITashaPerson person, Random random)
{
    throw new NotImplementedException("This method is no longer supported for V4.0+");
}
```

### GetLocationWorkBased

This method is no longer supported for GTAModel V4.0+.

```cs
public IZone GetLocationWorkBased(IZone primaryWorkZone, ITashaPerson person, Random random)
{
    throw new NotImplementedException("This method is no longer supported for V4.0+");
}
```

### LoadLocationChoiceCache

This method is used for loading in the data each iteration that GTAModel executes.  Level of
Service information and zone systems might have changed between calls so make sure to reload
your cached data.

```cs
public void LoadLocationChoiceCache()
```

### GetLocation

This method is invoked to get a random zone to assign to the given episode.

```cs
public IZone GetLocation(IEpisode ep, Random random)
```

### GetLocationProbabilities

You can call the following variant to get the probabilities
for going to each zone for the given activity episode.

```cs
public float[] GetLocationProbabilities(IEpisode ep)
```

## Example Code

In this following example we will implement a base bones implementation
that gives a uniform probability to each zone.

```cs
using XTMF;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "An example location choice model implementation")]
    public sealed class MyLocationChoiceModel : ILocationChoiceModel
    {
        [RootModule]
        public ITravelDemandModel Root;
    
        public void LoadLocationChoiceCache()
        {
            // We don't need to load anything for this example
        }

        public IZone GetLocation(IEpisode ep, Random random)
        {
            var zones = Root.ZoneSystem.ZoneArray.GetFlatData();
            return zones[random.Next(0,zones.Length)];
        }
    
        public float[] GetLocationProbabilities(ITripChain data)
        {
            var zones = Root.ZoneSystem.ZoneArray;
            var ret = new float[zones.Count];
            Array.Fill(ret, 1.0f / zones.Count);
            return ret;
        }

        public IZone GetLocationHomeBased(Activity activity, IZone zone, Random random)
        {
            throw new NotImplementedException("This method is no longer supported for V4.0+");
        }

        public IZone GetLocationHomeBased(IEpisode episode, ITashaPerson person, Random random)
        {
            throw new NotImplementedException("This method is no longer supported for V4.0+");
        }

        public IZone GetLocationWorkBased(IZone primaryWorkZone, ITashaPerson person, Random random)
        {
            throw new NotImplementedException("This method is no longer supported for V4.0+");
        }
    }
}
```
