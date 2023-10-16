# Area Population Aggregates

We will now continue our work in excel and copy our data from QGIS to excel.

## Steps

1.	Copy the attribute table to excel ordered by `Traffic Zones`(TAZ), see figure 1 below.
2.	Create a new table in your sheet containing columns with TAZ ID, DA ID, fraction of DA in TAZ from your attribute 
    table, and the population in each DA from your population data.
 1. If your population by DA is in a different order you can use a `VLOOKUP()` to get the correct population for each DA.
3.	Multiply the `frac_DA_in_TAZ` by the population in each DA to find the population in each intersection.
4.	Use a pivot table where rows is TAZ ID and values is sum of population in each intersection to aggregate the data 
    to have population in each TAZ.

<figure>
    <img src="images/PopulationOfDAs.png"
        alt="Add Module"/>
    <figcaption text-align="center">Figure 1: Population Of Dissemination Areas</figcaption>
</figure>
    


<figure>
    <img src="images/PopulationInTrafficZoneAggregate.png"
        alt="Add Module"/>
    <figcaption text-align="center">Figure 2: Population In Traffic Zone Aggregates</figcaption>
</figure>


## End
