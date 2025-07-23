# Mode Choice

## Algorithm Overview

The mode choice algorithm in GTAModel V4.0 is significantly different from previous GTAModels.  To begin with, Mode choice is computed
for each household individually instead of in aggregate terms, such as zonal origin destinations.  
The figure below shows a breakdown of how the model works.

![alt text](images/ModeChoiceOverview.png "Mode Choice Overview")

## Modes

All of the parameters for each mode are documented in [Mode Choice Parameters](mode_choice_parameters.md).

### Auto

The auto mode in GTAModel V4.0 is meant to represent when a person is the driver inside of a vehicle (be is car, motorcycle or any other personally owned vehicle) that runs on the auto network.  No special considerations are made in this model for motorcycle and are treated identically to cars both in mode choice and on the network.

Destination parking costs are applied for Non-home destined trips based on the average hourly weighted parking cost for the zone applied to the duration of the activity episode.  Currently only parking data from the city of Toronto, and downtown Hamilton have been included in the model.  In the future other regions can apply this data into the zone system file.

### Carpool

The carpool mode in GTAModel V4.0 is meant to represent inter household passenger trips, including taxi (GTAModel V4.0 only).
Explicitly this does not include passenger trips facilitated by household members.

### School bus

The school bus mode for GTAAModel V4.0+ provides a simple mode that is only allowed to go to or from a school activity.  This mode does not explicitly model school buses
however provides a utility based on the age of the student, the distance of the trip, and the auto travel times.

### DAT (Drive-Access-Transit)

The drive access transit mode is the only tour based mode in GTAModel V4.0, where the utility of the mode depends on an entire tour as opposed to an individual trip.
External to the model is an access station choice model that defines feasible zone pairs and provides a logsum of the different station choices.
If this mode is chosen a discrete access station choice will be generated for integration into the EMME demand matrices.

The access station choice model is described here.

### WAT (Walk-Access-Transit)

`V4.0`

Walk access transit primarily represents all public transportation trips that do not involve driving to and leaving a vehicle at a station.  This includes both walking to a station/stop and being dropped off as a passenger to a station/stop.
In the future we will look at designing the passenger mode to encompass the latter functionality.

`V4.1+`

Walk access transit represents trips where both the access and egress legs of the trip are done using active transportation modes, such as walking or cycling, and where
at least one public transit vehicle is used for the trip.

### Walk

The walk mode is a simple mode that by default will use the zone system's straight line distance and convert it into time using a global walking speed.

This module has been upgraded in XTMF 1.5 to be able to take in a custom distance matrix (in metres) to override the distance matrix from the zone system.
If the zone system is using a custom distance matrix, that will be used instead of a straight line distance unless overridden.

### Bike

The bike mode is a simple mode that by default will use the zone system's straight line distance and convert it into time using a global walking speed.
Additionally this mode has the requirement that the bicycle must return back home at the end of the day.  The bicycle also can not be used if it is not current
located at the zone during a trip chain.

This module has been upgraded in XTMF 1.5 to be able to take in a custom distance matrix (in metres) to override the distance matrix from the zone system.
If the zone system is using a custom distance matrix, that will be used instead of a straight line distance unless overridden.

### Passenger

This mode, and Rideshare, are applied after the main mode choice model.  Persons within their household who were not allocated an auto for their tour will and
who have persons who could possibly facilitate their trips are checked to see if they can be facilitated to their destination.  The potential
driver will chose to make the highest utility choice between either not facilitating the passenger, facilitating the passenger, or choosing
to facilitate a different passenger.  That is to say that even if there is a driver available the potential passenger is not guaranteed the trip.
The utility for the whole household is maximized.

There are two passes, first for drivers who are currently on the road.  The second pass checks to see if there is someone at home and if there
is also a vehicle available to facilitate the trip.  At each pass the household utility is maximized.

![alt text](images/PassengerAlgorithmOverview.png "Passenger Algorithm Overview")  ![alt text](images/PassengerAlgorithmDetailed.png "Passenger Algorithm Detailed")

### Rideshare

This mode serves as a dummy mode for persons who are not in charge of their joint trip chain.  If the tour-leader chooses to take Auto Drive
then this mode will be assigned to the passenger.

### Passenger Access Transit (PAT)

Available in GTAModel V4.1+, this mode serves as an auto passenger trip to transit stations that have parking
lots.  This mode does not require the facilitation by a household member, nor the allocation of a household
auto.

### Passenger Egress Transit (PET)

Available in GTAModel V4.1+, this mode serves as an auto passenger trip from transit stations that have parking
lots.  This mode does not require the facilitation by a household member, nor the allocation of a household
auto.


### Vehicle For Hire (VFH)

Available in GTAModel V4.1+, this mode serves as a grouping for Taxi and Uber, Lift, and other Vehicle for Hire services.
