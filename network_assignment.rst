Network Assignment (with Emme)
############################################################################################
The last stage of the 4-Step model is network assignment. XTMF provides the connectivity tools and modules
to to interface with EMME to perform network assignment.

Much of this last section is a general repeat (in fact, iteration) of some of the previous parts of trip distribution and mode choice. In general each iteration of network assignment calculates updated demand matrices for each
mode based on the previous iterations travel times. Over successive iterations, it as assumed that a balance will be
reached and the network assignment will approach equillibrium.

Modules that Iterate
------------------------------------------------------------------------------------------
The final parts of this model system are to find balance in the route assignment process. Begin by adding a child
module under the the Model System's *To Execute* module of type *Iteration*. Under the modules parameters, set "Execution Iterations" to 4. Execute in Parallel should be left as false. The iteration module allows sections
of the model system to be executed multiple times.

.. figure:: images/auto_mode_choice.png
   :scale: 50 %
   :align: center

   An iteration module.


Unloading Resources
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
For an iteration to be capable of computing new values, those resources calculated and loaded in previous steps must
first be unloaded. This is required because *Resources* are calculated only once whenever they are first accessed
by an executing module. The calculated value is persisted until either an unload occurs or another run has started.

Under the iteration module, add child modules to *Iteration Modules* of type Resource for each of the resources
that were used in the previous steps.

#. CostMatrixResource
#. GravityModel2DResource
#. AutoDemandResource
#. TransitDemandResource

Iterating Assignment
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
Under Iteration modules, simply copy and paste the **Execute Tools from Modeller Resource** module
into iteration modules' children. Under the *Tools* module, remove the module that imported
the "0" demand matrix. This will need to be replaced with the new auto and travel time matrices
that have been calculated.

Add a module of type *ImportBinaryMatrixIntoEmmme* for both the auto and travel demand matrices. Remember
to set unique matrix numbers for both demand matrices. Import into Scenario 11. The import modules
should exist just under the *Extra Attribute Context Manager* module.

.. figure:: images/import_auto_demand.png
   :scale: 50 %
   :align: center

   Model System with import matrix into EMME active.

For both transit and auto assignment, the *Class* modules need to have a value set to for "Time Matrix". This is the
matrix that will be exported for EMME and used as part of the calculation to prepare updated inputs for the
next iteration. Set a unique value to both auto and transit. Make sure the field / property "Demand Matrix" is
set to the same matrix number used in the demand matrix import modules.

There should already exist two modules for exporting the new time matrices. If the corresponding matrix numbers do not
match, update them to the correct values that match the ones just created. Update the type from *ExportMatrix...*
to *ExportBinaryMatrixFromEmme* to export an .mtx file that will be used in the cost matrix resource.

Updating Travel Demand
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
This section can simply re-use the modules designed in the trip distribution stage. Each
iteration begins by calculating new travel demand matrices based on the updated *cost* values
that were output in the previous steps. While most of the modules here are similar to those previously
made, there are still some changes. Instead of reading in a "0" demand matrix - we will use the demand
matrices calculated each iteration. At the end of each iteration assignment, the updated time matrices
will be exported from EMME and fed back into (iterated) the trip distribution calculations.

This step will require recreating a new *CostMatrixResource* that reads in the network assignment's new
travel time outputs. Create a new resource based on the previous Cost Matrix calculation and set the inputs (reader) to use the .mtx files created in the previous step with *ReadEmme4BinaryMatrix*.

Under the children of "Iteration Modules", add a new module *SaveAsCSVMatrix* that will output a new cost matrix
as a CSV file in the output directory. Simply use the same cost matrix resource already created.

Next, the gravity model needs to be updated. Again, create a module with type *SaveAsCSVResource* that uses the previously made gravity model resource.

With the gravity model calculation completed, finally follow up with two modules that create a new output of the
Transit demand and Auto demand resources.
