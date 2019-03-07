
# Calc 407ETR Tolls
This tools allows the user to calculate tolls for the 407ETR. 
 
## Opening the Tool with Modeller
The Tool is found in "TMG Toolbox" -> "Assignment" -> "Preprocessing" -> "Calc 407ETR Tolls"

## Using the Tool with Modeller
### Scenario
The "Scenario" field is used to specify the scenario in which the 407ETR tolls are to be calculated. Only one scenario can be specified at a time.

### Attributes

#### Result Attribute 
This is the link attribute in which the calculated toll for that link is stored
#### Toll Zone Attribute
This attribute tells the tool what zone number the link belongs to.
1. Light toll zone
2. Regular Toll Zone
All other values are assumed not to be tolled
>Noe that this tool only works for the Light and Regular toll zone system that was present in the pre-2017. Starting from January 2017, the provincial portion of the 407E  was opened and tolled. Later in the year, the toll zone system changed for the 407ETR as well to include more zones. To model this more complex system, it is recommended to use the Toll Zone attribute to flag the area, and then to use a series of Network Calculations to calculate the toll.

### Toll Costs
#### Light zone toll
In $/km applied to toll zone 1.
#### Regular zone toll
In $/km, applied to toll zone 2.

## Using the Tool with XTMF
The tool is called Calc407Tolls. It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun. This tool still assumed only two zones are present on the 407. For more advanced zoning, it is recommended to use a series of Network Calculations.

### Light Zone Price
The price per km for the light zone is specified here.
### Regular Zone Price
The price per km for the light zone is specified here.
### Result Attribute Id
The attribute which stores the toll value for each link on the 407 including the "@" character.
### Scenario 
The scenario for which tolls are to be applied for. Only one scenario can be specified at a time
### Toll Attribute Id
The ID which tags whether a link is tolled and what zone (Light or Regular) it is. An attribute value of 0 means it is not tolled, 1 is light zone, while 2 is the regular zone
