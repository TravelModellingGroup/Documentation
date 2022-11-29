# GTAModel V4 Introduction

GTAModel V4 is the next generation travel demand model platform developed by the Travel Modelling Group at the University of Toronto.
 The model is designed to aid in the forecasting of travel patterns with the allowance of testing different policy decisions. This version of 
GTAModel radically departs from its predecessors by moving both to an activity based design and an integrated daily model. Five time periods are 
represented, AM, Mid-day, PM, Evening, and Overnight. The work is largely based upon the Travel Activity Scheduler for Household Agents (TASHA) model 
written by Matthew J. Roorda.

GTAModelV4.0 has been designed to work within the eXtensible Travel Modelling Framework (XTMF), allowing it to be easily extended and 
customized by both TMG and consultants alike. The model is property of the University of Toronto however, has been freely licensed to
 all funding agencies of TMG. The code for the XTMF modules is open-source and is publicly available under the GPLV3 license as
 required by XTMF’s license.

## What's New in GTAModel V4.1.0

* Updated parameters based upon the 2016 Transportation of Tomorrow Survey
* Tighter convergence requirement for Road assignment during the final iteration
* Auto ownership and Driver License models
* Integrated Freight model
* Surface Transit Speed Updating (STSU) for transit assignment
* New mode choice options:
  * Passenger Access Transit (PAT)
  * Passenger Egress Transit (PET)
  * Vehicle For Hire (VFH)
* Improved targets for Market and Other trip purposes
* Custom distance matrices for walk / bicycle modes, and zonal distances
* Improved model setup experience