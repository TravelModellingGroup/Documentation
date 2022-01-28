# AimsunBridge

## Overview 

AimsunBridge is responsible for loading and running the Aimsun software. 
The bridge internally communicate using a series of integer signals. 
The signals allows the bridge to communicate with itself and send commands, 
messages and error messages back to the user. 

The bridge is responsible for loading and running Aimsun. To run Aimsun
the bridge does the following:
1. Determine which aimsun tool needs to be run
1. Determine the inputs the tool needs to run and passes them in
1. Evaluates the tool runs successful. For unsuccessful runs, the bridge is 
responsible for outputting detailed error messages back to the user
1. Determine the location of the network package and any other data files
the tools need to properly setup the model system

