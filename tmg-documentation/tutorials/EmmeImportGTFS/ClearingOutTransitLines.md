# Clearing out any existing transit lines

Before importing the GTFS data in EMME we first need to delete any pre-existing Transit lines.
This is important to avoid having multiple transit lines in the network.
To remove all TTC transit line data from the network for example, follow the steps below.

## Steps
1.	Data management > Network > Transit > Delete transit lines
2.	To remove all TTC lines use line=T_____
Warning: In order for the above filter to work, the lines being deleted need to have exactly 6 characters. If we had a line in 
the network with less than 6 characters in the name or more than 6 characters, such a line would not be deleted. In other words,
a line with a name such as TABC or T123456 for example, would not be deleted if it was in the network.


The five underscore dashes are wildcard characters that basically ensure every line starting 
with the transit line ID of T is deleted.


<figure>
    <img src="images/ClearingOutTransitLines.png"
            alt="Add Module"/>
    <figcaption text-align="center">Figure 1: ClearingOutTransitLines</figcaption>
</figure>

## Next Steps

Now that we have deleted all previous transit lines, we can proceed to the next step which is Creating network fields.
