
# **Import Network Update**
This tool can update one or more scenarios using a Network Update (*.nup) file that contains scripts and macros. Macros used to perform a network update are based on Emme's Network Editor, which can sometimes cause an error when network elements are missing. It is recommended to check the Database directory for the created reports file(s). 

> **Create a Network Update (\*.NUP) File** 
> 
> The NUP file is a renamed ZIP file with the following specifications. 
> Two text files need to be created and Macros need to be updated.
> * *info.txt*: Contains information and metadata about the update. The first
            line of the file must be the date of the export. Subsequent lines
            will just be printed verbatim to the page. Lines starting with '*'
            will be displayed as lists.
> * *run_order.txt*: For each line in this file, a script or macro of the same
            name will be executed (currently only macros ending in '.mac' are 
            supported). 
>
>   * For each script named in *run_order.txt*, the corresponding script file must also exist in the NUP file. For Emme macro scripts, the folder containing the sub-components must also exist within the NUP file and have the same name as the script. This folder can be copied from the Database folder of the Emme project which saved the macro (from a Network Editor session). 
> * *macros*: Macro itself also need be edited by replacing all instances of the subfolder's name with '$DIR$'.
>    * For example, if the macro was originally titled "Update_Yonge_St_lanes.mac',
    there will be a folder named "Update_Yong_St_lanes" inside of Database. In the
    .mac file itself, replace all instances of "Update_Yong_St_lanes" with "$DIR$": <br />
> *~<_edb_ 2 211 Update_Yong_St_lanes/00000_nodes* <br />
> becomes <br />
> *~<_edb_ 2 211 $DIR$/00000_nodes* <br />
>
>        It also recommended to replace the "reports=[macro name]-%s%.rep" line with: <br />
>       *reports=$REP$-%s%.rep* <br />
>       *~t9=$REP$-%s%.rep* <br />
>     This ensures that the reports files are written to the Database folder, not
    the temporary directory which gets deleted.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Input Output" -> "Import Network Update"

### Scenarios
Select the scenario(s) to be updated with.

### Network Update file
Select "Browse..." to navigate to the location of the Network Update file (*.nup) that is to be imported. 


## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.
