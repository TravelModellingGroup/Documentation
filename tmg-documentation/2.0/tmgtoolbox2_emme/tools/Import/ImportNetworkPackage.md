# **Import Network Package**

> [!NOTE]
> This tool works with Emme version 4.6.0+, XTMF2, and produces results similar to the TMG Import Network Package in XTMF1/TMGToolbox1.

The Import Network Package imports a new scenario from a compressed network package (\*.nwp) file. The tool can be found in "TMG Toolbox 2" -> "Import" -> "Import Network Package". You can find the code for this tool [here](https://github.com/TravelModellingGroup/TMG.EMME/blob/master/TMG.EMME/TMGToolbox2/src/Import/import_network_package.py).

## **Using the Tool with Modeller**

`ImportNetworkPackage` tool is available within the Emme Modeller. You can navigate to this tool in the Emme Modeller via TMG Toolbox 2 (if you have added TMG's toolbox to your current project) -> Import -> Import Network Package.

## **Using the Tool with XTMF2**

> [!CAUTION] 
> **NOTE TMG Modeller**: Update (and delete this warning) the location where Import
Network Package tool could be found when within the model system in XTMF2.

Using XTMF2 graphical user interface, parameters (defined below) needed to run the `ImportNetworkPackage` tool can be set by the users. This tool is called `ImportNetworkPackage`. In **XTMF2**, it is available to add within a model system under **_ExecuteToolsFromModellerResource_** or **_EmmeToolsToRun_**.

## **Using the Tool from an External Python API Call**

You can call the `ImportNetworkPackage` by calling the python API. Below is a script sample.

**Script Example**

```python
import inro.modeller as _m
_MODELLER = _m.Modeller()
 parameters = {
            "network_package_file": "TestFiles/test.nwp",
            "scenario_description": "From XTMF",
            "scenario_number": 1,
            "conflict_option": "PRESERVE",
        }

import_network_package = _MODELLER.tool("tmg2.Import.import_network_package")
import_network_package(parameters)
```

### Module Parameter Explanation: "Import Network Package"

| Parameter `type`                    | Explanation                                                                                         |
| :---------------------------------- | :-------------------------------------------------------------------------------------------------- |
| Scenario Number `integer`           | The scenario to import into.                                                                        |
| Network Package File `string`       | The location of the file to load into the EMME bank.                                                |
| Scenario Description `string`       | A description for the imported scenario.                                                            |
| Conflict Option (optional) `string` | Select an action to take if there are conflicts found Ignore if skip_merging_functions is checked. |
