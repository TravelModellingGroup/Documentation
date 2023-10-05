# Clearing out any existing transit lines

Before importing the GTFS data in EMME we first need to delete any pre-existing Transit lines.
This is important to avoid having mutiple transit lines in the network.
To remove all TTC transit line data from the network for example, follow the steps below.

## Steps
1.	Data management > Network > Transit > Delete transit lines
2.	To remove all TTC lines use line=T_____


The five underscore dashes are wildcard characters that basically ensure every line starting 
with the transit line ID of T is deleted.


<figure>
    <img src="images/ClearingOutTransitLines.png"
            alt="Add Module"/>
    <figcaption text-align="center">Figure 1: ClearingOutTransitLines</figcaption>
</figure>

## Next Steps

Now that we have deleted all previous transit lines, we can proceed to the next step which is Creating network fields.
