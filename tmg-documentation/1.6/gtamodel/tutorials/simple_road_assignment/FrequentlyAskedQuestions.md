# **Frequently Asked Questions**

## Q1) A tool could not be found
![alt text](images/Slide52.jpg "A tool with the following namespace could not be found")<br />
You will need to add the TMG toolbox to the target Emme project: [How to Add TMG Toolbox?](https://tmg.utoronto.ca/doc/1.6/tmgtoolbox/index.html#adding-the-toolbox) <br />
Remember to save the project setting once you are done with the toolbox add-in. 
<br />
<br />

## Q2) Not enough room for extra attributes
![alt text](images/Slide53.jpg "Not enough room for extra attributes")<br />
<br />
You will need to increase the number of Extra Attribute Values in Emme Modeller:
![alt text](images/Slide54.jpg "Increase the number of Extra Attribute Values")<br />
<br />

## Q3) Matrix zones not compatible with scenario
![alt text](images/Slide55.jpg "Matrix zones not compatible with scenario")<br />
You will need to change the model system by adding and modifying modules in order to convert the matrix into your zone system.<br />
#### Step 1: Add a new module to the **Tools** under **To Execute**
![alt text](images/Slide56.jpg "Add a new module to the Tools under To Execute")<br />
#### Step 2: Move the new module up 
XTMF executes the modules in order, hence we need to convert the matrix before loading it into Emme.
![alt text](images/Slide57.jpg "Move the new module up")<br />
#### Step 3: Choose "Resource" for **Matrix To Save**, and "ConvertMatrixIntoZoneSystem" for **Data Source**
![alt text](images/Slide58.jpg "Data Source Modules")<br />
#### Step 4: Choose "LoadEMME4BinaryMatrixInMatrixZoneSystem" for **Source** and Enter the information for the *Matrix File* sub-module
![alt text](images/Slide59.jpg "Source Modules")<br />
#### Step 5: Specify the name of the converted matrix (e.g., *AMAuto_2.mtx*)
![alt text](images/Slide60.jpg "Output File")<br />
#### Step 6: Remember to change the *Matrix File* under **Extra Attribute Context Manager** module
This is to use the newly converted matrix instead of the original matrix. (Note: Enter the name of the newly converted matrix rather than choosing one since it does not exist yet.)
![alt text](images/Slide61.jpg "Change the Loaded Matrix")<br />


