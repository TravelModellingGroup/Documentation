# Set up XTMF2

This page covers the downloaded XTMF2 distribution and the first steps needed to open the desktop application. Source builds are only needed when developing XTMF2 itself.

## Requirements

Download and extract the complete XTMF2 distribution. It includes the application and the module libraries used to build and run model systems. You will also need a writable directory for projects and run output.

The downloaded distribution is the recommended starting point for this learning path. It avoids requiring users to clone the source repository or install module libraries separately.

## Optional source build

If you are developing XTMF2 itself, or wish to compile the latest builds, the repository requires the .NET 10.0 SDK or later. The source repository documents the following commands:

Clone the repository and build the release configuration:

```bash
git clone https://github.com/TravelModellingGroup/XTMF2.git
cd XTMF2
dotnet build -c Release
```

Run the unit tests before using a local build:

```bash
dotnet test -c Release
```

Launch the desktop application with:

```bash
dotnet run -c Release --project src/XTMF2.GUI/XTMF2.GUI.csproj
```

The exact appearance of the application can vary between releases. Use the model-system list or project view as the starting point for creating or opening a model system.

## Create a project

The built-in interactive tutorials create and open a separate practice project for you; you do not need to create a project before launching one. To make your own model, create a project in a writable directory, then create a model system inside that project. Give them names that describe their purpose, such as `MyProject` and `HelloModel`.

Keep tutorial projects separate from production projects. This makes it easier to remove an experiment, compare runs, and import an example package without changing an existing model.

## Project and run artifacts

When you build your own models, distinguish between three kinds of files:

- Project files, which identify the project and its model systems.
- Model-system exports, which can be imported into another compatible XTMF2 project.
- Run output, which is generated when a model system executes and should not be treated as part of the model definition.

An exported model system is a ZIP-based `.xmsys` package. It contains the serialized model system and export metadata, but it does not embed external CSV files, databases, or run output.

## Next step

In the next step we will explore the [primary concepts](concepts.md) of XTMF2
