# Auto Ownership And Driver's License

`Available in GTAModel  V4.1`

## Background

Without having a driver license, people are not allowed to drive a vehicle.
 Thus, an individual decision to have a driver license directly influence his/her
 decision making in terms of both activity scheduling and mode choice.
 The number of vehicles in a household also has effects on the availability of cars
 for pursuing a trip and therefore influence the activity scheduling. Hence,
 it is important to model individuals’ decision to have a driver license and
 households’ decision to own one or several vehicles. These decisions are
 interconnected and usually made together; although one is at the individual
 level and the other is at the household level. We start with independent models
 for driver license and number of vehicles in the household (presented in this technical memo). The hope is that we later replace these models with a joint econometric model or neural network model of driver license and vehicle ownership.

## Driver License

For modelling individual’s driver license, a binary logit model is used.
A sample of 10,269 individuals who are older than 16 years old from the households
who reported their income and live in GTHA is selected for model estimation.
Variables included are age, gender, occupation type, part time status, household
income, home location population density, perceived transit travel time to work and
school, distance (shortest path) to work and school. The summation of travel time
(distance) to work and school locations are used for individuals who are both worker
and student.

_Table 1 Driver License Binary Logit Model Estimation Results_

|    Variables                                            |    Coef.       |    Std err    |    t-stat    |
|---------------------------------------------------------|----------------|---------------|--------------|
|    Constant                                             |    -0.7586     |    0.188      |    -4.03     |
|    Female                                               |    -0.7775     |    0.064      |    -12.10    |
|    Age                                                  |                |               |              |
|    Age 16-17                                            |    -0.3646     |    0.209      |    -1.75     |
|    Age   18-20                                          |    0.9070      |    0.213      |    4.25      |
|    Age 21-25                                            |    1.3652      |    0.194      |    7.05      |
|    Age 26-35                                            |    1.7433      |    0.180      |    9.69      |
|    Age 36-45                                            |    2.1094      |    0.183      |    11.56     |
|    Age 46-55                                            |    2.0226      |    0.177      |    11.42     |
|    Age 56-65                                            |    1.9770      |    0.169      |    11.71     |
|    Age 66-75                                            |    1.9461      |    0.165      |    11.83     |
|    Age 76-85                                            |    1.2269      |    0.168      |    7.28      |
|    Age 86+ (Base)                                       |                |               |              |
|    Occupation=g                                         |    0.5737      |    0.142      |    4.05      |
|    Occupation=m                                         |    0.7314      |    0.173      |    4.24      |
|    Occupation=p                                         |    1.2349      |    0.120      |    10.25     |
|    Occupation=s                                         |    0.4507      |    0.117      |    3.87      |
|    Part time employment status                          |    -0.3366     |    0.119      |    -2.84     |
|    Income                                               |                |               |              |
|    $0 to $14,999 (base)                                 |                |               |              |
|    $15,000 to $39,999                                   |    0.4493      |    0.128      |    3.52      |
|    $40,000 to $59,999                                   |    0.7008      |    0.130      |    5.40      |
|    $60,000 to $99,999                                   |    0.8689      |    0.127      |    6.83      |
|    $100,000 to $124,999                                 |    1.0242      |    0.146      |    7.00      |
|    $125,000 and above                                   |    1.3385      |    0.140      |    9.56      |
|    Population density of home location (person/sq.m)    |    -29.0526    |    3.882      |    -7.48     |
|    Transit perceived travel time to work/school         |    0.0018      |    0.001      |    2.71      |
|    Distance to work/school (km)                         |    0.0200      |    0.006      |    3.14      |
|    Log-likelihood at constant                           |    -4629       |               |              |
|    Final Log-likelihood                                 |    -3684       |               |              |
|    Pseudo R2 (McFadden)                                 |    0.20        |               |              |


## Vehicle Ownership

