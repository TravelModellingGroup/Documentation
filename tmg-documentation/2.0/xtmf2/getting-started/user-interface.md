# Explore the user interface

XTMF2's desktop application is organized around projects, model systems, and runs. The names and layout of individual controls can change between builds, but the workflow remains the same.

## Projects and model systems

A project is the container for one or more model systems. The project view is where you create, open, import, export, and select model systems. A model system is the workflow you edit and run.

To explore a model system, open it from the project view. For guided practice, launch an interactive tutorial from **Help** > **Interactive Tutorial…**; XTMF2 opens the tutorial in a separate project.

## The model-system editor

The editor is the canvas where modules are arranged and connected. A module appears as a node in the model system. Select a node to inspect its configured parameters and submodules.

Use the editor to:

- Add a module from the available module libraries.
- Set scalar values and choose submodules.
- Connect modules through compatible links.
- Arrange nodes so the workflow is easy to read.
- Save the model system before running it.

The canvas is a representation of the workflow. The order in which nodes appear on screen does not by itself define execution order; links and module behavior do.

## Module configuration

A module can expose parameters, submodules, or both. Parameters are values or expressions used by the module. Submodules are other modules assigned to a named role, such as the source of a value or the action to execute.

Use the module reference when a field is unclear. It identifies the module's class variants, base type, parameters, submodules, and requiredness.

## Links and validation

Links connect compatible module outputs and inputs. A link may carry a value, pass execution to another module, or do both, depending on the module contract.

Validate the model system after configuring its links. Validation catches missing required values, missing required submodules, and incompatible configuration before a run starts. Treat a validation error as part of model construction, not as a runtime result to ignore.

## Running and inspecting results

Use the run controls after validation. During a run, monitor progress and messages in the run view or log output. When the run finishes, inspect the output values or files produced by the model system.

A run creates output separately from the model definition. If a result is important, record the input configuration and output location so that the run can be reproduced.

## Estimation and calibration views

Estimation and calibration are configured for a model system and then launched as specialized runs. Their dialogs expose the parameter and output relationships used by the optimization or calibration workflow. For guided practice, launch **Estimate a Model Parameter** or **Calibrate a Model Parameter** from **Help** > **Interactive Tutorial…**; see [Run XTMF2 interactive tutorials](estimation-calibration.md).

## Next step

Continue with the [XTMF2 canvas primer](canvas-primer.md) to learn the visual elements used to build a model system.
