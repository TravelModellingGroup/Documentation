# Develop XTMF2 modules

This walkthrough is for developers who want to add their own modules to XTMF2. It begins with the simpler action module, then introduces function modules:

- `BaseAction` for a module that performs work without returning a value.
- `BaseFunction<T>` for a module that computes and returns a value.

The examples use the same attributes and contracts as the built-in XTMF2 modules. They can be placed in a separate class-library project and loaded alongside the complete XTMF2 distribution.

## Walkthrough

1. [Build a module, function, and action](function-and-action.md): create the project, implement `BaseFunction<T>` and `BaseAction`, and add module parameters.
2. [Test and install a module](test-and-install.md): verify behavior, build the library, and make it available to XTMF2.

You should be comfortable with C# classes, properties or fields, and basic unit testing. The walkthrough does not require changes to the XTMF2 core repository.

## Framework contracts

The core interfaces are:

- `IModule`, which provides the module name and runtime validation contract.
- `IFunction<T>`, implemented by `BaseFunction<T>`, which returns a value from `Invoke()`.
- `IAction`, implemented by `BaseAction`, which performs work from `Invoke()`.

Context-aware variants are available when a workflow passes a context value: `BaseFunction<Context, Result>` and `BaseAction<Context>`.
