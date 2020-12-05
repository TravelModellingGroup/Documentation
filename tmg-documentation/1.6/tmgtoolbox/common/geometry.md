# Geometry
Provides functions for geometry and ESRI shapefile interaction. Knits three Python libraries: `shapely`, `shapelib`, and `dbflib` into one unified interface for working with geometry.

> The `Shapely` library supports all manner of geometric operations, including intersection testing, set theory operations of polygons, linear offsets, and affine transformations. 
> A manual for `Shapely` is available at http://toblerity.org/shapely/manual.html.

**Shapely2ESRI** is a Class for converting Shapely geometric object to/from ESRI Shapefile format. It also loads the associated DBF if available, so that fields can be accessed as part of the returned Shapely geometries. It can be used in a `with` statement.

The functions used to convert Emme **Network** objects into **Shapely** geometries are  `nodeToShape()`, `linkToShape()`, and `transitLineToShape()`.
