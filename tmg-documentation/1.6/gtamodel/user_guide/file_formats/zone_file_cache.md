# Zone File Format (.zfc)

## Overview

The zone file format was created to store zonal attributes without needing to load everything into memory.  It was originally designed
during the Pentium 3 era when RAM was extremely limited and serves very little purpose today.  It had a sister format Origin Destination
Cache (.odc) that was used for storing OD matrices of different types for different times of day, caching the results to limit memory
usage.

## Format

The zfc file starts with the following header.

| Field    | Type  |
|----------|-------|
| Version  | Int32 |
| Types    | Int32 |
| Segments | Int32 |

Version gives the version number of the zfc, typically 2.  Types gives the number of different types of data that are stored for each zone.
The segments field gives us the number of zonal segments that are contained.  Each segment is a range of continuous zones allowing for
the zone numbers to have large gaps without using any disk space.

Each segment is then stored with a record in the following format.

| Field        | Type  |
|--------------|-------|
| Start        | Int32 |
| Stop         | Int32 |
| DiskLocation | Int64 |

Start contains the starting Zone number for the segment. Stop contained the last zone of the segment.  DiskLocation stores
the starting location of the data for this segment.

After all of the segments the data is then stored in order from the first zone for each type to the last as a float32.

