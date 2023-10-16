# Accessing And Importing Files

Before we can begin our zone system conversion. We will first need to visit the Statcan website and the DMG website in order to
download the files we will need. The steps on how to do this are outlined below.

## Steps
1.	Find shapefiles of both zone systems and download them.
 1. Census boundary files can be found on the StatsCan website here:
    https://www12.statcan.gc.ca/census-recensement/2021/geo/sip-pis/boundary-limites/index2021-eng.cfm?year=21
 2. TAZ shapefiles can be found on the DMG website here: http://dmg.utoronto.ca/survey-boundary-files/
2.	Import both zone systems into QGIS as separate vector layers.
 1. Import only the .shp files and save them to ensure that the attribute table is editable.
3.	Open the attribute table of both shapefiles and use the field calculator to find the area of each zone.
 1. Create a new field or column in the attribute table called system_area and set it to `$area/1000000` to get the area in `km^2`.

<figure>
    <img src="images/CreatingNewShapefileAttributes.png"
            alt="Add Module"/>
    <figcaption text-align="center">Figure 1: Creating New Shapefile Attributes</figcaption>
</figure>

## Next Steps

Once the shape files have been imported and the above steps completed it is time to create the area intersections.
