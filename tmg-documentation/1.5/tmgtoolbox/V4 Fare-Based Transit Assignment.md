
# V4 Fare-Based Transit Assignment
Executes a congested transit assignment procedure for GTAModel V4.0. 

Hard-coded assumptions:
Boarding penalties are assumed to be stored in UT3
The congestion term is stored in US3
In-vehicle time perception is stored in US2. 
All available transit modes will be used.
This tool is only compatible with Emme 4.1.5 and later versions

## Opening the Tool with Modeller
The tool can be found in "TMG Toolbox" -> "Assignment" -> "Transit" ->"V4 FBTA"

## Using the Tool with Modeller
### Scenario Inputs
#### Scenario
The scenario in which to execute the transit assignment.
#### Demand Matrix
The matrix which contains the OD transit demand
#### Headway Fraction Attribute
This is the attribute which the assignment uses to store the headway fraction. Select NONE to create a temporary attribute. 
**Warning:** using a temporary attribute causes an error with subsequent strategy-based analyses. 
#### Effective Headway Attribute
TRANSIT_LINE extra attribute to store effective headway value. Select NONE to create a temporary attribute. 
**Warning:** using a temporary attribute causes an error with subsequent strategy-based analyses.
#### Walk Perception Attribute
Link extra attribute to store walk perception value. Select NONE to create a temporary attribute. 
**Warning:** using a temporary attribute causes an error with subsequent strategy-based analyses.

#### Link Fare Attribute
Link extra attribute that contains actual fare costs. 

#### Segment Fare Attribute
SEGMENT extra attribute that contains actual fare costs.

### Output Matrices
This section allows the user to save output matrices in the specified matrix. Note: Matrices may need to be initialized first in order to appear in the matrix list. To initialize a matrix, please use the following tool "Emme Standard Toolbox" -> "Data Management" -> "Matrix" -> "Initialize matrix".
>An "Impedance" matrix stores the total perceived cost to travel between any OD.

### Parameters
#### Effective Headway Slope
Applies to headways greater than 15 minutes. 
>It is used in the following formula 
>Effective Headway = 15+2*(Slope)*(Actual Headway-15)
#### Wait Time Perception
Converts waiting minutes to impedance
#### Walking Speed
Walking speed, in km/hr. Applied to all walk modes.
#### Toronto Access Perception
Walk perception on Toronto centroid connectors
#### Toronto Walk Time Perception
Walk perception on Toronto links not including centroid connectors
#### Non-Toronto Access Perception
Walk perception on Non-Toronto centroid connectors
#### Non-Toronto Walk Time Perception
Walk perception on Non-Toronto links not including centroid connectors
#### PD1 Walk Time Perception
Walk perception on links inside Planning District 1 (PD1) where link type == 101.
#### Boarding Perception
Converts boarding penalties into impedance. 
#### Fare Perception
Converts fare costs to impedance. In $/hr. Effectively, it is a value of time (VOT)
#### Assignment Period
Network Capacities are multiplied by this value to allow Emme to get correct congestion values.
Typically equal to the number of hours in the assignment period of the demand matrix.
### Congestion Parameters
List of congestion perceptions and exponents. Applies different congestion parameter values based on a segment's ttf value. 

Syntax: [ttf] : [perception] : [exponent] ... 

Separate (ttf-perception-exponent) groups with a comma or new line. 

The ttf value must be an integer. 

Any segments with a ttf not specified above will be assigned the congestion parameters of the final group in the list.
### Convergence Criteria
#### Iterations
The maximum number of iterations to perform. If the gaps have been achieved before this number, the assignment will stop
#### Normalized Gap and Relative Gap
The gaps that show how well converged the assignment is. It can be thought of as the difference between iterations.
### Number of Processors
The higher the value, the faster the assignment can be completed. It comes at a cost of slowing down other processes on the computer.
### Use boarding levels?
The use of boarding levels forces all trips to board a transit vehicle at least once in their journey (no walk-all-ways).

