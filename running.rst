Running Model Systems
####################################################
Understanding Runs
=====================================================================================
In previous versions of XTMF model system runs were launched in a separate tab page in the XTMF interface. XTMF 1.3 migrates the run information into a dock-able pane apart of the main interface. It is now easier to flip between active tabs, projects and model systems while still being able to observe the active run.

A new run can be started by first opening the model system you wish to use. Next, XTMF provides two shortcuts to start the run process: Keypress F5 or simply click the “Run Model System” button located above the model system tree view.

Once a new run has been initiated, a user prompt will be displayed asking to enter a name for the new run. Each run’s name is associated with the file location / folder name inside of the project directory. Due to this design, run names are considered unique and previous output data can be corrupted if careful attention is not paid in choosing a suitable name. In the case a run name already exists, XTMF will ask for further instruction in whether or not to delete the previous run’s output. Choosing no at the message box prompt will continue the run, however there will be no explicit deletion of previous data existing in the output folder.

If the model system being run has any disabled modules, a small reminder is displayed as part of the run name input dialog. This can serve as a useful reminder if the user was unaware that certain modules are currently disabled.

Once a run has started, the “Model System Run” pane will be present at the bottom of the XTMF window. The run pane contains various crucial information related to the run progress. On the left hand side, information regarding elapsed time and progress information is layed out. The progress bar percented is calculated based on the total amount of modules within the model system that have finished executing.  On the right, an area for output is displayed. This console will output any debug or information printed by modules.


Requirement Checks
-------------------------------------------------------------------------------------------
Before a run can be successfuly started, XTMF implements a requirements check on the modules that are
present in the current model system. These checks will scan for missing requirements that modules may have
declared. For example if a module requires a type definition, then the model system will be unable to run.


Run Completion and Output
----------------------------------------------------------------------------------
The current run’s output can be found by clicking the “Open Run Output” button at the top of the run pane. This action launches the file system explorer at the output location. Clicking “Cancel Run” will begin cancellation of the current run. Depending on which module is currently active (or how it is designed), cancellation may not be immediate. When a run has completed, previous output information can be cleared by pressing “Clear Run Display.

Run Errors
====================================================================================
If an error occurs during the model system execution, a dialog will be shown to the user indicating
what module or section of the model system the error occured. Often times there are problems that cannot
be tested for before running and will only become apparent once model system running has started.

The output window contains line numbers for both the XTMF module and possible modules of python tools that may be called.

Error Logs
-------------------------------------------------------------------------------
In the event that an error occurs during a model system run, in addition to a dialog window being presented,
XTMF will output error details to file **XTMF.error.log** in the active run directory.
