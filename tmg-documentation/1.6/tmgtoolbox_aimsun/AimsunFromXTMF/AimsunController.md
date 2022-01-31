# AimsunController

## Overview

The controller is the interface on the C# side to interact with 
the Aimsunbridge

## Protocol

AimsunController initates a pipe by which all signals and data 
are passed between the controller and AimsunBridge. It is the controller 
which initiates and builds the pipe. 

As discussed in the AimsunBridge documentation internal communication 
between the Controller and the AimsunBridge is done using integer signal 
commands where a specific integer corresponds to a specific action. 

Below are the steps of the general process: 
1. The XTMF calls the AimsunController and sends signals to 
AimsunBridge. 
1. Upon successful handshake, the controller passes the data to the 
bridge using the signal commands followed by the data payload in a json
format. 
1.The controller passes the following information
    1. Aimsun tool to run. Specifically the name of the tool
    1. Input data files e.g. csv file such as OD.csv 
    1. Filepath to network package file
    1. Name of the saved network (optional) 
1. Upon sending the data, the controller waits for the Aimsun bridge 
to return back a response of success or failure of the tool. 
1. The resulting information is then passed back to the XTMF accordingly

## Writing Custom Tools/Scripts 

The user may be required to either write their own custom Aimsun 
tools/scripts to be executed. If the user wishes to run the tool using 
XTMF simply follow the following steps:
1. Copy the path location of your tools into the Toolbox Default Directory
module as shown in Figure 1
1. AimsunController will now be able to detect your new tools and will be 
searchable using the new module. 

<figure>
    <img src="images\ToolBoxDirectoryPath.png"
         alt="ToolBox Directory Moule">
    <figcaption>Figure 1: ToolBoxDirectoryTool module path to the custom tool location</figcaption>
</figure>