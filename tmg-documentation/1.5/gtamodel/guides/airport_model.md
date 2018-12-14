# Airport Model

## Overview
GTAModel V4.0.1 includes an additional model to represent trips to and from Pearson airport.  The primary advancement of this model compared to GTAModel V2.5 is that it is able to predict transit trips to Pearson in addition to auto trips.  This allows for far better policy applications.  The model is a simple 4 step model with an exogenous generation rate for each time period.

In GTAModel’s Pre-Iteration module set, the GTAModelV4 airport module is added that will compute both mode choice for both auto and transit, and the distribution probability.  Currently AM travel time data is fed into the model to build these probabilities no matter the time of day we are generating for.  In the Post-Household module list we include a special generator for each EMME demand matrix that takes the mode probability resource, the distribution resource, and multiplies it against a given emplaning and deplaning parameters for the time period to build demand. 

## Estimation

Estimation of this model is not possible by TMG since the model was developed externally by James Vaughan and Eric Miller who have gifted both the code and model to the group for unlimited use.  The model was estimated using XTMF however the data used for estimating the model is no longer available.  If the data was to be gathered however you would need a trip diary of auto and transit trips to Pearson.  The mode choice would then be estimated first, then the utilities from that estimation would be saved into the distribution estimation model system to complete the process.

The estimation model systems both rely on the ‘TashaRuntime’ model system template being used as the client for the TMG Estimation Framework.  Inside of Post Iteration after the airport model has been run we also include the module ‘Tasha.Airport.V4AirportModel2014.AirportModeSplitFitnessFunction’ in order to calibrate mode choice.  For distribution we use ‘Tasha.Airport.V4AirportModel2014.AirportDistributionFitnessFunction’ to evaluate the fitness for each parameter set.  Both modules provide a maximum-log-likelihood fitness function.