## Using the Tool with XTMF
The module is called "V4FBTA". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun.
### Add Congestion to IVTT
This option adds the congestion time to the In Vehicle Travel Times.
### Boarding Matrix
This stores the average boarding penalty paid in an OD matrix. Specify that matrix number here. If the matrix doesn't exist, it will be created. If it exists, it will be overwritten. Input "0" to not save it.
### Boarding Penalty Perception
The boarding penalty perception factor
### Congestion Matrix
This stores the average congestion time in an OD matrix. Specify that matrix number here. If the matrix doesn't exist, it will be created. If it exists, it will be overwritten. Input "0" to not save it.
### Connector Logit Scale
This specifies the logit scale for connectors (between 0 and 1). If "0" is chosen, every centroid connector has an equal chance of being selected, regardless of whichever one is best for the trip. If "1" is chosen, no probabilities are used and only the best centroid connector for the trip is selected. 
### Demand Matrix Number
The matrix which contains the OD transit demand.
### Distance Matrix
The matrix that gives that average distance traveled in an OD format. Specify that matrix number here. If the matrix doesn't exist, it will be created. If it exists, it will be overwritten. Input "0" to not save it.
### Effective Headway attribute
TRANSIT_LINE extra attribute to store effective headway value. Include the "@" character
### Effective Headway Slope
The slope used to calculate headways for headways that are longer than 15 minutes. 
>It is used in the following formula 
>Effective Headway = 15+2*(Slope)*(Actual Headway-15)
### Fare Matrix
This matrix will store the average fair paid in OD format. If the matrix doesn't exist, it will be created. If it exists, it will be overwritten. Input "0" to not save it.
### Fare Perception
Perception factor applied to transit fares to convert them from $ to a value of time. This should be given in $/hr. It can be thought of as Value of Time (VOT)
### Headway Fraction Attribute
This is the attribute which the assignment uses to store the headway fraction. Include the "@" character. 
### Impedance Matrix
The matrix that stores the average Perceived Travel Time (PTT). If the matrix doesn't exist, it will be created. If it exists, it will be overwritten. Input "0" to not save it.
### In-vehicle Time Matrix
The matrix that stores the average In vehicle times. If the "Add Congestion to IVTT" option is set to True, this matrix will include congestion times. If it is set to False, this will give the "Actual" in vehicle times. If the matrix doesn't exist, it will be created. If it exists, it will be overwritten. Input "0" to not save it.
### Iterations
The number of iterations to perform. If the gaps are reached before this number, the assignment will stop.
### Link Fare Attribute
This is the LINK extra attribute that contains the fare information. Include the "@" character
### Non-Toronto Access Perception
Walk perception on Non-Toronto centroid connectors
### Non-Toronto Walk Perception
Walk perception on Non-Toronto links not including centroid connectors
### Normalized Gap, Relative Gap
The gaps that measure the level of convergence in the assignment.
### PD1 Walk Perception
Walk perception in Planning District 1 (link type == 101)

### Representative Hour Factor
Network Capacities are multiplied by this value to allow Emme to get correct congestion values.
Typically equal to the number of hours in the assignment period of the demand matrix.
### Scenario Number
The scenario number of the scenario in which the assignment is to be performed
### Segment Fare Attribute
The SEGMENT extra attribute that contains the fare information. This is typically used in distance based fare calculations. Include the "@" character when specifying the attribute. 
### Toronto Access Perception
Walk perception on Toronto centroid connectors
### Toronto Walk Perception
Walk perception on Toronto links not including centroid connectors
### Use Boarding Levels
The use of boarding levels forces all trips to board a transit vehicle at least once in their journey (no walk-all-ways).
### Wait Time Perception
Converts waiting minutes to impedance
### Wait Times Matrix
The matrix that stores the average Wait Times. If the matrix doesn't exist, it will be created. If it exists, it will be overwritten. Input "0" to not save it.
### Walk Perception Attribute
A LINK extra attribute that will be used to store the perception of walking on that link. Include the "@" symbol.
### Walk Speed
The walk speed for all auxiliary transit modes in km/hr.
### Walk Times Matrix
The matrix that stores the average Walk Times. If the matrix doesn't exist, it will be created. If it exists, it will be overwritten. Input "0" to not save it.





