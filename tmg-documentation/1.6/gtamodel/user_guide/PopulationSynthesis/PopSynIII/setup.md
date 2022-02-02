# Setup

To setup PopSynIII we are going to need to install mysql, setup the database that we will use, install the Visual Studio C Runtime, and finally the Java Runtime Environment.

## Dependencies 

1. MySql Server 5.5.64, which you can download from [here](https://tmg.utoronto.ca/files/PopulationSynthesis/mysql-5.5.62-winx64.msi).
2. Visual Studio C Runtime, which you can download from [here](https://tmg.utoronto.ca/files/PopulationSynthesis/vcredist_x64.exe).
3. Java JRE 7, which you can download from [here](https://tmg.utoronto.ca/files/PopulationSynthesis/jre-7u80-windows-x64.exe)
4. Base Input files from TMG.

## Installing MySQL

When installing MySQL make sure use the following settings.

1. Select "Launch the MySQL Instance Configuration Wizard"
2. Select "Next"
3. Select Detailed Configuration
4. Select Developer Machine
5. Select "Multifunctional Database"
6. Select Manual Setting and include at least as many connections as you have CPU cores.
7. Enable TCP/IP networking.  Make sure to disable Port 3306 in the firewall.  Do not enable a firewall exception for this unless your database is on a server other than the one that will run PopSynIII.
8. Select "Standard Character Set".
9. Select "Include Bin Directory in Windows PATH".
10. Select Modify Security Settings and set the root password.  Do not allow root access from remote machines.
11. Press Execute and MySQL will install itself.

## Setting up the Database

Once you have installed MySQL run the following commands to create the database used by PopSynIII.

First we are going to log into the mysql server.  Enter the following command.  Once it has run it will prompt you for the root user's password that we setup during the installation.

> mysql -u root -p

Next we are going to create the database.

> CREATE DATABASE TorontoPopSynIII;

Now that we have the database setup we can exit mysql with the following command.

> exit

## Install Visual Studio C Runtime

For the Visual Studio C Runtime just follow the default settings in the installer.

## Install Java Runtime Environment 7

Install the JRE 7 revision 80 with default settings.  Other revisions and versions of Java have been found to be incompatible.  A link to the JRE used by TMG can be found above.