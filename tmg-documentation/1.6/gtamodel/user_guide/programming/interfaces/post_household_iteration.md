# IPostHouseholdIteration

Using this interface, you can implement a module that runs after the mode choice has
finished processing a single mode choice iteration through the household.  This allows
you to see the combination of modes, access choice data, and other extremely detailed
data that is recycled between the iterations of mode choice.
    
## Methods

### HouseholdComplete

This is the function that will be executed when TASHA has finished running both
the Scheduler and Mode choice modules.

```cs
void HouseholdComplete(ITashaHousehold household, bool success);
```

### HouseholdIterationComplete

This method will be invoked when the mode choice has finished processing all of the mode choice
iterations for the household.

```cs
void HouseholdIterationComplete(ITashaHousehold household, int hhldIteration, int totalHouseholdIterations);
```

### HouseholdStart

This method will be executed when the household has finished running through the scheduler and entered into
the mode choice model.  You can use this method for building any temporary memory for your analysis
instead of checking if the iteration is zero in `HouseholdIterationComplete`.

```cs
void HouseholdStart(ITashaHousehold household, int householdIterations);
```

### IterationStarting

This method gets executed when a new iteration of GTAModel is starting
after the Level of Service has been updated.

```cs
void IterationStarting(int iteration, int totalIterations);
```

### IterationFinished

This method gets executed when an iteration of GTAModel all of the households have been
processed for an iteration but before the `IPostIteration` modules have run.

```cs
void IterationFinished(int iteration, int totalIterations);
```

## Example Code

For this example we will implement a barebones IPostHouseholdIteration module that counts
up the number of times each mode has been selected and writes it out when the iteration finishes.

```cs
using XTMF;
using System.Linq;
using System.Threading;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "An example post household iteration module implementation")]
    public sealed class MyPostHouseholdIteration : IPostHouseholdIteration
    {
        [RootModule]
        public ITashaRuntime Root;

        private long[] _tripsByMode;

        public IterationStarting(int iteration)
        {
            _tripsByMode = new long[Root.AllModes.Count];
        }

        public void HouseholdStart(ITashaHousehold household int householdIterations)
        {
            // This is where your would initialize your temporary memory cache
        }

        public void HouseholdIterationComplete(ITashaHousehold household, int iteration, int totalHouseholdIterations)
        {
            var modes = Root.AllModes;

            foreach(var person in household.Persons)
            {
                foreach(var tripChain in person.TripChains)
                {
                    foreach(var trip in tripChain.Trips)
                    {
                        int index = modes.IndexOf(trip.Mode);
                        if(index >= 0)
                        {
                            Interlocked.Increment(ref _numberOfTrips[index]);
                        }
                    }
                }
            }
        }

        public void HouseholdComplete(ITashaHousehold, bool success)
        {
            // If you are caching your results you would commit your changes into
            // your larger data cache here
        }

        public IterationFinishing(int iteration)
        {
            var modes = Root.AllModes;
            for(int i = 0; i < modes.Count; i++)
            {
                Console.Write(modes[i].ModeName);
                Console.Write(" = ");
                Console.WriteLine(_tripsByMode[i]);
            }
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
