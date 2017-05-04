Appendix
####################################################

List of Files Required
====================================================
Zones.csv
    This file contains the zone information for Frabitztown. Zones.csv is in a format that is understood by the
    BasicTravelDemandModel. Zones.csv provides context to BasicTravelDemandModel - such as information about the amount of zones.
     
ZoneAttractions.csv
    This file contains the amount of attractions for each zone in third-normalized form.

ZoneProductions.csv
    This file contains the amount of productions for each zone in third-normalized form.
	
	
XTMF Modules XML for Frabitztown
====================================================

Attributes to Create
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

.. code-block:: xml

	<CopiedModule>
	  <CopiedModules>
		<TypeDefinitions>
		  <Type Name="System.Collections.Generic.List`1[[TMG.Emme.ExtraAttributeData, TMG.Emme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" TIndex="0" />
		  <Type Name="TMG.Emme.ExtraAttributeData, TMG.Emme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="1" />
		  <Type Name="System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" TIndex="2" />
		  <Type Name="System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" TIndex="3" />
		</TypeDefinitions>
		<Collection ParentTIndex="0" ParentFieldName="AttributesToCreate" Name="Attributes To Create">
		  <Module Name="Extra Attribute Data" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="LINK" />
			  <Param Name="Id" TIndex="2" Value="@volume" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		  <Module Name="Extra Attribute Data" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="LINK" />
			  <Param Name="Id" TIndex="2" Value="@toll" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		  <Module Name="@sfare" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="TRANSIT_SEGMENT" />
			  <Param Name="Id" TIndex="2" Value="@sfare" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		  <Module Name="@lfare" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="LINK" />
			  <Param Name="Id" TIndex="2" Value="@lfare" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		  <Module Name="@toll" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="LINK" />
			  <Param Name="Id" TIndex="2" Value="@toll" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		  <Module Name="@frac" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="NODE" />
			  <Param Name="Id" TIndex="2" Value="@frac" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		  <Module Name="@walkp" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="LINK" />
			  <Param Name="Id" TIndex="2" Value="@walkp" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		  <Module Name="@ehdw" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="TRANSIT_LINE" />
			  <Param Name="Id" TIndex="2" Value="@ehdw" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		  <Module Name="@hfrac" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="NODE" />
			  <Param Name="Id" TIndex="2" Value="@hfrac" />
			  <Param Name="Default" TIndex="3" Value="0.5" />
			</Parameters>
		  </Module>
		  <Module Name="@walkg" TIndex="1" ParentTIndex="1" ParentFieldName="AttributesToCreate">
			<Parameters>
			  <Param Name="Domain" TIndex="2" Value="LINK" />
			  <Param Name="Id" TIndex="2" Value="@walkg" />
			  <Param Name="Default" TIndex="3" Value="0" />
			</Parameters>
		  </Module>
		</Collection>
	  </CopiedModules>
	  <LinkedParameters />
	</CopiedModule>
	
	
Full Network Set Generator
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

