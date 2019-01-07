# Travel Modelling Group Documentation

## Building Documentation for V1.4+ (Including TMGToolbox)

### Requirements

1. Docfx 2.40.X+
2. Visual Studio for compiling required plugin that generates metadata and documentation files for XTMF modules.

### Instructions for building

1. Clone or download this repository.
2. Use tmg-documentation as your workspace root, this will include version 1.4+.
3. Build the solution `ModuleDocProcessor` and place all of the output files from ModuleDocProcessor in the `Plugins` folder where docfx.exe is located. If no `Plugins` folder exists, one will need to be created. This step is required in order for docfx.exe to recognize certain .json files (XTMF module doc information) as valid input files.
4. Run docfx.exe

### Generation new ModuleDoc metadata

Included in this repo is a small command line utility to convert XTMF module assemblies to an input format usable by docfx. The utility is called `ModuleDocMetaGenerator`. As an input, it takes a folder path containing compiled XTMF module assemblies (.dll) and an output path where the transformed meta data will be output (multiple .json and .md files).

#### Usage

`*ModuleDocMetaGenerator.exe* -i **PATH_TO_MODULES_FOLDER** -o **PATH_TO_OUTOUT_FOLDER**


## Building Documentation for 1.3 and lower (XTMF only)

### Requirements

- Python

### Setup Instructions

1. Install Python

2. Install dependencies
   `pip install -r requirements.txt`

### Building the Documentation

Use included make file for creating the HTML output.

`make html`


