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

An ordered logit model is used for modelling vehicle ownership on a sample of 28,937
households of TTS 2016 households in GTHA with income reported. Vehicle ownership
categories considered are: 0,1,2,3,4+ vehicles in the household.  A sample of 68251
households are hold out for validation. Variables considered are household
characteristics such as number of adults in the household, number of fulltime workers,
number of driver licenses and household income, as well as home location attributes
such as population and job density at zonal level, and a set of accessibility variables
based on home to work travel times. Home to work variables are at zonal level. Distance
to work variable is the average distance (shortest path) to work of workers residing in a
zone. Similarly, the travel times are average travel times by mode to work for workers in
a zone. These typical zonal attributes outperformed the household level LoS attributes both
in terms of fit and in prediction. These should also be more stable in the model, as they are
at the same level of aggregation as PORPOW.

In the traditional ordered response model, the discrete ordered variable
number of vehicles in the household) \\( \left(y_{i}\right) \\) is assumed to be associated with an underlying continuous latent variable
\\( \left(y_{i}^{*}\right) \\). This latent variable is typically specified as the following linear function:  

\begin{equation}
\left(y_{i}^{*}\right) = X_{i}\beta + \epsilon_{i} \text{ for } i = 1,2,... ... ...,N
\end{equation}

Where,

\begin{equation}
\begin{split}
i & \left(i = 1,2,... ... ...,N\right) \text{ represents the households} \\\\
X_i & \text{ is a vector of exogenous variables (excluding a constant)} \\\\
\beta & \text{ is a vector of unknown parameters to be estimated } \\\\
\epsilon & \text{ is the random disturbance term assumed to be standard logistic }
\end{split}
\end{equation}

Let \\( j \text{ } \left(j=1,2,.........,J\right) \\) denote the vehicle ownership levels (in our case, 0,1,2,3,4+) and
\\( \tau_{j} \\) represents the thresholds associated with these ownership levels. These unknown \\( \tau_{j} \\)
represents the thresholds associated with these ownership levels. These unknown \\( \tau_{j} \\) are assumed to partition the
propensity into \\( J - 1 \\) intervals. The unobservable latent variable \\( y_{i}^{*} \\) is related to the observable ordinal
variable \\( y_{i} \\) by the \\( \tau_{j} \\) with a response mechanism of the following form:

\begin{equation}
y_i = j\text{, if }\tau_{j - 1} < y_{i}^* < \tau_j \text{, for } j = 1,2,... ... ...,J
\end{equation}

In order to ensure the well-defined intervals and natural ordering of observed vehicle ownership,
the thresholds are assumed to be ascending in order,
such that \\( \tau_0<\tau_1< ……… \tau_J \text{ where } \tau_0=-\infty \text{ and } \tau_J=+\infty \\).
Given these relationships across the different parameters, the resulting probability expressions for household i and alternative j
for the OL take the following form:


\begin{equation}
\pi_{ij} = Pr\left(y_i = j|X_i\right) = \Lambda\left(\tau_j-X_i\beta\right) - \Lambda\left(\tau_{j - 1} - X_i\beta \right)
\end{equation}

where \\( \Lambda(.) \\) represents the standard logistic cumulative distribution function.

In order to finalize the model specification, a systematic process of removing statistically insignificant variables,
guided by intuition and parsimony considerations. The model estimation results are presented in Table 2.

_Table 2 Vehicle Ownership Ordered Logit Model Estimation Results_

|    Variables                                                                                   |    Coef.      |    Std. Err.    |    z         |
|------------------------------------------------------------------------------------------------|---------------|-----------------|--------------|
|    Number of adults in HH                                                                      |    0.159      |    0.022        |    7.27      |
|    Number of kids (<16) in HH                                                                  |    0.016      |    0.016        |    1.04      |
|    Number of FT workers in HH                                                                  |    0.184      |    0.019        |    9.86      |
|    Number of driver licenses in HH                                                             |               |                 |              |
|    Zero (Base)                                                                                 |               |                 |              |
|    One                                                                                         |    4.820      |    0.145        |    33.20     |
|    Two                                                                                         |    6.957      |    0.150        |    46.46     |
|    Three and more                                                                              |    8.704      |    0.160        |    54.49     |
|    HH Income                                                                                   |               |                 |              |
|    $0 to $14,999 (Base)                                                                        |               |                 |              |
|    $15,000 to $39,999                                                                          |    0.470      |    0.077        |    6.09      |
|    $40,000 to $59,999                                                                          |    0.746      |    0.077        |    9.63      |
|    $60,000 to $99,999                                                                          |    1.060      |    0.076        |    13.86     |
|    $100,000 to $124,999                                                                        |    1.374      |    0.082        |    16.80     |
|    $125,000 and above                                                                          |    1.751      |    0.080        |    21.97     |
|    Home location population density   (person/sq.m)                                            |    -49.620    |    2.222        |    -22.33    |
|    Home location job density (jobs/sq.m)                                                       |    -19.492    |    1.561        |    -12.49    |
|    Home-Work variables                                                                         |               |                 |              |
|    Average distance to work for workers   in the zone of home location (km)                    |    0.104      |    0.009        |    11.65     |
|    Average transit perceived travel time   to work for workers in the zone of home location    |    0.005      |    0.000        |    12.65     |
|    Average auto travel time to work for   workers in the zone of home location                 |    -0.069     |    0.014        |    -5.07     |
|    Thresholds                                                                                  |               |                 |              |
|    Threshold1                                                                                  |    5.186      |    0.167        |              |
|    Threshold2                                                                                  |    9.395      |    0.174        |    -         |
|    Threshold3                                                                                  |    12.638     |    0.179        |    -         |
|    Threshold4                                                                                  |    14.570     |    0.184        |    -         |
|    Statistics                                                                                  |               |                 |              |
|    N                                                                                           |    28937      |                 |              |
|    LL                                                                                          |    -23613     |                 |              |
|    Pseudo R2 (McFadden)                                                                        |    0.367      |                 |              |

The model is used to predict on both estimation sample and validation sample. As expected, the aggregated results are promising.

_Table 3 Vehicle Ownership Model Validation Results_

|                              |    Estimation Sample (n=28937)    |    Validation Sample (n=68251)    |                 |                |
|------------------------------|-----------------------------------|-----------------------------------|-----------------|----------------|
|    Number of Veh. in hhld    |    Predicted                      |    Observed                       |    Predicted    |    Observed    |
|    0                         |    14.2                           |    14.3                           |    14.2         |    14.1        |
|    1                         |    42.1                           |    42.2                           |    42.2         |    42.3        |
|    2                         |    33.9                           |    33.7                           |    34.0         |    34.0        |
|    3                         |    7.5                            |    7.4                            |    7.4          |    7.3         |
|    4+                        |    2.3                            |    2.3                            |    2.2          |    2.3         |
