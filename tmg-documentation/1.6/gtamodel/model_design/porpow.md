# Place of Residence - Place of Work

## Overview

The place of residence – place of work model in GTAModel V4.0 is composed of two parts, an aggregate model that builds probability fields given worker categories, and an assignment procedure to produce a discrete choice per person.  

In the aggregate model workers are separated by both occupation and employment status (fulltime / part-time).  For each of these categories they are then split again into one of three worker categories.  The first category is for persons who either do not have a license or no vehicles in their household.  The second category are for persons who live in a household that has less vehicles than possible drivers, and has their own license.  The last category is for persons who have a license and their household has at least as many vehicles as persons with drivers licenses.  Each occupation / employment status is run through a triply constrained gravity model having residence, jobs, and probability of worker category as the constraints.

One the probabilities for each worker category has been computed that data is then passed forward when loading in the synthetic population.  A discrete zone is then selected for each person in the worker, employment, and occupation category for each person.

In `GTAModel V4.1` the model has been reduced to a 2D gravity model since it will execute before the number of
vehicles will not have been assigned to the household before assigning discrete places of work.

## Equations

The friction for the gravity model is given by the following equations:


$$
e^{Friction_{ijk}} = K_{ij}e^{V_{ijk}}

$$

Where,


$$
e^{V_{ijk}} = e^{\beta_{Constant_s}} \left(
\begin{cases}
e^{\beta_{intrazonal_s}} & i = j \\\\
1 & \text{else}
\end{cases}\right)
\left(
\begin{cases}
e^{\beta_{intraPD_s}} & PD_i = PD_j \\\\
1 & \text{else}
\end{cases}
\right)
\left(e^{\beta_{aivtt_{sk}}AIVTT_{ij}} + e^{\beta_{TransitConstant}+\beta_{ptivtt_s}PTIVTT_{ij}}+e^{\beta_{DitanceConstant}+\beta_{Distance}Distance_{ij}}\right)

$$

Where,


$$
\begin{split}
i & = \text{Origin Zone} \\\\
j & = \text{Destination Zone} \\\\
s & = \text{Spatial Segment} \\\\
PD & = \text{Planning District} \\\\
k & = \text{Worker Category} \\\\
K & = \text{K-Factor for zone } i \text{ to zone} j
\end{split}

$$

The Distance term is included starting in GTAModel V4.1.


## Estimation

The place of residence place of work models were estimated using XTMF with the particle swarm optimizer maximizing the log-likelihood.  After the estimation was complete constants were adjusted to improve the fit at the planning district and regional levels.