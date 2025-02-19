# Automated Calibration Framework

## Overview

`XTMF 1.14+`

The calibration framework is a set of modules that allow for multi-objective
calibration of model systems.

When using the automated calibration framework you will often want to use the [ODMath Framework](od_math/od_math.md)
to manipulate both the calibration targets and the model outputs.

Some features of the framework are available in XTMF 1.13 however, there are significant improvements starting in 1.14.

The calibration framework has three primary components:

- **Calibration Model System**: A model system that is used to calibrate a model.
- **Calibration Target**: A value linked to at least one parameter that will be adjusted. There are multiple types of targets, as found in the [Targets section](#targets)
- **Client**: The model system that is being calibrated.

To use the framework you will need to use the Model System Template `TMG.Estimation.Calibration.CalibrationHost`. This model system template has the following sub-modules:

* **Pre Run** - A list of Modules to execute before the rest of the model system initializes.
* **Client** - The model system that is being calibrated.
* **Post Run** - A list of Modules to execute after all of the calibration iterations has completed.
* **Calibration Report** - An optional file location to store the parameters that were tested at each step of the calibration in addition to the differences
        between the target and the result (model - observed).
* **Targets** - The list of targets that will be used to calibrate the model system.


## Targets

Targets are modules that the calibration framework use to evaluate the model system in order to adjust
the parameters.

There are multiple types of targets that can be used depending on the type of data that you are working with.
**Probabilities are the preferred type of target** as they allow for less execution of the client model system.
If you instead are only able to express the target as a scalar or matrix, you can use those types of targets,
however it will **require the client model system to be executed N + 1 times** where N is the number of non-probability
targets.

All calibration targets will have a parameter called `Parameter Path`.  This parameter is expecting a string that gives the location
of the parameter that will be calibrated. You can specify multiple parameters by separating them with a comma `,`,.
When specifying the target, you will need to give the path to the parameter.  To do that add a `.` between
each module and child starting from the Client model system's root module.  You do not need to include `Client.` in the path.
For example if you had a client model system that had a list of resources the path might look something like
`Resources.Resource1.Parameter1`.

### Matrix Target

This target is used when you want to compare the sum of two matrices.  If you can express this in terms of probabilities
please instead use the [Probability Target](#probability-matrix-target). When creating this target an additional run of the client model system will be required
per iteration.

#### SubModules

* **Target** - The matrix that you want to compare to the client model system's output.
* **Result** - The matrix that is the result of the client model system's output.

#### Parameters

* **Explore Size** - The difference between the parameter's current value and what will be used to approximate the derivative.
* **Learning Rate** - A multiplier applied to limit the movement of the parameter.  If set to 0.05, the parameter will only move 5% of the way to where the derivative would approximate the target to be at.
* **Maximum Change** - The maximum change that the parameter can have in a single iteration.
* **Minimum Value** - The minimum value the target parameter is allowed to be set to.
* **Maximum Value** - The maximum value the target parameter is allowed to be set to.


### Probability Matrix Target

This target is used when you want to compare the sum of two matrices.
This target is preferred over the [Matrix Target](#matrix-target) as it allows for
less execution of the client model system.  The matrices are expressed in real values
where both the modelled and the observed are normalized by their respective Total matrices.

#### SubModules

This takes in five matrices in order to update the parameter.
* **Observed Total** - A matrix containing the total number of observations for each cell.
* **Observed Selection** - A matrix containing the number of observations that were selected for each cell. 
* **Model Total** - A matrix containing the total number of generated observations for each cell.
* **Model Selection** - A matrix containing the number of generated observations that were selected for each cell.
* **Mask** -  A matrix with the values of 0 or 1.  If the value is 0, the cell will be ignored.

#### Parameters

* **Minimum Value** - The minimum value the target parameter is allowed to be set to.
* **Maximum Value** - The maximum value the target parameter is allowed to be set to.
* **Parameter Is Ratio** - Set this to true if the parameter is being applied to a ratio instead of
    a constant multiplied against a variable.
* **Only Mask Selection** - Only apply the mask to both of the observed and modelled selection matrix. This can be useful
    when trying to calibration a location choice model.

### Probability Target

This takes in two scalars, one for the probability of the target, and one for the result of the client.

#### SubModules

* **Result Probability** - The probability that the client model system generated.
* **Target Probability** - The probability from observed data.


#### Parameters

* **Minimum Value** - The minimum value the target parameter is allowed to be set to.
* **Maximum Value** - The maximum value the target parameter is allowed to be set to.


### Scalar Target

When creating this target an additional run of the client model system will be required
per iteration.  If possible, please prefer (Probability Target)[#probability-target]

#### SubModules

* **Target** - The scalar value that you want to compare to the client model system's output.
* **Compute Current Value** - The scalar value that is the result of the client model system's output.

#### Parameters

* **Explore Size** - The difference between the parameter's current value and what will be used to approximate the derivative.
* **Learning Rate** - A multiplier applied to limit the movement of the parameter.  If set to 0.05, the parameter will only move 5% of the way to where the derivative would approximate the target to be at.
* **Minimum Value** - The minimum value the target parameter is allowed to be set to.
* **Maximum Value** - The maximum value the target parameter is allowed to be set to.
* **Minimum Absolute Derivative** - If the absolute value of the derivative is under this value, the parameter will not be adjusted.
* **Maximum Change** - The maximum change that the parameter can have in a single iteration.


## Creating a Calibration Model System

1. To start building a calibration model system
you will want to use the `TMG.Estimation.Calibration.CalibrationHost` module.
1. Copy in the previously estimated model system into the `Client` sub-module.
1. Create a target for each parameter that you want to calibrate.


