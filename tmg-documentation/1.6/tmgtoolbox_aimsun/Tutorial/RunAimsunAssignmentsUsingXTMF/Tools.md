# **Tools**

## Overview

In this tutorial we build a network. At the end of this tutorial all tools will be successfully imported

### 1. ImportNetwork 

* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportNetwork" and add that module to the tool

<figure>
    <img src="images/Image19.jpg"
         alt="ImportNetwork Module">
    <figcaption>Figure 1: ImportNetwork Module</figcaption>
</figure>

* Step 2: Right click and on NetworkPackageFile and Add Module
* Click on "FilePathFromInputDirectory" and add that module

<figure>
    <img src="images/Image20.jpg"
         alt="ImportNetwork NetworkPackage File Module">
    <figcaption>Figure 2: ImportNetwork NetworkPackage File Module</figcaption>
</figure>

* Step 3: Copy paste in the path to the network package nwp file location

<figure>
    <img src="images/Image21.jpg"
         alt="ImportNetwork NetworkPackage File Location">
    <figcaption>Figure 3: ImportNetwork NetworkPackage File Location</figcaption>
</figure>

### 2. ImportTransitNetwork
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportTransitNetwork" and add that module to the tool

<figure>
    <img src="images/Image22.jpg"
         alt="ImportTransitNetwork Module">
    <figcaption>Figure 4: ImportTransitNetwork Module</figcaption>
</figure>

* Step 2: Right click and on NetworkPackageFile and click Add Module 
* Click on "FilePathFromInputDirectory" to add the module
* Copy the networkpackage directory to the page resulting in the output as shown in the screenshot below

<figure>
    <img src="images/Image23.jpg"
         alt="ImportTransitNetwork NetworkPackage File Module">
    <figcaption>Figure 5: ImportTransitNetwork NetworkPackage File Module</figcaption>
</figure>

### 3. ImportPedestrian
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportPedestrian" and add that module to the tool

<figure>
    <img src="images/Image24.jpg"
         alt="ImportPedestrian Module">
    <figcaption>Figure 6: ImportPedestrian Module</figcaption>
</figure>

** Note that for ImportPedestrian tool no further submodules are needed to be added as shown in the screnshot below

<figure>
    <img src="images/Image25.jpg"
         alt="ImportPedestrian Model Tree output">
    <figcaption>Figure 7: ImportPedestrian model tree output</figcaption>
</figure>

### 3. ImportTransitSchedule
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportTransitSchedule" and add that module to the tool

<figure>
    <img src="images/Image26.jpg"
         alt="ImportTransitSchedule Module">
    <figcaption>Figure 8: ImportTransitSchedule Module</figcaption>
</figure>

* Step 2: Right click and on NetworkPackageFile and Add Module
* Click on "FilePathFromInputDirectory" to add the module
* Step 3: Copy paste in the path to the network package nwp file location as shown in the screenshot below

<figure>
    <img src="images/Image27.jpg"
         alt="ImportTransitSchedule NetworkPackage File Location">
    <figcaption>Figure 9: ImportTransitSchedule NetworkPackage File Location</figcaption>
</figure>

* Step 4: Right click and on ServiceTable CSV and Add Module
* Click on "FilePathFromInputDirectory" to add the module
* Step 5: Copy paste in the path to the service table csv file location as shown in the screenshot below

<figure>
    <img src="images/Image28.jpg"
         alt="ImportTransitSchedule servicetable csv File Location">
    <figcaption>Figure 10: ImportTransitSchedule servicetable csv File Location</figcaption>
</figure>

### 4. ImportMatrixFromCSVThirdNormalized
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportMatrixFromCSVThirdNormalized" and add the module to the tool

<figure>
    <img src="images/Image29.jpg"
         alt="ImportMatrixFromCSVThirdNormalized Module">
    <figcaption>Figure 11: ImportMatrixFromCSVThirdNormalized Module</figcaption>
</figure>

* Step 2: Click on the ImportMatrixFromCSVThirdNormalized module and review and edit any of the paramters on the far right hand side
* Step 3: Right click and on ODCSV and Add Module
* Click on "FilePathFromInputDirectory" to add the module
* Step 4: Copy paste in the path to the ODCSV csv file location as shown in the screenshot below

<figure>
    <img src="images/Image30.jpg"
         alt="ImportMatrixFromCSVThirdNormalized ODCSV File Location">
    <figcaption>Figure 12: ImportMatrixFromCSVThirdNormalized ODCSV File Location</figcaption>
</figure>

* Step 5: Right click on Tools and add a second ImportMatrixFromCSVThirdNormalized tool

<figure>
    <img src="images/Image31.jpg"
         alt="ImportMatrixFromCSVThirdNormalized Module">
    <figcaption>Figure 13: ImportMatrixFromCSVThirdNormalized Module</figcaption>
</figure>

* Step 6: Adjust the parameters for the second ImportMatrix module. Change it to the following:
    * CentroidConfiguration: ped_baseCentroidConfig
    * MatrixID: transitOD
    * VehicleType: transit 

<figure>
    <img src="images/Image35.jpg"
         alt="ImportMatrixFromCSVThirdNormalized ODCSV Module">
    <figcaption>Figure 14: ImportMatrixFromCSVThirdNormalized ODCSV Module</figcaption>
</figure>

* Step 7: Copy and paste in the path to the ODCSV file and add in the AMTransit.csv file

<figure>
    <img src="images/Image32.jpg"
         alt="ImportMatrixFromCSVThirdNormalized ODCSV Module">
    <figcaption>Figure 15: ImportMatrixFromCSVThirdNormalized ODCSV Module</figcaption>
</figure>

### 5. RoadAssignment
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "RoadAssignment" and add the module to the tool

<figure>
    <img src="images/Image33.jpg"
         alt="RoadAssignment Module">
    <figcaption>Figure 16: RoadAssignment Module</figcaption>
</figure>

### 6. TransitAssignment
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "TransitAssignment" and add the module to the tool

<figure>
    <img src="images/Image34.jpg"
         alt="TransitAssignment Module">
    <figcaption>Figure 17: TransitAssignment Module</figcaption>
</figure>