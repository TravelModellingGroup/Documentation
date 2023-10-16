# Population Zone System Conversion QGIS - Overview
This is a brief overview of the different sections in the guide on how to perfom a Population Zone System 
Conversion in QGIS.

## Accessing And Importing Files
* [Accessing And Importing Files](AccessingAndImportingFiles.md) - Purpose: To access and import files in QGIS.

Most of the files we will be working with in this guide are publicly available on the StatCan website as well as
the University of Toronto's Data Management Group (DMG) websites. We will need the population Dissemination Area(DA)
shapefile from statcan as well as the Traffic Zone shapefile from the DMG website.

## Calculating Area Intersections
* [Calculating Area Intersections](CalculatingAreas.md) - Purpose: To create a new layer of intersection TAZ 
and DA zones.

In this section, you will use QGIS to create intersection areas of where the DA's and TAZ's zones intersect, so we can
then perfom population area aggregation. This way we can then estimate how much of the population lies within each 
traffic zone.

## Area Population Agregates
* [Area Population Agregates](AreaPopulationAgregates.md) - Purpose: To calculate population aggregates in Excel.

Finally we will use excel to perfom calculations to determine fractional population ratios and determine the Traffic 
populations each zone.
