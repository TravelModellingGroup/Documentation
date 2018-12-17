# Assign V4 Boarding Penalties

Assigns line-specific boarding penalties (which will be stored in UT3) based on specified line groupings.

## Opening the Tool

The tool is found in "TMG Toolbox" -> "Assignment" -> "Preprocessing" -> "Assign V4 Boarding Penalty"

## Using the Tool

### Scenarios

Choose the scenarios in which the specified boarding penalties should be applied. Note: More than one scenario can be selected.

### Line Group Boarding Penalties

List of filters and boarding penalties for line groups.

Syntax: [label (line group name)] : [network selector expression] : [boarding penalty] : [IVTT Perception Factor] ...

Separate (label-filter-penalty) groups with a comma or new line.

Note that order matters, since penalties are applied sequentially.
