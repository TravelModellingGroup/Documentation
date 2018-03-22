# Multi-Run Framework


TMG’s Multi-run framework is designed to aid in the automation of running model systems where each iteration would require setup.  The framework itself is extendable as modules are able to add their own additional commands to the language used in the configuration file.

## Multi-Run Configuration File Layout


### Initial State

## Basic Commands

### Copy

The copy command copies a file or directory from the given origin to the destination.  All paths are relative to the run directory.  If executed within a run command the path is relative to the inner run directory.

``<copy Origin="../../../NetworkScenarios/MyScenario" Destination="Network Scenario" />``

There is an optional parameter ‘Move’ that defaults to false.  If move is set then after the copy the original files will be deleted.


### Change Parameter

The change parameter command gives you the ability to at the point of the command to edit the value at runtime of the parameter specified.  The attribute ParameterPath is used to specify which parameter you wish to change.  In the following example we are going to change the parameter of the root’s child “ModuleA”’s child “ModuleB”’s parameter “MyParameter” to the value “TheValueIWant”.

.. code-block:: xml
 :linenos:

  <changeParameter ParameterPath="ModuleA.ModuleB.MyParameter"
	 Value="TheValueIWant"/>

You can also assign the same value to multiple parameters at the same time using the following format.

.. code-block:: xml
 :linenos:

 <changeParameter Value="TheValueIWant">
	 <parameter ParameterPath="ModuleA.ModuleB.MyParameter" />
	 <parameter ParameterPath="ModuleA.ModuleC.MyParameter" />
	 <parameter ParameterPath="ModuleA.ModuleD.MyParameter" />
 </changeParameter>


### Change Linked Parameter
Similar to change parameter there is a command to change a linked parameter.

.. code-block:: xml
 :linenos:

 <changeLinkedParameter Name="[Linked Parameter’s Name]"
    Value="[The value to set it to]"/>


### Delete

.. code-block:: xml
 :linenos:

 <delete Path="TheFileToDelete.txt" />

 <delete Path="TheDirectoryToDelete" />

 ### Unload

 This command is used in order to force resources or data sources to be unloaded, typically after a model run.

``<unload Path="Resources" Recursive="true" />``

The Path attribute gives the path to the module.  Recursive when set to true will also unload all child modules of this modules that are either a resource or data source.


## Extending Multi-Run

Below is an excerpt from TMG.Frameworks.Extensibility.LaunchProgram where it adds a command to Multi-Run.

.. code-block:: C#
 :linenos:

 private void AddMultiRunCommand()
 {
    var listToUs = ModelSystemReflection.BuildModelStructureChain(Config, this);
    for(int i = listToUs.Count - 1; i >= 0; i--)
    {
      var multiRunFramework = listToUs[i].Module as MultiRun.MultiRunModelSystem;
      if(multiRunFramework != null)
      {
        multiRunFramework.TryAddBatchCommand("LaunchProgram.ShutdownExternalProgram", (node) =>
        {
          var path = multiRunFramework.GetAttributeOrError(node, "Path", "In 'LaunchProgram.ShutdownExternalProgram' we were unable to find an xml attribute called 'Path'!\r\nPlease add this to your batch script.");
          IModelSystemStructure selectedModule = null;
          IModelSystemStructure multiRunFrameworkChild = null;

          if(!ModelSystemReflection.FindModuleStructure(Config, multiRunFramework.Child, ref multiRunFrameworkChild))
          {
            throw new XTMFRuntimeException("We were unable to find the multi-run frameworks child module's model system structure!");
          }

          if(!ModelSystemReflection.GetModelSystemStructureFromPath(multiRunFrameworkChild, path, ref selectedModule))
          {
            throw new XTMFRuntimeException("We were unable to find a module with the path '" + path + "'!");
          }

          var toShutdown = selectedModule.Module as LaunchProgram;
          if(toShutdown == null)
          {
            throw new XTMFRuntimeException("The module with the path '" + path + "' was not of type 'TMG.Frameworks.Extensibility.LaunchProgram'!");
          }
          toShutdown.ShutdownProgram();
        }, true);
      break;
    }
  }
 }
