---
uid: writing-modules.md
title: Writing XTMF Modules
---
# Writing XTMF Modules


## Development Environment - Visual Studio 2017+

### Installing Visual Studio

Begin by downloading the Visual Studio 2017 installer. A link to the 2017 community edition is available [here](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=15). 

In order to develop XTMF modules with Visual Studio, the appropriate packages must also be installed. If you have already installed Visual Studio - you can simply re-run the Visual Studio Installer and choose `modify` to add or remove packages from your current installation.

Required Package(s):

1. .NET Desktop Development


### Creating Your Module Project

After everything is installed the next step is to create your new project.  You will need to make it from a “Class Library”. (File -> New Project ... -> Class Library).

Once that is done you will need to add a reference to either the `XTMFInterfaces` project (if you are recompiling XTMF) or to the `XTMFInterfaces.dll` file. References can be added through the context menu on the `References` tree label located in the solution explorer. A list of your project's references will also be displayed here.

> [!NOTE]
>`XTMFInterfaces.dll` is included as part of the regular XTMF download package.



The second step is to set the output directory of the dynamically linked library to be inside of the XTMF’s Modules directory from the project’s properties page.  To get ready for debugging, in the project’s property page go to the Debug tab and set the ‘Start Action’ to ‘Start external program’ and direct it to your ‘XTMF.GUI.exe’.



## Writing Your First Module

If you have access to the XTMF Software Development Kit, you should find some examples in C# for how to make a module as a supplement to this documentation.

To begin, all XTMF modules need to be public classes, and need to implement ‘XTMF.IModule’ or a descendent of it.  You will need the following:
   * A public property of type string called ‘Name’ with both a getter and setter
   * A public Boolean function called ‘RuntimeValidation’ with a reference to a string as a parameter
   * A public property of type float called ‘Progress’ with at least a getter.
   * A public property of type ‘Tuple<byte, byte, byte>’ called ‘ProgressColour’ with at least a getter.
   * A public constructor with no parameters or a single parameter of type ‘XTMF.IConfiguration’.

The name field will be set by XTMF with the name given to the module from the model system. 

Progress represents the progress of the module (if that makes sense for the given component) with values 0 to 1.  ‘ProgressColour’ contains 3 bytes that represent the red, green, and blue components of colour that you wish the progress bar in XTMF to be of.  The value used in the components from TMG is typically 50, 150, and 50 respectively.

When XTMF creates an instance of your module it will detect what type of constructor you picked, and then use it to create it for the model system.  If you are going to be using ‘XTMF.Networking’ you may want to get a link to the configuration so you can interact more directly with XTMF.  If you fail to have any of these constructors marked as public, XTMF will be unable to create an instance of your module.  The default constructor created (by writing nothing) will be enough for XTMF to instantiate the module.

In all of the following code examples are assuming that you have already included the XTMF namespace.  Some code will reference interfaces from the TMG Interfaces library though their types do not matter in understanding how to program XTMF.


## Root and Parent Module References

One of the most common things needed in a module is a way to reference its ancestors.  XTMF provides two different ways to do this.  First, and most common, is an attribute for requesting the Root Module.

The following code provides an example of how to ask for this:


```cs
   [RootModule]
   public ITravelDemandModel Root;
```

```cs
    public class DemoModule : IModule
    {
       [RootModule]
       public ITravelDemandModel Root;
    }
```

When we write this code, we are also restricting what XTMF is allowed to do with respect of who can include our module as a sub module.  In this case, only a model system with the root module implementing

`TMG.ITravelDemandModel` is allowed to use this module.  So when implementing your module make sure to use the least restrictive interface for your parent as possible so it can be used by the most things in the future.

The second type of reference is to your direct parent.

## Module Parameters

```cs
   [RunParameter("Random Seed", 12345, "A number to use as the seed for the random number generator.")]
   public int RandomSeed
   {
    get;
    set;
   }
```

```cs
   [RunParameter("Random Seed", 12345, "A number to use as the seed for the random number generator.")]
   public int RandomSeed;
```

One of the most important things for any module will be its parameters.  There are two different types of parameters in XTMF, ‘Parameter’, and ‘RuntimeParameter’.  A runtime parameter will be able to be edited locally in the project, where as a regular one will not.  In the TMG modules all parameters are runtime parameters allowing for the most flexibility for our end users.

To create a new parameter, define a new public member variable or property with getter and setter of one of the supported types.  On top of it add an attribute of type ‘RuntimeParameter’.  All types that implement a TryParse( string input, out [TYPE]) method are supported.  This includes all of the .Net primitives.  In order to use non .Net primitives you will need to include the typeof([TYPE]) argument.
Here are some examples of parameters:

### Creating Custom Parameters

One of the most important things for any module will be its parameters.  There are two different types of parameters in XTMF, ‘Parameter’, and ‘RuntimeParameter’.  A runtime parameter will be able to be edited locally in the project, where as a regular one will not.  In the TMG modules all parameters are runtime parameters allowing for the most flexibility for our end users.

To create a new parameter, define a new public member variable or property with getter and setter of one of the supported types.  On top of it add an attribute of type ‘RuntimeParameter’.  All types that implement a TryParse( string input, out [TYPE]) method are supported.  This includes all of the .Net primitives.  In order to use non .Net primitives you will need to include the typeof([TYPE]) argument.
Here are some examples of parameters:

## Including Sub Modules

Sub Modules can be added to a module similar to how you add parameters.  The difference is that the type of the sub module can be inferred at runtime, since we do not have any default values.


```cs   
   [SubModelInformation(Description="The different data for the modes.", Required=false)]
   public IList<INetworkData> NetworkData
   {
        get;
        set;
   }
```

## Correct Use of Input Directories

Before implementing any module to read a file unless otherwise needed please use the TMG.FileLocation abstract module instead of creating your own.

If you still need some other customization consider looking at extending TMG.FileLocation to allow greater flexibility in TMG modules that have already used this interface.

When you are going to use parameters for strings, please make sure to look at your root module’s ‘InputBaseDirectory’ for the directory to base the paths from.

The following method will combine the path given to it with the root model system’s base directory.  It assumes that your root module is referenced to in a member variable called ‘Root’.

## Handling Resource Usage

Before implementing any module to read a file unless otherwise needed please use the TMG.FileLocation abstract module instead of creating your own.

If you still need some other customization consider looking at extending TMG.FileLocation to allow greater flexibility in TMG modules that have already used this interface.

When you are going to use parameters for strings, please make sure to look at your root module’s `InputBaseDirectory` for the directory to base the paths from.

The following method will combine the path given to it with the root model system’s base directory.  It assumes that your root module is referenced to in a member variable called `Root`.

## Runtime Validation

Runtime validation provides a way for the modules that you program to check their parameters before anything in the model system is allowed to run.  If you need to look up a resource from a parent module before executing, this is also the place to do that.  It is important to remember though that when you look at other modules, siblings may not have already had their validation code run, and the order is non-deterministic except for that a parent’s validation has always ran before a child’s.  To report an error set the value of the error string equal to the message that you wish to return, and then return false.  Returning true will let XTMF know that your module has passed validation.

When working with this method, please make sure to not do any data processing inside of this.  Progress may not be reported correctly if you are doing so.
