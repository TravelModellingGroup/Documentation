# Freight

```Available in GTAModel V4.1.0```

## Freight Model Methodology

### Introduction

Included in GTAModel V4.0.1 is a new freight model named CANUE, created by Tufayel Chowhury and Matthew Roorda.  This model was created using 

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

_The implementation of CANUE's generation models have a small variation in GTAModel where for medium and heavy freight there is no factoring in of
CVS survey data in order to allow the model to forecast._

### Trip Distribution

For light, medium and heavy trucks, doubly constrained gravity model was applied with initial β parameters obtained from the previous
GTHA freight model. The three OD matrices account for all trips by light trucks and non-CVS trips by medium and heavy trucks.
Next, CVS OD matrices for medium and heavy trucks (step 4) were added to corresponding OD matrices for medium and heavy
trucks obtained from gravity model.

### Trip Assignment

The model implementation for GTAModelV4.1.0 then differs from the CANUE model as the assignment is integrated into a multiclass auto assignment
along with the passenger demand coming from TASHA.


## Calibration of Auto Assignment with Freight

### Introduction

The purpose of this memorandum is to provide the documentation for the calibration of the 2016 Auto Assignment with the 2016 Demand
 obtained from TTS. This will serve to keep track of all issues that were faced as well as to provide a procedure for tracing the
 steps that were taken.

### Preparation of Input Data

All counts for all stations and screenlines for auto vehicles, light trucks, medium trucks, and heavy trucks were obtained from CCDRS in 15 minute windows. A python script was then run in order to determine the peak hour using a rolling hour window for each time period. This was done for both screenlines and stations. Stations were mapped to screenlines based on data obtained from DMG. The stations were also mapped to stations in the Emme Network.
The Emme Network was updated to 2016 and the collector and express were split on the highways that used a core collector system (401, 403, 404). The 407 Tolls were also updated with the 2016 values. 
For heavy truck restrictions, new restrictions were updated where possible, but improvements focused mainly on Toronto, Peel Region, and Hamilton. The network still resulted in connectivity issues for heavy vehicles, so certain centroids had to have special connectors that contained only the heavy truck mode and connected to the nearest road that allowed heavy trucks. The capacity on the highways and ramps were also bumped up by 10% in order to remove the restriction that was in place as a zero order approximation. (e.g. 1800 pcu/hour/lane to 2000 pcu/hour/lane).

### Peak Hour Factor Auto

When finding the Peak Hour Factors for the AM and PM time periods for auto, the link cost and perceptions were kept the same as
GTAModelV4.0.2 at $0.153/km $50/hour respectively. Various different Peak Period Factors were then tested out. For each Peak Period
Factor the following was done

\begin{equation}
\Delta_x = (\text{Emme Volume})_x - (\text{Observed Peak Hour Volume in Time Period})_x
\end{equation}

Where \\( x \) is a countpost.

\begin{equation}
\text{Average Error} = \dfrac{\sum_{x}{\Delta_x}}{\text{Count}(\Delta_x)}
\end{equation}

This was then plotted on a graph for both the AM and the PM, shown below in Figure 1 and Figure 2. The point at which the Average Error
is 0 is then taken to be the Peak Period Factor. 

![alt text](images/Freight/AvgErrorAM.png "Average Error AM")

#####_Figure 1 - Average Countpost Error based on PPF in the AM_

![alt text](images/Freight/AvgErrorPM.png "Average Error AM")

#####_Figure 2 - Average Countpost Error based on PPF in the PM_

The peak hour factor from this method was found to be 0.46 and 0.39 for the AM and PM respectively. When comparing these numbers to the 2016 TTS Trip starts,
 they seem to get AM correct but the PM appears to be too high. For comparison, the TTS peak hour factors which were 0.469 and 0.307. This is likely due to
 the known under-reporting of non-work, non-school trips in the 2016 TTS. In the AM time period, most of the trips are work based, so the demand provides good results when
 compared to the stations counts. However, in the PM due to the under-reporting of TTS, the Peak Hour Factor is forced to be higher in order to try to match the counts from the count posts.


### Peak Period Factor and Peak Hour Factor Freight

Since the freight model only provides freight demand data for a 12.5 hour period, it was necessary to break it in to time periods and peak hours for each time period in order to assign the freight into Emme.
Table 2 summarizes the calculations that were done.

#####_Table 2 - Freight factors_

| Adjustment Factors              |          |          |          |
|---------------------------------|----------|----------|----------|
| Vehicle   Class                 | Light    | Medium   | Heavy    |
| 12.5 Factor   (06:30-19:00)     | 0.78     | 0.78     | 0.66     |
| Off Peak   Factor (19:00-06:30) | 0.22     | 0.22     | 0.34     |
| Off Peak   Factor Per Half Hour | 0.009565 | 0.009565 | 0.014783 |
| 13 Hour   Factor (06:00-19:00)  | 0.789565 | 0.789565 | 0.674783 |
| AM Factor   (06:00-09:00)       | 0.185851 | 0.159685 | 0.135086 |
| MD Factor   (09:00-15:00)       | 0.355817 | 0.423595 | 0.364802 |
| PM Factor   (15:00-19:00)       | 0.247897 | 0.206285 | 0.174895 |
| EV Factor   (19:00-23:59)       | 0.095652 | 0.095652 | 0.147826 |
| AM PHF                          | 0.375068 | 0.419648 | 0.362608 |
| MD PHF                          | 0.177191 | 0.171329 | 0.176942 |
| PM PHF                          | 0.284042 | 0.325995 | 0.317223 |
| EV PHF                          | 0.2      | 0.2      | 0.2      |

