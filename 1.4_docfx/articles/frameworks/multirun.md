# Multi-Run Framework


TMG’s Multi-run framework is designed to aid in the automation of running model systems where each iteration would require setup.
The framework itself is extendable as modules are able to add their own additional commands to the language used in the configuration file.


Multi-Run files are XML based scripts that are executed from top to bottom.  The goal is to provide a way of chaining together runs, similar to how XTMF 1.4+ is now able.  Additionally it provides
useful ways of changing the parameters of a model system before running it, or to unload resources between runs.  Starting with XTMF 1.4 it is recommended to consider alternatives to using this
framework such as using quick parameters and linked parameters which can be set before a run.  In advanced cases though, the multi-run file might be the best option.

## Basic Commands

### Run

The most important command in the multi-run framework is Run. Run takes in two parameters, Name, and RunAs.  Name provides will augment the status message in XTMF, and RunAs will set the directory
that the run will ocure in.  Commands can be executed within the run command. They will executed once the working directory has been set but before the run itself has started.

```xml
<run Name="RunName:" RunAs="SubdirectoryName">
    <!-- Instructions here are executed after the working directory has been switched -->
</run>
```

### Copy

The copy command copies a file or directory from the given origin to the destination.  All paths are relative to the run directory.  If executed within a run command the path is relative to the inner run directory.

```xml
<copy Origin="../../../NetworkScenarios/MyScenario" Destination="Network Scenario" />
```

There is an optional parameter ‘Move’ that defaults to false.  If move is set then after the copy the original files will be deleted.


### Change Parameter

The change parameter command gives you the ability to at the point of the command to edit the value at runtime of the parameter specified.  The attribute ParameterPath is used to specify which parameter you wish to change.  In the following example we are going to change the parameter of the root’s child `ModuleA`’s child `ModuleB`’s parameter `MyParameter` to the value `TheValueIWant`.

```xml
<changeParameter ParameterPath="ModuleA.ModuleB.MyParameter" Value="TheValueIWant"/>
```

You can also assign the same value to multiple parameters at the same time using the following format.

```xml
<changeParameter Value="TheValueIWant">
    <parameter ParameterPath="ModuleA.ModuleB.MyParameter" />
    <parameter ParameterPath="ModuleA.ModuleC.MyParameter" />
    <parameter ParameterPath="ModuleA.ModuleD.MyParameter" />
</changeParameter>
```

### Change Linked Parameter
Similar to change parameter there is a command to change a linked parameter.

```xml
<changeLinkedParameter Name="[Linked Parameter’s Name]" Value="[The value to set it to]"/>
```

### Delete

```xml
<delete Path="TheFileToDelete.txt" />
```
```xml
<delete Path="TheDirectoryToDelete" />
```
 ### Unload

This command is used in order to force resources or data sources to be unloaded, typically after a model run.

```xml
<unload Path="Resources" Recursive="true" />
```
The Path attribute gives the path to the module.  Recursive when set to true will also unload all child modules of this modules that are either a resource or data source.

### Write
This command will write the inner xml to a provided file in the Path attribute.

```xml
<write Path="Test.txt">
    All of this text will be written to file.
</write>
```

## Advanced Commands

### Define
Define is used to store a floating point number in order to do conditional execution later in the script.

```xml
<define Name="myVariableName" Value="1.0" />
```

### Execute Template

This command will run a previously defined *Template*.  Each individual template will have a set of parameters defined for it.
In addition *execute template* will require you to give it a parameter with the name of the template called **Name**.  An example follows.

```xml
<executeTemplate Name="[myTemplateName]"
                FirstParameter="1"
                SecondParameter="2"
                ThirdParameter="3" />
```

### If

If allows us to do conditional execution during the script.  It has three attributes: LHS (left hand side), RHS (right hand side), and OP (operation).
LHS and RHS contain previously defined variable names using the *define* command.  The OP attribute can take in most arithmetic comparators.
Due to XML though greather than and less than are much harder to write so FORTRAIN notation is prefered.  You can still use < and > by entering in \&lt; or \&gt; to your text editor.
  * lt, < (less than)
  * lte, <= (less than or equal)
  * eq, =, == (equal)
  * neq, !, != (not equal)
  * gt, > (greater than)
  * gte, >= (greater than or equal)

```xml
<if LHS="myPreviouslyDefinedVariable" OP="lte" RHS="10.0">
    <changeLinkedParameter Name="myLP" Value="SpecialValue" />
</if>
```

### Import
Import allows you to be able to execute a seperate multi-run batch file from the given relative path.  This is best used to avoid
keeping complex *template* scripts in your main multi-run file.

```xml
<import Path="[file name relative to the location of this multi-run file]" />
```

### Template

