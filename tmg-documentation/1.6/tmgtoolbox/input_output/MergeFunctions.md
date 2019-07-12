
# **Merge Functions**
This tool is used to merge functions that are defined in a standard function transaction file into this emmebank. **Delete and modify commands are ignored**. 


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

| Option | For Non-conflict (Non-existing) Functions | For Conflict (Existing) Functions |
|------|------|------|
|EDIT  | Add new functions| User will decide to keep existing or use new functions | 
|RAISE | No change | No change (Warning will be given) |
|PRESERVE | Add new functions | Keeping existing functions and ignore new functions |
|OVERWRITE | Add new functions | Use new functions and drop existing functions |

For example, 
* Current Emmebank: fd1 = length*50
* Importing Emmebank: fd1 = length*100; fd2 = length/6

| Option | Results for fd1 | Results for fd2 |
|------|------|------|
|EDIT  | will ask user to choose the desired definition for fd1 | fd2 will be added | 
|RAISE | fd1 = length*50, warning will occur | no fd2 will be added |
|PRESERVE | fd1 = length*50 | fd2 will be added | 
|OVERWRITE |fd1 = length*100| fd2 will be added |

### Revert on error
Check the box to revert on error. Default is TRUE.

## **Using the Tool with XTMF**
The tool is not callable from XTMF. Please use Emme Modeller.

