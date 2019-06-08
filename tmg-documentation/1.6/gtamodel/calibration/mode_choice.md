# Mode Choice

Once all of the activity location choices have been calibrated the next step is to work on the mode choice model.  If you are
not familiar with GTAMode's mode choice model you can find its documentation [here](../model_design/mode_choice.md).

### Parameter Locations

##### GTAModel V4.1

To edit the mode choice parameters in GTAModel V4.1, you will directly change the parameters within the model system.  The modes
are located in three places in the model system, `Auto Mode`, `Other Modes`, and `Shared Modes`.  

##### GTAModel V4.0

For GTAModel V4.0, the mode choice parameters are loaded in from `EstimationResult/ModeChoice/EstimationResults.csv`. Inside 
of the `EstimationResults.csv` file are a series of rows containing the estimated parameters for the mode choice model.
The first row contains a header with the generation the parameter set was from, its fitness value, and continuing with all of
the parameter paths (module names separated by '.'s, with the final segment being the name of the parameter).  Only the second row
will be used for the parameter values.

### Calibration Steps

The first the to calibrate the mode choice model is to modify the modal constants to balance the number of trips by mode globally.  In
TMG provided GTAModels the Auto mode will have its constants fixed to zero.  In order to avoid parameter scaling, please leave this mode
with zero constants.  Each mode has size constants, one for each person category, and a constant for an intrazonal trip.  The intrazonal
constant is additive to the appropriate person category.

After the modes are balanced globally the next step is to add/modify the `Time Period Constants`.  If the time period
has not already been added you will need to do so.  Make sure to set the start and end time parameters to match the time period by
changing the parameters of the module accordingly.  Given the correct time period, check the `Spatial Constants` to see if
a parameter already exists for the OD that you wish to modify.  All modifications are done at a planning district to planning district
level.  For these parameters it is traditional to use the format `1-4,6:5,7-16` where the colon breaks up the two range sets, on the
left the origin and on the right hand side the destination range set.

> [!Tip]
> When working with the `Time Period Constants` remember that by modifying a parameter in any time period, the chosen modes in the other
> time periods will also be modified as tours containing the modified mode will now be more attractive.