# Full Network Set Generator

## Introduction

Full Network Set Generator (henceforth referred to as **Generator**) is a tool designed to eliminate many of the standard steps in the TMG workflow. Before, a full base network would need to be divided into time period networks and then all those networks would need to be cleaned before GTAModel could be run. This meant that,in order to prepare a new base network for packaging to a client, one would need to run over 15 tool instances. Now, that is one tool. The goal is that clients will be able to run this tool themselves, eliminating the need to package all five time period networks.

## General Algorithm

**Generator** calls other TMG tools, including *Create Transit Time Period*, *Prorate Transit Speeds*, *Remove Extra Links*, and *Remove Extra Nodes*. The general framework is shown below.

![alt text](images/FullNetworkSetGenerator.png "Full Network Generator Framework")


## Create Transit Time Period

The first external tool called by **Generator** is *Create Transit Time Period*, referred to henceforth as **CTTP**. 

CTTP is a useful tool that generates new scenarios for different time periods and uses a service table (a list of trips times) to generate headways and speeds for transit lines in each of those periods. Currently, this tool is run five separate times. 

The parameters and default values for CTTP are as follows:

|Parameter|Default Value|Description|
|---------|-------------|-----------|
|Base Scenario|Primary scenario|The scenario corresponding to the full base network that the user would like to work from|
|New Scenario Number|-|Scenario number to store the time period network|
|New Scenario Description|-|Title for the new scenario|
|Transit Service Table File|-|File location for the service table. <br/> The service table should be organized with the following header: *emme_id*, *trip_depart*, and *trip_arrive*.|
|Alternative Data File (Optional)|-|File location for alternative data file, containing headways and speeds for transit lines that are not listed in the service table or for which the user would like to override service table data. <br/> The alternative data file should be organized with the following header: *emme_id*, *xxxx_hdw*, and *xxxx_spd*, where *xxxx* corresponds to the start time of the time period to associate the data with. There can be multiple pairs of hdw/spd data in the *.csv file, with different values for xxxx. <br/> Note: Transit lines with a headway of ‘9999’ will be deleted from the time period network. Transit lines with a headway of ‘0’ will not be modified in the time period network.|
|Agg Type Selection File|-|This file specifies, for each line, what type of aggregation to use – naïve or average. *Naïve* sums up all trips in a time period and divides by the time period length; *Average* averages all headways throughout the period. <br/> The aggregation type selection file should be organized with the following header: *emme_id* and *agg_type*. This file can be generated using '*Create Aggregation Selection File*'.|
|Default Agg|naïve|Specifies which aggregation type to use for lines NOT listed in *Agg Type Selection File*.|
|Time Period Start|-|Start of the time period. User integer time, e.g., 2:30PM should be 1430.|
|Time Period End|-|End of the time period. User integer time, e.g., 2:30PM should be 1430.|


**Generator** calls this tool five times. By default, **Generator** uses the default **CTTP** values apart from those listed below. In **Generator**, these values are stored in *Scen#UnNumber*, *Scen#UnDescription*, *Scen#Start*, and *Scen#End*, where # varies from 1 to 5.

|#|New Scenario Number <br/> (Scen#UnNumber)|New Scenario Description <br/> (Scen#UnDescription)|Time Period Start <br/> (Scen#Start)|Time Period End <br/> (Scen#End)|
|-|-------------------|------------------------|-----------------|---------------|
|1|10|AM Uncleaned|600|900|
|2|20|MD Uncleaned|900|1500|
|3|30|PM Uncleaned|1500|1900|
|4|40|EV Uncleaned|1900|2400|
|5|49|ON Uncleaned|0|600|


## Prorate Transit Speed

The next external call is to **Prorate Transit Speed**. This tool takes overall transit line speeds and apportions speeds to individual transit segments (stored in *us1*) based on the link free flow speed (*ul2*). The parameters and default values are as follows:

