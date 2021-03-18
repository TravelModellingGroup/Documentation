# Development Notes and Other Miscellaneous Information

## Writing Aimsun Scripts

- Aimsun scripts are run from the command line using a tool aconsole.exe. This exists in teh main Aimsun installation folder as of Aimsun Next 20. 
It is important that the working directory for the current execution context is set the the location of the aconsole.exe application, otherwise several
python dependencies and modules will not be found.
- `aconsole.exe` takes a single parameter --script which must be the absolute path to the python script to be run.
- Any arguments after the path to the python sript are sent as command line arguments (argv) to the python script itself.

## A Brief Explanation of Writing a new Tool  for the Aimsun Toolbox

- Take a look at smaller existing tools for examples
- Get a reference to the Console object from Aimsum
    - Get the active Model from the console object provided
    - If none exists, make a new model.
- Using model reference, various editing actions can now take place.
- Save the model when finished, and close the console.

### Location of Required Python Modules

- The Python modules required for interacting with the Aimsun API are located in the main installation folder under *plugins/python*. *PyANGApp*, *PyANGonsole*, *PyANGKernel*, *PyANGGui* are the more frequently used/critical module dependencies. Reference them in your IDE if it supports parsing external modules for automcomplete and other intellisense features. Otherwise, any documetation on these modules must be inferred from the C implementation included in the Aimsun scripting documentation.