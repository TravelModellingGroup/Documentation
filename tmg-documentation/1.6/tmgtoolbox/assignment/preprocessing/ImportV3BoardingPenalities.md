# **Import V3 Boarding Penalty**
This tool is used to import boarding penalties into *UT3* (line attribute 3) from a *.txt file. 

The file should be delimited by ';' and must contain the headers 'boarding_penalty' and 'filter_expression'.
- '*boarding_penalty*' indicates an applied peanlty to be stored in UT3
- '*filter_expression*' indicates the expression used by the Emme Matrix Calculator to filter transit lines

For example:
> |boarding_penalty|filter_expression|description|
> |------|------|------|
> |0.0|ut1=26 and mode=m|TTC subway|

In the text file:
>boarding_penalty	; filter_expression	; description
>
>0.0; ut1=26 and mode=m; TTC subway


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Assignment" -> "Preprocessing" -> "Import V3 Boarding Penalty"

### Select Scenario
Select the scenario to execute against. Only one scenario at a time can be selected.

### File with boardings
Browse the *.txt file with the boarding penalty information.


## **Using the Tool with XTMF**
The tool is called "ImportV3BoardingPenalties". It is available to add under *ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

### Data File
Enter a absolute filepath to the file that specifies which boarding penalty to apply to particular filter expressions. 

### Scenario Number
Specify the scenario ID to execute against. Only one scenario at a time can be selected.
