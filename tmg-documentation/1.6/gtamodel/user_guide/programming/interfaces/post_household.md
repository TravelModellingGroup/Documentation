# IPostHousehold

This interface executes after the scheduler and mode choice have finished executing each household.

## Methods

### Execute

This is the function that will be executed when TASHA has finished running both
the Scheduler and Mode choice modules.

```cs
/// <summary>
/// This gets called what TASHA finishes processing a household
/// </summary>
/// <param name="household"></param>
/// <param name="iteration"></param>
void Execute(ITashaHousehold household, int iteration);
```

### IterationStarting

This method gets executed when a new iteration of GTAModel is starting
after the Level of Service has been updated.

```cs
/// <summary>
/// This will be called before a new iteration begins
/// </summary>
/// <param name="iteration"></param>
void IterationStarting(int iteration);
```

### IterationFinished

This method gets executed when an iteration of GTAModel all of the households have been
processed for an iteration but before the `IPostIteration` modules have run.

```cs
/// <summary>
/// Called when an iteration is complete
/// </summary>
/// <param name="iteration"></param>
void IterationFinished(int iteration);
```

### Load

This method gets executed at the start of the model system
after the zone system has been loaded.

```cs
/// <summary>
/// Loads the module, with configuration
/// information
/// </summary>
/// <param name="maxIterations">The number of iterations</param>
void Load(int maxIterations);
```

## Example Code

For this example we will implement a barebones IPostHousehold module that sums up the number of
trips made and prints it to the console at the end of the iteration.

```cs
using XTMF;
using System.Linq;
using System.Threading;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "An example post household module implementation")]
    public sealed class MyPostHousehold : IPostHousehold
    {
        private long _numberOfTrips;

        public void Load(int maxIterations)
        {
            // Load any cached data here
        }

        public IterationStarting(int iteration)
        {
            _numberOfTrips = 0;
        }

        public void Execute(ITashaHousehold household, int iteration)
        {
            var trips = household.Persons
                        .Sum(person => person.TripChains.Sum(tc => tc.Trips.Length));
            Interlocked.Add(ref _numberOfTrips, trips);
        }

        public IterationFinishing(int iteration)
        {
            Console.WriteLine(_numberOfTrips);
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
