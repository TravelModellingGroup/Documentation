# AimsunBridge

## Overview 

AimsunBridge is the connection between the Aimsun software and XTMF.

AimsunBridge has two objectives: 
1. Read and process the signals and data coming from XTMF.
1. Load and run the Aimsun software.

## Protocol

The AimsunBridge internally communicates with XTMF via the AimsunController 
using integer signal commands. Each integer corresponds to a specific action. 
Below is an example of a few signal commands and the responses passed back
to XTMF:
* **0**: Tell XTMF we are ready to accept messages.
* **5**: Tell XTMF an error occurred in running the Aimsun tool.

The bridge is responsible for loading and running Aimsun. To run Aimsun
the bridge does the following:
1. Determine which Aimsun tool needs to be run.
1. Run the Aimsun tool with the appropriate  parameters.
1. Evaluate the progress of the tool. For unsuccessful runs, the bridge is 
responsible for outputting detailed error messages back to XTMF.

## Data 

Input data to the Aimsunbridge is passed from XTMF using the JSON format 
with the key and associated value.  Below is an example of an example JSON
that contains all the parameters for the tool ImportMatrixFromCSVThirdNormalizedTool
that are required for a successful run. 

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

The user may write their own custom Aimsun tools/scripts.
AimsunBridge allows for this to be implemented. There are two ways to run
your custom tools.
1. Use a command terminal. The following code snippet illustrates how to 
run the tool ImportNetwork from the command line. The following information
is required 
    1. First argument is the path to the location of aconsole.exe.
    1. Second argument after the -script keyword is the relative path location to the tool to run.
    1. Third argument labelled generically as -args are the input parameters required for the tool to run. 

```
 "C:\\Program Files\\Aimsun\\Aimsun Next 22\\aconsole.exe\ -script src\\TMGToolbox\\inputOutput\\importNetwork.py args"
```

The second way to run the custom tool is directly from XTMF.
You can find more information about the [Running custom Aimsun tools from XTMF](AimsunController.md)
by clicking on the link.