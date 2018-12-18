# Place of Residence - Place of Work

## Overview

The place of residence – place of work model in GTAModel V4.0 is composed of two parts, an aggregate model that builds probability fields given worker categories, and an assignment procedure to produce a discrete choice per person.  

In the aggregate model workers are separated by both occupation and employment status (fulltime / part-time).  For each of these categories they are then split again into one of three worker categories.  The first category is for persons who either do not have a license or no vehicles in their household.  The second category are for persons who live in a household that has less vehicles than possible drivers, and has their own license.  The last category is for persons who have a license and their household has at least as many vehicles as persons with drivers licenses.  Each occupation / employment status is run through a triply constrained gravity model having residence, jobs, and probability of worker category as the constraints.

One the probabilities for each worker category has been computed that data is then passed forward when loading in the synthetic population.  A discrete zone is then selected for each person in the worker, employment, and occupation category for each person.

## Equations

TODO

## Estimation

The place of residence place of work models were estimated using XTMF with the particle swarm optimizer maximizing the log-likelihood.  After the estimation was complete constants were adjusted to improve the fit at the planning district and regional levels.