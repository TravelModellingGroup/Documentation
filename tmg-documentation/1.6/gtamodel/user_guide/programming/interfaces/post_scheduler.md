# IPostScheduler

This interface executes after the scheduler has finished each household but before
mode choice has executed.
    
## Methods

### Execute

This method is invoked by the TashaRuntime after a household has finished running
through the scheduler but before it has run through the mode choice.  Since
households are processed in parallel code in this method needs to be thread-safe.

```cs
void Execute(ITashaHousehold household);
```

### IterationFinished

This method is invoked after all households have finished being processed but
before the `IPostIteration` modules have executed.

```cs
void IterationFinished(int iterationNumber);
```

### IterationStarting

This method is invoked before households have started to be processed but after
the `IPreIteration` modules have executed.

```cs
void IterationStarting(int iterationNumber);
```

### Load

This method is invoked at the start of a model run, but after the zone system
has been loaded in.

```cs
void Load(int totalIterations);
```


## Example Code

For this example, we will implement a small module that calculates how many minutes
of time has been reduced for activities.  This example will also require you
to make a reference to `Tasha.dll` in addition to the standard `TashaInterfaces.dll`.

```cs
using XTMF;
using Tasha.Common;
using Tasha.Scheduler;

namespace Example
{
    [ModuleInformation(Description = "An example post scheduler module implementation")]
    public sealed class MyPostScheduler : IPostScheduler
    {
        private double _lostMinutes = 0.0;

        public void Load(int totalIterations)
        {
            
        }

        void IterationStarting(int iterationNumber)
        {
            _lostMinutes = 0.0;
        }

        public void Execute(ITashaHousehold household)
        {
            var lostTime = 0.0;
            foreach(var person in household.Persons)
            {
                if(person["SData"] is SchedulerPersonData data)
                {
                    foreach(var episode in data.Scehdule.Episodes)
                    {
                        if(episode != null)
                        {
                            lostTime += Math.Max(OriginalDuration - Duration, 0.0);
                        }
                    }
                }
            }
            lock(this)
            {
                _lostMinutes += lostTime;
            }
        }

        void IterationFinished(int iterationNumber)
        {
            Console.WriteLine($"We lost {_lostMinutes} minutes to episode duration shrinking!");
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