.. code-block:: xml

    <CopiedModule>
	  <CopiedModules>
		<TypeDefinitions>
		  <Type Name="TMG.Emme.IEmmeTool, TMG.Emme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="0" />
		  <Type Name="TMG.Emme.Tools.FullNetworkSetGenerator, TMG.Emme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="1" />
		  <Type Name="System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" TIndex="2" />
		  <Type Name="TMG.Emme.Tools.FullNetworkSetGenerator+Aggregation, TMG.Emme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="3" />
		  <Type Name="System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" TIndex="4" />
		  <Type Name="TMG.Input.FileLocation[], TMGInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="5" />
		  <Type Name="TMG.Input.FileLocation, TMGInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="6" />
		  <Type Name="TMG.Input.FilePathFromInputDirectory, TMGInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="7" />
		  <Type Name="TMG.Input.FileFromInputDirectory, TMGInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="8" />
		  <Type Name="TMG.Emme.Tools.FullNetworkSetGenerator+TimePeriodScenario[], TMG.Emme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="9" />
		  <Type Name="TMG.Emme.Tools.FullNetworkSetGenerator+TimePeriodScenario, TMG.Emme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="10" />
		  <Type Name="XTMF.Time, XTMFInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" TIndex="11" />
		</TypeDefinitions>
		<Module Name="Full Network Set Generator" TIndex="1" ParentTIndex="0" ParentFieldName="Tools">
		  <Parameters>
			<Param Name="Base Scenario Number" TIndex="2" Value="1" />
			<Param Name="Default Aggregation" TIndex="3" Value="Naive" />
			<Param Name="Node Filter Attribute" TIndex="4" Value="None" />
			<Param Name="Stop Filter Attribute" TIndex="4" Value="@stop" />
			<Param Name="Connector Filter Attribute" TIndex="4" Value="None" />
			<Param Name="Attribute Aggregator" TIndex="4" Value="vdf: force,length: sum,type: first,lanes: force,ul1: avg,ul2: force,ul3: force,dwt: sum,dwfac: force,ttf: force,us1: avg_by_length,us2: avg,us3: avg,ui1: avg,ui2: avg,ui3: avg,@stop: avg,@lkcap: avg,@lkspd: avg,@stn1: force,@stn2: force" />
			<Param Name="Line Filter Expression" TIndex="4" Value="line=______ xor line=R____" />
			<Param Name="Transfer Modes" TIndex="4" Value="t" />
		  </Parameters>
		  <Collection ParentTIndex="5" ParentFieldName="AdditionalTransitAlternativeTable" Name="Additional Transit Alternative Table" />
		  <Module Name="Batch Edit File" TIndex="7" ParentTIndex="6" ParentFieldName="BatchEditFile">
			<Parameters>
			  <Param Name="File From Input Directory" TIndex="8" Value="Network Scenario\Batch Line Edit.csv" />
			</Parameters>
		  </Module>
		  <Collection ParentTIndex="9" ParentFieldName="TimePeriods" Name="Time Periods">
			<Module Name="AM" Description="" TIndex="10" ParentTIndex="10" ParentFieldName="TimePeriods">
			  <Parameters>
				<Param Name="Unclean Description" TIndex="4" Value="AM - Uncleaned Network" />
				<Param Name="Cleaned Description" TIndex="4" Value="AM - Cleaned Network" />
				<Param Name="Uncleaned Scenario Number" TIndex="2" Value="10" />
				<Param Name="Cleaned Scenario Number" TIndex="2" Value="11" />
				<Param Name="Start Time" TIndex="11" Value="6:00" />
				<Param Name="End Time" TIndex="11" Value="9:00" />
			  </Parameters>
			  <Module Name="Scenario Network Update File" Description="The location of the network update file for this time period." TIndex="-1" ParentTIndex="6" ParentFieldName="ScenarioNetworkUpdateFile">
				<Parameters />
			  </Module>
			</Module>
		  </Collection>
		  <Module Name="Transit Aggreggation Selection Table" TIndex="7" ParentTIndex="6" ParentFieldName="TransitAggreggationSelectionTable">
			<Parameters>
			  <Param Name="File From Input Directory" TIndex="8" Value="Network Scenario\Aggregation.csv" />
			</Parameters>
		  </Module>
		  <Module Name="Transit Alternative Table" TIndex="7" ParentTIndex="6" ParentFieldName="TransitAlternativeTable">
			<Parameters>
			  <Param Name="File From Input Directory" TIndex="8" Value="Network Scenario\Alt File.csv" />
			</Parameters>
		  </Module>
		  <Module Name="Transit Service Table" TIndex="7" ParentTIndex="6" ParentFieldName="TransitServiceTable">
			<Parameters>
			  <Param Name="File From Input Directory" TIndex="8" Value="Network Scenario\Service Table.csv" />
			</Parameters>
		  </Module>
		</Module>
	  </CopiedModules>
	  <LinkedParameters />
	</CopiedModule>