# **TMG Transit Assignment Tool**
This tool executes a multi-class transit assignment

## **Using the Tool with Modeller**
`TMGTransitAssignmentTool` tool is not callable from Modeller. It is intended only to be called from XTMF.

The tool can be found in "TMG Toolbox" -> "XTMF Internal" -> "TMG Transit Assignment Tool". 

## **Using the Tool with XTMF**
The tool is called "TransitAssignmentTool". In XTMF, it is available to add under ***ExecuteToolsFromModellerResource*** or ***EmmeToolsToRun***.

## Module Parameters - "TransitAssignmentTool"

### Connector Logit Scale
Scale parameter for logit model at origin connectors.

### Effective Headway Attribute
The name of the attribute to use for the effective headway.

### Effective Headway Slope

### Exclusive ROW TTF Range
Set this to the TTF, TTFs or range of TTFs (seperated by commas) that represent going in an exclusive right of way. This is the use in STSU.

### Headway Fraction Attribute
The ID of the NODE extra attribute in which to store headway fraction. Should have a default value of 0.5.

### Iterations
Convergence criterion: The maximum number of iterations performed by the transit assignment.

### Logit Scale at Critical Nodes
This is the scalre parameter for the logit model at critical nodes. Set it to 1 to turn it off logit. Set it to 0 to ensure equal proportion on all connected auxiliary transfer links. Critical nodes are defined as the non centroid end of centroid connectors and nodes that have transit lines from more than one agency.

### Normalized Gap
Convergence criterion.

### Relative Gap
Convergence criterion.

### Representative Hour Factor
A multiplier applied to the demand matrix to scale it to match the transit line capacity period. This is similar to the peak hour factor used in auto assignment.

### Scenario Number
Emme Scenario Number.

### Walk Speed
Walking speed in km/hr. Applied to all walk (aux. transit) modes in the Emme scenario

## Sub-Module Parameters - TransitAssignmentTool -> Class

### Boarding Penalty Matrix
The number of the FULL matrix which to save the applied boarding penalties. Enter 0 to skip this matrix.

### Boarding Penalty Perception 
Perception factor applied to boarding penalty component. 

### Congestion Matrix
The number of the FULL matrix which to save transit congestion. Enter 0 to skip saving this matrix.

### Demand Matrix Number
The number of full matrix containing transit demand ODs.

### Fare Matrix
The number of the FULL matrix which to save transit fares. Enter 0 to skip saving this matrix.

### Fare Perception 
Perception factor applied to boarding penalty component.

### In-vehicle Times Matrix
The number of the FULL matrix which to save in-vehicle travel time. Enter 0 to skip saving this matrix

### Link Fare Attribute
The ID of the LINK extra attribute containing actual fare costs.

### Modes
A character array of all the modes applied to this class '*' selects all.

### Perceived Travel Time Matrix
The number of the FULL matrix which to save the incurred penalties. Enter 0 to skip saving this matrix.

### Segment Fare Attribute
The ID of the SEGMENT extra attribute containing actual fare costs.

### Wait Time Perception
Perception factor applied to wait time component.

### Wait Times Matrix
The number of the FULL matrix which to save total waiting time. Enter 0 to skip saving this matrix.

### Walk Perceptin Attribute
The ID of the LINK extra attribute in which to store walk time perception. Should have a default value of 1.0.

### Walk Times Matrix
The number of the FULL matrix which to save total walk time. Enter 0 to skip saving this matrix.

## Sub-Module Parameters - TransitAssignmentTool -> Class -> WalkPerceptionSegment

### Filter
The filter expression for links that the perception applies to. The `Filter` expects a String parameter type.

### Walk Perception Value
The work perception links. The `WalkPerceptionValue` parameter type is a String.