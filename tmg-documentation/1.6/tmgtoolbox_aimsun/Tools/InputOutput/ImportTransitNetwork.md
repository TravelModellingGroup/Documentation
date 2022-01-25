
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

As shown in the Figure 1 below, ImportTransitNetwork contains one inner 
submodule called NetworkPackageFile highlighted with the bottom left red box.
On the right hand side we see the red box on the top right side of the page where user 
is responsbile for pasting in the file path to the network package file (.nwp). 

<figure>
    <img src="images/ImportTransitNetworkParameters.jpg"
         alt="ImportTransitNetwork SubModules">
    <figcaption>Figure 1: ImportTransitNetwork Tool with submodules and 
                location of module paramters. 
    </figcaption>
</figure>