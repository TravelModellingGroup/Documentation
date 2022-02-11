# V4.0 Population Synthesis

## Overview

The V4.0 Population Synthesis program provides a convenient program for generating synthetic populations for GTAModel V4.0 based models.  This includes
not just the household and person records but also the required supporting files for [PoRPoW](../../../model_design/porpow.md).  To create a new
synthetic population the only file you will need to provide, in addition to the standard input directory, is a CSV which specifies
the future year population by zone.

> [!Warning]
> All CSV files expect to have the first row be the column's header!

## Algorithm

1. Read in the seed population and aggregate it into planning districts.
1. For each zone randomly draw a households until we meet the zone's total population.
    1. When drawing a zone we do so without replacement to help reduce statistical drift.
    1. If there are no households left to draw from, re-initialize the pool to their original weightings.
1. Gather the zonal residence and worker categories from the selected persons.
1. Store the results to file.

## Input File Directory

The following files are required to be stored in an input directory to be able to complete a run.  
All CSV files below expect their columns with a header and in the given order.

### SeedHouseholds.csv

* HouseholdId
* HouseholdPD
* ExpansionFactor
* DwellingType
* NumberOfPersons
* NumberOfVehicles
* IncomeClass

### SeedPersons.csv

* HouseholdId
* PersonNumber
* Age
* Sex
* License
* TransitPass
* EmploymentStatus
* Occupation
* FreeParking
* StudentStatus
* EmploymentPD
* SchoolPD
* ExpansionFactor

### ZoneSystem.csv

The ZoneSystem.csv gives us the ability to map each traffic analysis zone to a given planning district. This information is used for choosing
which seed pool that this zone will draw records from. A PD of 0 will tell the model to not generate population for this zone.

* Zone
* PD

## Forecast Population

In addition to the input directory you will also need to include a CSV file that gives the forecast population you wish to generate.

* Zone
* FuturePopulation


## Output File Directory

The results of the synthesis include the Household and Person records. Additionally we also export an updated ZonalResidence and WorkerCategories directory that
contain eight CSV files, one for each combination of occupation and non-home-based employment class. For example "PF.csv" would refer to the combination of "Professional Full-Time".

### HouseholdData/Households.csv

The household records are stored in a CSV file with the following columns in order, identical to the input seed's format:

* HouseholdId
* HouseholdPD
* ExpansionFactor
* DwellingType
* NumberOfPersons
* NumberOfVehicles
* IncomeClass


### HouseholdData/Persons.csv

The person records are stored in a CSV file with the following columns in order, identical to the input seed's format:

* HouseholdId
* PersonNumber
* Age
* Sex
* License
* TransitPass
* EmploymentStatus
* Occupation
* FreeParking
* StudentStatus
* EmploymentPD
* SchoolPD
* ExpansionFactor

### ZonalResidence/*.csv

* HomeZone
* NumberOfWorkers

### WorkerCategories/*.csv

The worker category files provide GTAModel a way of splitting the aggregate workers into different auto accessibility categories. There are
eight files in this directory representing each combination of occupation and employment status category.

Each of the files will contain the following columns

* HomeZone
* WorkerCategory
* Ratio

## Creating a V4.0 Population Scenario

After running the synthesis, you will need to append some files to this directory for it to be compatible with your model. if you review the 
`ZoneData` folder from your input directory you should find some of the following files depending on your version of GTAModel.

* IntrazonalDistance.csv `V4.1+`
* PDs.csv `V4.1+`
* Population.csv `V4.1+`
* Region.csv
* Zones.csv `V4.0`

In all cases copy the base scenario's folder and then update either `Zones.csv` for `Population.csv` depeding on your model's version.

> [!Warning]
> Make sure to include population for your external zones! If you do not there will be no trips made from the external residents into the study area.


## User Interface

When launching V4.0 Population Synthesis you will be presented with a small window that takes in 4 inputs and presents to you a button called `Run`.
To select a file click the button _..._ and it will bring up a directory/file selection dialog to help.

1. `Input Directory`: Select the the location of your *Input File Directory* as described above.
1. `Population Forecast File`: Select the future year population CSV file described above to generate.
1. `Output Directory`: Select the directory that the results will be stored into.  You may wish to create a new folder to store the output into.
1. `Random Seed`: This seed will control the random selection process.  You can leave this to the default unless you want to recreate a particular run.
1. With Everything setup you can press Run and the population will be generated.

