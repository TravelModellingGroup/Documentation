# Airport Model

## GTAModel V4.2

### Overview

For GTAModelV4.2 a groundside access travel demand model for Pearson International Airport
is estimated using data provided by the Greater Toronto Airports Authority (GTAA). In addition 
the level-of-service variables provided by running the network assignments using demand from
the TTS2016 survey.  In comparison to the model previously used in GTAModel V4.0 and V4.1, this
airport model is broken up by business and non-business related travel for both residents
and non-residents.  We have also broken up the mode choice into five options:
Auto Drive, Passenger Out of Party, Public Transit, Rideshare,
and Other.  This was done to help achieve a better back-flow for passenger drop-offs when
building demand matrices.

### Model Design

The model is a nested logit model with an upper level consisting of a two layers.  The top layer
is for the distribution of trips to Pearson airport with the lower level of a mode choice model providing an accessibility term.

\begin{equation}
P_{i} = \frac{e^{\alpha X_{i}+\theta I_{i}}}{\sum_{i' \epsilon C}e^{\alpha X_{i'}+\theta{i'}}}
\end{equation}

\begin{equation}
P_{m|i} = \frac{e^{\beta Z_{m|i}}}{\sum_{m' \epsilon M_i}e^{\beta Z_{m'|i}}}
\end{equation}

\begin{equation}
I_{i} = log(\sum_{m' \epsilon M_i}e^{\beta Z_{m'|i}})
\end{equation}

Where:

\\( P_i \\) = Probability of person t in market segment k making a trip from origin zone i to TPIA (subscripts t and k suppressed for simplicity of notation)

\\( X_i \\) = Column vector of explanatory variables for origin zone i

\\( \alpha \\)  = Row vector of parameters.

\\( I_i \\)  = Inclusive value (logsum) for origin zone i

\\( \theta \\)  = Scale parameter \\( 0 \le \theta \le 1 \\)

\\( C \\)  = Choice set of feasible access zones

\\( P_{m|i} \\) = Probability of person t in market k using mode m to make a trip from origin zone i to TPIA.

\\( Z_{m|i} \\) = Column vector of explanatory variables for mode m given origin zone i

\\( \beta \\) = Row vector of parameters.

\\( M_{i} \\) = Choice set of feasible modes for trips from access zone i



### Estimated Parameters

The models are estimated using Biogeme V3.2.5. 199 randomly chosen alternatives zones were selected in addition to the observed zone.

#### Mode Choice

_Business Purpose, Residents (No. of observations = 4421; Adjusted Rho2 = 0.269)_

|     Name                    |     Value        |     Std err     |     t-test    |     p-value     |     Rob. Std err    |     Rob. t-test    |     Rob. p-value    |
|-----------------------------|------------------|-----------------|---------------|-----------------|---------------------|--------------------|---------------------|
|     ASC_Other               |     -0.722       |     0.138       |     -5.24     |     1.57e-07    |     0.239           |     -3.02          |     0.00254         |
|     ASC_Passenger           |     -0.184       |     0.0423      |     -4.34     |     1.45e-05    |     0.0423          |     -4.34          |     1.45e-05        |
|     ASC_PublicTransit       |     -0.67        |     0.159       |     -4.21     |     2.51e-05    |     0.205           |     -3.27          |     0.00109         |
|     ASC_Rideshare           |     0.546        |     0.0692      |     7.89      |     3.11e-15    |     0.0652          |     8.38           |     0               |
|     B_AutoUtil              |     -0.0455      |     0.00564     |     -8.08     |     6.66e-16    |     0.00564         |     -8.07          |     6.66e-16        |
|     B_AutoUtil_Rideshare    |     -0.057       |     0.00573     |     -9.95     |     0           |     0.00571         |     -9.98          |     0               |
|     B_Distance              |     -8.42e-05    |     7.58e-06    |     -11.1     |     0           |     1.42e-05        |     -5.91          |     3.45e-09        |
|     B_TransitUtil           |     -0.0101      |     0.00117     |     -8.65     |     0           |     0.00164         |     -6.17          |     6.68e-10        |

_Business Purpose, Visitors (No. of observations = 1265; Adjusted Rho2 = 0.370)_

