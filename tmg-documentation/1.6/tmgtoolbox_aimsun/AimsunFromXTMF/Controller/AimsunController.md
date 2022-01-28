# AimsunController

## Overview

The AimsunController is the main system that controls Aimsun by 
interacting with AimsunBridge. 

AimsunController initates a pipe through which all data is passed between
the controller and AimsunBridge. 

The generic steps are the following: 
1. The XTMF GUI calls the AimsunController and sends signals to 
AimsunBridge. 
1. Upon successful handshake, the controller passes the data to the bridg. 
1.The controller passes the following information
    1. toolname to run 
    1. input data files e.g. csv file such as OD.csv 
    1. filepath to network package file
    1. Name of saved network (optional) 
1. Upoin sending the data, the controller waits for the Aimsun bridge 
to return back a reponse of success or failure of the tool.