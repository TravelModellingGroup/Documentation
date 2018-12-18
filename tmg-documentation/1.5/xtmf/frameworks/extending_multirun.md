---
uid: extending-multirun-1-5
title: Extending the Multi-Run Framework
---
# Extending Multi-Run

Below is an excerpt from TMG.Frameworks.Extensibility.LaunchProgram where it adds a command to Multi-Run.

```cs
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
```