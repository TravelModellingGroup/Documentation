# **Import Cordon Counts**
This tool is used to validate traffic assignment by comparing assigned volumes with the cordon count results from a file. An extra attribute (@cord) will be created to store the cordon counts on the relevant links. The difference in assigned volumes and counts can be visualized using the *Links* Layer in Emme Desktop (set Bar Value = Volau - @cord).


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Traffic" -> "Import Cordon Counts"

### Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### Cordon Count File (\*.csv)
Select "Browse..." to navigate to the cordon count file that contains at least three columns: countpost IDs, link IDs, and cordon counts. An extra attribute (@cord) will be created or overwritten to store the cordon counts.


## **Using the Tool with XTMF**
The tool is called "CordonCountEstimation".  It is available to use as a standalone module.

#### Absolute Error Factor
The factor applied to *the sum of each station's Abs(error)*.

#### Input Directory
Specify the input directory for this model system.

#### Mean Squared Error Factor
The factor applied to *the sum of each station's (error)^2*.

#### Total Error Factor
The factor applied to *the sum of error*.

### Model Output FIle
A CSV file contains the modelled traffic volumes with the first column being the name and the second column being the value.

### Station Name Map File
A mapping between the truth data and the model data's names for stations.

### Truth File
A CSV file contains the cordon counts with the first column being the name and the second column being the value.
