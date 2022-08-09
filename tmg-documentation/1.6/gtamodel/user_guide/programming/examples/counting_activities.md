# Counting Activities

In this tutorial we will walk through the process of creating a new
[IPostHousehold](../interfaces/post_household.md) module that will count
the number of activities of each type.

 If you have not already made sure to have included references to
`XTMFInterfaces.dll`, `TMGInterfaces.dll`, and `TashaInterfaces.dll` found in your
copy of XTMF's Modules directory.

## Step 1: The Initial Template

In the example code below, we start by including the different namespaces that
we will require.  This is followed by declaring what namespace we are going to work in,
for our case we have chosen the name `Example`.  Within the namespace's scope we then
declare a new class called `CountActivities` which is going to implement the interface
`IPostHousehold`.

```cs
using XTMF;
using TMG.Input;
using System;
using System.IO;
using System.Threading;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "", DocURL = null)]
    public sealed class CountActivities : IPostHousehold
    {
        public void Load(int maxIterations)
        {
        }

        public void IterationStarting(int iteration)
        {
        }

        public void Execute(ITashaHousehold household, int iteration)
        {
        }

        public void IterationFinished(int iteration)
        {
        }

        public string Name { get; set; }

        public float Progress => 0f;

        public Tuple<byte, byte, byte> ProgressColour => new Tuple<byte, byte, byte>(50, 150, 50);

        public bool RuntimeValidation(ref string error)
        {
            return true;
        }
    }
}
```

## Step 2: Datastructures

To store our results we are going to setup three
member variables.  

* `_activityCount` is an array
  of integers where we will store the number of each activity.
  The vector will be sized using the enumeration shown below.
* `_finalIteration` will have the iteration number that
  will be the final iteration, this will let us only record data
  on the last iteration.
* `_activities` will be used to store the array of activity types.

```cs
private int[] _activityCount;
private int _finalIteration;
private Activity[] _activities;
```

With our member variables initialized we can now move onto
initializing them.  We first ask the Activity type how many
options it has and store the results.  In .Net framework
the Enum type returns an `Array` object instead of an
`Activity[]` so we need to post-process that to increase
the performance later.  For `_activityCount` we now
initialize the array with the correct size.  `_finalIteration`
is also setup using the maxIterations parameter.

```cs
public void Load(int maxIterations)
{
    Array activityArray = Enum.GetValues(typeof(Activity));
    _activities = new Activity[activityArray.Length];
    for (int i = 0; i < activityArray.Length; i++)
    {
        _activities[i] = (Activity) activityArray.GetValue(i);
    }
    _activityCount = new int[_activities.Length];
    _finalIteration = maxIterations - 1;
}
```
For the IterationStarting method we clear out the
`_activityCount` so all of the counts are zero before
we begin recording.

```cs
public void IterationStarting(int iteration)
{
    // Only Store data for the final iteration
    if (iteration < _finalIteration)
    {
        return;
    }
    Array.Clear(_activityCount, 0, _activityCount.Length);
}
```

## Step 3: Gathering Data

To gather the activity counts we first check to make sure that
we are in the final iteration.  If this is the final iteration
we then go through each persons' trip chains' trips.  For each
of those trips we get its purpose and find which index we
should store the count to by looking it up in the `activities`
array.  You will notice that we are using the Interlocked
class to increase the value.  This is required because
the Execute method is most likely being executed in parallel.
If we were to just add to it directly there is a good chance
that two threads would collide, and we would end up getting
the wrong answer.

```cs
public void Execute(ITashaHousehold household, int iteration)
{
    // Only Store data for the final iteration
    if(iteration < _finalIteration)
    {
        return;
    }
    foreach(var person in household.Persons)
    {
        foreach (var tripChain in person.TripChains)
        {
            foreach (var trip in tripChain.Trips)
            {
                var index = Array.IndexOf(_activities, trip.Purpose);
                if (index >= 0)
                {
                    Interlocked.Increment(ref _activityCount[index]);
                }
            }
        }
    }
}
```

