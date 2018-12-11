# Building TMG Documentation

## ModuleDocProcessor

Compile the ModuleDocProcessor solution location in the subfolder of the same name. ModuleDocMetaGenerator does not need to be run unless there are updates to any of XTMF's modules. The intermediate output is stored in the repo for convenience. However in order to build the documentation, the project `ModuleDocProcessor` must be compiled and its output placed inside of the the templates/Plugins folder. The Debug configuration is currently configured to output to this directory automatically.

## Building

Simply run `docfx build` with `docfx serve` to view the site at `http://<address>/_site`.