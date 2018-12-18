
# Calc 407ETR Tolls
This tools allows the user to calculate tolls for the 407ETR. 

## Opening the Tool
The Tool is found in "TMG Toolbox" -> "Assignment" -> "Preprocessing" -> "Calc 407ETR Tolls"

## Using the Tool
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

