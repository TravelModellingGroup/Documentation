# Episode Generation

The episode generation for GTAModel is based on 262 different distributions
extracted from the TTS survey. In this section we are going to see how we can adjust the generation
rates in order to better fit to your model's area.
 
> [!TIP]
> Documentation on how map Distribution IDs to activities can be found
> [here](../model_design/scheduler.md#generate-trip-chains).  

You can find the list of modules to adjust the generation rates at
`Scheduler/Generation Rate Adjustments` within GTAModel V4.1.

You can add as many `GenerationAdjustment` modules as required.  This module has 4 parameters.

| Parameter | Description |
|------------------------|----------------------------------------------------------------------------------------|
| Distribution ID Range | Takes in a range set for the distributions you would like to modify |
| Factor | Is a multiplier to assign to all non-zero frequencies, controlling the generation rate |
| Planning Districts | Takes in a range set for the person's home zone |
| Work Planning District | Takes in a range set for the person's work zone |

An unemployed person 'works' in planning district 0.  If there are multiple generation rate
adjustments that cover the same activity distribution and home and work planning districts,
the adjustment that comes first in the list will be applied.

> [!Warning]
> When adjusting the factor for work trips, remember that an individual can only make a single
> Primary work episode. This will force you to iterate while tuning the generation rates.

The results of episode generation can be found in the [Microsim](../user_guide/file_formats/microsim.md)
data within the Trips table.