|     Name                    |     Value       |     Std err     |     t-test    |     p-value     |     Rob. Std err    |     Rob. t-test    |     Rob. p-value    |
|-----------------------------|-----------------|-----------------|---------------|-----------------|---------------------|--------------------|---------------------|
|     ASC_Other               |     1.75        |     0.23        |     7.58      |     3.51e-14    |     0.254           |     6.88           |     6.1e-12         |
|     ASC_Passenger           |     -0.588      |     0.102       |     -5.77     |     7.83e-09    |     0.102           |     -5.77          |     7.83e-09        |
|     ASC_PublicTransit       |     0.319       |     0.279       |     1.14      |     0.252       |     0.264           |     1.21           |     0.226           |
|     ASC_Rideshare           |     1.21        |     0.141       |     8.61      |     0           |     0.145           |     8.36           |     0               |
|     B_AutoUtil              |     -0.0419     |     0.0101      |     -4.15     |     3.29e-05    |     0.00845         |     -4.95          |     7.26e-07        |
|     B_AutoUtil_Rideshare    |     -0.0605     |     0.00997     |     -6.07     |     1.29e-09    |     0.00833         |     -7.26          |     3.84e-13        |
|     B_Distance              |     -0.00019    |     1.63e-05    |     -11.7     |     0           |     1.7e-05         |     -11.2          |     0               |
|     B_TransitUtil           |     -0.0118     |     0.00207     |     -5.69     |     1.27e-08    |     0.0017          |     -6.92          |     4.45e-12        |

_Non-Business Purpose, Residents (No. of observations = 14382; Adjusted Rho2 = 0.364)_

|     Name                    |     Value        |     Std err     |     t-test    |     p-value     |     Rob. Std err    |     Rob. t-test    |     Rob. p-value    |
|-----------------------------|------------------|-----------------|---------------|-----------------|---------------------|--------------------|---------------------|
|     ASC_Other               |     -0.382       |     0.0769      |     -4.97     |     6.73e-07    |     0.125           |     -3.06          |     0.00219         |
|     ASC_Passenger           |     0.631        |     0.0233      |     27.1      |     0           |     0.0233          |     27.1           |     0               |
|     ASC_PublicTransit       |     0.513        |     0.0723      |     7.09      |     1.33e-12    |     0.0882          |     5.81           |     6.07e-09        |
|     ASC_Rideshare           |     0.59         |     0.0425      |     13.9      |     0           |     0.0417          |     14.2           |     0               |
|     B_AutoUtil              |     -0.0304      |     0.00288     |     -10.6     |     0           |     0.00316         |     -9.6           |     0               |
|     B_AutoUtil_Rideshare    |     -0.0423      |     0.00299     |     -14.2     |     0           |     0.00327         |     -12.9          |     0               |
|     B_Distance              |     -6.94e-05    |     3.88e-06    |     -17.9     |     0           |     6.62e-06        |     -10.5          |     0               |
|     B_TransitUtil           |     -0.00966     |     0.000577    |     -16.7     |     0           |     0.000829        |     -11.7          |     0               |

_Non-Business Purpose, Visitors (No. of observations = 2892; Adjusted Rho2 = 0.334)_

|     Name                    |     Value        |     Std err     |     t-test    |     p-value     |     Rob. Std err    |     Rob. t-test    |     Rob. p-value    |
|-----------------------------|------------------|-----------------|---------------|-----------------|---------------------|--------------------|---------------------|
|     ASC_Other               |     1.58         |     0.132       |     12        |     0           |     0.191           |     8.28           |     2.22e-16        |
|     ASC_Passenger           |     0.452        |     0.055       |     8.22      |     2.22e-16    |     0.055           |     8.22           |     2.22e-16        |
|     ASC_PublicTransit       |     0.886        |     0.169       |     5.25      |     1.52e-07    |     0.188           |     4.71           |     2.46e-06        |
|     ASC_Rideshare           |     1.26         |     0.0956      |     13.2      |     0           |     0.0938          |     13.4           |     0               |
|     B_AutoUtil              |     -0.01        |     0.0066      |     -1.52     |     0.128       |     0.00614         |     -1.63          |     0.103           |
|     B_AutoUtil_Rideshare    |     -0.0428      |     0.00678     |     -6.31     |     2.77e-10    |     0.0064          |     -6.68          |     2.35e-11        |
|     B_Distance              |     -0.000128    |     9.54e-06    |     -13.4     |     0           |     1.49e-05        |     -8.6           |     0               |
|     B_TransitUtil           |     -0.00889     |     0.00134     |     -6.65     |     2.92e-11    |     0.00157         |     -5.66          |     1.49e-08        |


#### Distribution

_Residents (No. of observations = 18750; Adjusted Rho2 = 0.0146)_

