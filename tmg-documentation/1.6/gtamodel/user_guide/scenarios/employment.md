# Employment

The employment scenario contains land-use information regarding the jobs each TAZ contains.  These jobs
are broken done further by the number by classifying them with occupation type and employment status, whether
or they are done at home, and if they are held by a person who lives outside of the simulation.

In addition to jobs the employment scenario also often includes input files for the Truck models.

> [!Tip]
> In GTAModel V4 input data is organized into the _Scenario folders_ with the following structure,
> _Scenario-Directory_/_RunYear_/_ScenarioName_.

## Contained Files

For employment you have the following file and directories:

* EmpOccRates: A folder containing a CSV file for each employment category rate of jobs belonging to the category.
* ExternalRates: A folder containing a CSV file for each employment category with the rate of jobs belonging to external workers.
* WaHRates: A folder containing a CSV file for each employment category with the rate of jobs belonging to workers who work from home.
* TotalEmploymentByZone.csv: This file contains a CSV mapping each zone to the total employment contained within.


Each directory contains either files, corresponding to each of the four occupations and Full-Time or Part-Time.  The four occupations
are:

* P - Professional / Managerial
* G - General / Clerical Office Worker
* S - Sales / Retail
* M - Manufacturing / Construction

This gives us a file name of `PF.csv` as Professional-Full-Time.

> [!NOTE]
> All rates in the default GTAModel V4.1+ are computed at the zonal level.

If your version of GTAModel contains a freight/truck model the input files will be either in a directory called `Freight` or `TruckModel`.

Contained within this truck directory will be the following files:

* AM_Directional.csv - A matrix given planning districts to control the flow of medium and heavy trucks.  It has three columns: OriginPD, DestinationPD, and a Factor to apply.
* cbd.csv - This file gives each TAZ a ratio of how much of a "CBD" (central business district) it is.
* emp_xy.csv - This file gives how much employment of each two-digit NAICS code there is for each TAZ.
* est_xy.csv - This file gives how many establishments of each two-digit NAICS code there is for each TAZ.
* External-Heavy.csv - This contains how many heavy trucks we are expecting to come (and go out) for the external zones.
* External-Light.csv - This contains how many light trucks we are expecting to come (and go out) for the external zones.
* External-Medium.csv - This contains how many medium trucks we are expecting to come (and go out) for the external zones.
* PM_Directional.csv - A matrix given planning districts to control the flow of medium and heavy trucks.  It has three columns: OriginPD, DestinationPD, and a Factor to apply.
* rural.csv - This file gives each TAZ a ratio of how much of is it classified as rural.
* Special-Heavy.csv - This contains how many heavy trucks we are expecting to come (and go out) for the special generator zones.
* Special-Light.csv - This contains how many light trucks we are expecting to come (and go out) for the special generator zones.
* Special-Medium.csv - This contains how many heavy trucks we are expecting to come (and go out) for the special generator zones.
* suburban.csv - This file gives each TAZ a ratio of how much of is it classified as suburban.
* total_households.csv - The total number of households in each TAZ.
* urban.csv - This file gives each TAZ a ratio of how much of is it classified as urban (but not CBD).  It has two columns, TAZ, the ratio [0.0-1.0]

The sum for each TAZ for `cbd.csv`, `rural.csv`, `suburban.csv`, and `urban.csv` should add up to one.

> [!WARNING]
> In older versions of GTAModel if you accidentally add an extra column to any
of the two column CSV files the vector might not be loaded in correctly.

## Creating a New Scenario

When we create a new employment scenario the only file that we modify is
`TotalEmplyomentByZone.csv`, which is updated with updated total jobs by TAZ.  In very special cases you may wish to also modify the
ratios within `EmpOccRates`, for example if you are transforming a TAZ into a large shopping mall from an old industrial facility you
will want to change the employment-occupation rates to include more sales instead of manufacturing.

This still leaves the question of what to do with the Truck model inputs.  On the employment side we can apply
some rates based on the changes made to `TotalEmploymentByZone.csv`.  The establishment files however are another story, they
do not increase linearly with population.  TMG is currently exploring the topic however, for the meantime it is most common to
keep the establishments constant across scenarios.
