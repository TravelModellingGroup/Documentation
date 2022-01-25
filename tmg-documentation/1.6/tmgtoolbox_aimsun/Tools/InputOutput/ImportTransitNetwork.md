
# ImportTransitNetwork

## Overview 

ImportTransitNetwork tool is responsible for desiging the transit component of the network model.
ImportTransitNetwork generates the following: 
* imports the transit vehicles and adds vehicle and transit bus stops 
* build the transit lines 
* Add bus transit stops across the transit lines
* build the walking transfer points between bus stops



## Parameters

There is only one parameter the user has to input which is the following:
* **Network Package File**: The file path to the location where the .nwp file is stored on your machine. 


## In XTMF

As shown in the figures below the Network Package File is a separate inner module and an example of the file path on the right hand side

<figure>
    <img src="images/ImportTransitNetworkParameters.jpg"
         alt="ImportTransitNetwork SubModules">
    <figcaption>Figure 1: Submodules of ImportTransitNetwork along with example image of the network package file path written in the module parameter box</figcaption>
</figure>