|Parameter|Default Value|Generator Default Value|Description|
|---------|-------------|-----------------------|-----------|
|Scenario|Primary Scenario|10; 20; 30; 40; 49|The scenario to apply the tool to. **Generator** applies this tool to the scenarios created by **CTTP** in the previous step (i.e., Scen#UnNumber).|
|Line Filter Expression|-|'line=______ xor line=TS____ xor line=GT____'|The transit lines to apply the tool to. By default, **Generator** applies this tool to all transit lines except for TTC subways and GO trains due to hand-coded *us1* values.|


## Remove Extra Links

**Remove Extra Links** is a tool that cleans the network of unnecessary or detrimental links. This is done in several steps:

* Links which have no transit lines but only transit modes are deleted.
* Non-connector dead-end links are removed.
* Links with transfer modes that do not connect two stations, or connect a station to the road network are deleted. Links of this nature which have other, non-transfer modes are not deleted; however, the transfer modes are removed from these links. Retaining transfer modes on these links can result in agents being able to bypass paying a fare in the hypernetwork.

The default parameters are listed below.

|Parameter|Default Value|Generator Default Value|Description|
|---------|-------------|-----------------------|-----------|
|Base Scenario|Primary Scenario|10; 20; 30; 40; 49|The scenario to be cleaned. **Generator** applies this tool to the scenarios created by **CTTP** (i.e., Scen#UnNumber).|
|Transfe Mode List|t, u, y|'tuy'|Modes used to transfer between transit stops, or to transit stops. <br/> Default list contains three modes: **t**-Transfer between two transit lines for the same transit agency, **u**-Transfer between two different transit agencies, **y**-Walk between park & ride lot and a transit station.|
|New Scenario Flag|True|True|If True, new scenario will be created. If False, current scenario will be overwritten.|
|New Scenario ID|-|11; 21; 31; 41; 50|To store the cleaned scenario to. From Scen#Number in **Generator**.|
|New Scenario Description|-|AM Cleaned; MD Cleaned; PM Cleaned; EV Cleaned; ON Cleaned|Title for the cleaned scenario. From Scen#Desciption in **Generator**.|


## Remove Extra Nodes

Remove Extra Nodes is a tool that “cleans” the network of all cosmetic nodes. For example, a node that does not connect to a centroid connector, is not an intersection and is not a transit stop will be removed. Using extra attributes, the set of nodes to be removed can be expanded to allow for removal of, for example, certain transit stops. This tool is necessary in order to allow for a hypernetwork to be generated that does not exceed the node limit. The default values are listed below:

|Parameter|Default Value|Generator Default Value|Description|
|---------|-------------|-----------------------|-----------|
|Base Scenario|Primary Scenario|10; 20; 30; 40; 49|The scenario to be cleaned. **Generator** applies this tool to the scenarios created by **CTTP** (i.e., Scen#UnNumber).|
|Node Filter Attribute ID|No attribute|No attribute|Extra attribute used to change the selection of nodes. By default, all nodes will be accepted.|
|Stop Filter Attribute ID|No attribute|No attribute|Extra attribute used to change the selection of transit stops. By default, all stops will be accepted. Recommended to use *@stop* (all nodes value = 1) to allow for removal of some transit stops, otherwise node limit will be exceeded in hypernetwork.|
|Connnector Filter Attribute ID|No attribute|No attribute|Extra attribute used to allow removal of selected nodes attached to connectors. Will remove affected connectors.|
|Attribute Aggregator String|'vdf: force, <br/> length: sum, <br/> type: first, <br/> lanes: avg, <br/> ul1: avg, <br/> ul2: force, <br/> ul3: avg, <br/> dwt: sum, <br/> dwfac: force, <br/> ttf: force, <br/> us1: avg_by_length, <br/> us2: avg, <br/> us3: avg, <br/> ui1: avg, <br/> ui2: avg, <br/> ui3: avg'|'vdf: force, <br/> length: sum, <br/> type: first, <br/> lanes: force, <br/> ul1: avg, <br/> ul2: force, <br/> ul3: force, <br/> dwt: sum, <br/> dwfac: force, <br/> ttf: force, <br/> us1: avg_by_length, <br/> us2: avg, <br/> us3: avg, <br/> ui1: avg, <br/> ui2: avg, <br/> ui3: avg, <br/> @stn1: force, <br/> @stn2: force'|Choose which functions to apply to attributes when combining affected links. Will apply *avg* to all extra attributes if not specified.|


## Other Notes
All user-defined attributes in **Generator** feed into the external calls and are listed in the above sections with the exception of one – **OverwriteScenarioFlag**. If this is set as True (by default, it is False), any selected already-occupied scenario will be deleted prior to calling the external tools.