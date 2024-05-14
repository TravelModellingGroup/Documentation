---
uid: writing-modules-1-6.md
title: Writing XTMF Modules
---

# Writing XTMF Modules

### Creating Your Module Project

After installing your code editor and having a working knowledge of C#, the next step is to
create your new project. You will need to make it from a “Class Library”.
(File -> New Project ... -> Class Library).

Once that is done you will need to add a reference to either the `XTMFInterfaces` project (if you are recompiling XTMF) or to the `XTMFInterfaces.dll` file. References can be added through the context menu on the `References` tree label located in the solution explorer. A list of your project's references will also be displayed here.

> [!NOTE] 
> `XTMFInterfaces.dll` is included in the Modules directory in your XTMF program directory.

### Writing Your First Module

If you have access to the XTMF Software Development Kit, you should find some examples in C# for how to make a module as a supplement to this documentation.

To begin, all XTMF modules need to be public classes, and need to implement ‘XTMF.IModule’ or a descendant of it. You will need the following:

- A public property of type string called ‘Name’ with both a getter and setter
- A public Boolean function called ‘RuntimeValidation’ with a reference to a string as a parameter
- A public property of type float called ‘Progress’ with at least a getter.
- A public property of type ‘Tuple<byte, byte, byte>’ called ‘ProgressColour’ with at least a getter.
- A public constructor with no parameters or a single parameter of type ‘XTMF.IConfiguration’.

The name field will be set by XTMF with the name given to the module from the model system.

Progress represents the progress of the module (if that makes sense for the given component) with values 0 to 1. ‘ProgressColour’ contains 3 bytes that represent the red, green, and blue components of colour that you wish the progress bar in XTMF to be of. The value used in the components from TMG is typically 50, 150, and 50 respectively.

When XTMF creates an instance of your module it will detect what type of constructor you picked, and then use it to create it for the model system. If you are going to be using ‘XTMF.Networking’ you may want to get a link to the configuration so you can interact more directly with XTMF. If you fail to have any of these constructors marked as public, XTMF will be unable to create an instance of your module. The default constructor created (by writing nothing) will be enough for XTMF to instantiate the module.

In all of the following code examples are assuming that you have already included the XTMF namespace. Some code will reference interfaces from the TMG Interfaces library though their types do not matter in understanding how to program XTMF.

## Module meta-data and documentation annotations

The XTMF module SDK includes support for various forms of module meta data that can be generated as part of the XTMF main documentation (or your own). The XTMF documentation site uses docfx.

### Custom Module Icons

The XTMF `ModuleInformation` annotation includes support for custom icon displays as of XTMF 1.5. Use the IconURI property of the ModuleInformation initializer. A list of some of the available icons can be found at https://materialdesignicons.com/.

```cs
    [ModuleInformation(Description = "Example Module Description", IconURI = "TestTube")]
```

### Module Assembly Meta Information

Assembly description information as part of your module project can be used as part of documentation generation. The assembly meta description and information can is found within the project / assembly's `AssemblyInfo.cs` file.

```cs
[assembly: AssemblyDescription( "<Example Assembly Description>" )]
```

## Root and Parent Module References

One of the most common things needed in a module is a way to reference its ancestors. XTMF provides two different ways to do this. First, and most common, is an attribute for requesting the Root Module.

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

When we write this code, we are also restricting what XTMF is allowed to do with respect of who can include our module as a sub module. In this case, only a model system with the root module implementing

`TMG.ITravelDemandModel` is allowed to use this module. So when implementing your module make sure to use the least restrictive interface for your parent as possible so it can be used by the most things in the future.

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

One of the most important things for any module will be its parameters. There are two different types of parameters in XTMF, ‘Parameter’, and ‘RuntimeParameter’. A runtime parameter will be able to be edited locally in the project, where as a regular one will not. In the TMG modules all parameters are runtime parameters allowing for the most flexibility for our end users.

To create a new parameter, define a new public member variable or property with getter and setter of one of the supported types. On top of it add an attribute of type ‘RuntimeParameter’. All types that implement a TryParse( string input, out [TYPE]) method are supported. This includes all of the .Net primitives. In order to use non .Net primitives you will need to include the typeof([TYPE]) argument.
Here are some examples of parameters:

### Creating Custom Parameters

One of the most important things for any module will be its parameters. There are two different types of parameters in XTMF, ‘Parameter’, and ‘RuntimeParameter’. A runtime parameter will be able to be edited locally in the project, where as a regular one will not. In the TMG modules all parameters are runtime parameters allowing for the most flexibility for our end users.

To create a new parameter, define a new public member variable or property with getter and setter of one of the supported types. On top of it add an attribute of type ‘RuntimeParameter’. All types that implement a TryParse( string input, out [TYPE]) method are supported. This includes all of the .Net primitives. In order to use non .Net primitives you will need to include the typeof([TYPE]) argument.
Here are some examples of parameters:

```cs
[RunParameter("Random Seed", 12345, "A number to use as the seed for the random number generator.")]         
public int RandomSeed 
{             
    get;               
    set; 
} 
```
This will create a new parameter of type integer called Random Seed and set its default value to 12345.  The last parameter will be the description of the parameter. 

```cs
[RunParameter("Max Mutation", 0.4f, "The maximum amount (in 0 to 1) that a parameter can be mutated")]         
public float MaxMutationPercent; 
```
This creates a new parameter of float to bound how many percent are we allowed to mutate a parameter.  It is important to see here that the default value is not 0.4, it is 0.4f.  If we leave off the ‘f’ then it will be of type double, which will cause the module to not start-up correctly. 

