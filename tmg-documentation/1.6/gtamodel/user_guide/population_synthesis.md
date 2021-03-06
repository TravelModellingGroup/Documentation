---
uid: population-synthesis-1-6
title: Population Synthesis
---


# Population Synthesis

## Overview

GTAModelV4 has a population synthesized from the TTS (Transportation for Tomorrow Survey) records.

### Required Software and Dependencies

1. MySql Server 5.5 or greater
2. Python V3 or greater with required package dependencies dependencies

### Installation and Setup

#### Mysql Server Installation

If you do not have a copy of MySQL Server - an installer is available for download at <https://dev.mysql.com/downloads/mysql/.> A minimum version of version 5.5 of the Community Edition is required.

During the installation process, keep note of the server isntallation's root password that you provide. A valid database user and password is required is required to connect to the database server.

##### Server Configuration

It may be necessary to increase the size of the `max_allowed_packet` property before running the server. This property can be set in the server's configuration file. On Windows, the default property file loaded is `my.ini`, located in the root of the server installation directory.

> [!NOTE]
> For more information about this server variable, please see the MySql documentation at <https://dev.mysql.com/doc/refman/5.5/en/server-system-variables.html#sysvar_max_allowed_packet.>

##### Creating a Database

Apart from the MySQL Server installation, a database must be created with the proper access privileges for the user account used to connect to the server.

(TODO)

#### Python Installation

A valid installation of Python 3.5+ is required. Python can be downloaded at https://www.python.org/downloads/ or using the anaconda distrubtion: https://www.anaconda.com/distribution/. The Anaconda distrubtion is preferred, as there are some performance improvements available that are applicable to the packages used in gtamodel_popsyn (pandas, numpy).

##### Installing Package Dependencies

Restore package requirements with pip:

```sh

>pip install -r requirements.txt

```

#### Input Configuration

GTAModel's population synthesis procedure requires defining its inputs through a JSON formatted configuration file. A blank / schema version of the required input format is provided for guidance in creating the properly structured input.

The default configuration JSON has the following format:

```json
{
	"DatabaseName": "",
	"DatabasePassword": "",
	"DatabaseUser": "",
	"DatabaseServer": "",
	"PersonsSeedFile": "",
	"HouseholdsSeedFile": "",
	"OutputFolder": "",
	"MazLevelControls": "",
	"TazLevelControls": "",
	"MetaLevelControls": "",
	"Java64Path": "C:\\Path\\To\\Jre",
	"PopSyn3SettingsFile": "runtime\\config\\settings.xml",
	"CategoryMapping": {
		"Persons": [
			{
				"FieldName": "",
				"FieldValue": "",
				"MappedValue": 0
			}
		],
		"Households": [
			{
				"FieldName": "",
				"FieldValue": "",
				"MappedValue": 0
			}
		]
	}
}
```

| Configuration Value | Description                                                                                                                                                                                                                   |
| ------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| DatabaseName        | The database name to be used during the population synthesis procedure.                                                                                                                                                       |
| DatabasePassword    | The password to be used to connect to the database.                                                                                                                                                                           |
| DatabaseUser        | The user account to be used to connect to the database.                                                                                                                                                                       |
| DatabaseServer      | The IP address or host name of the database server.                                                                                                                                                                           |
| PersonsSeedFile     | File path to the persons seed data to be used. This file is expected to be in CSV format.                                                                                                                                     |
| HouseholdsSeedFile  | File path to the households seed data to be used. This file is expected to be in CSV format.                                                                                                                                  |
| OutputFolder        | Path to the folder where all output files will be written, including log files.                                                                                                                                               |
| MazLevelControls    | Input file path specifying control totals at MAZ level of geography. This file is autogenerated as part of the preconfiguration setup.                                                                                        |
| TazLevelControls    | Input file path specifying control totals at TAZ level of geography. This file is autogenerated as part of the preconfiguration setup.                                                                                        |
| MetaLevelControls   | Input file path specifying control totals at the META or regional level of geography. This file is autogenerated as part of the preconfiguration setup.                                                                       |
| Java64Path          | Path location of an available JRE installation. There is no need to specify the installation bin folder, only the base path of the installation.                                                                              |
| PopSyn3SettingsFile | File location of the settings configuration file used by PopSyn3. This is an XML document that is transformed to include configuration values specified in config.json alongside other PopSyn3 specific configuration values. |
| Category Mapping    | Contains a list of mapping values for households and persons that transforms input attributes from a character value to an integer mapping                                                                                    |

## Population Synthesis Procedure

### Pre-processing Input Data

### Starting a Run

The python module `gtamodel_popsyn` is used from the command line to perform all steps required to complete the population synthesis. The default behaviour when executing the `gtamodel_popsyn` module from the command line is perform all steps of the synthesis procedure:

1. Input transformations.
2. Control total calculations.
3. Synthesize records.
4. Write synthesized records to file.
5. Generate a summary report.

There are various several command line arguments available when running the module to target a specific step of the synthesis procedure. Command line arguments and their descriptions are listed below.

```console
	usage: __main__.py [-h] [-c CONFIG] [-i] [-d] [-o OUTPUT_ONLY]
					[-r VALIDATION_REPORT_ONLY]

	optional arguments:
	-h, --help            show this help message and exit
	-c CONFIG, --config CONFIG
							Path of the configuration file to use.
	-i, --input-process-only
							Only generate synthesis files and don't run synthesis
							procedure.
	-d, --database-only   Only initialize the database and tables required for
							PopSyn3.
	-o OUTPUT_ONLY, --output-only OUTPUT_ONLY
							Only write synthesized population from existing
							database data.
	-r VALIDATION_REPORT_ONLY, --validation-report-only VALIDATION_REPORT_ONLY
							Only generate a summary report from existing output
							files. Pass the generated output folder to use.
```


> [!NOTE]
> Please ensure that your MySQL server is started before starting the synthesis procedure.

## Post-Processing

Post-processing is performed automatically in the standard execution of the gtamodel_popsyn module. To specifically target the post-processining step of `gtamodel_popsyn`, use either the `-r` or `-o` command line arguments to only generate a report, or only generate output files.

When choosing to create the validation report only, the path to a previous run is required as part of the command line arguments. The relative path to the output folder is necessary. 

### Output Files

After the population synthesis procedure has completed, the synthesized population will be written to the output folder specified in the configuration settings.

#### Population Files

##### Households

##### Persons

##### Zonal Residence

##### Employment and Occupation Vectors

#### Log Files

Logginging information from different stages of execution are appended to several different log files in the output directory: 1. event.log - Output from PopSyn3 2. post-process.log - Output from the post process stage of execution. 3. pre-process.log - Output from the pre-process stage of execution. 4. run.log - Output during execution, which contains a mix of GTAModel specific information alongside PopSyn3 output information.
