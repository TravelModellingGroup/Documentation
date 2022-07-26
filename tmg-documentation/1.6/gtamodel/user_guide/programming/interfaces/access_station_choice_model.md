# IAccessStationChoice

The access station choice models are used by the drive access transit mode. To create your own access
station choice model for DAT you will need to implement the `Tasha.Common.IAccessStationChoiceModel`
interface in `TashaInterfaces.dll`.

## Methods

Below are the functions that will need to be implemented to build functional
access station choice model.

### Load

This function will be called before the drive access transit mode evaluates any utilities by
calling `ProduceResults`.

```cs
/// <summary>
/// Call this before using the module
/// </summary>
void Load()
```


### ProduceResult

This function will be called when a tour needs to be evaluated.  

```cs
/// <summary>
/// Get a result for the given data
/// </summary>
/// <param name="data">The data to use to process the result</param>
/// <returns>A result based on the given data</returns>
Pair<IZone[], float[]> ProduceResult(ITripChain data);
```

### Unload

This function gets called when the TASHA iteration is ending, and when the DAT is
going to clear out its own memory.  Use this to release any resources or
temporary buffers that use things like the zone system, or level of service
data.

```cs
/// <summary>
/// Call this after you have finished using this module, or between iterations
/// </summary>
void Unload();
```


## Example Code

For this example we will implement a barebones access station choice model.  For simplicity
it takes in a single parameter that contains the station zones and assigns a uniform distribution
to them.  It also requests XTMF to only allow this module to work within a Model System Template
that implements the ITravelDemandModel interface allowing it to access the zone system.

```cs
using Datastructures;
using System.Linq;
using XTMF;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "An example access station choice model implementation")]
    public sealed class MyAccessStationChoiceModel : IAccessStationChoice
    {
        [RunParameter("StationZones", "1-10", typeof(RangeSet), "The zones to use as stations.")]
        public RangeSet StationZones;
    
        [RootModule]
        public ITravelDemandModel Root;
    
        private IZone[] _stationZones;
    
        public void Load()
        {
            var zoneSystem = Root.ZoneSystem.ZoneArray;
            _stationZones = StationZones.SelectMany(range => range.EnumerateInclusive()
                                            .Select(zoneNumber => zoneSystem[zoneNumber))
                                        .ToArray();
        }
    
        public Pair<IZone[], float[]> ProduceResult(ITripChain data)
        {
            var results = new float[_stationZones.Length];
            Array.Fill(results, 1.0f);
            return new Pair<IZone[], float[]>(_stationZones, results);
        }
    
        public void Unload()
        {
            _stationZones = null;
        }
    }
}
```