A generalized ordered logit (GOL) model is used for modelling vehicle ownership on a sample of 28,937 households
of TTS 2016 households in GTHA with income reported. Given the spatial variation in vehicle ownership in
the region and inability of capturing such variation with typical independent variables (and since ignoring this 
variation would result in under predicting of number of vehicles for household in 905 region and over predicting of
number of vehicles for household in Toronto), a GOL model (instead of a simple ordered logit model) is used by
parameterizing the thresholds to include spatial dummy variables. This way the estimated threshold parameters vary
by the location. After a descriptive analysis, we determined four cluster to allow thresholds to vary by including a
dummy variables for each in the model. The clusters are: inner of Toronto, suburbs of Toronto, district in 905 region,
and Hamilton. 

Vehicle ownership categories considered are: 0,1,2,3,4+ vehicles in the household. 
A sample of 68251 households are hold out for validation. Variables considered are household
charcteristics such as number of adults in the household, number of fulltime workers,
number of driver licenses and household income, as well as home location attributes
such as population and job density at zonal level, and a set of accessibility variables
based on home to work travel times. Home to work variables are at zonal level. Distance 
to work variable is the average distance (shortest path) to work of workers residing in a zone. 
Similarly, the travel times are average travel times by mode to work for workers in a zone. These typical
zonal attributes outperformed the household level LoS attributes both in terms of fit and in prediction. 
These should also be more stable in the model, as they are at the same level of aggregation as PORPOW.

In the traditional ordered response model, the discrete ordered variable
number of vehicles in the household) \\( \left(y_{i}\right) \\) is assumed to be associated with an underlying continuous latent variable
\\( \left(y_{i}^{*}\right) \\). This latent variable is typically specified as the following linear function:  


$$
\left(y_{i}^{*}\right) = X_{i}\beta + \epsilon_{i} \text{ for } i = 1,2,... ... ...,N

$$

Where,


$$
\begin{split}
i & \left(i = 1,2,... ... ...,N\right) \text{ represents the households} \\\\
X_i & \text{ is a vector of exogenous variables (excluding a constant)} \\\\
\beta & \text{ is a vector of unknown parameters to be estimated } \\\\
\epsilon & \text{ is the random disturbance term assumed to be standard logistic }
\end{split}

$$

Let \\( j \text{ } \left(j=1,2,.........,J\right) \\) denote the vehicle ownership levels (in our case, 0,1,2,3,4+) and
\\( \tau_{j} \\) represents the thresholds associated with these ownership levels. These unknown \\( \tau_{j} \\)
represents the thresholds associated with these ownership levels. These unknown \\( \tau_{j} \\) are assumed to partition the
propensity into \\( J - 1 \\) intervals. We also consider \\( \tau_{j} \\) of a constant and a spatial
dummy variable based on the planning district that the household belongs. The unobservable latent variable \\( y_{i}^{*} \\) is related to the observable ordinal
variable \\( y_{i} \\) by the \\( \tau_{j} \\) with a response mechanism of the following form:


$$
y_i = j\text{, if }\tau_{j - 1} < y_{i}^* < \tau_j \text{, for } j = 1,2,... ... ...,J

$$

In order to ensure the well-defined intervals and natural ordering of observed vehicle ownership,
the thresholds are assumed to be ascending in order,
such that \\( \tau_0<\tau_1< ……… \tau_J \text{ where } \tau_0=-\infty \text{ and } \tau_J=+\infty \\).
Given these relationships across the different parameters, the resulting probability expressions for household i and alternative j
for the OL take the following form:



$$
\pi_{ij} = Pr\left(y_i = j|X_i\right) = \Lambda\left(\tau_j-X_i\beta\right) - \Lambda\left(\tau_{j - 1} - X_i\beta \right)

$$

where \\( \Lambda(.) \\) represents the standard logistic cumulative distribution function.

In order to finalize the model specification, a systematic process of removing statistically insignificant variables,
guided by intuition and parsimony considerations. The model estimation results are presented in Table 2.

