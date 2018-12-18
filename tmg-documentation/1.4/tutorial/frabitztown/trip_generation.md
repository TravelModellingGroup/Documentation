# Trip Generation

Part of the 4-Step model approach involves generating productions and attractions for each analysis zone. *Zones.csv* includes the relevant zonal data to create this information. For the sake of simplicity, the attractions and productions
were manually synthesized for each analysis zone.



    * EmploymentRate.csv
    This file contains total zonal attractions in third-normalized form.

    * Population.csv
    This file contains total zonal productions in third-normalized form.

These files are included as part of the input / resources downloaded that is accompanied with this guide. Zone totals
can also be found in the included *Zones.csv* file. The Frabitztown model system only has a single class of employment: *General*. Therefore, the the total amount of trip productions for each zone is simply the total number of workers
for that zone. Likewise, the total number of attractions for each zone is simply the amount of employment.
