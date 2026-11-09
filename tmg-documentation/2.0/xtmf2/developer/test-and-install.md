# Test and install a module

Test a custom module outside the desktop application first. Then build the class library and make its output available to the XTMF2 installation.

## Unit-test the behavior

Test the module's observable behavior and its configuration rules. A function test should assert the returned value. An action test should assert its side effect using a testable dependency or output collector rather than relying only on a manual console observation.

For the initial `AddNumbers` function with no configuration, a minimal test can look like:

```csharp
[Fact]
public void AddNumbersReturnsTheSum()
{
    var module = new AddNumbers();

    var result = module.Invoke();

    Assert.Equal(5.0f, result);
}
```

Also test invalid configuration when you override `RuntimeValidation`. Assert both the `false` result and the useful error message.

## Build the library

Build the module project in Release configuration and keep the output associated with the XTMF2 version against which it was compiled. Do not mix assemblies built against incompatible framework contracts.

Before installing a new version, close active XTMF2 model-system editors and runs. This prevents the application from retaining an older assembly while you are testing the replacement.

## Make the module available

Copy or install the compiled module assembly using the module-loading mechanism provided by your XTMF2 distribution. Restart XTMF2 if required by that distribution, then open the module picker and search for the value from `ModuleAttribute.Name`.

Create a small test model system containing the module. Configure its parameters or submodules, validate it, and run it. This checks discovery, metadata, type compatibility, and execution together.

If the module does not appear:

- Confirm the assembly is in the directory scanned by XTMF2.
- Confirm the class is public and has `ModuleAttribute`.
- Confirm the assembly targets a compatible framework and references the matching XTMF2 contracts.
- Check the application log for loader or dependency errors.

If the module appears but cannot be configured, inspect the parameter and submodule types and their metadata indices. If it validates but fails during execution, reproduce the behavior in a unit test and add a more specific runtime validation message where appropriate.

## Version and distribution notes

Distribute the module assembly together with its documentation and any required dependencies. Record the XTMF2 version used to build it. A serialized model system stores references to module types, so a recipient must have the module assembly installed before importing a model that uses it.

## Next steps

Once the module works in a small model system, add an example model, generated reference page, and release notes. Keep the example small enough that another modeler can inspect every parameter, submodule, and link.
