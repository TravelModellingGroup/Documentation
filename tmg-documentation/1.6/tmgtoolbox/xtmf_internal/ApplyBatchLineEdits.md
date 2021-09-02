# **Apply Batch Line Edits**
This tool is used to make changes to headways and speeds of transit lines in a set of scenarios. `ApplyBatchLineEdits` processes a csv file that is seleceted through XTMF.

Example file header:
> |filter|x_hdwchange|x_spdchange|
> |------|------|------|
<!-- > |line=T501|1|1| -->

Where:
>filter is a network calculator filter expression
>
>x refers to the scenario number
>
>hdwchange and spdchange are factors by which to change headways and speeds for the filtered lines
>
>x columns can be multiple (ie. multiple definitions in a single file)

Example file with multilple defintions in a single file:

> |filter|10_hdwchange|10_spdchange|20_hdwchange|20_spdchange|
> |------|------|------|------|------|
> |line=T501|1|1|0.5|1|


## **Using the Tool with Modeller**
`ApplyBatchLineEdits` tool is not callable from Modeller. It is intended only to be called from XTMF.

The tool can be found in "TMG Toolbox" -> "XTMF Internal" -> "Apply Batch Line Edits". 


## **Using the Tool with XTMF**
The tool is called "ApplyBatchLineEdits". In XTMF, it is available to add under **ExecuteToolsFromModellerResource** or **EmmeToolsToRun**.

### Input Data File
Enter an absolute filepath to the file that specifies which headways and speeds to change based on a particular filter expressions. 

### Additional Input Data File (optional)
Can be either a string containing 'None' or a list of additional alt files ; separated..

### Scenario Number
Specify the scenario ID to execute against. Only one scenario at a time can be selected.
