# Location Choice

There are three models that deal with location choice in GTAModel V4, Market, Other, and Work-Based-Business.
You can find documentation on the location choice [here](../model_design/scheduler.md#location-choice).  The modules are
located within model system at `Scheduler/Location Choice Model`.

Each model will contain a list of modules called `Time Period` allowing you to specify the calibration factors to each time period
individually.  Each time period will provide you two list of modules called `ODConstants` and `PDConstant`.  Starting with the 
simpler of the models `PDConstant` modules provides you a spacial dummy variable.

| Parameter | Description                                                                                 |
|-----------|---------------------------------------------------------------------------------------------|
| Constant  | The constant to add to the utility of zones contained within the planning   district range. |
| PDRange   | The range of planning districts to apply the constant to.                                   |

Only the first `PDConstant` that matches a will be applied.  These parameters are able to be precomputed reducing its impact on
runtime performance.

`ODConstants` are the second type of calibration module available for location choice.  It allows for the additional flexibility
of choosing, where the previous activity was, where the current activity is, and where the next activity will be.

| Parameter         | Description                                                                                 |
|-------------------|---------------------------------------------------------------------------------------------|
| Constant          | The constant to add to the utility of zones contained within the planning district range.   |
| Interest PD Range | The range of planning districts where the episode will be located.                          |
| Next PD Range     | The range of planning districts where the next episode must have been   located.            |
| Previous PD Range | The range of planning districts where the previous episode must have been   located.        |

