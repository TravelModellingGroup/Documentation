# Full Network Set Generator

## Introduction

Full Network Set Generator (henceforth referred to as Generator) is a tool designed to eliminate many of the standard steps in the TMG workflow. Before, a full base network would need to be divided into time period networks and then all those networks would need to be cleaned before GTAModel could be run. This meant that,in order to prepare a new base network for packaging to a client, one would need to run over 15 tool instances. Now, that is one tool. The goal is that clients will be able to run this tool themselves, eliminating the need to package all five time period networks.

## General Algorithm

Generator calls three other TMG tools: Create Transit Time Period, Prorate Transit Speeds, Remove Extra Links and Remove Extra Nodes. The general framework is shown below.

TODO

## Create Transit Time Period

The first external tool called by Generator is Create Transit Time Period, referred to henceforth as CTTP. CTTP is a useful tool that generates new scenarios for different time periods and uses a service table (a list of trips times) to generate headways and speeds for transit lines in each of those periods. Currently, this tool is run five separate times. 

The parameters and default values for CTTP are as follows:

TODO

Generator calls this tool five times. By default, Generator uses the default CTTP values apart from those listed below. In Generator, these values are stored in Scen#UnNumber, Scen#UnDescription, Scen#Start, Scen#End, where # varies from 1 to 5.

TODO

## Prorate Transit Speed

The next external call is to Prorate Transit Speed. This tool takes overall transit line speeds and apportions speeds to individual transit segments (into us1) based on the link free flow speed (ul2). The parameters and default values are as follows:

TODO

## Remove Extra Links

Remove Extra Links is a tool that cleans the network of unnecessary or detrimental links. This is done in several steps:

* Links with no transit lines, which have only transit modes are deleted.
* Non-connector dead-end links are removed.
* Links with transfer modes that do not connect two stations, or connect a station to the road network are deleted. Links of this nature which have other, non-transfer modes are not deleted; however, the transfer modes are removed from these links. Retaining transfer modes on these links can result in agents being able to bypass paying a fare in the hypernetwork.

The default parameters are listed below.

TODO

## Remove Extra Nodes

Remove Extra Nodes is a tool that “cleans” the network of all cosmetic nodes. For example, a node that does not connect to a centroid connector, is not an intersection and is not a transit stop will be removed. Using extra attributes, the set of nodes to be removed can be expanded to allow for removal of, for example, certain transit stops. This tool is necessary in order to allow for a hypernetwork to be generated that does not exceed the node limit. The default values are listed below:

TODO

## Other Notes

All user-defined attributes in Generator feed into the external calls and are listed in the above sections with the exception of one – OverwriteScenarioFlag. If this is true (it is false be default), any selected already-occupied scenario will be deleted prior to calling the external tools.