|     Name                         |     Value    |     Std err    |     t-test    |     p-value     |          |     Rob. Std err    |     Rob. t-test    |     Rob. p-value    |
|----------------------------------|--------------|----------------|---------------|-----------------|----------|---------------------|--------------------|---------------------|
|     ASC_Business_PD1             |     0.531    |     0.0324     |     16.4      |     0           |          |     0.0317          |     16.8           |     0               |
|     ASC_PD1                      |     1.15     |     0.0479     |     24.1      |     0           |          |     0.0461          |     25             |     0               |
|     B_Business_LogMEmployment    |     0.081    |     0.0113     |     7.14      |     9.65e-13    |          |     0.0114          |     7.1            |     1.25e-12        |
|     B_Business_LogPEmployment    |     0.147    |     0.00758    |     19.4      |     0           |          |     0.00743         |     19.8           |     0               |
|     B_Business_LogSEmployment    |     0.113    |     0.0105     |     10.7      |     0           |          |     0.0104          |     10.9           |     0               |
|     B_Business_Logsum            |     0.559    |     0.0171     |     32.7      |     0           |          |     0.0191          |     29.2           |     0               |
|     B_LogMEmployment             |     0.133    |     0.0209     |     6.39      |     1.62e-10    |          |     0.0205          |     6.5            |     7.78e-11        |
|     B_LogPEmployment             |     0.211    |     0.0133     |     15.8      |     0           |          |     0.0137          |     15.4           |     0               |
|     B_LogSEmployment             |     0.152    |     0.0198     |     7.65      |     2.04e-14    |          |     0.0201          |     7.55           |     4.2e-14         |
|     B_Logsum                     |     0.467    |     0.0237     |     19.7      |     0           |          |     0.0268          |     17.4           |     0               |

_Visitors (No. of observations = 4149; Adjusted Rho2 = 0.0561)_

|     Name                         |     Value    |     Std err    |     t-test    |     p-value     |     Rob. Std err    |     Rob. t-test    |     Rob. p-value    |     Rob. p-value    |
|----------------------------------|--------------|----------------|---------------|-----------------|---------------------|--------------------|---------------------|---------------------|
|     ASC_Business_PD1             |     1.12     |     0.0607     |     18.4      |     0           |     0.0622          |     18             |     0               |     0               |
|     ASC_PD1                      |     1.95     |     0.0771     |     25.2      |     0           |     0.0723          |     26.9           |     0               |     0               |
|     B_Business_LogMEmployment    |     0.32     |     0.0238     |     13.4      |     0           |     0.0237          |     13.5           |     0               |     1.25e-12        |
|     B_Business_LogPEmployment    |     0.31     |     0.0163     |     19.1      |     0           |     0.0171          |     18.2           |     0               |     0               |
|     B_Business_LogSEmployment    |     0.182    |     0.0254     |     7.17      |     7.66e-13    |     0.026           |     7.01           |     2.44e-12        |     0               |
|     B_Business_Logsum            |     0.346    |     0.152      |     2.28      |     0.0226      |     0.158           |     2.19           |     0.0284          |     0               |
|     B_LogMEmployment             |     0.326    |     0.0396     |     8.23      |     2.22e-16    |     0.0361          |     9.04           |     0               |     7.78e-11        |
|     B_LogPEmployment             |     0.337    |     0.0254     |     13.3      |     0           |     0.0251          |     13.4           |     0               |     0               |
|     B_LogSEmployment             |     0.25     |     0.042      |     5.95      |     2.6e-09     |     0.0429          |     5.83           |     5.49e-09        |     4.2e-14         |
|     B_Logsum                     |     0.699    |     0.0478     |     14.6      |     0           |     0.0583          |     12             |     0               |     0               |



## GTAModel V4.0

### Overview
GTAModel V4.0.1 includes an additional model to represent trips to and from Pearson airport.  The primary advancement of this model compared to GTAModel V2.5 is that it is able to predict transit trips to Pearson in addition to auto trips.  This allows for far better policy applications.  The model is a simple 4 step model with an exogenous generation rate for each time period.

In GTAModel’s Pre-Iteration module set, the GTAModelV4 airport module is added that will compute both mode choice for both auto and transit, and the distribution probability.  Currently AM travel time data is fed into the model to build these probabilities no matter the time of day we are generating for.  In the Post-Household module list we include a special generator for each EMME demand matrix that takes the mode probability resource, the distribution resource, and multiplies it against a given emplaning and deplaning parameters for the time period to build demand. 

### Estimation

Estimation of this model is not possible by TMG since the model was developed externally by James Vaughan and Eric Miller who have gifted both the code and model to the group for unlimited use.  The model was estimated using XTMF however the data used for estimating the model is no longer available.  If the data was to be gathered however you would need a trip diary of auto and transit trips to Pearson.  The mode choice would then be estimated first, then the utilities from that estimation would be saved into the distribution estimation model system to complete the process.

The estimation model systems both rely on the ‘TashaRuntime’ model system template being used as the client for the TMG Estimation Framework.  Inside of Post Iteration after the airport model has been run we also include the module ‘Tasha.Airport.V4AirportModel2014.AirportModeSplitFitnessFunction’ in order to calibrate mode choice.  For distribution we use ‘Tasha.Airport.V4AirportModel2014.AirportDistributionFitnessFunction’ to evaluate the fitness for each parameter set.  Both modules provide a maximum-log-likelihood fitness function.
