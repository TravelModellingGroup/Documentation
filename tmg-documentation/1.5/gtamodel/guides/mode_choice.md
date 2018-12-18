# Mode Choice

## Algorithm Overview

The mode choice algorithm in GTAModel V4.0 is significantly different from previous GTAModels.  To begin with, Mode choice is computed for each household individually instead of in aggregate terms, such as zonal origin destinations.  The figure below shows a breakdown of how the model works.

TODO

## Modes

All of the parameters for each mode are documented in `Mode Choice Parameters`.

### Auto

The auto mode in GTAModel V4.0 is meant to represent when a person is the driver inside of a vehicle (be is car, motorcycle or any other personally owned vehicle) that runs on the auto network.  No special considerations are made in this model for motorcycle and are treated identically to cars both in mode choice and on the network.

Destination parking costs are applied for Non-home destined trips based on the average hourly weighted parking cost for the zone applied to the duration of the activity episode.  Currently only parking data from the city of Toronto, and downtown Hamilton have been included in the model.  In the future other regions can apply this data into the zone system file.

### Carpool

The carpool mode in GTAModel V4.0 is meant to represent inter household passenger trips, including taxi.  Explicitly this does not include passenger trips facilitated by household members.

### DAT (Drive-Access-Transit)

The drive access transit mode is the only tour based mode in GTAModel V4.0, where the utility of the mode depends on an entire tour as opposed to an individual trip.  External to the model is an access station choice model that defines feasible zone pairs and provides a logsum of the different station choices.  If this mode is chosen a discrete access station choice will be generated for integration into the EMME demand matrices.

The access station choice model is described here.

### WAT (Walk-Access-Transit)

Walk access transit primarily represents all public transportation trips that do not involve driving to and leaving a vehicle at a station.  This includes both walking to a station/stop and being dropped off as a passenger to a station/stop.  In the future we will look at designing the passenger mode to encompass the latter functionality.

### Walk

### Bike

TODO