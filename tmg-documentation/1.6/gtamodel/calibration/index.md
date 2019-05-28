# Calibration Guide

> [!Tip]
> This section is designed for consultants or individuals who have received a copy of
> GTAModel V4 and need to adjust the model to better fit a specific region.  If you
> wish to learn how to use the model instead please look to the User Guide section instead.

Models based on GTAModel V4 will require calibration. Before beginning calibration please make sure that your network
model has been updated with all of the changes for your base year and including all changes
to the zone system.  Additionally, please familiarize yourself 
with the [model system's design](../model_design/overview.md).
Below is the recommended order of steps, designed in such as to reduce the
amount of iteration required as the models interact with each other.

1. [Transit Assignment](transit_assignment.md)
2. [Place-of-Residence Place-of-Work (PoRPoW)](porpow.md)
3. [Driver's License](dlic.md)
4. [Auto Ownership](auto_ownership.md)
5. [Episode Generation](episode_generation.md)
6. [Location Choice](location_choice.md)
7. [Mode Choice](mode_choice.md)

It is recommended to create a single iteration model system that avoids calling any network
assignment modules in order to reduce the model run-time while making the initial calibration
steps.  After the single iteration runs have come to an acceptable calibration you would then
move on to full model runs, increasing by one iteration at a time and running network assignments,
until you have achieved the final model's calibration.

> [!Warning]
> If you change your planning district system please go through each calibration step to
> see what parameters be affected, including the ones that came with the base GTAModel V4.

> [!Tip]
> When working with calibration modules TMG has the tradition of naming the module to describe
> the planning districts they apply to by planning district numbers using the range set format.
> For example, `1-4,6` refers to planning districts 1, 2, 3, 4, and 6.  If the calibration
> factor contains an origin and destination a colon ':' is used to separate the range sets.
> For example, `1-4,6:5,7-16` represents trips originating in the inner planning districts of
> Toronto going to the Outer planning districts of Toronto.