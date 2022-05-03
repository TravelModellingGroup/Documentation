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
1. For each zone randomly draw households until we meet the zone's total population.
    1. When drawing a zone, we do so without replacement to help reduce statistical drift.
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

In addition to the input directory, you will also need to include a CSV file that gives the forecast population you wish to generate.

* Zone
* FuturePopulation


## Output File Directory

The results of the synthesis include the Household and Person records. Additionally, we also export an updated ZonalResidence and WorkerCategories directory that
contain eight CSV files, one for each combination of occupation and non-home-based employment class. For example, "PF.csv" would refer to the combination of "Professional Full-Time".

### HouseholdData/Households.csv

The household records are stored in a CSV file with the following columns in order, identical to the input seed's format:

* HouseholdId
    * A unique number for the household [0, 2147483647].
* Zone
    * The traffic analysis zone that the household resides in.
* ExpansionFactor
    * The factor to expand this record up to get the full population.
* DwellingType
    * 1 - House
    * 2 - Apartment
    * 3 - Townhouse
* NumberOfPersons
    * The number of persons living the house household.
* NumberOfVehicles
    * The number of vehicles owned by the household.
* IncomeClass
    * 1 - $0 to $14,999
    * 2 - $15,000 to $39,999
    * 3 - $40,000 to $59,999
    * 4 - $60,000 to $99,999
    * 5 - $100,000 to $124,999
    * 6 - $125,000 and above
    * 7 - Decline / don't know

### HouseholdData/Persons.csv

The person records are stored in a CSV file with the following columns in order, identical to the input seed's format:

* HouseholdId
    * A unique number for the household that contains this person.
* PersonNumber
    * A unique number within the household for the person.
* Age
* Sex
    * F - female
    * M - male
* License
    * Y - Yes
    * N - No
* TransitPass
    * N - None
* EmploymentStatus
    * O - Not employed
    * F - Full-time
    * P - Part-Time
    * H - Full-time work-at-home
    * J - Part-time work-at-home
* Occupation
    * G - General Office / Clerical
    * M - Manufacturing / Construction / Trades
    * P - Professional / Management / Technical
    * S - Retail Sales and Service
    * O - Not Employed
* FreeParking
    * N - No
    * O - Not applicable
    * Y - Yes
* StudentStatus
    * O - Not a student 
    * P - Part time student
    * S - Full time student
* EmploymentPD
    * 0, the external zone number where they work, or 8888 if they have a non-fixed place-of-work.
* SchoolPD
    * 0, or the external zone number where they go to school.
* ExpansionFactor
    * The factor to expand this record up to get the full population.

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

In all cases copy the base scenario's folder and then update either `Zones.csv` or `Population.csv` depending on your model's version.

> [!Warning]
> Make sure to include population for your external zones! If you do not there will be no trips made from the external residents into the study area.


## User Interface

When launching V4.0 Population Synthesis you will be presented with a small window that takes in 4 inputs and presents to you a button called `Run`.
To select a file click the button _..._ and it will bring up a directory/file selection dialog to help.

1. `Input Directory`: Select the location of your *Input File Directory* as described above.
1. `Population Forecast File`: Select the future year population CSV file described above to generate.
1. `Output Directory`: Select the directory that the results will be stored into.  You may wish to create a new folder to store the output into.
1. `Random Seed`: This seed will control the random selection process.  This number will be used to initialize the random number generator to a fixed state.  This means that if
you run with the same inputs and the same random seed the outputted population will be identical.  Changing this number will generate a slightly different population.
1. With Everything setup you can press Run and the population will be generated.

