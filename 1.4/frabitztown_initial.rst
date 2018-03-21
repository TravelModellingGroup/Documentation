Initial Setup
=======================================================================================

This part of the XTMF documentation assumes that the provided Frabitztown input files have already
been downloaded and extracted.

EmploymentRate.csv
  A two-column CSV input file with the amount of attractions per zone.

Population.csv
  A two-column CSV input file listing the amount of trip productions per zone.

Zones.csv
  A multi-column CSV input file total zone data for the Frabitztown network.

ZeroDemandMatrix.311
  A simple .311 Emme matrix filled with all zero values.

EMME_TransitLine_Aggregation.csv
  Transit line aggregation file for Emme.

(Network Scenario Folder)
  Additional input required for Frabitztown.

(Frabitztown Network)
  Emme project and data bank for Frabitztown.

.. note::

    Frabitztown input files can be accessed at: http://tmg.utoronto.ca/documentation/1.4/frabitztown.zip


Creating the Project
----------------------------------------------------------------------
Once XTMF is opened click "New Project". Enter Frabitztown as the project name and press enter. When the project is created,
XTMF will automatically be redirected to the project page. The next step is to create a new :term:`model system` that will be contained
within the "Frabitztown" project.



.. thumbnail:: images/frabitztown_new_project.png
   :align: center

   Entering a name for a new project.


At the bottom of the project page, click the button that is labelled "Create New Blank Model System". Enter "Frabitztown" here again,
or another name of your choosing. Once you have chosen a name, click "OK" or press enter. A new model system will appear on the left
hand side of the project page. There will be a small disclaimer warning that the model system requires additional setup -- this indicates
that the model system is new and requires further setup to be in a runnable / complete state.


.. thumbnail:: images/frabitztown_create_model_system_1.png
  :width: 25%
  :group: modelsystem

  From the floating action menu, select the "Create new model system" option.

.. thumbnail:: images/frabitztown_create_model_system_2.png
  :width: 25%
  :group: modelsystem

  Enter "Frabitztown Model System" into the dialog input to name the model system.

.. thumbnail:: images/frabitztown_create_model_system_3.png
  :width: 25%
  :group: modelsystem

  The model system has been created, shown on the left hand side.



Starting the Frabitztown Model System Construction
====================================================================================
With the Frabitztown project open in XTMF, double click the new Frabitztown model system that was made in the previous step. XTMF will now open
the model system in a new tab / page.

.. thumbnail:: images/frabitztown_blank_model_system.png
   :align: center

   The open Frabitztown Model System - in the initial blank state.


Choosing the Root Module
------------------------------------------------------------------------------------
The Frabitztown demo model system will make use of a module bundled as part of the main XTMF distribution. The module that will be used is called ``BasicTravelDemandModel``. To make this the model system' root module, select and right click the cell with the description "The root of the model system" and choose
"Set Module" from the context menu. A small dialog window will appear initially with a large list of modules that can serve as a "root" of a model system. Modules cannot be placed arbitrarily into model systems - only valid modules can be put into their proper slots. The list of modules shown are all those loaded by XTMF
that can be the root of a model system. The filter text box can be used to quickly find the module being looked for. In this case, enter the first few characters of "BasicTravelDemandModel" to find it quickly. Double click the module to finally set it to the root of the model system.


.. thumbnail:: images/xtmf_000008.png
   :width: 25%
   :group: RootModule

   Root module context menu.

.. thumbnail:: images/xtmf_000009.png
   :width: 25%
   :group: RootModule

   Choosing ``BasicTravelDemandModel`` from the 'Select Module' window.


Once the module type is chosen, the model system display will contain new items in the grid view. The ``BasicTravelDemandModel`` defines as its children 4 sections
of modules.

.. thumbnail:: images/xtmf_000010.png
   :width: 50%
   :align: center

   The root of the Frabitztown model system - (with ``BasicTravelDemandModel`` set as the root
   module).

.. graph:: foo

   graph [rankdir=LR];
   "Basic Travel Demand Model"[shape=box];
   "Network Data"[shape=box];
   "To Execute"[shape=box];
   "Resources"[shape=box];
   "Basic Travel Demand Model" -- "Network Data";
   "Basic Travel Demand Model" -- "Resources";
   "Basic Travel Demand Model" -- "To Execute";
   "Basic Travel Demand Model" -- "Zone System";





Basic Travel Demand Model Modules
------------------------------------------------------------------------------

``Network Data``
	 An optional module, this can be left unassigned for the purpose of this guide.

``Resources``
	 A list of resources that can be shared for modules throughout the model system.

``To Execute``
	 A list of modules that will be executed with the model sytem is run.

``Zone System``
	 A module that loads in zonal data for the model syrstem. This information is sometimes required and referenced
	 from other modules.


Setting the Input Directory
-------------------------------------------------------------------------------------
Typically a relative input directory needs to be set for model systems. Specifying an input directory makes it easier to refer
to files that need to be read-in. To set the base input directory, click on the module with description "The root of the model system". The right hand
panel of the model system page will have option to specify the input directory to use as a base for this ``BasicTravelDemandModel``.

.. thumbnail:: images/xtmf_000021.png
   :width: 10%
   :group: inputgroup

   Choosing a base input directory from the root module parameter display.

