# Transit Assignment
The first step recommended is to calibrate the Transit Assignment models. If you are not familiar with these models please review their documentation
[here](../model_design/transit_assignment.md).

You can find the Transit Assignment model in GTAModel V4.1 at
`Pre Run/Execute Transit Assignment` or `Post Iteration/Run Network Assignments`. Inside each Transit Assignment model, there are 6 modules that you may calibrate with as shown below:
1. Fare-based Transit Network (FBTN)
1. Boarding Penalities
1. Transit Demand
1. Walk Perceptions
1. Surface Transit Speed Updating Models (STSU)
1. Transit Time Functions (TTF)


#### Fare-based Transit Network (FBTN)
You can change the fare scheme by modifying the *Fares.xml* file in `Generate FBTN` module, which is stored in the input directory `Scenario-Transit Fares/Base`.

In the Emme network, it is assumed that boarding and transfer fares are stored in the link attribute '*@lfare*', and in-line fares are store in the transit segment attribute '*@sfare*'.


#### Boarding Penalities
The mode and agency-specific boarding penalty scheme is adopted to minimize the Root-Mean-Square Error (RMSE) of observed and modelled boardings/alightings. You can find the list of modules to adjust the boarding penality for a specific mode or agency in `Assign Boarding Penalities`. Each mode or agency module contains five parameters.

| Parameter | Description |
|-----------------|----------------------------------------------------------------------------------------------------------------------|
| In Vehicle Time Perception | Ratio of perceived travel time compared to true travel time |
| Label | Name of the specific mode/agency |
| Line Filter | To filter the transit lines for the specific agency |
| Mode Filter | To filter the transit lines for the specific mode |
| Penalty | Boarding penalty to apply for the mode/agency | 


#### Transit Demand
You can change the transit demand matrix in `Import Transit Demand` module, which is generated from `Mode Choice/Post Household Iteration/` and stored in the output directory `Demand`.


#### Walk Perceptions
A list of modules to change the walk perception can be found in `Transit Assignment/Classes` for 5 types of links, including `Toronto/Non-Toronto`, `PD1`, and `Toronto/Non-Toronto Centroid Connectors`. 

> [!Tip]
> The detailed description of the five types of links can be found [here](../model_design/transit_assignment.md#estimation-and-calibration).
 
Each module contains two parameters.

| Parameter | Description |
|-----------------|----------------------------------------------------------------------------------------------------------------------|
| Filter | An filter expression for links that the perception applies to|
| Walk Perception Value | Walk perception on links |


#### Surface Transit Speed Updating Models (STSU)
You can modify the surface transit speed updating models in `Surface Transit Speed Model` module. GTAModel V4.1 has included `Local Bus`, `GO Bus`, and `Streetcar`. You may add as many `SurfaceTransitSpeed` modules as needed. Each module contains 7 parameters.

| Parameter | Description |
|-----------------|----------------------------------------------------------------------------------------------------------------------|
| Alighting Duration | Alighting time in *seconds per passenger* |
| Boarding Duration | Boarding time in *seconds per passenger* |
| Default Duration | Default duration time in *seconds per stop* |
| Global EROW Speed | The speed to use in segments that have Exclusive Right of Way for transit and do not have @erow_speed defined. This includes accelaration and decelaration time. |
| Line Filter Expression | To determine which lines will get surface transit speed updating applied to them (Leave it BLANK to select all lines) |
| Mode Filter Expression | To determine which modes will get surface transit speed updating applied to them (Leave this and Line Filter BLANK to select all lines) |
| Transit Auto Correlation | The multiplier to auto time in order to find transit time (i.e., the ratio of Transit Running Time to Auto Time) |


#### Transit Time Functions (TTF)
A list of modules to change the Transit Time Functions (TTF) can be found in `TTF` module. Currently in GTAModel V4.1, there are five types of TTF functions to apply for various services/modes.

> [!Tip]
> A more detailed introduction to TTF functions can be found [here](../model_design/transit_assignment.md#congestion-delay-functions).

Each module contains three parameters.

| Parameter | Description |
|-----------------|----------------------------------------------------------------------------------------------------------------------|
| Congestion Exponent | The congestion exponent term to apply to this TTF|
| Congestion Perception | The congestion perception to apply to this TTF |
| TTF | The TTF number to assign to (e.g., 1 means TTF1) |