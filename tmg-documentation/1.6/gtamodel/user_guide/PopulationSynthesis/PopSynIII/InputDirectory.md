# Input Directory

In the following documentation we will review the files contained in the PopSynIII package that you have received from TMG.

> [!Warning]
> When modifying the files in the input directory all columns must be in the same order otherwise your data will be loaded incorrectly!


## Directories

The following are the main directories of the Input files.

### BaseYearData

This folder holds the static data describing the zone system and the base year conditions that will be scaled in order to do forecasting.

#### hhtable.csv

This file contains the seed household records used in PopSynIII with the default columns as follows:

* HouseholdId
    * The unique ID for this household, used for mapping the assosiated person records to this household
* puma
    * The PUMA that this household belongs to.
* DwellingType
    * 1 for ground
    * 2 for apartment
* NumberOfPersons
    * The number of persons that live in this household.
* Vehicles
    * The number of vehicles this household has
* IncomeClass
    * The TTS's income class for the household
* weight
    * The expansion factor for the household

#### meta_controls.csv

This file contains the base year's control totals by PUMA/Region.  These should match the aggregation of the totals from `taz_controls.csv`.

#### perstable.csv

This file contains the seed person records used in PopSynIII with the following columns by default:

* HouseholdId
* PersonNumber
* puma
* Age
* Sex
    * 1 for female
    * 2 for male
* License
    * 1 if they have a license, 0 otherwise
* TransitPass
    * This field is ignored for the moment
* EmploymentStatus
    * 1 if they are unemployed
    * 2 if they are full-time
    * 3 if they are part-time
    * 4 if they are full-time work at home
    * 5 if they are part-time work at home
* Occupation
    * 0 if unemployed
    * 1 if General/Clerial worker
    * 2 if Professional/Mangerial worker
    * 3 if in Retail/Sales
    * 4 if in manufacturing or construction
* FreeParking
    * 1 if they have free parking at work, 0 otherwise
* StudentStatus
    * 1 FullTime
    * 2 PartTime
    * 3 Not a student
* EmploymentZone
    * 0 unless it is an external zone or non-fixed-place-of-work (NFPW) 8888
* SchoolZone
    * 0 unless it is an external zone
* weight
    * The expansion factor for this person rounded to the nearest integer

#### settings.xml

This file contains the weights and configuration for PopSynIII.  Inside of this file you will need to update the database parameters as shown below:
``` XML
<database>
    <server>localhost</server>
    <type>MYSQL</type>
    <user>root</user>
    <password>[ROOTs PASSWORD]</password>
    <dbName>[The name of your database, we use TorontoPopSynIII]</dbName>
</database>
```

The rest of the parameters in this file tell the model how to trade off between the control totals.  Edit this only if necessary.

#### taz_controls.csv

This file contains the base year's control totals by TAZ.  The following are the columns:

* region
    * The seed pool to draw from, region must be the same as puma
* puma
    * The seed pool to draw from, region must be the same as region
* taz
    * The traffic zone we are defining control totals for, same as maz
* maz
    * The traffic zone we are defining control totals for, same as taz
* totalhh
    * The total number of households in the zone
* totpop
    * The total number of persons in the zone
* income_class_1
    * The total number of households in TTS's income class 1 in the zone
* income_class_2
    * The total number of households in TTS's income class 2 in the zone
* income_class_3
    * The total number of households in TTS's income class 3 in the zone
* income_class_4
    * The total number of households in TTS's income class 4 in the zone
* income_class_5
    * The total number of households in TTS's income class 5 in the zone
* income_class_6
    * The total number of households in TTS's income class 6 in the zone
* male
    * The total number of male persons persons in the zone
* female
    * The total number of female persons in the zone

#### ZoneSystem.csv

This file contains all of the zones in the zone system with the following columns in order.

*  TAZ
   *  The zone number
*  PD
    * The planning district number
* PUMA
    * The number used for specifying what pool of seeds that we will draw from.
* Population
    * The base year number of persons living within the zone.

### Runtime

This folder contains the program files that are required for running PopSynIII.  You should not edit any of these files.

### Scripts

This directory contains the SQL code that will operate on the MySQL database.  If you are using non-standard controls, you will need to modify
your version of `ControlsTableCreation.sql` to import the required data appropriately.

* ControlsTableCreation.sql
    * This file is used for creating the tables used as controls during the IPU.
* PUMFTableCreation.sql
    * This file is used for creating the tables used to store the seed household and peron records.
* PUMFTableProcessing.sql
    * This file is used to instruct the model how to prepare the seed household and person records for processing by PopSynIII.


#### ControlsTableCreation.sql

This file contains the scripts to create the tables in the MySQL database for the tables that hold the control totals for MAZ, TAZ, and Meta level controls. The control files
that are read into these tables are generated by PopSynIIIAutomation at the start of the run.  **Please make sure to check the order of the columns against your control total CSV files** to
ensure that the totals are being loaded with the correct values.


#### PUMFTabelCreation.sql

This script creates the tables that are used to hold the original household and persons records before they have started to be processed.  it is unlikely that you will need to modify this
file however **please ensure that these columns match your seed population's Household.csv and Persons.csv files.**


#### PUMFTableProcessing.sql

This script takes the original households and persons and generates new tables that will be operated upon during the algorithm.  You should not modify this file.
