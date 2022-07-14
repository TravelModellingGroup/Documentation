# GTAModel V4 Walkthrough - Executing A Run

After completing your initial configuration of the model system you are now ready to execute your first run.

## Setting up Scenarios

Before executing a run you will need to setup the different input scenarios.  In your input directory
you will have seen multiple "Scenario-X" directories. Each of these directories should have a corresponding
Quick Parameter in the model system. By default the model system should be preconfigured to execute against
the base year however, we will walk through the procedure in any case for GTAModel V4.2's inputs.

For all of the scenario directories each scenario is organized first by year, and then by a scenario name.
For example we might have the path `~/Scenario-Population/2016/Base`.  For this example we have a 2016 population
that contains the "Base" scenario, likely a synthetic population based on TTS population totals.

You can access more detailed documentation for the input directory
[here](../InputDirectory/index.md).

## Next Step

Now that we have finishing executing our first run we can now explore what the [model's outputs look like](model_outputs.md).