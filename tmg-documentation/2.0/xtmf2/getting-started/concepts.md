# Understanding model systems

A model system is a connected workflow of modules. XTMF2 stores the workflow as a model-system definition and executes it through the runtime.

## Modules

A module is a reusable unit of behavior. The core contracts include:

- A function, which returns a value when invoked. Examples include `BaseFunction<T>` and `BaseFunction<Context, T>`.
- An action, which performs work without returning a value. Examples include `BaseAction` and `BaseAction<Context>`.
- An event, which can invoke registered actions.

Modules also expose a name and can provide runtime validation. The [module reference](../modules/index.md) describes the concrete modules available to configure in the editor.

## Nodes and links

When a module is placed in a model system, it becomes a node in the workflow. A link connects nodes through a compatible role or hook. Depending on the module, a link can provide a function result, assign a submodule, or pass execution to the next action.

The type on both sides of a connection matters. A function returning `T` cannot be used where a function returning an unrelated type is required. Context-aware functions and actions also require compatible context types.

## Parameters and submodules

A parameter is a value the module reads. It may be a constant, an expression, or a value supplied by another module. A submodule is a module assigned to a named role, such as `StartModule`'s `ToExecute` action.

Required fields must be configured before a run. Optional fields let a module support simpler workflows. A module's reference page lists these fields and their expected types.

## Boundaries and variables

A model system has a global boundary and can contain additional boundaries for organizing groups of modules. Nodes exposed as model-system variables can be referenced by expressions such as a `ScriptedParameter<T>`.

Boundaries are organizational and execution scopes. Use them to keep a model readable and to define which parts of a workflow are composed together; do not assume that visual placement alone changes the order of execution.

## Execution and validation

A start module provides the entry point for an action workflow. From there, links and module behavior determine what is invoked. Functions may be evaluated when another module requests their value rather than as a separate linear step.

Runtime validation checks the configuration before execution. Typical problems include a missing required submodule, an unset expression, or an incompatible link. Fix validation errors at the module that owns the missing or incompatible configuration.

## Model-system persistence

Project metadata and model-system definitions are stored separately. An exported model-system package contains the serialized definition and metadata, while run output is generated separately. Because serialized definitions reference module types, imports require compatible assemblies to be installed.

Continue with the [XTMF2 canvas primer](canvas-primer.md) to learn how these concepts appear in the editor.