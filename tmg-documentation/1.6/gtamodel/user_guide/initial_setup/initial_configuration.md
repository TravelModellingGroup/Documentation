## Setting up Inputs

In this section we will setup the inputs and EMME databases required for running GTAModel V4.

### GTAModel V4 Inputs

In order to run GTAModel you will require inputs that describe the land-use, population, and network configuration.
You can find a full outlining of the input directories for various versions
[here](../InputDirectory/index.md).  To get the input files for your base model
please contact TMG and they will prepare it for download or give you the internal network file path for the input folder.

### Setting up the EMME Run Databases

Now that we have EMME installed and are able to run the software we can create one of the databases that GTAModel will require to execute its network assignments.  You can
find detailed information on how to do this, and setup the TMGToolbox for EMME [here](../Network/emme_project_setup.md).  **Please make sure to link to the TMGToolbox that
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

## Next Step

Now that we have all of our files in place, and we have our run databanks we can now [execute our first run](executing_a_run.md).