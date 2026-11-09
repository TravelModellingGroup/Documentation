# XTMF2 canvas primer

The model-system canvas shows the elements in the currently open boundary and the connections between them. The background grid and the elements' positions help organize a model, but visual position alone does not determine execution order. Module behavior and links determine how the model runs.

## Module nodes

A module node is a configured instance of a module. Its card has a name and may show a parameter value or connection hooks. Select a node to edit its parameters and submodules in the editor. A node can represent an action, a function, a parameter, or another module type; consult the [module reference](../modules/index.md) to understand its behavior.

Parameter modules such as `BasicParameter<T>`, `ScriptedParameter<T>`, and `SetableParameter<T>` appear as nodes too. Their value is part of the model configuration. A scripted parameter calculates a value from an expression, while a settable parameter can be changed by supported model workflows such as estimation or calibration.

Hooks are the named connection points on nodes. They represent module inputs, outputs, or submodule roles. Required hooks are shown on the node; optional hooks can be revealed with the node's hook control. The hook name and module contract determine what can connect there.

## Starts

A Start is a circular entry point for an action workflow. It is not a module node. Connect it to the action that should run first; a run uses a selected Start to begin execution. A model system can contain more than one Start.

## Links

Links join compatible hooks or connect a Start to an action. Depending on the hook, a link can provide a value, assign a submodule, or pass execution to another action. A link is a model relationship, not merely a visual line; moving nodes changes its route but not its meaning.

To create a link, drag from the Start or an origin hook to the destination node or compatible hook. If a link is rejected or the model fails validation, check that the source and destination roles and types are compatible and that required hooks are configured.

## Comments

A comment block is a note on the canvas with a header and a body. Use it to explain the purpose or assumptions of a part of the model. Comments help people understand the model but do not participate in execution.

## Function templates, parameters, and instances

A function template is a reusable workflow shown as a container on the canvas. Double-click it to open its internal boundary and edit the modules inside. Use the editor's boundary navigation to return to the parent canvas.

Function parameters define the template's exposed interface. Inside a template, each appears as a special parameter element with a name, type, and optional description. Those parameters become hook rows on the template in its parent boundary and on each instance that uses it.

A function instance is a use of a function template. Its hook rows correspond to the template's exposed parameters; connect or configure these to provide the values or modules that the template needs. Multiple instances can reuse the same template with different inputs.

## Boundaries and ghost nodes

A boundary is a scope containing part of a model system. The top-level model system and a function template's internal modules are separate boundaries; navigating into a function template changes which boundary is shown on the canvas.

When a connection crosses a boundary, XTMF2 can show a ghost node: a dashed proxy for a real node or function instance located in another boundary. It is a reference to that element, not a second independent module. Ghosts help show and manage cross-boundary connections.

## Canvas guides and temporary visuals

The background grid helps align elements but has no effect on the model. When displayed, a faint correspondence line connects a ghost node to the real element it represents. A pending link while you are drawing one and a selection rectangle while selecting multiple elements are temporary editor visuals, not saved model elements.

## Add elements

Right-click an empty area of the canvas to open the context menu. It provides commands for adding a Start, module, comment, function template, or function instance. The shortcuts include **Ctrl+M** for a module, **Ctrl+N** for a comment, **Ctrl+T** for a function template, and **Ctrl+I** for a function instance. Within a function template, the menu also offers **Add Function Parameter**.

The [Getting Started interactive tutorial](simple-model.md) demonstrates a Start, module node, link, and comment in a small runnable model. See [Run XTMF2 interactive tutorials](estimation-calibration.md) to launch it.
