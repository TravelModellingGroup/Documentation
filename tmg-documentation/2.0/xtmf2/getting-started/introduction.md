# Introduction to XTMF2

XTMF2 is the eXtensible Travel Modelling Framework 2. It provides a desktop environment and runtime for composing travel-model workflows from reusable modules.

A model system describes a workflow rather than a single calculation. It contains modules, their configuration, and the connections that determine how execution and data move through the workflow. This lets a model be assembled from small, testable pieces and replaced or extended without rewriting the whole system.

## XTMF2 and TMG modules

XTMF2 supplies the framework, user interface, runtime, persistence, and core runtime modules. Travel-model functionality is supplied by module libraries maintained in related repositories, including:

- [TMG-Framework](https://github.com/TravelModellingGroup/TMG-Framework) for general travel-demand model data and processing.
- [TMG.Tasha2](https://github.com/TravelModellingGroup/TMG.Tasha2) for TASHA and TASHA2 workflows.
- [TMG.EMME](https://github.com/TravelModellingGroup/TMG.EMME) for EMME integration and TMGToolbox2 for EMME.
- [TMG.Visum](https://github.com/TravelModellingGroup/TMG.Visum) for VISUM integration.

The built-in interactive tutorials use modules contained within the standard XTMF2 distribution.

## The model-building cycle

Workflows using XTMF2 typically follow two patterns:

Operational use:
  1. Creating projects and importing model systems.
  2. Editing the parameters to specify the scenario.
  3. Running the model system.
  4. Processing the outputs.

Model System Construction:
  1. Create a project and a model system.
  2. Add modules that represent data, calculations, control flow, or outputs.
  3. Configure parameters and submodules.
  4. Link compatible modules so values and execution flow reach the right places.
  5. Run it and inspect logs or generated outputs.
  6. Adjust the model and repeat.

Estimation and calibration use the same model system with additional configuration describing which parameters may change and which outputs should be compared.

## What comes next

Start with [Set up XTMF2](setup.md), then review [model systems](concepts.md) and the [canvas primer](canvas-primer.md). When you are ready to practice, launch the [interactive tutorials](estimation-calibration.md). Experienced users can go directly to the [module reference](../modules/index.md).
