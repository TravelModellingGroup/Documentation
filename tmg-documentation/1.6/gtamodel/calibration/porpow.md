# Place-of-Residence Place-of-Work (PoRPoW)

After your [network assignment](transit_assignment.md) models are prepared and have generated the initial
level-of-service matrices, the next step is to calibrate the PoRPoW models.  Our calibration will
focus on the aggregate PoRPoW models, one for each occupation category and full-time / part-time
employment.  If you are not similar with these models please review their documentation
[here](../model_design/porpow.md).

You can find the Professional Full-Time model in GTAModel V4.1 at
`Resources/Professional FT Probabilities/PoRPoW`.  The other occupation and employment
categories are located similarly.

Inside of each PoRPoW model's `Friction` module you will be able to create K-Factors between
planning districts by adding, or modifying, the modules in the `KFactors` module list.

Each K-Factor has the following parameters:

| Parameter | Description |
|-----------------|----------------------------------------------------------------------------------------------------------------------|
| Origin PDs | The planning districts to select if the person lives in the   given home zone. |
| Destination PDs | The planning districts to select if the person would work in   the given work zone. |
| Factor | The multiplicative factor to apply to the friction for the   defined home zone's and work zone's planning districts. |


If a planning district OD is defined more than once, the K-Factors will be multiplied together.

> [!Warning]
> If you have created additional planning districts you may need to update these K-Factors
> origin and destination planning districts to remain within the initial
> calibration provided by TMG.

In order to validate the results GTAModel V4.1 will save the results of the
final aggregate models to the output directory `Validation/PoRPoW/Compare/` in that
directory you will see three folders: `PD`, `Region`, and `Zone`.  Each of these directories
will have a matrix containing the \\( Model_{occemp} - TTS_{occemp} \\) at the given aggregation.




