# Toll Attribute Transit Background
Executes a standard Emme traffic assignment using tolls for link costs converted to a time penalty, using a specified link extra attribute containing the toll value. The actual times and costs are recovered by running a second 'all-or-nothing' assignment. 

This version uses a link extra attribute containing the link toll amount, as well as calculates custom transit BG traffic from segments with flagged TTFs. It assumes that segments flagged with ttf=3 mix with traffic. 

Temporary Storage Requirements: 2 extra link attributes, 1 extra function parameter (el1), 1 full matrix, 1 scenario.

## Opening the Tool with Modeller
The tool can be found in "TMG Toolbox" -> "Assignment" -> "Road" -> "Tolled" -> "Toll Attribute Transit Background"
## Using the Tool with Modeller
### Scenario
#### Select a Scenario
The scenario in which to apply the Road Assignment.
#### Select a demand matrix
The auto demand matrix for use in the Road Assignment.
#### Link Toll Attribute
The attribute which contains the toll value for that link. In GTAModelV4 the standard link Toll Attribute is "@toll".
### Output Matrices
#### Travel time matrix
This allows the user to store the auto travel times in the specified matrix. The user can create or override a matrix. The option to store in the "Next available matrix" is also available.
#### Travel costs matrix
This allows the user to store the auto travel costs in the specified matrix. The costs include both link unit costs (such as gas, maintenance etc.) and link toll costs. The user can create or override a matrix. The option to store in the "Next available matrix" is also available.
#### Tolls Matrix
This allows the user to store the auto tolls costs in the specified matrix. The user can create or override a matrix. The option to store in the "Next available matrix" is also available.

#### Run Title
A description of the run in 25 characters or less for use in the Emme Logbook
### Parameters
#### Peak Hour Factor
This converts a Peak Period Demand matrix into a Peak Hour matrix since Emme only assigns a one hour demand for its road assignment. If a Peak Hour Matrix is specified as the demand matrix in the above, then this should be kept as 1.
#### Link Unit Cost
This is the cost of travelling in $/km. It can be used as a substitute for gas costs, maintenance, wear and tear, etc. If no cost is to be used, input 0.
#### Toll Perception
This is the generalized perception of the cost in $/hr. It is used to convert the cost of using the road in $ to a unit of time.

### Convergence Criteria
#### Iterations
The maximum number of iterations to perform. If the gaps are achieved before this number, the assignment will stop.
#### Relative Gap, Best Relative Gap, Normalized Gap
These gaps are used to calculate how converged the assignment is. The standard values are 0.1, 0, and 0.05 respectively. 

### Tool Options
#### Enable High Performance Mode
This option will enable multi threading and will therefore use more cores for the assignment. This might slow down other processes on your computer. It is generally advised to enable this. 
#### Use SOLA traffic assignment?
The SOLA (Second Order Linear Approximation) procedure provides nearly identical results to the standard assignment but performs it much faster. It is highly recommended to leave this option as enabled. 

## Using the Tool with XTMF
The tool is called "TollAttributeRoadAssignment". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun.

### Relative Gap, Best Relative Gap, Normalized Gap
These gaps are used to calculate how converged the assignment is. The standard values are 0.1, 0, and 0.05 respectively. 

### Demand File Name
For debugging. Optional file name to export the tallied demand matrix. Otherwise, a temporary file will be used.
### Demand Matrix Number
The Full Period Demand Matrix number is specified here. If using a Peak Hour matrix here, set the Peak Hour Factor to 1.
### High Performance Flag
This option will enable multi threading and will therefore use more cores for the assignment. This might slow down other processes on your computer. It is generally advised to enable this. 
### Link Toll Attribute
The attribute which contains the toll value for that link including the "@" character. In GTAModelV4 the standard link Toll Attribute is "@toll".
### Link Unit Cost
This is the cost of travelling in $/km. It can be used as a substitute for gas costs, maintenance, wear and tear, etc. If no cost is to be used, input 0.
### Max Iterations
The maximum number of iterations to perform. If the gaps are achieved before this number, the assignment will stop.
### Peak Hour Factor
The number which converts the Peak Period demand matrix to the Peak Hour matrix for use in Emme. If a Peak Hour Matrix was already specified, input 1.
### Scenario Number
The scenario number in which the assignment is to be completed
### SOLA Flag
The SOLA (Second Order Linear Approximation) procedure provides nearly identical results to the standard assignment but performs it much faster. It is highly recommended to leave this option as enabled. 
### Toll Perception Factor
This is the generalized perception of the cost in $/hr. It is used to convert the cost of using the road in $ to a unit of time.
### Toll Matrix Number
The matrix number in which to store the average toll paid OD matrix.
### Transit Background Traffic Flag
This option enables the addition of transit vehicles on roads (thereby affecting the road volume) using transit line headways to calculate the number of transit vehicles per hour.
### Travel Cost Matrix Number
The matrix number in which to store the average cost paid OD matrix.
### Travel Time Matrix Number
The matrix number in which to store the average travel times OD matrix.
