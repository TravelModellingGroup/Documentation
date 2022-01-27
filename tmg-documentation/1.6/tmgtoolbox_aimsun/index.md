# TMG Toolbox for Aimsun

## Introduction

TMG Toolbox for Aimsun is designed for the Aimsun Next software 
(version 22). Aimsun Next software is a multi-resolution, multi-modal 
modeling tool.

The documentation is divided into sections Tools and Tutorials.

### Tools section

Lists all the Aimsun tools built and available. Each page has three major sections,
an overview of the objective of the tool, the input parameters required 
to be added by the use, and screenshots of how the tools is used in
XTMF

### Tutorial

This section goes through building a full network with the Aimsun tools 
using a small city called Frabitztown.

# Development Notes and Other Miscellaneous Information

## Writing Aimsun Scripts

- Aimsun scripts are run from the command line using a tool aconsole.exe. This exists in the main Aimsun installation folder as of Aimsun Next 20. 
It is important that the working directory for the current execution context is set the the location of the aconsole.exe application, otherwise several
python dependencies and modules will not be found.
- `aconsole.exe` takes a single parameter --script which must be the absolute path to the python script to be run.
- Any arguments after the path to the python sript are sent as command line arguments (argv) to the python script itself.

## A Brief Explanation of Writing a new Tool  for the Aimsun Toolbox

- Take a look at smaller existing tools for examples
- Get a reference to the Console object from Aimsum
    - Get the active Model from the console object provided
    - If none exists, make a new model.
- Using model reference, various editing actions can now take place.
- Save the model when finished, and close the console.

## Location of Required Python Modules

- The Python modules required for interacting with the Aimsun API are located in the main installation folder under *plugins/python*. *PyANGApp*, *PyANGonsole*, *PyANGKernel*, *PyANGGui* are the more frequently used/critical module dependencies. Reference them in your IDE if it supports parsing external modules for automcomplete and other intellisense features. Otherwise, any documetation on these modules must be inferred from the C implementation included in the Aimsun scripting documentation.

## Suggested development pipeline for efficient module testing / development

Use a Python IDE that supports parsing/reading external python modules and libraries that are then included as part of autocomplete and other intellisense features. Point PYTHONPATH or related IDE variables to the Aimsun plugins/python folder for the required modules.

Develop a launch task that passes the active file as the --script parameter to `aconsole.exe`.  Ensure that the active working directory is the same directory where `aconsole.exe` is located. 

