# Model Systems

## Overview

### Importing a Model System

For users of XTMF one of the first things that you are going to do after loading XTMF for the first time is loading your first model system created by your model system designer.  To import a model system, click the hamburger menu in the top left and
choose the option "import a model system" from the floating menu list in the bottom right. 

### Creating a Model System

If there is no existing model system that can be imported - a new blank one can be created from an open Project page. To create one, click "Create Model System" button
at the bottom of the Project page. A prompt will appear requesting a name to given to the model system. You can access a specific project page by opening one (or creating one) using the global
XTMF menu.

### Cloning Model Systems

Before you edit a model system it can be helpful to create a copy (clone) of it to ensure you have a backup.  In order to do this, from the project screen right click on the model system and select ‘Copy Model System’.
The copied model system will have standard clipboard behaviour. Once copied, you can press Ctrl +V (or right click and select ‘Paste Model System’) to clone it into the active project. When pasting (cloning),
 you will be asked to assign a name to the new clone of the model system.
Model system cloning is available across projects. You can copy / paste (clone) a model system into any other active project in XTMF.

## Basic Model System Editing

Learning to edit a model system is one of the most fundamental skills when using XTMF.  It will allow you to tune your model system to behave however you would like it to instead of being forced into a static system.  Model systems can be edited both as a free model system or one contained within a project.

The model system editing screen is divided into two parts.  On the left hand side is a graphic representation of the model system.  Each button represents a module in the model system where its name and description are contained in the text.  On the right hand side are the parameters for the currently selected module.  In our image a list has been selected (lists will be described below) so there are no parameters for this structure.

Since XTMF 1.1, you now have to manually save a model system.  This will no longer happen automatically.  You can either press ‘Ctrl+S’ or use the menu by selecting File and then ‘Save’.

You are also now able to have multiple editing windows for the same model system by either opening the model system from the project screen again or opening the model system twice.  This can be extremely useful to avoid scrolling when copying parameters or modules between different sections is large model systems.  Both windows will be editing the same model system and all settings are synchronized between both windows so saving either window will work.  In addition, you will not be prompted when closing a window to save your changes if there is still another window keeping the session open.

You can now also filter modules and parameters.  When you filter modules you will get an expanded tree to the modules that match your criteria.  You can then further explore into those modules.  Modules that do not fit that description will be filtered out.  Pressing Escape will cancel the filter.  The same process occurs for parameters.

### Viewing an Overview of the Model System

XTMF 1.3 adds a new tab to the model system display. Any disabled modules part of your model system will be itemized under the Model System Information tab. This tab provides a useful way to quickly check what modules are disabled before your next run. Beside the module name, a link is provided to quickly re-enable the module without having to navigate the model system tree.

## Modules

Modules can have sub modules that customize the behaviour of the parent.  These submodules can either be a single module or optionally a list of modules.

In XTMF GUI 1.4 lists of modules are represented by the   icon.  Lists can contain any number of modules including zero.  If a module’s border is green, it is optional but not currently filled out.  If a module has a red background with an (!), then it is a required module where none is currently selected for.  XTMF will not allow a model system to run if a required module has not been filled out.

In the example image we have a small model system that was previously made that has a zone system and loads up INRO’s EMME software using their Modeller interface using TMG’s Modeller Bridge.  From this point we can start adding in modules to automate EMME during the run.

If you right click on Tools you will be prompted with a list of the possible modules that can be used.  Double click on any module to add it to the currently selected position.   In this case we selected a module that will export a matrix from EMME.

### Creating a Meta-Module

To create a Meta module right click on the module and select Meta-Module then click on [Convert To].

Now that the meta-module has been created an extra parameter is added to the list, allowing you to select what file to load.  Since this process can have very similar parameter names another feature was added allowing you to change them.


### Changing Module names and Descriptions

Pressing F2 while a module is highlighted allows the user to rename the module. In some cases modules are required to be renamed for use in ODMath. Module descriptions can be added by pressing shift + f2 (or through the context menu) on a selected module.



Parameters
-------------------------------------------------------------------------
Most modules that are present in XTMF expose parameters to the end user that can be changed from the interface. Parameters allow the user to customize and control
how modules execute during a model system run.

Typically, when a model system designer has given you a new model system instead of editing the model system you will instead be changing some of the parameters.

In this case we have selected the ‘Zone System’ module and have right clicked on the ‘Zone Cache File’ parameter. This will bring up a context menu that provides a number of different operations. From here we can copy the parameter’s name, select a file as the value of this parameter, or even open up the parameter if it is a file from the input directory. In addition, this will let you set the parameter as part of a linked parameter. You can of course change the text in the textbox to change the value of the parameter. Remember to save your changes or they will be discarded when the model system editing session has been closed. A dialog will warn you if you are going to close the model system session without saving.


### Changing Parameter Names

To change a parameters name right click on the parameter can select Rename.  Once you’ve done this you will get a rename adorner in which you can change the name of the parameter.  Parameters need to have a name that has non-whitespace characters.

### Using Quick Parameters

Quick parameters provide an easy way to access the parameters that will be changed the most often.  Each parameter has a check box in the top left corner, in this image highlighted by the gold square.  If it is checked then this parameter will be added to the list of Quick Parameters.

You can access the list of quick parameters by clicking on the Quick Parameter tab, or by pressing ‘Ctrl+Q’.  In the image the quick parameter tab is highlighted by the gold rectangle on the right hand side.


### Using Linked Parameters

Linked Parameters are sets of parameters that have been linked together to share the same value.  The benefit of having this is immense for large model systems.  It also makes things easier when using the Multi-run framework as it allows you to specify linked parameters for editing during a run.  You can access linked parameters by right clicking on a parameter or by pressing (Ctrl+L).

To create a new linked parameter press the button in the bottom right corner.

In this example we have created a new linked parameter called ‘Test Linked Parameter’.  You can edit the value for the linked parameter in the bottom left text box.
Once you have the value you want for your parameter press enter or double click on the linked parameter to add the currently selected parameter to the linked parameter set.

After you’ve added your parameter to the linked parameter that linked parameter will be added to the recent linked parameter list.  You can quickly add another parameter to this linked parameter by selecting it through the parameter context menu.

You can always use the full dialog to add a parameter to a linked parameter by selecting the linked parameter and pressing enter or double clicking on it.
