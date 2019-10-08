# V4Input Directory Structure

This section describes how files are organized within the XTMF project input directory.  Depending on your base version of GTAModel
the exact structure will change.  If your model system was constructed outside of TMG please contact your provider for
your model's specific layout.

> [!NOTE]
> There is a significant change in file structure starting in GTAModel V4.0.2 and continuing into GTAModel V4.1 in order to help organize model runs.

# [**GTAModel V4.1.0**](#tab/tabid-1)

> [!Tip]
> In GTAModel V4.1.0 input data is organized into the _Scenario folders_ with the following structure:
> 1. Run Year
> 2. Scenario Name

> The scenario names are not required to be the same between the different scenario folders.

#### Activity Distributions

This directory contains the information on how to generate activity episodes.  Between runs these files should not change unless it has been recalibrated.

#### Base Year Matrix

Files contained in this directory are used for estimation and validation purposes.

The folder `AccessStationInitialCapacities` contains a CSV vector for each time period with the ratio of the number of parking
spots for each station that are occupied.

#### Estimation

This directory contains the parameters used to estimate the different models contained within GTAModel.

#### Estimation Result

This directory contains the results of the estimation process for GTAModel V4.1.  The files contained
within are not used in the model system.

#### Scenario-Employment

* EmpOccRates: A folder containing a CSV file for each employment category rate of jobs belonging to the category.
* ExternalRates: A folder containing a CSV file for each employment category with the rate of jobs belonging to external workers.
* WaHRates: A folder containing a CSV file for each employment category with the rate of jobs belonging to workers who work from home.
* TotalEmploymentByZone.csv: This file contains a CSV mapping each zone to the total employment contained within.

> [!NOTE]
> All rates in the default GTAModel V4.1.0 are computed at the zonal level.

#### Scenario-Network

Each year contains a file called BaseNetwork.nwp containing the master network.  Each scenario then contains a set of files
that are used for generating the time period networks.  More information can be found [here](file_formats/network_scenario_format.md) describing their format.

#### Scenario-Population

* HouseholdData:
  * Households.csv: 
  * Persons.csv: 
* ZonalResidence: For each occupation and employment category a CSV exists containing two columns:
Zone, and the number of workers in that zone that work within the GTHA and the number of non-roaming workers of that
category living in that zone.
* ZoneData: 
  * IntrazonalDistance.csv: A CSV File in the format (Zone, Distance) describing the expected distance in metres that a trip will take.  This is usually done with \\( \frac{2\sqrt{Area}}{6} \\).
  * PDs.csv: A CSV file in the format (Zone, PD) describing the planning district that each zone belongs in.  Zones not specified will be assigned to PD 0. 
  * Population.csv: A CSV file in the format (Zone, Population) describing the population for each zone.  Zones that are not defined will get a population of zero.
  * Regions.csv: A CSV file with two columns: (Zone, Region).  Each zone can only belong to a single region.  External zones
    should be absent or given a region number of 0.

#### Scenario-Stations

* StationCapacity.csv: A CSV file with the columns in the order of Zone and Capacity for each station zone.

#### Scenario-Transit Fares

* Fare Rules.xml: An XML file in the [fare schema format](file_formats/fare_schema_file_specification.md) describing the fare policies
    when initially boarding or transferring between transit agencies.
* York_Region_Zone: A folder containing a shapefile that shows the different fare zones for York Region.

#### Scenario-School

* ElementaryStudents.csv: A CSV vector containing the number of students from TTS by home zone.
* ElementaryStudentsLinkages.csv: A square CSV matrix of home zone to school zone linkages from TTS
        for the elementry school aged students.
* HighschoolStudents.csv: A CSV vector containing the number of students from TTS by home zone.
* HighschoolStudentsLinkages.csv: A square CSV matrix of home zone to school zone linkages from TTS
        for the highschool aged students.
* PostSecondaryStudents.csv: A CSV vector containing the number of students from TTS by home zone.
* PostSecondaryStudentsLinkages.csv: A square CSV matrix of home zone to school zone linkages from TTS
        for the post secondary aged students.

#### Validation

* RoadCounts
  * Screenline Mapping 2.csv: This file contains a mapping of screenline names to the station numbers within
    TMG's base year network.  This file is used in the model system.
  * Screenline Mapping.csv: This file contains the same mapping of screenline names to the station numbers
    with the addition of local screenline names and local station ids.

# [**GTAModel V4.0.2**](#tab/tabid-2)

> [!Tip]
> In GTAModel V4.0.2 input data is organized into the _Scenario folders_ with the following structure:
> 1. Run Year
> 2. Scenario Name

> The scenario names are not required to be the same between the different scenario folders.

#### Activity Distributions

This directory contains the information on how to generate activity episodes.  Between runs these files should not change unless it has been recalibrated.

#### Base Year Matrix

Files contained in this directory are used for estimation and validation purposes.

The folder `AccessStationInitialCapacities` contains a CSV vector for each time period with the ratio of the number of parking
spots for each station that are occupied.

#### Estimation

This directory contains the parameters used to estimate the different models contained within GTAModel.

#### Estimation Result

This directory contains the results of the estimation process for GTAModel V4.  
The mode choice algorithm’s parameters are read in from this directory.  
For re-calibration you can edit the mode choice’s values, please contact TMG before doing this though for guidance.

