
# **Merge Functions**
This tool is used to merge functions that are defined in a standard function transaction file into this emmebank. Delete and modify commands are ignored. New functions are simply merged in.


## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Input Output" -> "Merge Functions"

### Functions File
Select "Browse..." to navigate to the location of the functions file that is to be imported. 

### Conflict Resolution Option
Select one of the four following options for this tool to perform if conflicts in functional definitions are detected:
* EDIT: Launch an editor GUI to resolve conflicts manually. (Default)
* RAISE: Raise an error if any conflicts are detected.
* PRESERVE: Preserve functional definitions from the current Emme project.
* OVERWRITE: Overwrite functional definitions from the function file.

### Revert on error
Check the box to revert on error. Default is TRUE.

## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.

