# Convert Between NCS Scenarios

## Overview 
This tool is responsible for converting a network from one standard to the next.
In this tool we are converting from the 2016 NCS standard to the 2022 NCS Standard. 

The tool can be run from either the Emme Modeller Gui or from XTMF2. 

Below is the link to the NCS22 standard document for reference. 
https://tmg.utoronto.ca/wp-content/uploads/2022/05/NCS22_Final_Mar-25-22.pdf

## Parameters
For this tool the following parameters and data are required. 
Note that all input data is provided in a csv data format.
Each csv file contains the 2016 data and the new 2022 data to which
to change to.

#### Old NCS Scenario: 
This is the original network scenario
#### New NCS Scenario:
The new network scenario where the NCS conversion will happen on
#### Station Centroid File CSV File Location: 
Csv file with the station centroid data
#### Zone Centroid CSV File Location: 
Csv file of zone centroids
#### Mode Code Definitions CSV File Location: 
Csv file of mode definitions.
#### Link Attributes CSV File Location: 
Csv file of link attributes
#### Transit vehicle definitions CSV File Location: 
Csv file of traffic vehicles
#### Lane Capacities CSV File Location: 
Csv file of lane capacities 
#### Transit Line Code CSV File Location:
Csv file of the transit lines
#### Skip Missing Transit Lines
Boolean value to determine if user should skip missing transit lines.
Default is True. Click checkbox to select False so missing transit
lines are not skipped

## Using the tool with EMME Modeller GUI
The tool can be found in "TMG Toolbox2" -> "Convert" -> "Convert Between NCS Scenarios"

## Using the tool with XTMF2.

## Note
For every new network that a user wants to convert into ncs22, 
user has to provide the corresponding input files for that network.
