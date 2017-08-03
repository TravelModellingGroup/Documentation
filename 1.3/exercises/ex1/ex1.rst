
Exercise 1
=====================================================================

1.1 - Create a Project
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Create New Project named Frabitztown

.. thumbnail:: images/1.png
   :align: center
   :width: 25%
   :class: tbclass
   :group: 1

.. thumbnail:: images/2.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 1

1.2 - Create a Model System
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Create New Model System name Exercise 2

.. thumbnail:: images/3.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 2

.. thumbnail:: images/4.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 2

.. thumbnail:: images/5.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 2

1.3 - Create a Root Module
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Click on the root module and either press Ctrl+M or right click and select Set Module.
* Search for the module type “BasicTravelDemandModule”
* Double click on the Module type “BasicTravelDemandModel” or press “Enter”
* Press Shift+F2 or right click and select “Edit Description” and write down the description “Trip Generation”

.. thumbnail:: images/6.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 3

.. thumbnail:: images/7.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 3

.. thumbnail:: images/8.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 3



•	Download Input from [insert link here] and extract them

1.4 - Setting the Base Directory
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
•	Set model system input base directory
*	Select the module named “Exercise 2”
*	Select parameter “Input Base Directory”
*	Set the value to the location of the input directory

.. thumbnail:: images/9.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 4

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

.. thumbnail:: images/10.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5

.. thumbnail:: images/11.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5
   
.. thumbnail:: images/12.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5

.. thumbnail:: images/13.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5

.. thumbnail:: images/14.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5

.. thumbnail:: images/15.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5

.. thumbnail:: images/16.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5

.. thumbnail:: images/17.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5

.. thumbnail:: images/18.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 5

1.5 - Copy the Population Resource
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Click on the Population module and press Ctrl+C or right click and select “Copy”
* Click on “Resources” and paste by pressing Ctrl+V or right click and selecting “Paste”
* Click on the bottom Population and press F2 or right click and select “Rename”
* Type in “WorkParticipation” and then press Enter.
* Expand the module, and expand again the Data Source submodule
* Select Reader
* Change the parameter “File Name” to “WorkParticipationRate.csv”
* Click on the Population module and press Ctrl+C or right click and select “Copy”
* Click on “Resources” and paste by pressing Ctrl+V or right click and selecting “Paste”
* Click on last Population and press F2 or right click and select “Rename”
* Type in “EmploymentRate” and then press Enter.
* Expand the module, and expand again the Data Source submodule
* Select Reader
* Change the parameter “File Name” to “EmploymentRate.csv”

.. thumbnail:: images/19.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 6

.. thumbnail:: images/20.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 6


.. thumbnail:: images/21.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 6


.. thumbnail:: images/43.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 6


.. thumbnail:: images/44.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 6


.. thumbnail:: images/45.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 6

.. thumbnail:: images/46.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 6

.. thumbnail:: images/47.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 6

1.7 - Create Work Generation
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Select Resources and add a new module by pressing Ctrl+M or by right clicking and selecting “Add Module”.
* Select the type “Resource”
* Rename the module “Work Generation”
* Change the parameter “Resource Name” to “WorkGeneration”
* Select sub-module Data Source.
* Set the module type to VectorMath by pressing Ctrl+M or right clicking and selecting “Set Module”
* Change the name of the module to “Compute Work Trips By Zone”
* Select Data Sources
* Add a new module by pressing Ctrl+M or right clicking and selecting “Add Module”
* Search and select the type “RemoteDataSource`1” a second window will come up asking for the sub-type.  Search for and select the type “DataStructure.SparseArray`1”.  Another window will come up for the subtype of the SparseArray.  Now search and select the type “System.Single”.
* Rename this module “Population”
* Change the parameter “Resource Name” to “Population”
* Copy Population and paste it into Compute Work Trips By Zone’s Data Sources.
* Rename the second copy of Population to “WorkParticipation”
* Change “WorkParticipations”’s parameter “Resource Name” to “WorkParticipation”
* Copy Population and paste it into Compute Work Trips By Zone’s Data Sources.
* Rename the second copy of Population to EmploymentRate
* Change “EmploymentRate”’s parameter “Resource Name” to EmploymentRate

.. thumbnail:: images/22.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/23.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/24.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/25.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/26.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/27.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/28.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/29.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/30.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/31.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/32.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/33.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/34.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/35.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/36.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/37.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/38.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/39.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/40.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/41.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/42.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

.. thumbnail:: images/49.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 7

1.8 Calculate Work Generation Expression
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

* Select the module 'Compute Work Trips By Zone'
* Set expression to `Population * WorkParticipation * EmploymentRate`

.. thumbnail:: images/48.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 8


1.9 Create Save Work Generation
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
* Select To Execute and add a module of the type “SaveSparseArrayToCSV”
* Select the created module and rename it to “Save Work Generation”
* Expand the module and select Data.
* Set the module type of Data to “ResourceLookup”
* Change the parameter “Resource Name” to “WorkGeneration”
* Select the module “Output To”
* Set the module type of “Output To” to "FilePathFromOuputDirectory".
* Change the value of the parameter “File From Output Directory” to “WorkGeneration.csv”
* Create Zone System
* Select the module named “Zone System”
* Set the module type to “ZoneRetriever”

.. thumbnail:: images/51.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/52.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/53.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/54.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/55.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/56.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/57.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/58.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/59.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/60.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/61.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9

.. thumbnail:: images/62.png
   :width:  25%
   :align: center
   :class: tbclass
   :group: 9