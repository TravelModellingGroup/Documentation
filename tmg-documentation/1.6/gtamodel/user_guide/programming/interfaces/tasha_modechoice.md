# ITashaModeChoice

The ITashaModeChoice interface is used to implement a new mode choice algorithm
for TASHA.

## Methods

### IterationFinished

This function is called by the ITashaRuntime when it completes an iteration.

```cs
void IterationFinished(int iteration, int totalIterations);
```

### IterationStarted

This function is called by the ITashaRuntime when the iteration is starting.
The zone system and network level of service data will have already been loaded.

```cs
void IterationStarted(int iteration, int totalIterations);
```

### LoadOneTimeLocalData

This function is called by the ITashaRuntime after the zone system has been loaded.

```cs
/// <summary>
/// Load the data that the Mode Choice needs to initialize
/// </summary>
void LoadOneTimeLocalData();
```

### Run

This method is called for each household in parallel.  All code
called by this method must be thread-safe.  The implementation will
be expected to set each Trip's Mode and ModesChosen array with
selected modes.

```cs
/// <summary>
/// Run the mode choice on the given household
/// </summary>
/// <param name="household"></param>
bool Run(ITashaHousehold household);
```

## Example Code

The following is a simple example of a mode choice module that assigns everyone
to use the Auto mode from TASHA.

```cs
using XTMF;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "An example mode choice implementation")]
    public sealed class MyModeChoice : ITashaModeChoice
    {
        [RootModule]
        public ITashaRuntime Root;

        public void LoadOneTimeLocalData()
        {
            // If there is data that the mode choice needs to load after the zone system finishes you can
            // do that here.
        }

        public void IterationStarted(int iteration, int totalIterations)
        {
        }

        public bool Run(ITashaHousehold household)
        {
            var autoMode = Root.AutoMode;
            foreach(var person in household.Persons)
            {
                foreach(var tripChain in person.TripChains)
                {
                    foreach(var trip in tripChain.Trips)
                    {
                        trip.Mode = autoMode;
                        for(int i = 0; i < trip.ModesChosen.Length; i++)
                        {
                            trip.ModesChosen[i] = autoMode;
                        }
                    }
                }
            }
        }

        public void IterationFinished(int iteration, int totalIterations)
        {
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
