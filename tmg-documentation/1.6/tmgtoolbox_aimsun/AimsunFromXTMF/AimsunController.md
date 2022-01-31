# AimsunController

## Overview

AimsunController is the interface on the C# side to interact with 
the AimsunBridge.

## Protocol

AimsunController initates a pipe by which all signals and data 
are passed between the controller and AimsunBridge.

As discussed in the AimsunBridge documentation internal communication 
between the AimsunController and the AimsunBridge is done using integer 
signal commands where a specific integer corresponds to a specific action. 

Below are the steps of the general process: 
1. AimsunController opens a pipe to the AimsunBridge.
1. Upon confirmation pipe is successfully open, 
AimsunController sends a SignalCommand.
1. Upon confimration that Signal was properly received, AimsunController
sends the data as a json payload execute the tool. 
1. AimsunController waits for the AimsunBridge to execute the tool.
1. AimsunController reports back to user any failures and errors of the tool
not properly executing. 

## Writing Custom Tools/Scripts 

The user may be required to either write their own custom Aimsun 
tools/scripts to be executed. If the user wishes to run the tool using 
XTMF follow the following steps:
1. Copy the path location of your custom tool directory into the 
Toolbox Default Directory module as shown in Figure 1.
1. XTMF will now detect your custom tools. 

<figure>
    <img src="images\ToolBoxDirectoryPath.png"
         alt="ToolBox Directory Moule">
    <figcaption>Figure 1: ToolBoxDirectoryTool module path to the custom tool location</figcaption>
</figure>