> [!NOTE]
> In GTAModel V4.0 the mode choice estimation results are used in order to setup the parameters for the run.  Starting in
> GTAModel V4.1 the parameters are directly integrated into the model system.

#### Scenario-Employment

* EmpOccRates: A folder containing a CSV file for each employment category rate of jobs belonging to the category.
* ExternalRates: A folder containing a CSV file for each employment category with the rate of jobs belonging to external workers.
* WaHRates: A folder containing a CSV file for each employment category with the rate of jobs belonging to workers who work from home.
* TotalEmploymentByZone.csv: This file contains a CSV mapping each zone to the total employment contained within.

> [!NOTE]
> All rates in the default GTAModel V4.0.2 are computed at the planning district level. Some versions of the model have
> changed this to work at the zonal level.

#### Scenario-Network

Each year contains a file called BaseNetwork.nwp containing the master network.  Each scenario then contains a set of files
that are used for generating the time period networks.  More information can be found [here](file_formats/network_scenario_format.md) describing their format.

#### Scenario-Population

* HouseholdData:
  * Households.csv: 
  * Persons.csv: 
* WorkerCategories: For each occupation and employment category a CSV file is exists containing with three columns:
Zone, WorkerCategory, and the ratio of that worker category for the given zone.
* ZonalResidence: For each occupation and employment category a CSV exists containing two columns:
Zone, and the number of workers in that zone that work within the GTHA and the number of non-roaming workers of that
category living in that zone.
* ZoneData: 
  * Zones.csv: Contains information related to each zone in the zone system.  A detailed description of the format can be found [here](file_formats/zones_file_format.md).
  * Zones.zfc: A binary cached version of the Zones.csv.  Starting in XTMF1.5 this file is no longer created during the model run.
  * Regions.csv: A CSV file with two columns: (Zone, Region).  Each zone can only belong to a single region.  External zones
    should be absent or given a region number of 0.

#### Scenario-Stations

* StationCapacity.csv: A CSV file with the columns in the order of Zone and Capacity for each station zone.

#### Scenario-Transit Fares

* Fare Rules.xml: An XML file in the [fare schema format](file_formats/fare_schema_file_specification.md) describing the fare policies
    when initially boarding or transferring between transit agencies.
* York_Region_Zone: A folder containing a shapefile that shows the different fare zones for York Region.

#### School

* BaseYearStudentLinkages-Elementry.csv: A square CSV matrix of home zone to school zone linkages from TTS
        for the elementry school aged students.
* BaseYearStudentLinkages-Highschool.csv: A square CSV matrix of home zone to school zone linkages from TTS
        for the highschool aged students.
* BaseYearStudentLinkages-PostSecondary.csv: A square CSV matrix of home zone to school zone linkages from TTS
        for the post secondary aged students.
* ElementaryStudentsByZone2011.csv: A CSV vector containing the number of students from TTS by home zone.
* HighschoolStudentsByZone2011.csv: A CSV vector containing the number of students from TTS by home zone.
* UniversityStudentsByZone2011.csv: A CSV vector containing the number of students from TTS by home zone.

#### Validation

* RoadCounts
  * Screenline Mapping 2.csv: This file contains a mapping of screenline names to the station numbers within
    TMG's base year network.  This file is used in the model system.
  * Screenline Mapping.csv: This file contains the same mapping of screenline names to the station numbers
    with the addition of local screenline names and local station ids.
 

# [**GTAModel V4.0.1**](#tab/tabid-3)

#### Activity Distributions

This directory contains the information on how to generate activity episodes.  Between runs these files should not change unless it has been recalibrated.

#### Estimation Result

This directory contains the results of the estimation process for GTAModel V4.  
The mode choice algorithm’s parameters are read in from this directory.  
For re-calibration you can edit the mode choice’s values, please contact TMG before doing this though for guidance.

> [!NOTE]
> In GTAModel V4.0 the mode choice estimation results are used in order to setup the parameters for the run.  Starting in
> GTAModel V4.1 the parameters are directly integrated into the model system.

#### Employment

There are a couple different sub-directories inside of this directory.  The first, ‘EmpOccRates’, contains the probability of being part of an occupation and employment status for each zone.  The second, ‘WorkerCategories’ contains the probability of being in a worker mobility category.  This the first two directories are generated from population synthesis.  The third directory is ‘ZonalResidence’.  This directory contains the number of residents in each zone that belong to the employment status and occupation.

#### Estimation

This directory contains all of the parameter files used in estimation.  Unless you are re-calibrating GTAModel there are no files here to edit.

#### Household Data

This directory contains the household and person files for the synthetic population. Titled Household.csv and Persons.csv respectively. In addition, you may have a Summary.csv file which contains the sum of the two aforementioned files.

#### School

This directory contains the base year school linkages and the vectors of students by zone in order to do future year updating.

#### Stations

This directory contains information for every station that provides drive-access capabilities.  If you are going to add a new station to the model a corresponding entry must be made into the ‘StationCapacity.csv’ database.  Follow the guidelines in the section for “Adding a new Station” for more information.

#### Transit Fares

This directory contains the information used to generate the transit hyper-networks.

#### Validation

This directory will contain different worksheets and other files used for highly detailed analysis of the model’s performance.  It will also contain EMME worksheets for visualization of results.

#### Zone Data

This directory contains the information to generate the zone system for the model.  Every centroid in EMME must be represented in the zones file.  The regions file contains a linkage of zones to region, if left out a zone will belong to the null/external region (region 0).

***