_Table 2 Vehicle Ownership Generalized Ordered Logit Model Estimation Results_

| Variables                                                                                | Coef.   | Std. Err. | z      |
|------------------------------------------------------------------------------------------|---------|-----------|--------|
| Number of adults in HH                                                                   | 0.1444  | 0.022     | 6.54   |
| Number of FT workers in HH                                                               | 0.1984  | 0.019     | 10.66  |
| Number of driver licenses in   HH                                                        |         |           |        |
| Zero (Base)                                                                              |         |           |        |
| One                                                                                      | 5.1644  | 0.15      | 34.4   |
| Two                                                                                      | 7.2856  | 0.154     | 47.18  |
| Three and more                                                                           | 8.9816  | 0.164     | 54.67  |
| HH Income                                                                                |         |           |        |
| $0 to $14,999 (Base)                                                                     |         |           |        |
| $15,000 to $39,999                                                                       | 0.5424  | 0.082     | 6.6    |
| $40,000 to $59,999                                                                       | 0.8795  | 0.082     | 10.69  |
| $60,000 to $99,999                                                                       | 1.231   | 0.081     | 15.14  |
| $100,000 to $124,999                                                                     | 1.5664  | 0.086     | 18.15  |
| $125,000 and above                                                                       | 1.9862  | 0.084     | 23.51  |
| Home location population   density (person/sq.m)                                         | -38.22  | 2.235     | -17.1  |
| Home location job density   (jobs/sq.m)                                                  | -12.51  | 1.486     | -8.42  |
| Home-Work variables                                                                      |         |           |        |
| Average distance to work for   workers in the zone of home location (km)                 | 0.0151  | 0.004     | 3.76   |
| Average transit perceived   travel time to work for workers in the zone of home location | 0.0045  | 0         | 12.45  |
| Spatial Dummies                                                                          |         |           |        |
| Sub-urban Toronto (PD 5, 7-16)                                                           | 1.2104  | 0.067     | 18     |
| 905 Region (PD 17-45)                                                                    | 2.1488  | 0.079     | 27.06  |
| Hamilton (PD 46)                                                                         | 1.131   | 0.136     | 8.32   |
| Thresholds                                                                               |         |           |        |
| Threshold1                                                                               | 6.2727  | 0.177     | 35.47  |
| Sub-urban Toronto (PD 5, 7-16)                                                           | -       | -         | -      |
| 905 Region (PD 17-45)                                                                    | -       | -         | -      |
| Hamilton (PD 46)                                                                         | -       | -         | -      |
| Threshold2                                                                               | 10.1737 | 0.18      | 56.52  |
| Sub-urban Toronto (PD 5, 7-16)                                                           | 0.7054  | 0.08      | -8.78  |
| 905 Region (PD 17-45)                                                                    | 0.9968  | 0.084     | -11.81 |
| Hamilton (PD 46)                                                                         | 0.2133  | 0.16      | -1.34  |
| Threshold3                                                                               | 12.8775 | 0.196     | 65.58  |
| Sub-urban Toronto (PD 5, 7-16)                                                           | 0.9677  | 0.121     | -7.97  |
| 905 Region (PD 17-45)                                                                    | 1.6857  | 0.116     | -14.48 |
| Hamilton (PD 46)                                                                         | 0.6901  | 0.22      | -3.13  |
| Threshold4                                                                               | 14.7459 | 0.261     | 56.47  |
| Sub-urban Toronto (PD 5, 7-16)                                                           | 0.9921  | 0.232     | -4.28  |
| 905 Region (PD 17-45)                                                                    | 1.7269  | 0.211     | -8.18  |
| Hamilton (PD 46)                                                                         | 0.7934  | 0.4       | -1.98  |
| Statistics                                                                               |         |           |        |
| N                                                                                        | 28937   |           |        |
| LL                                                                                       | -23069  |           |        |
| Pseudo R2 (McFadden)                                                                     | 0.382   |           |        |

