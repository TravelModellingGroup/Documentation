
# Generate Hypernetwork From Schema
This tool generates a hyper-network to support fare-based transit assignment (FBTA), from an XML schema file. Links and segments with negative fare values will be reported to the Logbook for further inspection.

Temporary storage requirements: one transit line extra attribute, one node extra attribute. 
For more information on the Fare Schema please visit [Fare Schema File Specification](https://tmg.utoronto.ca/doc/1.5/gtamodel/fbtn/fare_schema_file_specification.html)
For more information on the hyper network generation procedure please visit [Hypernetwork Generation Procedure](https://tmg.utoronto.ca/doc/1.5/gtamodel/fbtn/hypernetwork_generation_procedure.html)


## Opening the Tool with Modeller
The tool can be found in "TMG Toolbox" -> "Network Editing" -> "Transit Fare Hypernetworks" -> "Generate Hypernetwork From Schema"

## Using the Tool with Modeller
### Fare Schema File
Click "Browse..." to navigate to the location of the stored Fare Schema File

#### Fare Schema File Format
For full details of the File Format, please consult the [Fare Schema File Specification Page](https://tmg.utoronto.ca/doc/1.5/gtamodel/fbtn/fare_schema_file_specification.html)
A sample file is given here.

    <?xml version="1.0" encoding="utf-8"?>
    <root>
        <version number="1.0" />
	        <groups>
		        <group id="TTC Regular">
			        <selection>line=T_____</selection>
		        </group>
			    <group id="GO Transit">
			        <selection>mode=rg</selection>
			    </group>
			</groups>
		    <fare_rules>
			    <!--TTC (Toronto Transit Commission)-->
			    <fare cost="1.98" type="initial_boarding">
				    <group>TTC Regular</group>
			    </fare>
			    <fare cost="-1.98" type="transfer">
				    <from_group>TTC Regular</from_group>
				    <to_group>GO Transit</to_group>
				    <bidirectional>True</bidirectional>
			    </fare>
			    <!-- GO Transit Fares -->
			    <fare cost="4.07" type="initial_boarding">
				    <group>GO Transit</group>
			    </fare>
			    <fare cost="0.0825" type="distance_in_vehicle">
				    <group>GO Transit</group>
			    </fare>
    </root>
### Scenario
The scenario from which the hyper-network is to be generated from is specified here. 

### New Scenario ID
The scenario which will contain the hyper network
### New Scenario Title
The title of the new scenario
### Options and Results
#### Virtual Node Domain
This option allows you to specify where in the node range the virtual nodes will be created. All virtual node IDs created will be greater than this number
#### Transfer Mode
Select an AUX_TRANSIT mode to apply to virtual connector links
#### Segment Fare Attribute
Select a TRANSIT SEGMENT extra attribute which will store the transit fares on the lines that have a distance based fare

#### Segment I-node Attribute
Select a TRANSIT SEGMENT extra attribute in which to save the base node ID. This data is used to implement transit speed updating. Select 'None' to disable this feature.
#### Allow station-to-centroid connections?
This will allow a person to go directly from a centroid to a station without going through a hyper network link.
## Using the Tool with XTMF
The tool is called "BuildFbtnFromSchema". It is available to add under ExecuteToolsFromModellerResource or EmmeToolsToRun.

### Base Scenario
This is number of the Emme scenario from which the hyper network will be generated.
### New Scenario
The number of the scenario that will contain the hyper network
### Link Fare Attribute
The link attribute that will store the fare for travelling on that link. This is used for boarding fares when initially boarding an agency. 
### Segment Fare Attribute
The segment attribute that stores the fare for travelling on the segment. This is used for distance based fares.
### Station Connector Flag
Flag to automatically integrate stations to centroid connectors.
### Transfer Mode
The Emme mode to assign to the new transfer links that will be generated in the hyper network
### Virtual Node Domain
Virtual nodes that will be created in the hyper network will be assigned node numbers that are higher than this number. No existing nodes will be overwritten.
### Fare Schema File
Specify the location of the Fare Schema file here by adding the appropriate module and then selecting the file location. For more information on the exact structure of the file, please see the sample above or visit the [Fare Schema File Specification Page](https://tmg.utoronto.ca/doc/1.5/gtamodel/fbtn/fare_schema_file_specification.html)
