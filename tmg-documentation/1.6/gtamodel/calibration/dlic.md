# Driver's License

`Available in GTAModel V4.1.0`

Once the PoRPoW models have been calibrated, the next step is to calibrate the
driver license model.  If you are not familiar with the model its documentation can be found
[here](../model_design/auto_ownership.md).

In GTAModel V4.1 you can find the driver license model at `Household Loader/Person Loader/Driver License Model`.
Within the module there is a module list called `Constants` which contain modules with two parameters.

| Parameter | Description |
|--------------------|-------------------------------------------------------------------------------|
| Constant | A constant applied to the binary logit |
| Planning Districts | The planning districts to select if the person lives in the given home zone |

The results of the driver license model can be found in the [Microsim](../user_guide/file_formats/microsim.md)
data within the Persons table.