# IPreIteration

This interface executes before any household has been processed for the current outer-loop.
   
## Methods

### Execute

This method will run before the households start processing but after the zone system
and level of service data has been loaded.

```cs
/// <summary>
/// This will be called before the iteration starts
/// </summary>
/// <param name="iterationNumber">The iteration that we are able to run</param>
/// <param name="totalIterations">The total number of iterations tasha will do</param>
void Execute(int iterationNumber, int totalIterations);
```

### Load

This method will execute at the start of a model run after the zone system
has been loaded in.

```cs
/// <summary>
/// Loads the module, letting it know how many iterations there will be
/// </summary>
/// <param name="totalIterations">The total number of iterations</param>
void Load(int totalIterations);
```


## Example Code

For this example we will implement a barebones IPreIteration module that alerts the user
that the iteration is starting.

```cs
using XTMF;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "An example pre iteration module implementation")]
    public sealed class MyPreIteration : IPreIteration
    {
        public void Load(int totalIterations)
        {
            // You setup any cached memory you need here
        }

        public void Execute(int iterationNumber, int totalIterations)
        {
            Console.WriteLine($"Starting to run iteration {iterationNumber + 1} of {totalIterations}!");
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
