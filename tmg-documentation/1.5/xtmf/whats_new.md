# What's new in XTMF Version 1.5?

## XTMF Software Changes


### Updated Model System Display

- The Model System display has been updated replacing the parameter tabs with collapsible panels. Both the quick parameter display and active module parameter display can be active at the same time.
- A status bar has been added to the bottom of the display containing quick-glance information of the model system.
- Modules now have customizable icons that are rendered in the display.
- Previous run names are now enumerated into the run dialog.

### Model System Regions

- A new regions pane is added to the model system display.
- Regions allow for customized grouping of specific modules outside of the model system hierarchy.
- A model system can have an unlimited numer of custom regions to help with quick logical grouping of modules specific to certain tasks.

### Improved Logging

- The run window console logger now includes timestamped information.
- Modules that make use of the ILogger interface will can also include logging info that details which module a message originated from.
- The run window console logger now saves / mirrors the same information to a XTMF.Console.log file in the current run directory.

### Run Schedule Re-Ordering

- Queued runs can now be re-ordered from the scheduler window. Simply drag and drop the run into the desired spot - or use the available context menu to shift runs in the queue up or down.

### Updated Documentation Browser

- The embedded module documentation will now display the appropriate information from the TMG documentation site (browser)/

### Miscelaneous

- Model systems now record their last-modified time. This information is displayed on the project display.
- Bug fixes and other performance improvements.
- A module exlude list can be provided to prevent XTMF from loading specified modules at application startup.
- Updated project and model system save format. Each model system in a project is now separated into multiple files, rather than being grouped as part of the same project file.

### Bug Fixes

As always, new iterations of XTMF address bugs previously identified in any of the issues created on the Github project tracker, and others
we may find internally.

## XTMF SDK Changes

- The XTMF `ModuleInformation` attribute has an added property for customized module icons.
- Dependency injection support for log4net ILogger is now provided for modules. Creating an ILogger field in an IModule definition will have have the logger created when the module is initialized. Use this functionality for more detailed log output.

## Development

- The XTMF code database has undergone substantial code cleanup and refactoring for this version.

## Requesting New Features

New feature requests are always welcome for the XTMF project. If you would like to contribute, make any suggestions for a new feature, or report any
bugs encountered during your usage of XTMF please see: https://github.com/TravelModellingGroup/XTMF/issues.