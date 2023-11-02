# What's new in XTMF 

## Version 1.12

> [!WARNING]
> This version of XTMF uses the new .Net 7.0 and will not work if you just directly
> paste it directly over previous versions of XTMF.  If your copy of XTMF contains
> additional libraries not distributed by TMG, you will need to copy those .dll
> files into the `Modules` directory of your XTMF installation folder.


New Features:
* Supports EMME 2023.
* Updated to .Net 7.0.
* Fixed regression in the transit assignment tool.
* Improved performance for ExportSubarea tool by adding a max core count.
* Improved stability when opening/saving projects on network drives.
* Improved performance of GTAModel V4 when running on high core count machines.


Change Log:
* Update references to XTMF 1.12. by @JamesVaughan in [160](https://github.com/TravelModellingGroup/XTMF/pull/160)
* Stta xtmf1 by @wdiogu in [161](https://github.com/TravelModellingGroup/XTMF/pull/161)
* Edit parameters by @wdiogu in [162](https://github.com/TravelModellingGroup/XTMF/pull/162)
* add parameter descriptions by @wdiogu in [163](https://github.com/TravelModellingGroup/XTMF/pull/163)
* Adds support for the new AddTransferTimeAdjustments tool. by @JamesVaughan in [164](https://github.com/TravelModellingGroup/XTMF/pull/164)
* Rearranged files by @wdiogu in [165](https://github.com/TravelModellingGroup/XTMF/pull/165)
* Added the codes for calculate and copy background traffic by @wdiogu in [166](https://github.com/TravelModellingGroup/XTMF/pull/166)
* DotNet7 by @JamesVaughan in https://github.com/TravelModellingGroup/XTMF/pull/167
* added ability to choose create tvph or not in STTA by @wdiogu in [168](https://github.com/TravelModellingGroup/XTMF/pull/168)
* Fix Command Line Build by @JamesVaughan in [169](https://github.com/TravelModellingGroup/XTMF/pull/169)
* Fix Assigning Linked Parameter by @JamesVaughan in [170](https://github.com/TravelModellingGroup/XTMF/pull/170)
* Rename Module and Description fix. by @JamesVaughan in [171](https://github.com/TravelModellingGroup/XTMF/pull/171)
* Fix Recent Projects by @JamesVaughan in [172](https://github.com/TravelModellingGroup/XTMF/pull/172)
* Aggregations for Network Calculations in  EMME by @JamesVaughan in [173](https://github.com/TravelModellingGroup/XTMF/pull/173)
* Fix Enter moving to next parameter by @JamesVaughan in [174](https://github.com/TravelModellingGroup/XTMF/pull/174)
* Created Publishing profiles. by @JamesVaughan in [175](https://github.com/TravelModellingGroup/XTMF/pull/175)
* Fix unit tests for ODC. by @JamesVaughan in [176](https://github.com/TravelModellingGroup/XTMF/pull/176)
* Fixes from STTA setup + New tool to set has transit or traffic by @wdiogu in [177](https://github.com/TravelModellingGroup/XTMF/pull/177)
* Tasha performance by @JamesVaughan in [178](https://github.com/TravelModellingGroup/XTMF/pull/178)
* Reduce DAT memory usage. by @JamesVaughan in [179](https://github.com/TravelModellingGroup/XTMF/pull/179)
* Upgrade DirectorySeperatedPathFromOutputDirectory by @JamesVaughan in [180](https://github.com/TravelModellingGroup/XTMF/pull/180)
* Remove Newtonsoft.JSON references by @JamesVaughan in [181](https://github.com/TravelModellingGroup/XTMF/pull/181)
* Update references to external libraries. by @JamesVaughan in [182](https://github.com/TravelModellingGroup/XTMF/pull/182)
* Add modules for converting matrices and vectors between zone systems. by @JamesVaughan in [183](https://github.com/TravelModellingGroup/XTMF/pull/183)
* Use Matrix zone system for ConvertMatrixIntoZoneSystem by @JamesVaughan in [184](https://github.com/TravelModellingGroup/XTMF/pull/184)
* Revert to MaterialDesign 0.2.8 to fix hint text by @JamesVaughan in [185](https://github.com/TravelModellingGroup/XTMF/pull/185)
* Add nullable to interfaces by @JamesVaughan in [186](https://github.com/TravelModellingGroup/XTMF/pull/186)
* Added a new module for loading in a matrix for a given zone system. by @JamesVaughan in [187](https://github.com/TravelModellingGroup/XTMF/pull/187)
* Create Square SparseTwinIndex with 2D data by @JamesVaughan in [194](https://github.com/TravelModellingGroup/XTMF/pull/194)
* Dispose IDisposable modules by @JamesVaughan in [195](https://github.com/TravelModellingGroup/XTMF/pull/195)
* Fix no keyboard focus when renaming. by @JamesVaughan in [196](https://github.com/TravelModellingGroup/XTMF/pull/196)
* Clear Keyboard Focus when opening a StringRequestDialog. by @JamesVaughan in [197](https://github.com/TravelModellingGroup/XTMF/pull/197)
* Return Keyboard Focus for StringRequests by @JamesVaughan in [198](https://github.com/TravelModellingGroup/XTMF/pull/198)
* Add option to paste multiple parameters from a Spreadsheet. by @JamesVaughan in [199](https://github.com/TravelModellingGroup/XTMF/pull/199)
* Fix regression in V4.1 place of school assignment by @JamesVaughan in [200](https://github.com/TravelModellingGroup/XTMF/pull/200)
* Synchronize TMGToolbox by @JamesVaughan in [201](https://github.com/TravelModellingGroup/XTMF/pull/201)
* Force Keyboard focus by @JamesVaughan in [203](https://github.com/TravelModellingGroup/XTMF/pull/203)
* Fix AddTransferTimeAdjustmentsFromCSV by @JamesVaughan in [202](https://github.com/TravelModellingGroup/XTMF/pull/202)
* Added Scaling Parameters for AutoOwnership by @JamesVaughan in [204](https://github.com/TravelModellingGroup/XTMF/pull/204)
* Update Subarea tool by @JamesVaughan in [205](https://github.com/TravelModellingGroup/XTMF/pull/205)
* Enable delayed loading of model systems by @JamesVaughan in [206](https://github.com/TravelModellingGroup/XTMF/pull/206)
* Fix renaming a model system that is not loaded. by @JamesVaughan in [207](https://github.com/TravelModellingGroup/XTMF/pull/207)
* Removed self update. by @JamesVaughan in [208](https://github.com/TravelModellingGroup/XTMF/pull/208)
* Fixed tab overhang by @JamesVaughan in [209](https://github.com/TravelModellingGroup/XTMF/pull/209)
* Fix regression when copying and pasting a model system by @JamesVaughan in [210](https://github.com/TravelModellingGroup/XTMF/pull/210)
* Removed debug counter for dropped work episodes in a spin-lock by @JamesVaughan in [211](https://github.com/TravelModellingGroup/XTMF/pull/211)
* added ability to change default auto time attribute by @wdiogu in [213](https://github.com/TravelModellingGroup/XTMF/pull/213)
* Copy attribute c# by @wdiogu in [214](https://github.com/TravelModellingGroup/XTMF/pull/214)
* Fix model system reflection when in debug mode. by @JamesVaughan in [215](https://github.com/TravelModellingGroup/XTMF/pull/215)
* Fix QParameter and Module Parameter Filter Width by @JamesVaughan in [216](https://github.com/TravelModellingGroup/XTMF/pull/216)
* Fix ParkingCost by @JamesVaughan in [217](https://github.com/TravelModellingGroup/XTMF/pull/217)
* STTA Path Analysis by @JamesVaughan in [218](https://github.com/TravelModellingGroup/XTMF/pull/218)
* Implemented STTA Traversal Analysis by @JamesVaughan in [219](https://github.com/TravelModellingGroup/XTMF/pull/219)
* Fix Exporting and Renaming model systems before they are loaded. by @JamesVaughan in [220](https://github.com/TravelModellingGroup/XTMF/pull/220)

Full Changelog: [1.11.1414...1.12.1418](https://github.com/TravelModellingGroup/XTMF/compare/1.11.1414...1.12.1420)

## Version 1.11

> [!NOTE]
> This release of XTMF 1 continues support for both EMME 4.6 and versions before EMME 4.4.5.1. <br/>
> If you are using EMEME 4.6 please use the toolbox included with XTMF at Modules/TMG_Toolbox_Python3.mtbx.<br/>
> If you are using version of EMME 4.4.5.1 or before, please use the toolbox at Modules/TMG_Toolbox.mtbx. Both toolboxes contain full support for all EMME tools produced by TMG.<br/>

New Features
* Searching a model system now also searches parameter names and their values!
* Calibrating Start Times for TASHA activity episodes.
* New Export Subarea Tool - Documentation can be found [here](/1.6/tmgtoolbox/input_output/ExportSubareaTool.html)!

What's Changed
* Fix Start Time Adjustments by @JamesVaughan in [#159](https://github.com/TravelModellingGroup/XTMF/pull/159)
* Fix a race condition for SumColumns. by @JamesVaughan in [#146](https://github.com/TravelModellingGroup/XTMF/pull/146)
* Update GUI and assembly version numbers. by @JamesVaughan in [#147](https://github.com/TravelModellingGroup/XTMF/pull/147)
* fixed road assignment within subarea tool by @wdiogu in [#150](https://github.com/TravelModellingGroup/XTMF/pull/150)
* rearranged parameters by @wdiogu in [#151](https://github.com/TravelModellingGroup/XTMF/pull/151)
* Fix Module Descriptions by @JamesVaughan in [#152](https://github.com/TravelModellingGroup/XTMF/pull/152)
* Fix resetting a gzipped CSV stream. by @JamesVaughan in [#153](https://github.com/TravelModellingGroup/XTMF/pull/153)
* Small UI Updates. by @JamesVaughan in [#154](https://github.com/TravelModellingGroup/XTMF/pull/154)
* Search Parameters. by @JamesVaughan in [#155](https://github.com/TravelModellingGroup/XTMF/pull/155)
* Calibration Parameters for Episode Start Times. by @JamesVaughan in [#156](https://github.com/TravelModellingGroup/XTMF/pull/156)
* Fix StringRequest Validation Logic and Padding. by @JamesVaughan in [#157](https://github.com/TravelModellingGroup/XTMF/pull/157)
* Synchronize TMGToolbox. by @JamesVaughan in [#158](https://github.com/TravelModellingGroup/XTMF/pull/158)

New Contributors
* @wdiogu made their first contribution in [#150](https://github.com/TravelModellingGroup/XTMF/pull/150)

Full Changelog: [1.10.1407...1.11.1414](https://github.com/TravelModellingGroup/XTMF/compare/1.10.148...1.11.1414)

## Version 1.10

In this update to XTMF1 we have included support for EMME 4.6 in addition to previous versions of EMME. 
To use EMME 4.6 please switch to including the toolbox Modules/TMG_Toolbox_Python3.mtbx. Only one of the two toolboxes should be added at a time to the project.

Revision 1
New in this revision is a synchronization with TMGToolbox 1.10 Revision 1. This revision of the TMGToolbox contains a fix for how background transit affects the multiclass road assignment.

What's Changed:
* Add Setting Child Module Order. by @JamesVaughan in [#124](https://github.com/TravelModellingGroup/XTMF/pull/124)
* Expanded Root Module on Load by @JamesVaughan in [#125](https://github.com/TravelModellingGroup/XTMF/pull/125)
* Write Model Run Complete to Console by @JamesVaughan in [#126](https://github.com/TravelModellingGroup/XTMF/pull/126)
* StringRequestOverlay Cancel Button by @JamesVaughan in [#127](https://github.com/TravelModellingGroup/XTMF/pull/127)
* LinkedParameter value is set when loading first parameter. by @JamesVaughan in [#128](https://github.com/TravelModellingGroup/XTMF/pull/128)
* Highlight selected tab control by @JamesVaughan in [#129](https://github.com/TravelModellingGroup/XTMF/pull/129)
* Add Module for Remove extra nodes by @JamesVaughan in [#130](https://github.com/TravelModellingGroup/XTMF/pull/130)
* Select StringDialog starting text. by @JamesVaughan in [#131](https://github.com/TravelModellingGroup/XTMF/pull/131)
* Fix Copy Stack Trace. by @JamesVaughan in [#132](https://github.com/TravelModellingGroup/XTMF/pull/132)
* Update Newtonsoft.Json. by @JamesVaughan in [#133](https://github.com/TravelModellingGroup/XTMF/pull/133)
* Update NuGet packages. by @JamesVaughan in [#134](https://github.com/TravelModellingGroup/XTMF/pull/134)
* Fix dwelling type and Income Class by @JamesVaughan in [#135](https://github.com/TravelModellingGroup/XTMF/pull/135)
* Fix scrolling when filtering modules. by @JamesVaughan in [#136](https://github.com/TravelModellingGroup/XTMF/pull/136)
* File Path modules for EMME Parameters. by @JamesVaughan in [#137](https://github.com/TravelModellingGroup/XTMF/pull/137)
* Hypernetwork generation fix by @JamesVaughan in [#138](https://github.com/TravelModellingGroup/XTMF/pull/138)
* Add check for missing unconsolidated tools. by @JamesVaughan in [#139](https://github.com/TravelModellingGroup/XTMF/pull/139)
* Defensive Modeller Bridge Initialization by @JamesVaughan in [#140](https://github.com/TravelModellingGroup/XTMF/pull/140)
* Mixed Traffic TTFs by @JamesVaughan in [#141](https://github.com/TravelModellingGroup/XTMF/pull/141)
* Remove Migration Backup by @JamesVaughan in [#143](https://github.com/TravelModellingGroup/XTMF/pull/143)
* Update Toolboxes. by @JamesVaughan in [#144](https://github.com/TravelModellingGroup/XTMF/pull/144)
* Fix Edit Description by @JamesVaughan in [#145](https://github.com/TravelModellingGroup/XTMF/pull/145)

Full Changelog: [1.9.1398...1.10.148](https://github.com/TravelModellingGroup/XTMF/compare/1.9.1398...1.10.148)

## Version 1.9

* Includes the new modules for GTAModel's C-19 variant
* You can find more information on this model variant here
* Able to read compressed CSV files (.csv.gz)
* Updated to .Net Framework 4.8
* Includes a more flexible implementation for importing transit lines into EMME for backwards compatibility
* Added a new flag for the auto mode to include intrazonal trip parking costs
* Added support for EMME 4.4.5
* Quick Parameters are now saved to the run directory in the file QuickParameters.xml


## Version 1.8

* Improved support for EMME 4.4.4.2
* Added a new Parking Cost model to support GTAModel V4.2
* Updated Auto Ownership model
* Added Passenger Mode OD Constants by time of day for calibration
* Added a new modules "Assign Parameter From Data Source" and "Execute Model System With Random Seeds"
* Improved GUI for Runs.
* Small bug fixes for the ODMath framework. [286eb55](https://github.com/TravelModellingGroup/XTMF/commit/286eb559df3229acf504f3e7d9666c88eaff9552)
* Updated GUI dependencies
* Updated Microsim outputs to add columns so you can differentiate between Passenger Access and Egress Transit for station access.
* Implemented the Airport 2020 model for GTAModel V4.2
* Added the ability to toggle on/off if PAT/PET can access stations that are defined but have no capacity.
* Added a module to import an EMME Function Batch File
* Added the sqrt function to the ODMath Framework
* Additional miscellaneous GUI updates.
* Revision 1 fixes a bug when pressing F1 for module documentation


## Version 1.7

* Improved memory usage and performance for DAT, PAT, PET on many core machines.
* Improved performance for Surface Transit Speed Update algorithm.
* EMME system path is now correctly setup allowing for the usage of different versions of EMME even if there are issues with the
  system's environment variables hard coding a particular version in the PATH.
* Additional error detection


## Version 1.6

### XTMF Software Changes


#### Updated Model System Display

- The Model System display has been updated replacing the parameter tabs with collapsible panels. Both the quick parameter display and active module parameter display can be active at the same time.
- A status bar has been added to the bottom of the display containing quick-glance information of the model system.
- Modules now have customizable icons that are rendered in the display.
- Previous run names are now enumerated into the run dialog.

#### Model System Regions

- A new regions pane is added to the model system display.
- Regions allow for customized grouping of specific modules outside of the model system hierarchy.
- A model system can have an unlimited number of custom regions to help with quick logical grouping of modules specific to certain tasks.

#### Improved Logging

- The run window console logger now includes time-stamped information.
- Modules that make use of the ILogger interface will can also include logging info that details which module a message originated from.
- The run window console logger now saves / mirrors the same information to a XTMF.Console.log file in the current run directory.

#### Run Schedule Re-Ordering

- Queued runs can now be re-ordered from the scheduler window. Simply drag and drop the run into the desired spot - or use the available context menu to shift runs in the queue up or down.

#### Updated Documentation Browser

- The embedded module documentation will now display the appropriate information from the TMG documentation site (browser)/

#### Miscellaneous

- Model systems now record their last-modified time. This information is displayed on the project display.
- Bug fixes and other performance improvements.
- A module exclude list can be provided to prevent XTMF from loading specified modules at application startup.
- Updated project and model system save format. Each model system in a project is now separated into multiple files, rather than being grouped as part of the same project file.

#### Bug Fixes

As always, new iterations of XTMF address bugs previously identified in any of the issues created on the Github project tracker, and others
we may find internally.

### XTMF SDK Changes

- The XTMF `ModuleInformation` attribute has an added property for customized module icons.
- Dependency injection support for log4net ILogger is now provided for modules. Creating an ILogger field in an IModule definition will have the logger created when the module is initialized. Use this functionality for more detailed log output.

### Development

- The XTMF code database has undergone substantial code cleanup and refactoring for this version.

### Requesting New Features

New feature requests are always welcome for the XTMF project. If you would like to contribute, make any suggestions for a new feature, or report any
bugs encountered during your usage of XTMF please see: https://github.com/TravelModellingGroup/XTMF/issues.