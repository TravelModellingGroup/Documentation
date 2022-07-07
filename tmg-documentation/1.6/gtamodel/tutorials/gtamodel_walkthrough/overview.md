# GTAModel V4 Walkthrough

This tutorial will walk you through setting up GTAModel V4 using XTMF and then
provide links to explore more advanced topics.  This tutorial will assume that you
will be running a version of GTAModel that uses EMME, please contact TMG is your require
additional support for setting up Aimsun.

These instructions assume that you are running a fully patched x86_64 based Windows operation system
(7 SP1+) with at least 12GB of RAM (16GB recommended) or at least 8GB plus 1GB per hardware
thread on your CPU.

## Software Packages

To run GTAModel V4 you will require the following software packages:
1. **XTMF** - The eXensible Travel Modelling Framework is a software package [created](https://github.com/TravelModellingGroup/XTMF) 
    by TMG for creating and executing model systems. For more details please reference the XTMF
    documentation at [here](../../../xtmf/index.md)
1. **EMME** - A software package created by [INRO](https://www.inrosoftware.com) for modelling road and transit networks.
1. **TMGToolbox1 for EMME** - A set of tools [created](https://github.com/TravelModellingGroup/TMGToolbox) by TMG to automate EMME for GTAModel.

Instructions for downloading and setting them up are contained in the following sections.

## Setting up Software

This section will walk you through installing and setting up
all of the software required to execute GTAModel V4 and the process for importing the base model.

### XTMF

The [eXtensible Travel Modelling Framework (XTMF)](https://github.com/TravelModellingGroup/XTMF/releases) is a software package created by TMG that is used for creating, estimating,
calibrating, and running model systems.  The following instructions will go over the simple steps for running XTMF on your machine. First you will need 
to [download the latest copy available off of github](https://github.com/TravelModellingGroup/XTMF/releases).  When going through the releases there is a compiled build
of each release in the assets zipped.  To run this on your local PC you can extract it to any directory.  TMG recommend extracting it to a folder called `XTMF` in your `Documents` folder.

If you are not running an updated Windows 10+ operating system you may also need to [install .Net Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
or download it as an optional `Windows Update`.

### EMME

EMME is a software package that GTAModel will use for executing both its road and transit macro network assignments.  The following subsections will go through the process of
installing, authorizing, connecting to a license server, and finally using EMME to setup a database for GTAModel to use.

#### Installing the Software

The first software package that we will require is EMME. If you do not have admin access on the machine you are setting GTAModel up on, please
you will need the assistance of your IT admin staff. To run GTAModel please [download](https://www.inrosoftware.com/en/account/downloads/)
the latest installer for EMME.  If you do not have an INRO account, please contact someone from TMG or DMG for assistance.

> [!WARNING]
> If you are using an EMME license service over the network you will also need to disable the local service called `INRO License Service` from starting up otherwise you will
> be unable to connect.

Once you have finished installing EMME you will also need to get an authorization file before you can run the software.  To get an authorization file you will need to open the
`INRO Software Manager`, often found in your system tray, and select the `Authorizations` tab.  Once there, in the EMME tab, click the `Add Authorization` button.  This will then
open up the wizard for adding an authorization.  If you have already been provided an authorization file select so, otherwise select that you will need to request one `Over the Internet`.
The Wizard will then ask for your authorization code.  This code will need to be provided by your IT admin or from the Data Management Group (DMG).  After entering in the authorization code
your default web browser will launch taking you to INRO's website.  From there you will need to log into your INRO account in order to confirm that you want to request the Authorization file.
After confirming that you do in fact want the file it will be emailed to the associated email address to your INRO account.  Save the authorization file to disk and then continue with the Wizard
selecting the file for use.  **Make sure that the newly added authorization's radio button is selected before continuing on.**

#### Getting a License

Now that we have EMME installed and have an authorization the next step is to connect to our license server.  If you have a local key you can skip this step, otherwise if you are
using the DMG license server please follow their instructions for installing [PuTTY](https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html) and creating a shortcut to log
into their license VPN.

At this point you should be able to manually connect and get a license.  **It is recommended to switch this over to `Automatic` so that in the future if you are not using EMME you will
not consume a license by accident.**

## Setting up Inputs

In this section we will setup the inputs and EMME databases required for running GTAModel V4.

### GTAModel V4 Inputs

In order to run GTAModel you will require inputs that describe the land-use, population, and network configuration.
You can find a full outlining of the input directories for various versions
[here](../../user_guide/InputDirectory/index.md).  To get the input files for your base model
please contact TMG and they will prepare it for download or give you the internal network file path for the input folder.

### Setting up an EMME Run Databases

Now that we have EMME installed and are able to run the software we can create one of the databases that GTAModel will require to execute its network assignments.  You can
find detailed information on how to do this, and setup the TMGToolbox for EMME [here](../../user_guide/Network/emme_project_setup.md).  **Please make sure to link to the TMGToolbox that
came with your copy of XTMF** unless you are testing custom tools or are working from TMG's development branch.

Now that you have a working database we will make enough copies of the EMME project and database to work with your model system.
For models coming from TMG based on GTAModel V4.0 this will be four, for GTAModel V4.1+ this will be two.
specified otherwise.  If your model system is coming from a consulting firm instead of TMG please consult their
model documentation to see how they have setup their run databanks.

## Setting up the Model System

Now that we have the environment setup we can continue with preparing the model system.  The following section
will walk you through importing the model system and configuring it for your first run.  For general information
on using XTMF please click [here](../../../xtmf/getting_familiar_with_xtmf.md).


### Importing the Model System

Now that we have the software and input files ready to run, we can setup a new project and import the base model system
into XTMF.

The first step is to make sure that you have a copy of your model system either from TMG or your consulting firm.
This will be an XML file that describes how all of the modules fit together.

Once we have our model system file our next step is to open XTMF.  In order to do this you will need to open
the directory that you extracted XTMF to earlier and run the program `XTMF.GUI.exe`.  Windows might give you
a warning that you are running a program from the internet.  Depending on your version of Windows see if there
is an option that says run anyways and select it.  If you are still having problems running XTMF please
contact TMG for assistance.

With XTMF open you will now be able to create a new project and import the model system.  From the Start
screen select `Create a new project`.  This will bring up dialog to enter in the project's name.  Once you
have selected a name you will be presented with the project's screen.  On the bottom right you will see a "+"
button, press it and a set of options will pop-up.  Select the option `Import Model System From File`.  You will
then be directed to select the XML model system file provided by TMG or your consulting firm.  After selecting the file
you will be prompted to give the model system a name within your project.

### Initial Configuration

Now that we have the model system imported we are going to need to fix some file paths so it will work
on our machine. Our first step is to open the model system.  You can do this by double clicking on the
model system that we just imported under the *Model Systems* list on the left hand side of the project's page.
This will bring up the model system's screen.

On the left hand side of the screen you will see a tree that represents the model system's modules.  On the right
you will initial see the Quick Parameters. Once you have clicked on a module a second set of parameters will popup
that are specific to that particular module.

After setting up EMME and your input directory the model system should be configured properly to execute your
first model run.

#### EMME

In most configurations you will see two quick parameters named `Emme Project 1` and
`Emme Project 2`.  We will need to change these two file paths to match the EMME projects that were created previously.
`Emme Project 1` will be used to run the AM MD (mid day), and ON time period. `Emme Project 2` will be used for the PM
and EV (evenning) time periods.  To set the paths you can either copy in the path manually, or follow one of the following
techniques for loading in a file path.  Press ctrl+f to bring up the file select dialog and navigate to the `.emp` file
in the EMME project directory, or drag and drop the `.emp` file from file explorer.

If you have multiple versions of EMME installed on your machine you may want to specify which version of EMME you would like
to use.  If you want to do this navigate to `Resources` inside of modules and select the child module `Emme Project`.
Inside of that module you can then alter the `EmmePath` parameter to the installation directory of the version you want.
For example if you want to use EMME 4.4.4.2, and assuming that it has been installed to the default path, you would enter
`C:\Program Files\INRO\Emme\Emme 4\Emme-4.4.4.2` into the parameter.

#### Input Directory

You will also need to setup the location of the input directory that you have previously obtained from TMG or your
consultant.  First select the root (top) module to bring up its parameters.  From its parameters on the right go to
`Input Base Directory` and then enter in the path that you have stored those files to.  You can do this by either
manually entering in the path, or by pressing ctrl+d to bring up the select directory dialog and navigate to the
input directory.

## Executing A Run

After completing your initial configuration of the model system you are now ready to esecute your first run.

TODO: Complete this section.

## GTAModel V4 Outputs

Modelling travel demand allows us to forecast alternative scenarios.

The planning agencies typically extract out the following types of data:
1. Mode share/split
1. Public transit ridership
1. Vehicle Kilometres Travelled (VTKs)
1. Road congestion

For more details about the outputs from GTAModel V4 please continue [here](model_outputs.md).
