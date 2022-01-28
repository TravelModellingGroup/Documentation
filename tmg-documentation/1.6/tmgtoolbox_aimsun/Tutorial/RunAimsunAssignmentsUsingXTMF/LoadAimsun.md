# **Load Aimsun**

## Overview
In this tutorial we will launch Aimsun and connect it to XTMF using the module `TMG.Aimsun.LoadModellerController`.

## 1. Add the Module to Execute Aimsun Tools
* Step 1: Right-click on To Execute and select "Add Module" or Press "Ctrl"+"M"
* Search for the term "aimsun"
* Add "ExecuteToolsFromModellerResource" module to "To Execute"
* Note that it should read TMG.Aimsun.ExecuteToolsFromModellerResource. An equivalent one for EMMME also exists<br />

<figure>
    <img src="images/Image10.jpg"
         alt="ExecuteToolsFromModellerResource Module">
    <figcaption>Figure 1: ExecuteToolsFromModellerResource Module</figcaption>
</figure>

* Step 2: Double click on Aimsun Modeller
* Select "Tasha.Common.Resource" from the three available options. This is second in the box.
* This will result in a new attribute to appear called Data Source<br />

<figure>
    <img src="images/Image11.jpg"
         alt="Select ResourceLookup Module">
    <figcaption>Figure 2: Select ResourceLookup Module</figcaption>
</figure>

* Step 3: The model system should now look like this:
* You should now see a "Data Source" attribute now available

<figure>
    <img src="images/Image12.jpg"
         alt="Data Source Output Module">
    <figcaption>Figure 3: Data Source Output Module</figcaption>
</figure>

* Step 4: Right-click on "Data Source" and select "Set Module" or Press "Ctrl"+"M"
* Type LoadAimsunController to load the AimsunController<br />

<figure>
    <img src="images/Image13.jpg"
         alt="Enter Resource Name">
    <figcaption>Figure 4: Enter Resource Name</figcaption>
</figure>

* Step 5: Loading the AimsunController will result in three attributes to be displayed
    * **AimsunPath**: The directory where the Aimsun aconsole.exe is located. Typically on the C drive
    * **ProjectFile**: The directory where the network package .nwp file is located.
    * **ToolboxDefault Directory**: The directory where the Aimsun tools are located.

<figure>
    <img src="images/Image14.jpg"
         alt="Input path to AimsunController">
    <figcaption>Figure 5: Input path to AimsunController</figcaption>
</figure>

* Step 6: Right-click on "Aimsun Path" and select "Set Module" or Press "Ctrl"+"M"
* Click on "FilePathFromInputDirectory"

<figure>
    <img src="images/Image15.jpg"
         alt="FilePathFromInputDirectory Module">
    <figcaption>Figure 6: FilePathFromInputDirectory Module</figcaption>
</figure>

* Step 7: Add the path to the Aimsun aconsole.exe file path

<figure>
    <img src="images/Image16.jpg"
         alt="Aconsole path Module">
    <figcaption>Figure 7: Aconsole path Module</figcaption>
</figure>

* Step 8: Right-click on "Project File" and select "Set Module" or Press "Ctrl"+"M"
* Click on "FilePathFromInputDirectory"
* Copy and paste the path to the Project File folder as shown in the image

<figure>
    <img src="images/Image17.jpg"
         alt="ProjectFile Module">
    <figcaption>Figure 8: ProjectFile Module</figcaption>
</figure>

* Step 9: Right-click on "Toolbox Default Directory" and select "Set Module" or Press "Ctrl"+"M"
* Click on "FilePathFromInputDirectory"
* Copy and paste the path to the Toolbox Directory folder as shown in the image

<figure>
    <img src="images/Image18.jpg"
         alt="Toolbox Default Directory Module">
    <figcaption>Figure 9: Toolbox Default Directory Modules</figcaption>
</figure>