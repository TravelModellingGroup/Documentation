# Freight Truck Model

```Available in GTAModel V4.1.0```

## Freight Model Methodology

### Introduction

Included in GTAModel V4.0.1 is an adaptation of a new commercial vehicle model, created by Tufayel Chowhury and Matthew Roorda.  Slight modifications
were made to the original model in order to incorporate it into GTAModel V4.1's model system structure and to allow forecasting.

In GTAModel V4.2.0 a re-calibrated model targeting 2016 cordon-counts has replaced the original model.

### Trip Generation

1. Separate simple linear regression models were developed for light, medium and heavy trucks and for 15 industry types. 
The models had one explanatory variable – employment and the dependent variable was total number of incoming and outgoing trips in a weekday.
Three types of model specifications were tested: A) intercept-only, B) slope-only and C) with intercept and slope. For each industry, model
 with the lowest root mean square error (RMSE) was selected as the best model. The regression models were converted from 24-hour to 12.5-hour
 equivalents (6:30 am to 7:00 pm) by applying calibration factors used in the previous version of GTHA freight model.

2. A household trip rates from QRFM (originally from a study conducted in Phoenix, AZ) that were calibrated in the previous version of
 GTHA freight model were used for household trip generation.

3. Zonal trip generation was calculated using regression models and household trip rates. Number of trips produced or attracted
 (production/attraction) was obtained by dividing total incoming and outgoing trips by 2.

4. For light trucks, production/attraction by 7 gateway zones (to account for external flows incoming, outgoing and through GTHA) was assumed
 to be equal to light truck counts of screen lines located closed to the gateway zones. Note that gateway zones are located outside GTHA
 and within GGH. So, cordon counts may be slightly different from actual production/attraction by the gateway zones. For medium and heavy
 trucks, 4 external gateway zones were selected to correspond to 4 external regions in Canada and US. External flows are accounted for in
 the model by directly including them in CVS OD matrices. Thus, unlike light trucks, no gateway zone trip generation was included for medium
 and heavy trucks.

##### _Table 1: External CVS Regions and Corresponding Gateway Zones_

| External Region  | Gateway   Zone/Centroid Location |
|------------------|----------------------------------|
| US Eastern       | QEW near Niagara                 |
| US Western       | 403 at Woodstock, ON             |
| Canada   Western | 400 near Barrie                  |
| Canada   Eastern | 401 in Durham Region             |


Special generators were also included for zones 2009, 3332, 3709 (Toronto Pearson airport), and 3816.

_The adaptation of the generation models have a small variation in GTAModel where for medium and heavy freight there is no factoring reduction
in generation and replacement from the CVS survey data.  This simplifies the forecasting of the model._

### Trip Distribution

For light, medium and heavy trucks, doubly constrained gravity model was applied with initial β parameters obtained from the previous
GTHA freight model. The three OD matrices account for all trips by light trucks and non-CVS trips by medium and heavy trucks.
Next, CVS OD matrices for medium and heavy trucks (step 4) were added to corresponding OD matrices for medium and heavy
trucks obtained from gravity model.

### Trip Assignment

The model implementation for GTAModelV4.1.0 then differs from the original model as the assignment is integrated into a multiclass auto assignment
along with the passenger demand coming from TASHA.  For a detailed explanation please review GTAModelV4.1's [Auto Assignment Documentation](auto_assignment.md#gtamodel-v41).


