# Getting Started

When developing for XTMF there are two primary work-flows.  You can develop for XTMF directly, editing the underlying
software environment, or you can develop a plug-in library of modules that can be added to the XTMF's Modules directory.  These
custom modules will then be made available for use when constructing model systems as long as those modules implement the correct
interfaces.

## Installing Visual Studio

While not strictly required we recommend that you begin by downloading the Visual Studio 2019 (or newer) installer from 
[here](https://visualstudio.microsoft.com/downloads/).

In order to develop XTMF modules with Visual Studio, the appropriate packages must also be installed. If you have already
installed Visual Studio - you can simply re-run the Visual Studio Installer and choose 'modify' to add or remove packages from
your current installation.

Required Package(s):

1. .NET Desktop Development

The second step is to set the output directory of the dynamically linked library to be inside of the XTMF's Modules directory from
the project's properties page. To get ready for debugging, in the project's property page go to the Debug tab and set the
'Start Action' to 'Start external program' and direct it to your 'XTMF.GUI.exe'.

## Learning to Program

The first step for creating any module is to learn gain at least a basic understanding of
a .Net compatible language. [MSDN](https://docs.microsoft.com/en-us/learn/modules/csharp-write-first/1-introduction)
has a good interactive tutorial for learning C#, the language that TMG uses to develop XTMF and its modules.
Alternatively, you can also use the C++/CLI, F#, or VB.Net languages if they are more comfortable
for yourself.  The following documentation is going to assume that you are working with C# however.
