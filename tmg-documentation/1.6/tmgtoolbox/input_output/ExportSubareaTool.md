# **Export Subarea Tool**
This tool allows users to extract the road network for a subarea as well as the traffic demand matrices and link and turn volumes for a multi-class assignment. The transit network and demand may also be extracted if a transit assignment specification is provided.
> The user must specify either of the followings to define the subarea:
> * Extra node/link attributes that define 
>   * the nodes within the subarea (e.g., @nflag) 
>   * the gates - i.e., the centroid connectors within the subarea and links crossing the boundary (e.g., @gate)
> * A shapefile that defines the boundary of the subarea
>  
> More details can be found in the Emme Help of *Subarea (Tool Category)* on defining the subarea from the regional model and *Subarea O-D matrix* on defining the gate labels.


## **Using the Tool with Modeller**
The tool is not callable from Emme Modeller. Please use XTMF instead.


## **Using the Tool with XTMF**
The tool is called "ExportSubareaTool". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun. 

### Extract Transit
Whether or not the tool will extract out transit line and demand information from the scenario. A transit assignment has to be specified if set as *TRUE*.

### Gate Labels
Enter the link extra attributes specified by the user that defines gate numbers (e.g., @gate). Leave as *None* if a shapefile is used instead.

### Scenario Number
The scenario number to execute against.

### Starting Node Number
Starting node range for the gate labels if they are not defined by a link extra attribute parameter.

### Subarea Node Attribute
The node attributes that will be used to define the subarea (e.g., @nflag). Can be specified along with a shapefile or by itself, but either a shapefile or a node attribute must be defined.

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
Set this to false to leave a free core for other work, recommended leaving set to true.

### Relative Gap
The minimum gap required to terminate the algorithm.

### **Classes**
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
A link to the shapefile to specify the boundary of the subarea. Leave *Blank* if the node/link extra attributes are used to define the subarea instead.

### **Subarea Output Folder**
A link to the folder to output the subarea database.




