Getting Familiar with XTMF
===================================================================


The XTMF Interface
---------------------------------------------------------

XTMF 1.3 in its most basic form functions as a single window user experience. The interface allows the user
to work with projects and model systems which is the underlying format of the XTMF work-flow. Multiple model systems
and projects can be active at the same time.


Main Menu
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

At the top of the main XTMF window is the menu bar. Operations for new projects and model systems can be
found under the file menu.

File Menu
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
The File Menu provides options to create new model systems and projects, opening model systems and projects,
saving functionality, updating and options to close the XTMF application.

Edit Menu
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
The edit menu provides options for undo / redo when a model system is open. The run

Run Menu
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
The run menu provides options for starting a  model system run or the option to launch a remote client.

View Menu
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
The view menu provides options to relaunch tabs or windows that might have been closed recently, such as the
start page or settings page. If a run is currently active, an option is provided to re-display the run pane
if it had been previously closed.

Help Menu
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
The help menu provides options to retrieve details about the currently running version of XTMF as well as
providing a link to documentation for all of the currently active / installed modules.

Start Window
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Projects are designed to help organize your work-flow within XTMF.  Projects contain multiple model systems and provide logical grouping of model system runs.  In order to run a model system, it must also contained within a project.

After you have selected ‘Create a new project’ you will be prompted to enter a name.
Project names do have some restrictions. The name entry dialog will inform you if the name entered is invalid.

Otherwise you can just press Enter or click on the button ‘OK’ to create the new project.  Once project creation is completed, the interface will automatically navigate to the newly created project page.

Help Window
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^




XTMF Settings
----------------------------------------------------------


Working with Multiple XTMF Installations
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
In most cases you will only have a single installation of XTMF.  There are cases when people want more than one installation of XTMF.  Normally each user on a given machine will have their own unique configuration unless a local XTMF configuration is saved in the XTMF’s installation directory.  In order to do this, you will need to create a configuration file called ‘LocalXTMFConfiguration.xml’ in the root of the installation directory.  If this is detected XTMF will prioritize this configuration over the standard user configuration location.  Doing this requires that the user have access to the installation directory.

XTMF 1.3 added the ability to create a local configuration from the settings page. After creating a local configuration, the application will reload under the new context. The settings page provides information about which configuration file is being used by XTMF. In the event a local configuration exists, an option is provided to remove the occurrence and revert to the shared XTMF configuration. The local configuration will be created under the name ‘Configuration.xml’.

Changing the Look and Feel of XTMF
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
Version 1.3 of XTMF offers the ability for users to change the appearance of their XTMF interface. Bundled with XTMF are 4 different colour schemes to choose from: Light Theme (default), Dark Theme, Forest Theme and Warm Theme. Appearances are set on the XTMF settings page.

The XTMF is set locally for the active configuration of the XTMF instance.

Creating Interface Customizations
---------------------------------------------------------
XTMF provides basic support for the ability to skin and customize the user interface. The appendix includes a reference theme that can be modified
to create a more personalized colour and brush set.
