# Software Setup

This section will walk you through installing and setting up
all of the software required to execute GTAModel V4 and the process for importing the base model.

To run GTAModel V4 you will require the following software packages:
1. **XTMF** - The eXensible Travel Modelling Framework is a software package [created](https://github.com/TravelModellingGroup/XTMF) 
    by TMG for creating and executing model systems. For more details please reference the XTMF
    documentation at [here](../../../xtmf/index.md)
1. **EMME** - A software package created by [INRO](https://www.inrosoftware.com) for modelling road and transit networks.
1. **TMGToolbox1 for EMME** - A set of tools [created](https://github.com/TravelModellingGroup/TMGToolbox) by TMG to automate EMME for GTAModel.

Instructions for downloading and setting them up are contained in the following sections.

## XTMF

The [eXtensible Travel Modelling Framework (XTMF)](https://github.com/TravelModellingGroup/XTMF/releases) is a software package created by TMG that is used for creating, estimating,
calibrating, and running model systems.  The following instructions will go over the simple steps for running XTMF on your machine. First you will need 
to [download the latest copy available off of github](https://github.com/TravelModellingGroup/XTMF/releases).  When going through the releases there is a compiled build
of each release in the assets zipped.  To run this on your local PC you can extract it to any directory.  TMG recommend extracting it to a folder called `XTMF` in your `Documents` folder.

If you are not running an updated Windows 10+ operating system you may also need to [install .Net Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
or download it as an optional `Windows Update`.

## EMME

EMME is a software package that GTAModel will use for executing both its road and transit macro network assignments.  The following subsections will go through the process of
installing, authorizing, connecting to a license server, and finally using EMME to setup a database for GTAModel to use.

### Installing the Software

The first software package that we will require is EMME. If you do not have admin access on the machine you are setting GTAModel up on, please
contact your IT admin staff. To run GTAModel please [download](https://www.inrosoftware.com/en/account/downloads/)
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

### Getting a License

Now that we have EMME installed and have an authorization the next step is to connect to our license server.  If you have a local key you can skip this step, otherwise if you are
using the DMG license server please follow their instructions for installing [PuTTY](https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html) and creating a shortcut to log
into their license VPN.

At this point you should be able to manually connect and get a license.  **It is recommended to switch this over to `Automatic` so that in the future if you are not using EMME you will
not consume a license by accident.**


## Next Step

Now that our software is setup, our next step is to [configure the software](initial_configuration.md).