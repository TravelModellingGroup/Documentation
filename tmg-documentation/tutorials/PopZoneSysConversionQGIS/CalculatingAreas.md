# Calculating Area Intersections

Next we need to determine how much of the population `Disemination Areas`(DA) lie within the `Traffic Zones` (TAZ's).
To do this we need to create intersection areas overlay and then later find aggregate populations in those areas.

## Steps
1.	Go to Vector > Geoprocessing tools > Intersection and calculate the intersection of the zones.
 1. Change invalid feature filtering to ‘Skip (Ignore) Features with Invalid Geometries’.
 2. Save intersection to a new shapefile called zonea_zoneb_intersection.

<figure>
    <img src="images/CreatingIntersections.png"
            alt="Add Module"/>
    <figcaption text-align="center">Figure 1: Creating Intersections</figcaption>
</figure>

2. In the new intersection layer, calculate the area following the same process as before, and then create a new 
   attribute to represent the fraction of one zone type that overlaps with the other. For example, if converting 
   DAs to TAZs, you’ll have to create a field or column called `frac_DA_in_TAZ` which compares the size of a given 
   intersection to the DA it’s a part of. The Calculation for this would be: `area_int/area_DA`.
3. The fraction of the DA covered by that intersection is what the DA population will be multiplied by to find the 
   population of that intersection.

<figure>
    <img src="images/Intersection Populations.png"
            alt="Add Module"/>
    <figcaption text-align="center">Figure 1: Intersection Populations</figcaption>
</figure>

## Next Steps

The next step is to copy the intersection attribute table over to excel and complete our calculations there.