The 12.5 Hour Factor is given by the Freight Model, the documentation for which is also provided. Uniform distribution is assumed to occur in the Off Peak Period from 19:00-06:30. This uniform distribution is
 then used to find a 13 hour factor that neatly fits into the AM, MD, and PM Time Periods of GTAModel. The time period factor for AM, MD, and PM was then found by multiplying the 13 hour factor by the sum
 of the number of vehicles in the time period divided by the total number of trucks in the 13 hours. The EV time period happens in the Off Peak time period so is assumed to have uniform distribution.
 The Off Peak Factor per Half Hour was multiplied by 10 (for the 5 hour EV period) in order to obtain EV Factor.

The Peak Hour Factor (PHF) for trucks was found using the count station data. A simple rolling hour window was used to find the maximum volume
 in an hour for each time period. This was then divided by the sum of the volume of the volume in the time period in order to obtain the Peak Hour Factor (PHF). 

### Toll Perception Estimation Framework

The model system was set up with the 2016 407 tolls but no link costs in order to estimate the Toll perception factor in $/hr for each vehicle class.
 A higher Toll Perception Factor means that the toll cost does not matter much, while a lower perception means that the cost matters a lot. The perception parameter was 
fixed to be the same for both AM and PM and was allowed to float between $15/hr and $100/hr. 


The fitness function was set up using the following formula

\\( \text{Fitness} = 0.49\text{AM} + 0.33\text{PM} \\)

Where

\begin{equation}
\text{Period} = \dfrac{\text{Sum}(Error Auto)}{\text{Count}(Error Auto)} + \dfrac{\text{Sum}(Error Light)}{\text{Count}(Error Light)} + \dfrac{\text{Sum}(Error Medium)}{\text{Count}(Error Medium)} + \dfrac{\text{Sum}(Error Heavy)}{\text{Count}(Error Heavy)}
\end{equation}

\begin{equation}
Error = (Observed - Modelled)^2
\end{equation}

The error was calculated for each station, summed up for each time period, and divided by the number of stations in that time period to obtain the fitness. A lower fitness value implies a better model,
 with 0 being a perfect model. The same method was done for the PM time period.

### Initial Results

The results from the run showed that the lowest fitness for this was found to be 1193. There was not too much variation between even the lowest perceptions and the highest perception.
There were some trends though, Auto perception generally found that being in the mid $30/hour range to minimize the error. Light trucks showed the highest Value of Time which would make
sense as they carry professional workers. Medium and Heavy vehicles show values that are a little higher than auto. 

### TTS Peak Hour Factors

During this process, there was discussions regarding a new PM model for GTAModelV4.1 which would help to fill in the missing TTS trips during that time period. This would lead to the Peak Period Factors as currently
calculated to be too peaky for the PM since new demand would be added and therefore the model would be able to hit counts without bumping up the Peak Hour Factors. This led to a new estimation run with the TTS
Peak Period Factors being used instead of the ones calculated in the method above for Auto vehicles only.

The results for this show similar results as compared to the first model. The distribution pattern of Auto, Medium and Heavy vehicles being in a similar range with only light commercial vehicles being higher
also held in this estimation.  The lowest fitness result was 1188, which is slightly lower than the first model, but the difference in value is very minor. In this model however, light commercial vehicles
seemed to have a preference for a significant increase in the VOT while the other classes showed smaller increases.

### Summary

In order to calibrate the new auto assignment with freight, input data was collected for auto vehicles and freight vehicles from transit counts. These counts were used to establish the Peak Period Factors as
well as the Peak Hour Factors for freight vehicles. Two different models were then evaluated, one with Peak Hour Auto Factors from count station and Emme data, and the other with TTS auto Peak Hour Factors. 

Both of these models shared similarities especially with regards to the pattern of perception values that show better results. Further analysis of the results show that while there are definitely **wrong**
peak period factors, there appears to be a valid range in the values that can be used. Overall there was not too much difference between the worst performing numbers and the highest performing numbers
in terms of its Root Mean Squared Error fitness values.  

After discussions, it was decided to use the Peak Period Factor from TTS due to the possible future inclusion of the PM model into GTAModelV4.1. The chosen set of parameters, while not the lowest fitness value,
was one that was felt to be the most reasonable set of values that performed well as well. The values were  $50.99/hour, $76.02/hour, $37.96/hour and $67.06/hour for Auto, Light, Medium, and Heavy vehicles respectively.
This corresponded to a fitness value of 1192.488.