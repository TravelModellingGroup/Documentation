# Selecting Vehicle Types

After setting up the transit lines, next we need to select the vehicle types in the GTFS data.
In general, if there are different vehicles of same mode may require separate uploads.

The following are the vehicle mode codes for TTC vehicles:
    
1.	Streetcar - LFLRV30  

2.	Metro
    1.	Line 1 - Sub6carRkt
    2.	Line 2 - Sub6carT1
    3.	Line 3 - SRT4car
    4.	Line 4 - Sub4carT1

3.	Buses - bus12

Now select the correct TTF's. The following are the vehicle codes.
1.	Streetcar - ft3
2.	EROW Streetcar - ft2
3.	TTC currently runs 509, 510, and 512 streetcars EROW but verify at time of upload
4.	Metro - ft1
5.	Bus - ft4
6.	EROW bus - ft6

Note: EROW bus is only marked as TTF6 if using GTA Model V4.2+. For older GTA models the ERROW bus is marked as TTF2.


<figure>
    <img src="images/ChoosingTTFs.png"
        alt="Add Module"/>
    <figcaption text-align="center">Figure 1: Choosing TTFs</figcaption>
</figure>

To ensure correct branch names have all been correctly uploaded and have correct vehicles and TTFs

1.	Open Notebook
2.	Open GTFS Renamer python script
3.	Run first cell to generate CSV of all existing TTC lines
4.	Rework line selection criteria to first char in branch name = x for other regions
5.	Open CSV in excel to perform branch renaming
    1. Use find and replace to modify line names
    2. Replace branch names going from emme automatic format to NCS format
    3. Branch letters switch so branch identifier is first and direction is second
    4. Branch identifier is capitalized and direction lower case
    5. N and E become a and S and W become b
    6. Branch identifiers shift one letter down, blank ones become branch A
    7. Ea -> Ba (E becomes a, a becomes B, switch places)
    8. W -> Ab (W becomes b, _ becomes A, switch places)
    9. Nb -> Ca (N becomes a, b becomes C, switch places)
    10.	Double check cases where Nd or Ed become Ea and make sure that the Ea cases aren`t all changed to Fb
    11.	Create document containing changed names where the first column is the original names, and the second column is the corresponding new name
    12. Use conditional formatting > Highlight duplicate values to ensure that no two branches have the same name, this occurs when a single line has both N and E components or S and W components, something that happens when two branches start in different spots and in different directions
    13. Once all branch names are NCS compliant and no duplicates exist, run the second cell of the python script with current scenario and the filepath to the document with the converted names
