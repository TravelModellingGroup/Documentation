# **To Execute**

## 1. Add the Module to Execute Standard/TMG Emme Tools
* Step 1: Add "ExecuteToolsFromModellerResource" module to "To Execute"<br />
![alt text](images/Slide27.jpg "ExecuteToolsFromModellerResource Module")
<br />
* Step 2: Select “ResourceLookup” for **Emme Modeller** module<br />
![alt text](images/Slide28.jpg "Select ResourceLookup Module")
<br />
* Step 3: Enter the same name as the *Resource Name* of the target Emme Project file loaded before (i.e., "Emme Project")<br />
![alt text](images/Slide29.jpg "Enter the Resource Name")
<br />
<br />

## 2. Import Network Package
* Step 1: Add "ImportNetworkPackage" module to **Tools**<br />
![alt text](images/Slide30.jpg "ImportNetworkPackage Module")
<br />
* Step 2: Enter the parameter values of the *Import Network Package* module.<br/>(Note: Values below are examples only, you may customize any field.)<br/>
![alt text](images/Slide31.jpg "Parameter values of the module")
<br />
* Step 3: Choose "FilePathFromOutputDirectory" for **Network Package** module<br />
![alt text](images/Slide32.jpg "FilePathFromOutputDirectory Module")
<br />
* Step 4: Select the *Network Package file* (*.nwp) to load into the target Emme project file for use<br />
![alt text](images/Slide33.jpg "Select the Network Package file")
<br />
<br />

## 3. Load Attributes for Road Assignment
* Step 1: Add a new "ExtraAttributeContextManager" module to **Tools**, and customize the module parameters.<br />
![alt text](images/Slide34.jpg "ExtraAttributeContextManager Module")
<br />
* Step 2: Add the extra attributes to *Attribute To Create** module<br />
![alt text](images/Slide35.jpg "Add the extra attributes")
<br />
* Step 3: Add the following tools to **Emme Tools To Run** module (the tools will be executed in order): <br />
![alt text](images/Slide36.jpg "Add the tools")
  1. Calc407Tolls (Calculate 407 Tolls)
  ![alt text](images/Slide37.jpg "Calc407Tolls")
  2. ImportBinaryMatrixIntoEmme (Import Demand Matrix)
  ![alt text](images/Slide38.jpg "ImportBinaryMatrixIntoEmme")
  3. TollAttributeRoadAssignment (Road Assignment Settings)
  ![alt text](images/Slide39.jpg "TollAttributeRoadAssignment")
  4. ExportBinaryMatrixFromEmme (Export Auto Travel Cost Matrix)
  ![alt text](images/Slide40.jpg "Export ACOST Matrix")
  5. ExportBinaryMatrixFromEmme (Export Auto Travel Time Matrix)
  ![alt text](images/Slide41.jpg "Export AIVTT Matrix")