The model is used to predict on both estimation sample and validation sample. As expected, the aggregated results are promising.

_Table 3 Vehicle Ownership Model Validation Results_

|                        | Estimation Sample (n=28937) | Validation Sample (n=68251) |           |          |
|------------------------|-----------------------------|-----------------------------|-----------|----------|
| Number of Veh. in hhld | Predicted                   | Observed                    | Predicted | Observed |
| 0                      | 14.3                        | 14.3                        | 14.3      | 14.1     |
| 1                      | 41.9                        | 42.2                        | 42.1      | 42.3     |
| 2                      | 34                          | 33.7                        | 34        | 34       |
| 3                      | 7.6                         | 7.4                         | 7.5       | 7.3      |
| 4+                     | 2.3                         | 2.3                         | 2.2       | 2.3      |

To highlight the improvement in terms of spatial distribution of errors in prediction, the predictions are explored by planning district.

_Table 4 Prediction by Planning Districts on Estimation Sample_

|    PD    |    Absolute Error in Shares based on the Model with fixed thresholds     |    Absolute Error in Shares based on the Model with thresholds varying by   region    |             |             |             |             |             |             |             |             |
|----------|--------------------------------------------------------------------------|---------------------------------------------------------------------------------------|-------------|-------------|-------------|-------------|-------------|-------------|-------------|-------------|
|          |    0                                                                     |    1                                                                                  |    2        |    3        |    4+       |    0        |    1        |    2        |    3        |    4+       |
|    1     |    0.12                                                                  |    -0.05                                                                              |    -0.07    |    -0.01    |    0.00     |    0.03     |    -0.01    |    -0.02    |    0.00     |    0.00     |
|    2     |    0.11                                                                  |    0.05                                                                               |    -0.14    |    -0.02    |    0.00     |    0.03     |    0.03     |    -0.05    |    0.00     |    0.00     |
|    3     |    0.05                                                                  |    0.03                                                                               |    -0.06    |    -0.02    |    0.00     |    -0.05    |    0.02     |    0.02     |    0.00     |    0.00     |
|    4     |    0.06                                                                  |    0.01                                                                               |    -0.04    |    -0.01    |    -0.01    |    -0.04    |    -0.01    |    0.05     |    0.00     |    0.00     |
|    5     |    0.01                                                                  |    0.06                                                                               |    -0.06    |    -0.01    |    0.00     |    0.01     |    -0.01    |    -0.01    |    0.01     |    0.01     |
|    6     |    0.10                                                                  |    0.06                                                                               |    -0.13    |    -0.02    |    0.00     |    0.00     |    0.03     |    -0.03    |    -0.01    |    0.00     |
|    7     |    -0.01                                                                 |    0.06                                                                               |    -0.03    |    -0.01    |    0.00     |    -0.01    |    0.00     |    0.01     |    -0.01    |    0.00     |
|    8     |    -0.01                                                                 |    0.04                                                                               |    -0.02    |    0.00     |    0.00     |    0.00     |    -0.03    |    0.02     |    0.01     |    0.00     |
|    9     |    -0.03                                                                 |    0.07                                                                               |    -0.03    |    0.00     |    -0.01    |    -0.02    |    0.01     |    0.00     |    0.01     |    0.00     |
|    10    |    0.03                                                                  |    0.06                                                                               |    -0.05    |    -0.03    |    -0.01    |    0.03     |    0.01     |    -0.01    |    -0.02    |    0.00     |
|    11    |    -0.09                                                                 |    0.14                                                                               |    -0.01    |    -0.03    |    -0.01    |    -0.02    |    0.04     |    0.00     |    -0.02    |    0.00     |
|    12    |    0.00                                                                  |    0.07                                                                               |    -0.05    |    -0.02    |    0.00     |    0.01     |    0.01     |    -0.01    |    -0.01    |    0.00     |
|    13    |    0.02                                                                  |    0.06                                                                               |    -0.06    |    -0.01    |    -0.01    |    0.02     |    0.00     |    -0.02    |    0.00     |    0.00     |
|    14    |    0.00                                                                  |    0.08                                                                               |    -0.08    |    -0.01    |    0.00     |    0.00     |    0.01     |    -0.03    |    0.01     |    0.01     |
|    15    |    -0.01                                                                 |    0.03                                                                               |    -0.02    |    0.00     |    0.00     |    0.00     |    -0.03    |    0.01     |    0.01     |    0.01     |
|    16    |    -0.02                                                                 |    0.08                                                                               |    -0.03    |    -0.02    |    -0.01    |    -0.01    |    0.02     |    0.01     |    -0.01    |    -0.01    |
|    17    |    -0.03                                                                 |    -0.10                                                                              |    -0.01    |    0.07     |    0.08     |    -0.01    |    0.04     |    -0.05    |    0.00     |    0.02     |
|    18    |    -0.03                                                                 |    -0.10                                                                              |    0.06     |    -0.02    |    0.08     |    0.00     |    -0.01    |    0.05     |    -0.07    |    0.04     |
|    19    |    -0.02                                                                 |    -0.12                                                                              |    0.00     |    0.08     |    0.07     |    0.00     |    -0.01    |    -0.04    |    0.01     |    0.03     |
|    20    |    -0.02                                                                 |    -0.03                                                                              |    0.02     |    0.02     |    0.02     |    0.00     |    0.00     |    -0.03    |    0.01     |    0.01     |
|    21    |    -0.03                                                                 |    -0.02                                                                              |    0.04     |    0.01     |    0.00     |    -0.01    |    0.04     |    -0.01    |    -0.01    |    -0.01    |
|    22    |    -0.03                                                                 |    -0.04                                                                              |    0.04     |    0.03     |    -0.01    |    0.00     |    0.00     |    0.00     |    0.02     |    -0.01    |
|    23    |    -0.03                                                                 |    -0.01                                                                              |    0.03     |    0.02     |    -0.01    |    0.01     |    0.00     |    -0.01    |    0.01     |    -0.01    |
|    24    |    -0.02                                                                 |    -0.07                                                                              |    0.00     |    0.06     |    0.02     |    0.01     |    -0.01    |    -0.04    |    0.04     |    0.01     |
|    25    |    -0.04                                                                 |    -0.11                                                                              |    0.05     |    0.08     |    0.02     |    -0.01    |    -0.01    |    -0.03    |    0.04     |    0.01     |
|    26    |    -0.03                                                                 |    -0.04                                                                              |    -0.01    |    0.03     |    0.05     |    -0.01    |    0.01     |    -0.05    |    0.01     |    0.04     |
|    27    |    -0.03                                                                 |    -0.05                                                                              |    0.04     |    0.03     |    0.01     |    0.00     |    -0.02    |    -0.01    |    0.02     |    0.01     |
|    28    |    -0.02                                                                 |    -0.04                                                                              |    0.05     |    0.00     |    0.01     |    0.00     |    0.01     |    0.00     |    -0.01    |    0.01     |
|    29    |    -0.03                                                                 |    0.00                                                                               |    0.04     |    0.01     |    -0.01    |    0.00     |    0.01     |    0.00     |    0.00     |    -0.01    |
|    30    |    -0.02                                                                 |    -0.09                                                                              |    0.11     |    0.01     |    -0.01    |    0.01     |    -0.01    |    0.07     |    -0.03    |    -0.03    |
|    31    |    -0.03                                                                 |    -0.02                                                                              |    0.07     |    -0.01    |    0.00     |    0.00     |    0.00     |    0.02     |    -0.02    |    0.00     |
|    32    |    -0.03                                                                 |    -0.12                                                                              |    0.06     |    0.02     |    0.07     |    -0.02    |    -0.05    |    0.04     |    -0.02    |    0.05     |
|    33    |    -0.02                                                                 |    -0.04                                                                              |    0.08     |    -0.02    |    -0.01    |    0.00     |    -0.01    |    0.04     |    -0.02    |    0.00     |
|    34    |    -0.02                                                                 |    -0.09                                                                              |    -0.01    |    0.08     |    0.04     |    -0.01    |    0.02     |    -0.01    |    0.01     |    -0.01    |
|    35    |    -0.02                                                                 |    -0.02                                                                              |    0.04     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |
|    36    |    -0.05                                                                 |    0.02                                                                               |    0.03     |    0.00     |    0.00     |    0.01     |    0.01     |    -0.02    |    0.00     |    0.00     |
|    37    |    -0.02                                                                 |    -0.08                                                                              |    0.06     |    0.02     |    0.02     |    0.01     |    -0.03    |    0.01     |    0.00     |    0.01     |
|    38    |    -0.03                                                                 |    -0.09                                                                              |    0.13     |    0.00     |    0.00     |    -0.01    |    -0.02    |    0.07     |    -0.03    |    -0.01    |
|    39    |    -0.03                                                                 |    -0.02                                                                              |    0.03     |    0.01     |    0.01     |    0.00     |    0.00     |    -0.01    |    0.00     |    0.01     |
|    40    |    -0.03                                                                 |    -0.03                                                                              |    0.05     |    0.01     |    0.01     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |
|    41    |    -0.03                                                                 |    -0.06                                                                              |    -0.02    |    0.06     |    0.05     |    -0.01    |    0.04     |    -0.03    |    -0.01    |    0.00     |
|    42    |    -0.04                                                                 |    0.02                                                                               |    0.03     |    -0.01    |    0.00     |    -0.01    |    0.02     |    -0.01    |    -0.01    |    0.00     |
|    43    |    -0.03                                                                 |    -0.07                                                                              |    0.05     |    0.02     |    0.02     |    -0.01    |    -0.03    |    0.00     |    0.01     |    0.02     |
|    44    |    -0.04                                                                 |    0.00                                                                               |    0.05     |    0.01     |    -0.01    |    -0.01    |    0.09     |    -0.03    |    -0.02    |    -0.02    |
|    45    |    -0.04                                                                 |    -0.11                                                                              |    0.09     |    0.01     |    0.05     |    0.00     |    -0.06    |    0.05     |    -0.01    |    0.03     |
|    46    |    0.00                                                                  |    0.00                                                                               |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |

