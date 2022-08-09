# Building TMG Documentation

## Setting Up Environment

### DocFX
To setup your machine for building the documentation
you will need to install [docfx](https://dotnet.github.io/docfx/).
Follow their instructions [here](https://dotnet.github.io/docfx/tutorial/docfx_getting_started.html)
for how to setup the tool.  You will not need to initialize
a repository, only install it using Chocolatey, Homebrew, or
manually set it up from Github.  Make sure to be using the latest
build of version 2.

## Building

To build the site and host it on port 8080:

```cmd
cd tmg-documentation
docfx build --serve
```

You will then be able to view the site using a web browser going to the address
`http://localhost:8080`.