## Step 4: Outputting Results

The first thing that we will need to do to store our
results is to get the location on disk that the user
wants us to save to.  To do that we will use the
submodule `TMG.Input.FileLocation` abstract class.  By
adding the member variable as written below we tell XTMF
that this child is required, the model system will not start
if the user has not selected an option for it, and we have
given a description that will be presented to the user
as they are editing their model system as to what this will
be used for.  The `Index` parameter is new in XTMF 1.10 and
it allows us to control the order of our submodules.  If
you do not specify this then your child modules will
be ordered alphabetically.

```cs
[SubModelInformation(Required = true,
            Description = "The location that we will store the activity count to.",
            Index = 0)]
        public FileLocation SaveTo;
```

Now that we have our submodule setup, we can write our code to output
the results.  For this we will implement it in the IterationFinishing
method interface.

The first thing we do is open the file for writing.  To do that we will use
.Net's StreamWriter class and pass it the `FileLocation` submodule so it
will describe where to write to.  With the write stream open we can then
first write the header for the CSV file.  After the header is written we then
iterate through the activity array and write the name of the activity followed
by the number of times it was emitted during the run.

```cs
public void IterationFinished(int iteration)
{
    using(var writer = new StreamWriter(SaveTo))
    {
        writer.WriteLine("Activity,Count");
        for (int i = 0; i < _activities.Length; i++)
        {
            writer.Write(Enum.GetName(typeof(Activity), _activities[i]));
            writer.Write(',');
            writer.WriteLine(_activityCount[i]);
        }
    }
}
```

## Complete Code

With all the steps complete we now have our working module.  For reference the
completed module is below.

```cs
using XTMF;
using TMG.Input;
using System;
using System.IO;
using System.Threading;
using Tasha.Common;

namespace Example
{
    [ModuleInformation(Description = "", DocURL = null)]
    public sealed class CountActivities : IPostHousehold
    {
        private int[] _activityCount;
        private int _finalIteration;
        private Activity[] _activities;

        [SubModelInformation(Required = true,
            Description = "The location that we will store the activity count to.",
            Index = 0)]
        public FileLocation SaveTo;

        public void Load(int maxIterations)
        {
            Array activityArray = Enum.GetValues(typeof(Activity));
            _activities = new Activity[activityArray.Length];
            for (int i = 0; i < activityArray.Length; i++)
            {
                _activities[i] = (Activity) activityArray.GetValue(i);
            }
            _activityCount = new int[_activities.Length];
            _finalIteration = maxIterations - 1;
        }

        public void IterationStarting(int iteration)
        {
            // Only Store data for the final iteration
            if (iteration < _finalIteration)
            {
                return;
            }
            Array.Clear(_activityCount, 0, _activityCount.Length);
        }

        public void Execute(ITashaHousehold household, int iteration)
        {
            // Only Store data for the final iteration
            if(iteration < _finalIteration)
            {
                return;
            }
            foreach(var person in household.Persons)
            {
                foreach (var tripChain in person.TripChains)
                {
                    foreach (var trip in tripChain.Trips)
                    {
                        var index = Array.IndexOf(_activities, trip.Purpose);
                        if (index >= 0)
                        {
                            Interlocked.Increment(ref _activityCount[index]);
                        }
                    }
                }
            }
        }

        public void IterationFinished(int iteration)
        {
            using(var writer = new StreamWriter(SaveTo))
            {
                writer.WriteLine("Activity,Count");
                for (int i = 0; i < _activities.Length; i++)
                {
                    writer.Write(Enum.GetName(typeof(Activity), _activities[i]));
                    writer.Write(',');
                    writer.WriteLine(_activityCount[i]);
                }
            }
        }

        public string Name { get; set; }

        public float Progress => 0f;

        public Tuple<byte, byte, byte> ProgressColour => new Tuple<byte, byte, byte>(50, 150, 50);

        public bool RuntimeValidation(ref string error)
        {
            return true;
        }
    }
}
```