```cs
[RunParameter("School Morning End", "12:00 PM", typeof(Time), "The highest number of attempts to schedule an episode")]         
public Time SchoolMorningEndDateTime; 
```
This shows how to make a parameter out of a DateTime structure.  Note here that we enter in the default value as a string, and then manually say what type it is.  We recommend to avoid DateTime as when it is saved, the model systems will not be compatible between computers where their date/time format differs.  Such as a computer set up for Canadian and another set up for American date time formats. 

## Including Sub Modules

Sub Modules can be added to a module similar to how you add parameters. The difference is that the type of the sub module can be inferred at runtime, since we do not have any default values.

```cs
   [SubModelInformation(Description="The different data for the modes.", Required=false)]
   public IList<INetworkData> NetworkData
   {
        get;
        set;
   }
```

In the above code we are creating a property, which is a list of INetworkData, a type of module defined in the TMG Interfaces. 
Above that we have an attribute of type SubModelInformation.  By default all public member’s inside of a module are checked to
see if they reference a XTMF.IModule.  If they do XTMF will assume that you want it to be filled with a sub module.  If you do not,
there is another attribute that you can use to stop XTMF from allowing a match. 

```cs
    [DoNotAutomate]         
    public List<ITashaMode> NonSharedModes 
    {             
        get;               
        set; 
    } 
```

The DoNotAutomate attribute will let XTMF know that NonSharedModes should not receive submodules. 

## Correct Use of Input Directories

Before implementing any module to read a file unless otherwise needed please use the TMG.FileLocation abstract module instead of creating your own.

If you still need some other customization consider looking at extending TMG.FileLocation to allow greater flexibility in TMG modules that have already used this interface.

When you are going to use parameters for strings, please make sure to look at your root module’s ‘InputBaseDirectory’ for the directory to base the paths from.

The following method will combine the path given to it with the root model system’s base directory. It assumes that your root module is referenced to in a member variable called ‘Root’.

````cs
    private string GetFullPath(string localPath) 
    {        
        var fullPath = localPath;
        if (!Path.IsPathRooted(fullPath)) 
        { 
             fullPath = Path.Combine(this.Root.InputBaseDirectory, fullPath); 
        } 
         return fullPath; 
    } 
````

## Handling Resource Usage

Before implementing any module to read a file unless otherwise needed please use the TMG.FileLocation abstract module instead of creating your own.

If you still need some other customization consider looking at extending TMG.FileLocation to allow greater flexibility in TMG modules that have already used this interface.

When you are going to use parameters for strings, please make sure to look at your root module’s `InputBaseDirectory` for the directory to base the paths from.

The following method will combine the path given to it with the root model system’s base directory. It assumes that your root module is referenced to in a member variable called `Root`.

## Runtime Validation

Runtime validation provides a way for the modules that you program to check their parameters before anything in the model system is allowed to run. If you need to look up a resource from a parent module before executing, this is also the place to do that. It is important to remember though that when you look at other modules, siblings may not have already had their validation code run, and the order is non-deterministic except for that a parent’s validation has always ran before a child’s. To report an error set the value of the error string equal to the message that you wish to return, and then return false. Returning true will let XTMF know that your module has passed validation.

When working with this method, please make sure to not do any data processing inside of this. Progress may not be reported correctly if you are doing so.

## Throwing Exceptions

When an exception needs to be passed along to the user XTMF works best when wrapping that exception within an `XTMFRuntimeException`. This
will allow XTMF to present the module within the model system that caused the error.  Though you shouldn't capture Exception itself,
the following code shows you how in your module you can pass back an exception to the user while tying it to the particular module that the exception was
caused in.

```cs
try
{
    // Code that throws here
}
catch(Exception e)
{
    throw new XTMFRuntimeException(this, e);
}
```

## Custom Status Message

If you are writing a `ModelSystemTemplate` or another module that is expected to pass back a status message you will need to override the
`ToString` method for your module.  The resulting value will be passed back and displayed in the XTMF.GUI.

## A Hello World

Below we have a simple 'Hello World' module implementing a ModelSystemTemplate for reference.

```cs
using System;
using XTMF;

namespace MyModules;

[ModuleInformation(Description="A hello world module.")]
public class MyModule : IModelSystemTemplate
{
    public string Name { get; set; }
    
    public void Start()
    {
        Console.WriteLine("Hello World");
    }

    public bool ExitRequest() => false;
    
    public Tuple<byte, byte, byte> ProgressColour => new Tuple<byte, byte, byte>( 50, 150, 50 );
    
    public bool RuntimeValidation(ref string? error) => true;

    [Parameter("Input Base Directory", "Input", "The directory relative to the Run Directory where all of the input is kept." )]
    public string InputBaseDirectory { get; set; }
    
    // The OutputBaseDirectory property has been deprecated.
    public string OutputBaseDirectory { get; set; }
           
    public float Progress { get; set; }
}

```

Assuming you are familiar with C#, you will quickly see that we have an attribute attached to the class that provides
meta-data to describe this modules' functionality. Additionally you see a property named `Name`. This property will be filled out
by XTMF during runtime with the name selected by the model system designer.  Additionally you will see two methods `ProgressColour`,
and `RuntimeValidation`. `ProgressColour` provides an RGB value to associate with the module at runtime with values
0-255 for each channel.  All modules will share these elements in common however an `IModelSystemTemplate` requires some additional
elements.

`InputBaseDirectory` contains the path where the model system's input files are contained. `ExitRequest` will be called when the user
requests that the model system should terminate.  Setting this to false will let XTMF know that there is no termination sequence
that the model system will provide, so it will instead force the process to close. `OutputBaseDirectory` is vestigial for XTMF1 and
has been removed for XTMF2.

A recommended exercise is to create a new parameter that takes in a string and instead of writing 'Hello World' to the console
writes out that parameter.
