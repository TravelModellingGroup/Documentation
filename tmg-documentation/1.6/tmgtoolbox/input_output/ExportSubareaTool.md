# **Export Subarea Tool**
This tool allows users to extract the road network for a subarea as well as the traffic demand matrices and link and turn volumes for a multi-class assignment. The transit network and demand may also be extracted if a transit assignment specification is provided.
> The user must specify an existing subarea node attribute or a shapefile that defines the subarea.


## **Using the Tool with Modeller**
The tool is not callable from Emme Modeller. Please use XTMF instead.


## **Using the Tool with XTMF**
The tool is called "ExportSubareaTool". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun. 

### Extract Transit
Whether or not the tool will extract out transit line and demand information from the scenario.

### Gate Labels
If the user has a link extra attribute with the defined gate numbers, enter it here.

### Scenario Number
The scenario number to execute against.

### Starting Node Number
Starting node range for the gate labels if they are not defined by a link extra attribute parameter.

### Subare Node Attribute
The node attribute that will be used to define the subarea. Can be specified along with a shapefile or by itself. Either a shapefile or an node attribute must be defined.

### **SOLA**
The SOLA parameters to perform the analysis.

### Best Relative Gap
The minimum gap required to terminate the algorithm.

### Iterations
The maximum number of iterations to run.

### Normalized Gap
The minimum gap required to terminate the algorithm.

### Peak Hour Factor
The factor to apply to the demand in order to build a representative hour.

### Performance Mode
Set this to false to leave a free core for other work, recommended to leave set to true.

### Relative Gap
The minimum gap required to terminate the algorithm.

### *Classes*
The classes for the SOLA Road Assignment.

### Demand Matrix
The id of the demand matrix to use.

### LinkCost
The penalty in minutes per dollar to apply when traversing a link.

### Mode
The mode for this class.

### Toll Weight
The Toll Weight cannot be less than or equal to 0.

### Toll Attribute ID
The attribute containing the road tolls for this class of vehicle.

### Volume Attribute
The name of the attribute to save the volumes into (or None for no saving).

### **Shapefile Location**
A link to the shapefile to specify boundary of the subarea.

### **Subarea Output Folder**
A link to the folder to outout the subare database.




