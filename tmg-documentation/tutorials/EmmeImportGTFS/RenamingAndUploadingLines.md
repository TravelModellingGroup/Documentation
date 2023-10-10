# Renaming and Importing GTFS Line Data

Before the GTFS data is imported into the network, it needs to be updated to match our coding standard.
This makes it a lot easier to work with.

## Steps

1.	Open Routes.txt in excel
2.	Use Data > Text to Columns
3.	Add leading T and zeros in excel
    1. Leading TS for subways, still 6 digits long


To help with the renaming of the routes, we have created a script that can be made into a tool in Emme 
using python. The script is referenced below.

```python
# Get list of transit line names to be changed

import inro.modeller as m
import csv

_m = m.Modeller()
databank = _m.emmebank
scenario = databank.scenario(14)
network = scenario.get_network()

with open('network_names.csv', mode='w', newline='') as csvfile:
    filewriter = csv.writer(csvfile)
    filewriter.writerow(['Old Name', 'New Name'])
    
    for line in network.transit_lines():

        if line.id[0] == "T":
            filewriter.writerow([line.id])


# Rename Transit Lines using CSV of fixed names

import inro.modeller as m
import pandas as pd

_m = m.Modeller()
databank = _m.emmebank
scenario = databank.scenario(14)
network = scenario.get_network()

#Note:Replace the file location below with the directory where the Fixed Names CSV file is located

file_path = r"C:\Users\mukukaje\Documents\Fixed Names.csv"

def replace_name(network, old, new, delay):
    
    line = network.transit_line(old)
    check = network.transit_line(new)
    
    if line is not None:
        if check is not None:
            delay.append((old, new))
            return
    
        line.id = new
    return

    
with open(file_path, "r") as f:
    
    header = True
    delay = []
    
    for line in f.readlines():
        if header == True:
            header = False
            continue
        parts = line.split(",")
        if len(parts) >= 2:
            original = parts[0].strip()
            new = parts[1].strip()
            replace_name(network, original, new, delay)
    
    while len(delay) > 0: 
    
        new_delay = []

        for line in delay:
            replace_name(network, line[0], line[1], new_delay)
        
        if len(delay) == len(new_delay):
            print("bad lines:" )
            for line in new_delay:
                print(line)
            raise Exception("raise exception")
            
        delay = new_delay

    
scenario.publish_network(network)

```


After the naming is done, the GTFS data can now be imported in the network.

## Steps
1.	Data management > Network > Transit > Import from GTFS 
2.	Browse directory for folder containing lines
3.	Necessary documents are:
    1. Agency.txt
    2. Calendar.txt
    3. Calendar_dates.txt
    4. Routes.txt
    5. Shapes.txt
    6. Stop_times.txt
    7. Stops.txt
    8. Trips.txt


<figure>
    <img src="images/RenamingAndUploadingLines.png"
        alt="Add Module"/>
    <figcaption text-align="center">Figure 1: Renaming and Uploading GTFS Lines</figcaption>
</figure>
    

Next proceed to set time and day service details.
1.	Select day that ensures lines are representative of usual service
2.	Do not select a holiday or weekend
3.	Select whole day time period to ensure all time periods are represented
    1. 00:00 Start time
    2. 23:59 End time

<figure>
    <img src="images/SetDayAndTime.png"
        alt="Add Module"/>
    <figcaption text-align="center">Figure 2: Set Day and Time</figcaption>
</figure>


That done, proceed to do the following
1.  Select all route types for upload
2.	Trams, Metros, and Buses
3.	Select correct agency
4.	Select all routes to be uploaded
5.	Click the arrow next to `Select` to highlight all boxes

<figure>
    <img src="images/ImportingRouteTypes.png"
        alt="Add Module"/>
    <figcaption text-align="center">Figure 3: Importing Route Types</figcaption>
</figure>

Now Select user created Route name, Trip ID, and Stop name network fields, all other network fields are optional and not used in GTAModel

<figure>
    <img src="images/SelectingUserCreatedRoutesandTripIds.png"
        alt="Add Module"/>
    <figcaption text-align="center">Figure 4: Selecting User Created Routes and Trip Ids</figcaption>
</figure>

## Next Steps

Now we are ready to select the different vehicle types in our network.
