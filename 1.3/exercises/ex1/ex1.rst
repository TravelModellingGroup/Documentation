
Exercise 1
=====================================================================

1.1 - Create a Project
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Create New Project named Frabitztown

.. figure:: images/1.png
   :scale: 25 %
   :align: center



.. figure:: images/2.png
   :scale: 25 %
   :align: center

1.2 - Create a Model System
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Create New Model System name Exercise 2

.. figure:: images/3.png
   :scale: 25 %
   :align: center

.. figure:: images/4.png
   :scale: 25 %
   :align: center

.. figure:: images/5.png
   :scale: 25 %
   :align: center

1.3 - Create a Root Module
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Click on the root module and either press Ctrl+M or right click and select Set Module.
* Search for the module type “BasicTravelDemandModule”
* Double click on the Module type “BasicTravelDemandModel” or press “Enter”
* Press Shift+F2 or right click and select “Edit Description” and write down the description “Trip Generation”

.. figure:: images/6.png
   :scale: 25 %
   :align: center

.. figure:: images/7.png
   :scale: 25 %
   :align: center

.. figure:: images/8.png
   :scale: 25 %
   :align: center



•	Download Input from [insert link here] and extract them

1.4 - Setting the Base Directory
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
•	Set model system input base directory
*	Select the module named “Exercise 2”
*	Select parameter “Input Base Directory”
*	Set the value to the location of the input directory

.. figure:: images/9.png
   :scale: 25 %
   :align: center

1.5 - Setting the Population Resource
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Create the Population Resource
* Select the resources module
* Create Module of Type Resource
* Rename module to “Population”
* Change Parameter “Resource Name” to “Population”
* Change Data Source to ZoneInformation
* Change Reader to ReadOriginTextData
* Update Parameter “File Name” to “Population.csv”

.. figure:: images/10.png
   :scale: 25 %
   :align: center

.. figure:: images/11.png
   :scale: 25 %
   :align: center
   
.. figure:: images/12.png
   :scale: 25 %
   :align: center

.. figure:: images/13.png
   :scale: 25 %
   :align: center

.. figure:: images/14.png
   :scale: 25 %
   :align: center

.. figure:: images/15.png
   :scale: 25 %
   :align: center

.. figure:: images/16.png
   :scale: 25 %
   :align: center

.. figure:: images/17.png
   :scale: 25 %
   :align: center

.. figure:: images/18.png
   :scale: 25 %
   :align: center

•	Copy Population and Paste it to Resources
o	Click on the Population module and press Ctrl+C or right click and select “Copy”
o	Click on “Resources” and paste by pressing Ctrl+V or right click and selecting “Paste”
o	Click on the bottom Population and press F2 or right click and select “Rename”
o	Type in “WorkParticipation” and then press Enter.
o	Expand the module, and expand again the Data Source submodule
o	Select Reader
o	Change the parameter “File Name” to “WorkParticipationRate.csv”
•	Create Work Generation
o	Select Resources and add a new module by pressing Ctrl+M or by right clicking and selecting “Add Module”.
o	Select the type “Resource”
o	Rename the module “Work Generation”
o	Change the parameter “Resource Name” to “WorkGeneration”
o	Select sub-module Data Source.
o	Set the module type to VectorMath by pressing Ctrl+M or right clicking and selecting “Set Module”
o	Change the name of the module to “Compute Work Trips By Zone”
o	Select Data Sources
o	Add a new module by pressing Ctrl+M or right clicking and selecting “Add Module”
o	Search and select the type “RemoteDataSource`1” a second window will come up asking for the sub-type.  Search for and select the type “DataStructure.SparseArray`1”.  Another window will come up for the subtype of the SparseArray.  Now search and select the type “System.Single”.
o	Rename this module “Population”
o	Change the parameter “Resource Name” to “Population”
o	Copy Population and paste it into Compute Work Trips By Zone’s Data Sources.
o	Rename the second copy of Population to “WorkParticipation”
o	Change “WorkParticipations”’s parameter “Resource Name” to “WorkParticipation”
Update vector math:
	Set expression to population * work participation
•	Create Save Work Generation
o	Select To Execute and add a module of the type “SaveSparseArrayToCSV”
o	Select the created module and rename it to “Save Work Generation”
o	Expand the module and select Data.
o	Set the module type of Data to “ResourceLookup”
o	Change the parameter “Resource Name” to “WorkGeneration”
o	Select the module “Output To”
o	Set the module type of “Output To” to "FilePathFromOuputDirectory".
o	Change the value of the parameter “File From Output Directory” to “WorkGeneration.csv”
•	Create Zone System
o	Select the module named “Zone System”
o	Set the module type to “ZoneRetriever”
