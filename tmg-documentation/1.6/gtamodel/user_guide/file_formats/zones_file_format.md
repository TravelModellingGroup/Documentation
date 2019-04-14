# Zones.csv File Format

The Zones.csv file format is a standard CSV file with the columns in the given order:

* __Zone Number__
* __Planning District__
* __Population__
* Work General
* Work Manufacturing
* Work Professional
* Work Sales
* Work Unknown
* Employed General
* Employed Manufacturing
* Employed Professional
* Employed Sales
* Employed Unknown
* __X__ (UTM)
* __Y__ (UTM)
* __Internal Distance__
* Retail Level
* Other Level
* Work Level
* Internal Density
* __Parking Cost__
* Arterial Percentage

In GTAModel version 4 most of these fields are no longer in use and have been replaced by other data sources.  The columns in bold above
are the only ones still in use by the model.

For the Internal Distance you can use the formula \\( \frac{2\sqrt{Area}}{6} \\). This will give you the approximate distance between
two randomly selected points in a rectangular zone.