The *template* command gives you the ability to create a subscript that can be invoked with different parameters.  In our experience this is especially useful when
constructing simplified wrappers around runs that require substantial setup.  Template has two attributes, **Name** and **Parameters**.  **Name** will contains the
name that will be used to reference this *template* in *executeTemplate* and **Parameters** will contain a comma seperated list of the parameters that will need to be
passed into the template in order to execute.  **Template parameter names may not contain a space.**  The inner text of the *template* contains the script that will be executed
with the parameters substituted in.  To substitute the text with the parameter write %ParameterName% with the percent symbols surrounding it.  In more advanced scenarios 
you may wish to have templates being generated inside of another template.  You can achieve this by surrounding these templates with additional %'s so for a second depath parameter %%InnerParameter%% would work.
In order to write a %, you can escape it with %% in order to produce a single %.

The example below is the template used for GTAModelV4.0.2 in order to generate the main run template where there is another *template* previously defined called *SetAirport*.

    <template Name="InitializeV4"
              Parameters="AirportZone;EMMEBankDirectory;EmploymentScenarioBase;PopulationScenarioBase;StationScenarioBase;TransitFareScenarioBase;NetworkScenarioBase">
        <changeLinkedParameter Name="Airport Zone" Value="%AirportZone%" />
        <changeLinkedParameter Name="EmmeBaseDirectory" Value="%EMMEBankDirectory%"/>
        <!-- GTAModel V4.0.2 Execution Template -->
        <template Name="RunV4"
                  Parameters="RunName;Year;EmploymentScenario;PopulationScenario;NetworkScenario;StationScenario;TransitFareScenario">
            <executeTemplate Name="SetAirport" Year="%%Year%%" />
            <changeLinkedParameter Name="EmploymentScenario" 
            Value="%EmploymentScenarioBase%/%%Year%%/%%EmploymentScenario%%" />
            <changeLinkedParameter Name="PopulationScenario" 
            Value="%PopulationScenarioBase%/%%Year%%/%%PopulationScenario%%" />
            <changeLinkedParameter Name="StationScenario" 
            Value="%StationScenarioBase%/%%Year%%/%%StationScenario%%" />
            <changeLinkedParameter Name="TransitFareScenario" 
            Value="%TransitFareScenarioBase%/%%TransitFareScenario%%" />
            <changeLinkedParameter Name="NetworkScenario" 
            Value="%NetworkScenarioBase%/%%Year%%/%%NetworkScenario%%" />
            <!-- Fix the parameters that don't have other lookups -->
            <changeParameter ParameterPath="Zone System.Zone File Name" 
            Value= "%PopulationScenarioBase%/%%Year%%/%%PopulationScenario%%/ZoneData/Zones.csv" />
            <changeParameter ParameterPath="Zone System.Zone Cache File" 
            Value="%PopulationScenarioBase%/%%Year%%/%%PopulationScenario%%/ZoneData/Zones.zfc" />
            <changeParameter ParameterPath="Household Loader.FileName" 
            Value="%PopulationScenarioBase%/%%Year%%/%%PopulationScenario%%/HouseholdData/Households.csv" />
            <changeParameter ParameterPath="Household Loader.Person Loader.FileName" 
            Value="%PopulationScenarioBase%/%%Year%%/%%PopulationScenario%%/HouseholdData/Persons.csv" />
            <changeParameter ParameterPath="Post Iteration.Compute Station Capacity Factor.Station Capacity.File Name"
            Value="%StationScenarioBase%/%%Year%%/%%StationScenario%%/StationCapacity.csv" />
            <run Name="%%RunName%%:" RunAs="%%RunName%%" />
            <!-- Now that the run has completed unload all of the resources -->
            <unload Path="Resources" Recursive="true" />
        </template>
    </template>

To use this you would first invoke the outer template *InitializeV4*.
    
    <executeTemplate Name="InitializeV4"
                   AirportZone="3709"
                   EmploymentScenarioBase="Scenario-Employment"
                   PopulationScenarioBase="Scenario-Population"
                   StationScenarioBase="Scenario-Stations"
                   TransitFareScenarioBase="Scenario-Transit Fares"
                   NetworkScenarioBase="Scenario-Network"
                   EMMEBankDirectory="../../../EMMENetworks" />

Executing the outer template then creates the inner template *RunV4*.

     <executeTemplate Name="RunV4"
                   RunName="2011 TTS Base"
                   Year="2011"
                   EmploymentScenario="Synthetic"
                   PopulationScenario="Synthetic"
                   StationScenario="Base"
                   TransitFareScenario="Base"
                   NetworkScenario="TTS"/>

If you were to try to run *RunV4* before you had executed *InitializeV4* you would run into an error where it could not find a template with the name.
This is useful for cases where you want templates depend on other ones.

## Extending Multi-Run

Below is an excerpt from TMG.Frameworks.Extensibility.LaunchProgram where it adds a command to Multi-Run.

[!code-csharp[AddMultiRunCommand](../../../../XTMF/Code/TMG.Frameworks/Extensibility/LaunchProgram.cs#AddMultiRunCommand)]
