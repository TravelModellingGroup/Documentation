Extracting Data from Emme
##############################################################################################

Now that the model system has completed running, some further steps might involve exporting some of the data
that Emme has calculated. This last section of the Frabitztown guide goes over the final steps and extracting
the data from Emme into a more interchangeable / usable format.

As in the previous steps, interacting with Emme requires the model system to add another ``Execute Tools from Modeller Resource`` module. Add one more module of this type under the main ``To Execute`` modules that are part of the root
model system. Make sure this module is not a child module of the previous ``Iteration`` module. Again, make sure the
modeller resource has the correct resource name entered.

Return Transit Boardings
------------------------------------------------------------------------------------
Under the ``Tools`` module list, add a new module of type ``Return Boardings Multiclass``. Although there is only
a single class, the multiclass export "return" tool can still be used. Set the parameter ``Scenario Number`` to
11, the same as the previous steps. Set the ``Line Aggregation File`` as ``FilePathFromInputDirectory``, and set
the file path to *EMME_TransitLine_Aggregation.csv*.

.. topic:: Note

   *EMME_TransitLine_Aggregation.csv* is provided with the Frabitztown input files.

Under ``Save to Directory``, set it's type to ``FilePathFromOutputDirectory`` and set the file path to *TransitBoarings*. This module creates a directory with contents that contain the boardings for each of the defined
classes (as CSVs).

Export Traffic Assignments
------------------------------------------------------------------------------------------
Under the ``Tools`` module list, add a module of type ``ExportCountpostResults``. Set the scenario to 11, and leave
the other parameters as their default values. Set ``Save To`` to type ``FilePathFromOutputDirectory``, and choose
the file name as *CountpostResults.csv*, or another suitable name of your choosing.
