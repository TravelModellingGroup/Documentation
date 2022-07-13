# Overview - Scenarios

The scenario directories are used for quickly swapping which inputs will be used when running GTAModel V4.
Each scenario contains a grouping of files required to test a variety of policies but decoupled from each other allowing
the user to test different combinations of scenarios.  For instance there might be a three different population scenarios,
possibly a low, medium, and high forecast, that you would like to test against four different subway station locations.
In this case you would have three population scenarios and four transit scenarios, a total of twelve possible runs.

These scenario directories are then referenced in XTMF using quick parameters to select which policies to run.

> [!Tip]
> In GTAModel V4 input data is organized into the _Scenario folders_ with the following structure,
> _Scenario-Directory_/_RunYear_/_ScenarioName_.

Below are links to each scenario directory:

* [Scenario-C-19](c_19.md) - Only used by C-19 variant models.
* [Scenario-Employment](employment.md) - Provides land-use information for GTAModel regarding the location of jobs, their occupation/employment split, and
    the ratio of how many people work from home or are external workers.
* [Scenario-Network](network.md) - This goes over the inputs that GTAModel load in to construct the different time period networks for both auto and transit.
* [Scenario-Parking](parking.md) - This scenario directory, in `GTAModel V4.2+` gives fine grained control over how much parking costs.
* [Scenario-Population](population.md) - This directory contains all of the information about the households and people that live in the simulation area.
* [Scenario-School](school.md) - This directory contains all of the information about the linkages between household zone and school zone for Elementary, Secondary,
    and post-secondary schools.
* [Scenario-Stations](stations.md) - Learn how to add a new station to your model.
* [Scenario-Transit Fares](transit_fares.md) - These scenarios allow you to change the public transit fare policy.
