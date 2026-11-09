# Build a module, function, and action

Create a C# class-library project for the custom modules. Keep it separate from the XTMF2 application so the module library can be built, tested, and versioned independently.

## Create the project

Reference the XTMF2 interfaces assembly that defines `IModule`, `BaseFunction<T>`, `BaseAction`, and the module attributes. Use the same target framework and compatible XTMF2 version as the downloaded distribution.

A standard project has this shape:

```text
MyXtmfModules/
    src/
        MyXtmfModules/
            MyXtmfModules.csproj
            Modules/
                AddNumbers.cs
                ReportMessage.cs
    test/
        MyXtmfModules.Tests/
            MyXtmfModules.Tests.csproj
            AddNumbersTests.cs
```

Keep production module code under `src` and tests under `test`. Use a namespace that identifies your organization or project. Avoid placing custom classes in the `XTMF2` namespace; that namespace belongs to the framework.

## Choose the module contract

Start with `BaseAction` when the module performs an operation and has no return value. Use `BaseFunction<Result>` when another module needs to request a value.

## An action module

This action writes a message to the standard output stream:

```csharp
using System;
using XTMF2;

namespace MyXtmfModules;

[Module(
    Name = "Report Message",
    Description = "Writes a message when invoked.",
    DocumentationLink = "https://example.org/docs/report-message")]
public sealed class ReportMessage : BaseAction
{
    public override void Invoke()
    {
        Console.WriteLine("Message from XTMF2");
    }
}
```

`BaseAction` establishes an executable step with no return value. A start module or another action can invoke it through an action connection.

## A function module

This function returns the sum of two fixed values:

```csharp
using XTMF2;

namespace MyXtmfModules;

[Module(
    Name = "Add Numbers",
    Description = "Returns the sum of two numbers.",
    DocumentationLink = "https://example.org/docs/add-numbers")]
public sealed class AddNumbers : BaseFunction<float>
{
    public override float Invoke()
    {
        return 2.0f + 3.0f;
    }
}
```

`BaseFunction<float>` establishes the module's output type. A downstream module that expects `IFunction<float>` can consume it.

## Add parameters to AddNumbers

After the fixed-value `AddNumbers` module works, replace its `Invoke()` implementation with two required parameters:

```csharp
[Parameter(
    Name = "First",
    Description = "The first number to add.",
    Required = true,
    DefaultValue = "0",
    Index = 0)]
public IFunction<float> First = null!;

[Parameter(
    Name = "Second",
    Description = "The second number to add.",
    Required = true,
    DefaultValue = "0",
    Index = 1)]
public IFunction<float> Second = null!;

public override float Invoke()
{
    return First.Invoke() + Second.Invoke();
}
```

Each parameter is an `IFunction<float>`, so the editor can provide a literal value or connect another function module. The `Index` values are unique within the module.

## Submodules

A submodule is another module assigned to a named role:

```csharp
[SubModule(
    Name = "To Execute",
    Description = "The action to invoke after processing.",
    Required = false,
    PassesExecution = true,
    Index = 2)]
public IAction? ToExecute;
```

Use `PassesExecution = true` when the submodule participates in the action or function execution chain. Use the default value when it is an input module that supplies data without owning the next execution step.

Every parameter and submodule in a class must have a unique `Index`.

## Validate and document the module

`Required` controls whether the model system must provide a parameter or submodule before the model can run:

- `Required = true` means the field must be configured. XTMF2 validates this before execution, so `RuntimeValidation` does not need to check whether the field exists.
- `Required = false` means the field may be absent. The module should handle `null` or use an appropriate default when it invokes the field.

This applies to both `[Parameter]` and `[SubModule]`. For example, `ToExecute` can be optional when a module has a meaningful no-op or default behavior:

```csharp
[SubModule(
    Name = "To Execute",
    Description = "The action to invoke after processing.",
    Required = false,
    PassesExecution = true,
    Index = 2)]
public IAction? ToExecute;

public override void Invoke()
{
    ToExecute?.Invoke();
}
```

Use `RuntimeValidation` to test whether configured values and submodules are usable for the run. For example, `OpenReadStreamFromFile` has a required `File Path` parameter and a required `Check File Exists At Run Start` parameter. Its validation does not check whether those parameter modules exist; XTMF2 has already guaranteed that. Instead, it invokes the configured values and checks the file-system condition when the option is enabled:

```csharp
public override bool RuntimeValidation(ref string? error)
{
    if (CheckFileExistsAtRunStart.Invoke())
    {
        var filePath = FilePath.Invoke();
        if (!File.Exists(filePath))
        {
            error = $"The file '{filePath}' does not exist!";
            return false;
        }
    }

    return true;
}
```

This is a domain or configuration check, not an existence check for the `FilePath` and `CheckFileExistsAtRunStart` parameter modules. Override `RuntimeValidation` when a module has constraints that attributes cannot express:

```csharp
public override bool RuntimeValidation(ref string? error)
{
    if (!base.RuntimeValidation(ref error))
    {
        return false;
    }

    if (First.Invoke() < 0 || Second.Invoke() < 0)
    {
        error = "Both numbers must be non-negative.";
        return false;
    }

    return true;
}
```

Return `false` with a useful error message when the configuration cannot run. The `ModuleAttribute` description appears in the module picker and generated documentation. Keep `DocumentationLink` pointing to a page that describes the released module.

## Important rules

- Derive from the correct base class and implement its abstract `Invoke()` method.
- Use a stable, human-readable `ModuleAttribute.Name`; this is what users search for in XTMF2.
- Make the class public so the module loader can discover it.
- Avoid doing work in the constructor. Put execution behavior in `Invoke()` and configuration checks in `RuntimeValidation()`.

## Context-aware modules

When the module must receive a workflow context, use `BaseFunction<Context, Result>` or `BaseAction<Context>`. Keep the context type consistent across connected modules:

```csharp
[Module(
    Name = "Read Context Value",
    Description = "Returns the text representation of the context.",
    DocumentationLink = "https://example.org/docs/read-context-value")]
public sealed class ReadContextValue<Context> : BaseFunction<Context, string>
{
    public override string Invoke(Context context)
    {
        return context?.ToString() ?? string.Empty;
    }
}
```

Continue with [Test and install a module](test-and-install.md).
