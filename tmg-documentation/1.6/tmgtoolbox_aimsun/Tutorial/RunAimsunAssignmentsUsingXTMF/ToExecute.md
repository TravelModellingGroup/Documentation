# **Import and setup Aimsun**

## In this tutorial import and add the AimsunModeller Controller to run the Aimsun software.


## 1. Add the Module to Execute Aimsun Tools
* Step 1: Right-click on To Execute and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "aimsun"
* Add "ExecuteToolsFromModellerResource" module to "To Execute"
* Note that it should read TMG.Aimsun.ExecuteToolsFromModellerResource. An equivalent one for EMMME also exists<br />
![alt text](images/Image10.jpg "ExecuteToolsFromModellerResource Module")
<br />
<br />
* Step 2: Double click on Aimsun Modeller
* Select "Tasha.Common.Resource" from the three available options. This is second in the box.
* This will result in a new attribute to appear called Data Source<br />
![alt text](images/Image11.jpg "Select ResourceLookup Module")
<br />
<br />

* Step 3: The model system should now look like this:
* You should now see a "Data Source" attribute now available
![alt text](images/Image12.jpg "Output")
<br />
<br />

* Step 4: Right-click on "Data Source" and select "Set Module" or Press "Ctrl"+"M"
* Type LoadAimsunController to load the AimsunController<br />
![alt text](images/Image13.jpg "Enter the Resource Name")
<br />
<br />


* Step5: Loading the AimsunController will result in three attributes to be displayed
* AimsunPath: The directory where the Aimsun aconsole.exe is located. Typically on the C drive
* ProjectFile: The directory where the network package .nwp file is located.
* ToolboxDefault Directory: The directory where the Aimsun tools are located.
![alt text](images/Image14.jpg "ImportNetworkPackage Module")
<br />
<br />

* Step 6: Right-click on "Aimsun Path" and select "Set Module" or Press "Ctrl"+"M"
* Click on "FilePathFromInputDirectory"
![alt text](images/Image15.jpg "FilePathFromInputDirectory Module")
<br />
<br />

* Step 7: Add the path to the Aimsun aconsole.exe file path
![alt text](images/Image16.jpg "aconsole path Module")
<br />
<br />

* Step 8: Right-click on "Project File" and select "Set Module" or Press "Ctrl"+"M"
* Click on "FilePathFromInputDirectory"
* Copy and paste the path to the Project File folder as shown in the image
![alt text](images/Image17.jpg "ProjectFile Module")
<br />
<br />

* Step 9: Right-click on "Toolbox Default Directory" and select "Set Module" or Press "Ctrl"+"M"
* Click on "FilePathFromInputDirectory"
* Copy and paste the path to the Toolbox Directory folder as shown in the image
![alt text](images/Image18.jpg "Toolbox Default Directory Module")
<br />
<br />
