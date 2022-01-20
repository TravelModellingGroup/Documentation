# **Tools**

## 1. Import the Aimsun Tools 

### 1. ImportNetwork 
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportNetwork" and add that module to the tool
![alt text](images/Image19.jpg "ImportNetwork Module")
<br />
<br />

* Step 2: Right click and on NetworkPackageFile and Add Module
* Click on "FilePathFromInputDirectory" and add that module
* ![alt text](images/Image20.jpg "ImportNetwork NetworkPackage File Module")
<br />
<br />
* Step 3 : Copy paste in the path to the network package nwp file location
* ![alt text](images/Image21.jpg "ImportNetwork NetworkPackage File Location")
<br />
<br />

### 2. ImportTransitNetwork
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportTransitNetwork" and add that module to the tool
![alt text](images/Image22.jpg "ImportTransitNetwork Module")
<br />
<br />
* Step 2: Right click and on NetworkPackageFile and click Add Module 
* Click on "FilePathFromInputDirectory" to add the module
* Copy the networkpackage directory to the page resulting in the output as shown in the screenshot below
* ![alt text](images/Image23.jpg "ImportTransitNetwork NetworkPackage File Module")

### 3. ImportPedestrian
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportPedestrian" and add that module to the tool
![alt text](images/Image24.jpg "ImportPedestrian Module")
<br />
<br />

* Note that for ImportPedestrian tool no further submodules are needed to be added as shown in the screnshot below
* ![alt text](images/Image25.jpg "Model Tree output")

### 3. ImportTransitSchedule
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportTransitSchedule" and add that module to the tool
![alt text](images/Image26.jpg "ImportTransitSchedule Module")
<br />
<br />
* Step 2: Right click and on NetworkPackageFile and Add Module
* Click on "FilePathFromInputDirectory" to add the module

* Step 3: Copy paste in the path to the network package nwp file location as shown in the screenshot below
* ![alt text](images/Image27.jpg "ImportTransitSchedule NetworkPackage File Location")
<br />
<br /> 
* Step 4: Right click and on ServiceTable CSV and Add Module
* Click on "FilePathFromInputDirectory" to add the module

* Step 5: Copy paste in the path to the service table csv file location as shown in the screenshot below
* ![alt text](images/Image28.jpg "ImportTransitSchedule servicetable csv File Location")
<br />
<br />

### 4. ImportMatrixFromCSVThirdNormalized
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "ImportMatrixFromCSVThirdNormalized" and add the module to the tool
![alt text](images/Image29.jpg "ImportMatrixFromCSVThirdNormalized Module")
<br />
<br />

* Step 2: Click on the ImportMatrixFromCSVThirdNormalized module and review and edit any of the paramters on the far right hand side

* Step 3: Right click and on ODCSV and Add Module
* Click on "FilePathFromInputDirectory" to add the module

* Step 4: Copy paste in the path to the ODCSV csv file location as shown in the screenshot below
![alt text](images/Image30.jpg "ImportMatrixFromCSVThirdNormalized ODCSV File Location")
<br />
<br /> 

* Step 5: Right click on Tools and add a second ImportMatrixFromCSVThirdNormalized tool
![alt text](images/Image31.jpg "ImportMatrixFromCSVThirdNormalized Module")

* Step 6: Adjust the parameters for the second ImportMatrix module. Change it to the following:
* CentroidConfiguration: ped_baseCentroidConfig
* MatrixID: transitOD
* VehicleType: transit 

![alt text](images/Image35.jpg "ImportMatrixFromCSVThirdNormalized ODCSV Module")


* Step 7: Copy and paste in the path to the ODCSV file and add in the AMTransit.csv file
![alt text](images/Image32.jpg "ImportMatrixFromCSVThirdNormalized ODCSV Module")

### 5. RoadAssignment
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "RoadAssignment" and add the module to the tool
![alt text](images/Image33.jpg "RoadAssignment Module")
<br />
<br />

### 6. TransitAssignment
* Step 1: Right-click on "Tools" and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "TransitAssignment" and add the module to the tool
![alt text](images/Image34.jpg "TransitAssignment Module")
<br />
<br />