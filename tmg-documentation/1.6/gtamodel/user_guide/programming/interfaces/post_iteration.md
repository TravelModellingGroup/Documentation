# IPostIteration

This interface executes after all households have been processed through 
the scheduler and mode choice.
    
## Methods


### Execute

This method will be executed after all households have been processed.
This is often when we add modules into GTAModel to prepare matrices
for EMME or execute other models that build up demand.

```cs
/// <summary>
/// This will be called before the iteration starts
/// </summary>
/// <param name="iterationNumber">The iteration that we are able to run</param>
/// <param name="totalIterations">The total number of iterations tasha will do</param>
void Execute(int iterationNumber, int totalIterations);
```

### Load

This method is executed at the beginning of the model run after the zone
system has been loaded in.  You can use this to build a memory cache
for processing.  This method is not used often.

```cs
/// <summary>
/// Loads the module, letting it know how many iterations there will be
/// </summary>
/// <param name="config">The configuration file</param>
/// <param name="totalIterations">The total number of iterations</param>
void Load(IConfiguration config, int totalIterations);
```

## Example Code

For this example we will implement a small module that writes out to the console
when a model system has finished an iteration.

```cs
using XTMF;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "An example post household iteration module implementation")]
    public sealed class MyPostIteration : IPostIteration
    {
        public void Load(IConfiguration config, int totalIterations)
        {
            // You could use this to build a memory cache
        }

        public void Execute(int iterationNumber, int totalIterations)
        {
            Console.WriteLine("Finished processing all of the households in iteration "
                + iterationNumber);
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
