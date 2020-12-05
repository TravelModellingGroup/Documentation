# Spatial Index
Contains a class for indexing (organizing) geometry. This allows for smarter and faster lookup when testing for geometric intersection. This is important for certain applications such as CCGEN.

The key class is `GridIndex`, which accepts all geometry types (point, polyline, or polygon).