.. thumbnail:: images/xtmf_000022.png
   :width: 10%
   :group: inputgroup

   Input base directory parameter highlighted.

.. thumbnail:: images/xtmf_000023.png
   :width: 10%
   :group: inputgroup

   Input base directory parameter highlighted.

.. thumbnail:: images/xtmf_000024.png
   :width: 10%
   :group: inputgroup

   Input base directory parameter highlighted.

.. thumbnail:: images/xtmf_000025.png
   :width: 10%
   :group: inputgroup

   Selecting the module ``ModellerControllerDataSource``.

.. thumbnail:: images/xtmf_000026.png
   :width: 10%
   :group: inputgroup

   Project Folder module highlighted.

.. thumbnail:: images/xtmf_000027.png
   :width: 10%
   :group: inputgroup

   Assigning a module type to Project Folder.

.. thumbnail:: images/xtmf_000028.png
   :width: 10%
   :group: inputgroup

   Selecting the ``FilePathFromInputDirectory module``.

.. thumbnail:: images/xtmf_000029.png
   :width: 10%
   :group: inputgroup

   Setting the input file parameter.


This location should be pointed to the directory that contains the input contents for the model system.

Specifying the Zone System
====================================================================================
The next step is to specify the zone system file for use in the ``BasicTravelDemandModel``. The last child of the root module labelled ``Zone System`` is used to read-in
the zone system that will be used. Included with the Frabitztown documentation files is a file 'Zones.csv' - this file will be loaded by this module for use in the
model system. Clicking on the module will display the parameters view on the right hand side of the XTMF interface. This module's default parameter configuration
is generally in a prepared form by default.

Input Files
-------------------------------------------------------------------------------------
Zones.csv
  A CSV file containing OD/ Zone information about the model system. Population, inner distance and other data items
  are contained within this file. This file also describes the total number of zones that exist in the model system.

The region file (child module of) of ``Zone System`` can be left blank for the purpose of the demo.

.. note::

   Zones.csv is required for modules that will be created later on in the model system. For instance, any modules
   that read OD (origin / destination) matrix data need to be aware of the zone system specifications.


Establishing a connection with Emme
=====================================================================================


Specify a resource name for the Resource module added in the previous step. This resource name will be required later when configuring the required modules to execute EMME.

.. thumbnail:: images/xtmf_000030.png
   :align: center
   :width: 25%
   :group: resourcename


The next part of the model system creation process is to establish a resource that manages XTMF's connection to Emme. To start, begin by adding a new child
module under the module labelled ``Resources``. To do this, right click (or press ctrl + m with the module highlighted) and select the option **Add Module** from
the context menu. The parent module ``Resources`` is considered a ``collection``. (ie: a module that can have multiple child modules). Select the child module just added to open
its list of parameters. Listed on the right is field called ``Resource Name``; enter a descriptive name as an identifier for this module.

Next, a data source needs to be chosen for this resource. Since we are working with Emme, we want to set the module to type ``ModellerControllerDataSource``. This module allows
XTMF to reference an Emme instance for use during the run process. Once the data source is chosen, the next step is to point the Emme resource to the correct
project (input folder). Insert a ``DirectorySeparatedPathFromInputDirectory`` module into the Project Folder slot. Point the first parameter ``DirectoryRelativeToInputDirectory`` to the relative path of your input directory. The file name should point to the Emme project that will be loaded. Here Frabitztown
is used for this guide.


Under the ``To Execute`` module, add a new child module with the type ``Execute Tools From Modeller Resource``. This allows us to begin calling tools that are defined
within Emme or any loaded toolbox. From resource indicates that we will use the Emme resource defined earlier under the "Resources" module. When the module is expanded, assign ``Resource Lookup`` to the Emme Modeller child module. Once added, assign the unique name entered previously as the Resource Name.

.. seealso::

   For more information regarding resources and their usage please see Working with Resources.


.. thumbnail:: images/xtmf_000031.png
   :width: 10%
   :group: modellerresource

   Adding a module under ``To Execute``

.. thumbnail:: images/xtmf_000032.png
   :width: 10%
   :group: modellerresource

   Adding a module under ``To Execute`` - context menu.

.. thumbnail:: images/xtmf_000033.png
   :width: 10%
   :group: modellerresource

   Choosing module type ``ExecuteToolsFromModellerResource`.

.. thumbnail:: images/xtmf_000034.png
   :width: 10%
   :group: modellerresource

   Selecting the module ``Emme Modeller``.

.. thumbnail:: images/xtmf_000035.png
   :width: 10%
   :group: modellerresource

   Choosing the ``Resource Lookup`` module type.

.. thumbnail:: images/xtmf_000036.png
   :width: 10%
   :group: modellerresource

   Selecting the ``Resource Lookup`` module and specifying the EMME resource in the parameter section (right hand side).

Importing the Frabitztown Network Package
----------------------------------------------------------------------------------------

Under the module ``Execute Tools from Modeller Resource``, add a new module of type ``Import Network Package``. Under its child ``Network Package`` module, choose 
a module of type ``FilePathFromInputDirectory`` and direct the input path to the location of the Frabitztown network package which was downloaded.

.. thumbnail:: images/xtmf_000037.png
   :width: 25%
   :group: modellerresource
   :align: center

   Importing the Frabiztown Network Package into the active EMME project.