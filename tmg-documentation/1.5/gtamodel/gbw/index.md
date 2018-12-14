# General Base Workflow
Associated tool names in italics
1. Start with the pristine, fully NCS11-compliant full base network
2. Import a zone system if one is not in place. Use a scenario known to work fine. (Copy Zone System)
3. (might not be required) Connect centroids (CCGEN). 
4. Create a node extra attribute (default value = 1) to allow for removal of transit stops later on (Create extra attribute)
5. (might not be required) Create a link extra attribute (default value = 0) called @z407. (Create extra attribute)
6. (might not be required) Assign values to @z407. Can be loaded in from a text file. (Import attribute values)
7. (in development) Make an aggregation selection file so that headway generation can be performed using naïve or average aggregation. (Create Aggregation Selection File)
8. Split the full base into time period bases. (Create Time Period Network)
AM = 0600-0900
MD = 0900-1500
PM = 1500-1900
EV = 1900-2400
ON = 0000-0600
9. Assign values to us1 for all transit segments. Filter:
line=______ xor line=TS____ xor line=GT____
 (Prorate transit speeds)
10. Clean the time period networks using the parameters listed (Remove Extra Nodes). Apply @stop as the stop filter.
vdf: force
length: sum
type: first
lanes: force
ul1: avg
ul2: force
ul3: force
dwt: sum
dwfac: force
ttf: force
us1: avg_by_length
us2: avg
us3: avg
@stn1: force
@stn2: force

11. In order to send an edited network back to the network caretaker, first make sure to remove the zone system. Use Delete Nodes with subset i = 0,9000
12. Then use Export Network Package to prepare the network for sending.