_Table 5 Prediction by Planning Districts on Validation Sample_


|    PD    |    Absolute Error in Shares based on the Model with fixed thresholds     |    Absolute Error in Shares based on the Model with thresholds varying by   region    |             |             |             |             |             |             |             |             |
|----------|--------------------------------------------------------------------------|---------------------------------------------------------------------------------------|-------------|-------------|-------------|-------------|-------------|-------------|-------------|-------------|
|          |    0                                                                     |    1                                                                                  |    2        |    3        |    4+       |    0        |    1        |    2        |    3        |    4+       |
|    1     |    0.06                                                                  |    -0.04                                                                              |    -0.03    |    0.00     |    0.00     |    0.01     |    0.00     |    -0.01    |    0.00     |    0.00     |
|    2     |    0.12                                                                  |    -0.03                                                                              |    -0.09    |    0.00     |    0.00     |    0.04     |    0.00     |    -0.04    |    0.00     |    0.00     |
|    3     |    0.04                                                                  |    -0.01                                                                              |    -0.03    |    0.00     |    0.01     |    -0.04    |    0.01     |    0.02     |    0.00     |    0.00     |
|    4     |    0.03                                                                  |    -0.04                                                                              |    0.00     |    0.01     |    0.00     |    -0.04    |    -0.01    |    0.04     |    0.00     |    0.00     |
|    5     |    -0.02                                                                 |    0.03                                                                               |    -0.03    |    0.01     |    0.00     |    -0.01    |    0.01     |    -0.01    |    0.00     |    0.00     |
|    6     |    0.06                                                                  |    0.03                                                                               |    -0.09    |    0.00     |    0.00     |    -0.01    |    0.05     |    -0.03    |    -0.01    |    0.00     |
|    7     |    -0.02                                                                 |    0.05                                                                               |    -0.03    |    0.00     |    0.00     |    -0.01    |    0.02     |    0.00     |    0.00     |    0.00     |
|    8     |    -0.02                                                                 |    0.01                                                                               |    0.00     |    0.01     |    0.00     |    -0.01    |    -0.02    |    0.03     |    0.00     |    0.00     |
|    9     |    -0.02                                                                 |    0.03                                                                               |    -0.03    |    0.01     |    0.01     |    -0.01    |    0.00     |    0.00     |    0.01     |    0.00     |
|    10    |    -0.01                                                                 |    0.01                                                                               |    -0.01    |    0.01     |    0.00     |    0.01     |    -0.02    |    0.01     |    0.01     |    0.00     |
|    11    |    -0.06                                                                 |    0.06                                                                               |    -0.01    |    0.00     |    0.00     |    -0.02    |    0.02     |    0.00     |    0.00     |    0.00     |
|    12    |    0.01                                                                  |    0.04                                                                               |    -0.04    |    -0.01    |    -0.01    |    0.02     |    0.01     |    0.00     |    -0.01    |    -0.01    |
|    13    |    0.01                                                                  |    0.04                                                                               |    -0.04    |    0.00     |    0.00     |    0.02     |    0.00     |    -0.02    |    -0.01    |    0.00     |
|    14    |    0.00                                                                  |    0.03                                                                               |    -0.04    |    0.01     |    0.01     |    0.01     |    0.00     |    -0.02    |    0.01     |    0.01     |
|    15    |    0.00                                                                  |    0.03                                                                               |    -0.02    |    -0.01    |    0.00     |    -0.01    |    -0.02    |    0.03     |    0.00     |    0.00     |
|    16    |    -0.02                                                                 |    0.05                                                                               |    -0.03    |    0.00     |    -0.01    |    -0.01    |    0.01     |    0.01     |    0.00     |    -0.01    |
|    17    |    0.00                                                                  |    0.14                                                                               |    -0.07    |    -0.05    |    -0.02    |    0.00     |    0.08     |    -0.08    |    -0.01    |    0.01     |
|    18    |    0.00                                                                  |    0.04                                                                               |    0.03     |    -0.05    |    -0.02    |    0.00     |    0.02     |    0.00     |    -0.03    |    0.01     |
|    19    |    -0.02                                                                 |    0.02                                                                               |    -0.02    |    0.00     |    0.01     |    -0.01    |    0.00     |    -0.05    |    0.02     |    0.04     |
|    20    |    -0.01                                                                 |    -0.01                                                                              |    0.02     |    0.00     |    0.00     |    0.00     |    -0.02    |    0.00     |    0.01     |    0.01     |
|    21    |    0.00                                                                  |    0.01                                                                               |    0.02     |    -0.01    |    -0.02    |    0.00     |    0.00     |    0.00     |    0.01     |    -0.01    |
|    22    |    -0.01                                                                 |    0.02                                                                               |    0.01     |    -0.02    |    0.00     |    0.00     |    0.01     |    0.00     |    -0.01    |    0.00     |
|    23    |    -0.01                                                                 |    0.00                                                                               |    -0.01    |    0.01     |    0.01     |    0.01     |    -0.01    |    -0.02    |    0.01     |    0.01     |
|    24    |    -0.01                                                                 |    0.01                                                                               |    0.02     |    -0.01    |    0.00     |    -0.01    |    -0.02    |    0.00     |    0.02     |    0.01     |
|    25    |    0.01                                                                  |    0.05                                                                               |    0.03     |    -0.06    |    -0.03    |    0.01     |    -0.01    |    0.01     |    -0.01    |    0.01     |
|    26    |    -0.01                                                                 |    0.00                                                                               |    -0.02    |    0.00     |    0.04     |    -0.01    |    -0.02    |    -0.04    |    0.02     |    0.05     |
|    27    |    -0.01                                                                 |    -0.03                                                                              |    0.03     |    -0.01    |    0.02     |    0.01     |    -0.04    |    0.01     |    0.00     |    0.02     |
|    28    |    -0.02                                                                 |    -0.01                                                                              |    0.05     |    -0.01    |    -0.01    |    0.00     |    -0.01    |    0.02     |    -0.01    |    0.00     |
|    29    |    -0.02                                                                 |    -0.02                                                                              |    0.05     |    -0.01    |    0.00     |    0.00     |    0.00     |    0.01     |    -0.01    |    0.00     |
|    30    |    -0.01                                                                 |    0.03                                                                               |    0.00     |    -0.01    |    -0.01    |    0.00     |    0.02     |    -0.02    |    0.00     |    0.00     |
|    31    |    -0.02                                                                 |    -0.02                                                                              |    0.04     |    0.00     |    0.00     |    0.00     |    0.01     |    0.01     |    -0.01    |    -0.01    |
|    32    |    -0.01                                                                 |    -0.04                                                                              |    -0.05    |    0.07     |    0.03     |    0.00     |    -0.03    |    -0.08    |    0.07     |    0.04     |
|    33    |    -0.02                                                                 |    -0.06                                                                              |    0.07     |    0.00     |    0.02     |    0.00     |    -0.03    |    0.03     |    -0.01    |    0.01     |
|    34    |    0.00                                                                  |    0.02                                                                               |    0.05     |    -0.05    |    -0.02    |    0.00     |    0.01     |    0.02     |    -0.04    |    -0.01    |
|    35    |    -0.02                                                                 |    -0.02                                                                              |    0.03     |    0.01     |    0.01     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |
|    36    |    -0.04                                                                 |    0.01                                                                               |    0.02     |    0.01     |    0.00     |    0.00     |    0.01     |    -0.01    |    0.00     |    0.00     |
|    37    |    -0.02                                                                 |    -0.05                                                                              |    0.03     |    0.02     |    0.02     |    0.00     |    -0.04    |    0.01     |    0.02     |    0.02     |
|    38    |    -0.01                                                                 |    -0.03                                                                              |    0.09     |    -0.05    |    0.00     |    -0.01    |    -0.04    |    0.07     |    -0.04    |    0.01     |
|    39    |    -0.01                                                                 |    0.01                                                                               |    0.03     |    -0.02    |    -0.01    |    0.00     |    0.00     |    0.01     |    -0.01    |    -0.01    |
|    40    |    -0.02                                                                 |    0.01                                                                               |    0.02     |    -0.01    |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |    0.00     |
|    41    |    -0.01                                                                 |    0.01                                                                               |    0.03     |    -0.02    |    -0.02    |    0.00     |    0.01     |    0.01     |    -0.01    |    -0.01    |
|    42    |    -0.04                                                                 |    0.01                                                                               |    0.02     |    0.02     |    -0.01    |    -0.01    |    0.03     |    -0.02    |    0.01     |    -0.01    |
|    43    |    -0.01                                                                 |    -0.01                                                                              |    -0.01    |    0.02     |    0.01     |    0.00     |    -0.01    |    -0.03    |    0.03     |    0.01     |
|    44    |    -0.01                                                                 |    0.06                                                                               |    -0.03    |    -0.04    |    0.01     |    0.00     |    0.06     |    -0.06    |    -0.02    |    0.02     |
|    45    |    -0.02                                                                 |    0.03                                                                               |    0.02     |    0.00     |    -0.02    |    -0.01    |    0.02     |    -0.01    |    0.01     |    -0.01    |
|    46    |    -0.01                                                                 |    0.01                                                                               |    -0.02    |    0.01     |    0.01     |    -0.01    |    0.03     |    -0.03    |    0.00     |    0.01     |