# Overview

## Rust
Rust is a strongly typed, memory-safe system programming language designed to ensure high performance without sacrificing 
safety. It emphasizes concurrent programming, providing mechanisms to prevent data races at compile time. 
Rust’s ownership model, combined with strict compile-time checks, allows developers to write robust and efficient code with 
a focus on reliability, speed, and maintainability. Its expressive syntax, rich standard library, 
and modern tooling make Rust suitable for both system-level development and high-level application programming.


## The rust documentation:  

* [Rust Book](https://doc.rust-lang.org/cargo/) - This link is the rust book that goes into the both the basics and advanced concepts of how to use Rust. 
* [Rustlings](https://rustlings.rust-lang.org/) - An online (or optionally offline) tool to learn Rust through a series of problems.

## Installation Instruction: 


### Tools Needed:  

- You do need a code editor and choose any code editor of your choosing. The two recommended code editors are Visual Studio(Windows)
or Visual Studio Code. Download links provided below:  
- https://code.visualstudio.com/download 
- https://visualstudio.microsoft.com/downloads/


## Installing Rust Instructions 
The main installation instructions can be found at this link:
- https://rust-lang.org/tools/install/ 

 
The main page will then give you the terminal command lines needed to install Rust depending on your system and machine configurations.

### Installing Rust on Windows:  
On Windows will provide excecuable files you can directly download from the website and then double click to install. 
With respect to Windows you may need to instal some additioanl dependices like the C++ development environment which you can easily download from the Visual Studio environment. 

### Installing Rust on Linux command  
```
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh 
```

## Cargo  

Cargo is Rust’s official efficient build system and package manager. Cargo is responsible for installing and managing packages  for a given project.  Cargo makes it easy to create, manage and build Rust projects.  
The following commands are useful:

To create a new project that will create a folder with the base template files: 
```> cargo new hello_world
    Creating binary (application) `hello_world` package
note: see more `Cargo.toml` keys and their definitions at https://doc.rust-lang.org/cargo/reference/manifest.html
```

The command creates the following tree:
```
F:.
│   .gitignore
│   Cargo.lock
│   Cargo.toml
│
└───src
        main.rs
```
As you can the command generates one folder called src that has the main basic file called main.rs file which is the main rust file. The Cargo.toml file is the file which will manage and list all
the libraries and tools you will use for your project.
 Cargo.toml 

To run a rust application run the command cargo run like below

```
> cargo run
```

If you use the ls command you will see a new folder called target which stores the compiled binaries and dependenices for your project

If you wish to just build your application and not run it you can use cargo build
```
> cargo build
```

Cargo clean is used to clean the project during errors. 
```
> cargo clean
```

```
> cargo doc
> cargo doc -open
```
Cargo doc is a useful command line as it reads your rust code and automatically generates all the documentation for your project.
It productes a html file that can be opened in any browser. 
With the open command the documentation is automatically opened in the browser by the system default browser.

Here is an example of how to add libraries to the cargo. You use the command Cargo add for example 
```
> cargo add polars --features lazy,csv
```
- Note: the features command allows you to install the libary methods you wish and need. 

Upon successful completion opening your Cargo.toml file in the text editor under dependencies will show the installed libraries 
with the version.
Below is an example of a Cargo.toml file with some installed packages.
```
[dependencies] 
csv = "1.4.0" 
polars = { version = "=0.51.0", features = ["lazy", "bigidx"] } 
serde = "1.0.228" 
```
 
 