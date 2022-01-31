# AimsunBridge

## Overview 

Aimsun Bridge is the connection between the Aimsun software and XTMF.

AimsunBridge has two main general activities: 
1. Read and process the signals and data coming fromt XTMF.
1. Load and run the Aimsun software.

## Protocol
The bridge internally communicates with XTMF via the AimsunController 
using integer signal commands. Each integer corresponds to a specific action. 
Below is an example of a few signal commands and the responses passed back
to XTMF:
* **0**: Tell XTMF we are ready to accept messages 
* **1**: Tells XTMF that we exited. 
* **4**: Tells XTMF an error occured in generating the parameters
* **5**: Tells XTMF an error occured in running the Aimsun tool

The bridge is responsible for loading and running Aimsun. To run Aimsun
the bridge does the following:
1. Determine which aimsun tool needs to be run
1. Determine the inputs the tool needs to run and passes them in
1. Evaluates the tool runs successful. For unsuccessful runs, the bridge is 
responsible for outputting detailed error messages back to the user
1. Determine the location of the network package and any other data files
the tools need to properly setup the model system

## Data 
Input data to the Aimsunbridge is passed from XTMF using the JSON format 
with the key and associated value.  Below is an example of an example JSON
that contains all the parameters for the tool ImportMatrixFromCSVThirdNormalizedTool
requires to run. 
```
string jsonParameters = JsonConvert.SerializeObject(new
            {
                MatrixCSV = matrixCSV,
                ODCSV = odCSV,
                ThirdNormalized = thirdNormalized,
                IncludesHeader = includeHeader,
                MatrixID = matrixID,
                CentroidConfiguration = centroidconfig,
                VehicleType = vehicleType,
                InitialTime = initialTime,
                DurationTime = durationTime
            });
```

## Writing Custom Tools/Scripts 

The user may be required to either write their own custom Aimsun tools/scripts.
AimsunBridge allows for this to be implemented. There are two ways to run
your custom tools.
1. Use a command terminal. The following code snippet illustrates how to 
run the tool ImportNetwork from the command line. The following information
is required 
    1. first argument is the path to the location of aconsole.exe
    1. second argument after the -script is the path to the tool to run
    1. Third -args the input parameters required for the tool. 

```
 " "C:\\Program Files\\Aimsun\\Aimsun Next 22\\aconsole.exe\" -script src\\TMGToolbox\\inputOutput\\importNetwork.py args"
```

1. The second way to run the tool is to run it using the XTMF. 