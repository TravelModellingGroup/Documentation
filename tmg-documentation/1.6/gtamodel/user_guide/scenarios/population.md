# Population

The population scenario contains the households and persons agents that will be run through GTAModel.

> [!Tip]
> In GTAModel V4 input data is organized into the _Scenario folders_ with the following structure,
> _Scenario-Directory_/_RunYear_/_ScenarioName_.

## Contained Files

* HouseholdData
    * Households.csv
    * Persons.csv
    * Trips.csv (Optional, used only for observed data.)*
* WorkerCategories (V4.0)
* ZonalResidence
* ZoneData
    * ElementaryStudents.csv (V4.2+)
    * HighSchoolStudents.csv (V4.2+)
    * IntrazonalDistance.csv (V4.2+)
    * PDs.csv (V4.1+)
    * Population.csv (V4.1+)
    * PostSecondaryStudents.csv (V4.2+)
    * Regions.csv
    * Zones.csv (V4.0)

### HouseholdData/Households.csv

All trip records need to be sorted so that the `HouseholdId` are sorted ascending.

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
* IncomeClass `(V4.1+)`
    * 1 - $0 to $14,999
    * 2 - $15,000 to $39,999
    * 3 - $40,000 to $59,999
    * 4 - $60,000 to $99,999
    * 5 - $100,000 to $124,999
    * 6 - $125,000 and above
    * 7 - Decline / don't know

### HouseholdData/Persons.csv

All person records need to be sorted so that the `HouseholdId`, and `PersonNumber` are sorted ascending.

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

### HouseholdData/Trips.csv

`Optional, used only for observed data.`

All trip records need to be sorted so that the `HouseholdId`, `PersonNumber`, and `TripNumber` are sorted ascending.

The trips records are stored in a CSV file with the following columns in order:

* HouseholdId
    * The household id for the person making the trip.
* Person Number
    * The id for the person making the trip.
* TripNumber
    * The unique trip number for the person. Trip numbers should be in order.
* StartTime
    * The start time of the trip in the format [hh][mm] with the minutes always being at least 2 digits.  For example `900` is 9:00 AM and `1305` is 1:05 PM.
* Mode
    * The mode code for the trip. These 1 letter codes correspond to the TripChainLoader's "Mode Conversion" parameter.
* PurposeOrigin
    * The purpose of the trip's origin.  Purpose codes are below.
* ZoneOrigin
    * The TAZ of the trip's origin.
* PurposeDestination
    * The purpose of the trip's destination.  Purpose codes are below.
* ZoneDestination
    * The TAZ of the trip's destination.
* JointTourID
    * A unique id within the household for the joint tour, -1 if it is not a joint tour.
* JointTourRep
    * The person number of who is the representative of this joint tour, -1 if it is not a joint tour.


### ZonalResidence/*.csv

* HomeZone
* NumberOfWorkers

### WorkerCategories/*.csv

`This folder is only used in GTAModel V4.0.`

The worker category files provide GTAModel a way of splitting the aggregate workers into different auto accessibility categories. There are
eight files in this directory representing each combination of occupation and employment status category.

Each of the files will contain the following columns

* HomeZone
* WorkerCategory
* Ratio



## Creating a New Scenario

To create a new population scenario you will need to run your [population synthesis algorithm](../PopulationSynthesis/index.md).
Your population synthesis algorithm should provide you with your new `HouseholdData`, `WorkerCategories` (if your model requires it),
and `ZonalResidence` directories.  

For the `ZoneData` directory you will need to do the following:


1. Clone the files from a similar scenario to get your `IntrazonalDistance.csv`, `PDs.csv`, `Population.csv`, `Regions.csv`, and or `Zones.csv`
    to get the starting point.
1. Copy your three student files from population synthesis. (V4.2+)
1. Update the `Zones.csv`'s Population column (V4.0) or `Population.csv` (V4.1+) to match your inputs for population synthesis.
