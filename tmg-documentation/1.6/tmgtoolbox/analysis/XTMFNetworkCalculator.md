# **XTMF Network Calculator**


## **Using the Tool with Modeller**
The tool is not callable from Emme Modeller. Please use XTMF.


## **Using the Tool with XTMF**
The tool is called "NetworkCalculator". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun.

#### Domain
Select the type of Emme domains: Link, Node, Transit Lines, or Transit Segment.

#### Expression
Enter the expression to compute.

#### Link Selection
Select the specific links to include in the calculation. Default is ALL.

#### Node Selection
Select the specific nodes to include in the calculation. Default is ALL.

#### Result Attribute
The attribute to save the result into. Leave blank to not save.

#### Scenario Number
Enter the scenario ID to execute this against.

#### Transit Line Selection
Select the specific transit lines to include in the calculation. Default is ALL.

### Sum of Report
Resources that will store the sum of the network calculation.

#### Resource Name
The unique name for this resource.

#### Unload after Acquire
Select TRUE to release this resource after it has been acquired.