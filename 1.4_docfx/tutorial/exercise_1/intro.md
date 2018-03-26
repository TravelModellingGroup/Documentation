# Exercise 1


## 1.1 - Create a Project

Create New Project named Frabitztown.

![alt text](images/1.png "Figure 1")


![alt text](images/2.png "Figure 2")

## 1.2 - Create a Model System

Create New Model System name Exercise 2

![alt text](images/3.png "Figure 3")

![alt text](images/4.png "Figure 4")

![alt text](images/5.png "Figure 5")




## 1.3 - Create a Root Module

* Click on the root module and either press Ctrl+M or right click and select Set Module.
* Search for the module type “BasicTravelDemandModule”
* Double click on the Module type “BasicTravelDemandModel” or press “Enter”
* Press Shift+F2 or right click and select “Edit Description” and write down the description “Trip Generation”

![alt text](images/6.png "Figure 6")

![alt text](images/7.png "Figure 7")

![alt text](images/8.png "Figure 8")



## 1.4 - Setting the Base Directory

* Set model system input base directory
* Select the module named “Exercise 2”
* Select parameter “Input Base Directory”
* Set the value to the location of the input directory

![alt text](images/9.png "Figure 9")


## 1.5 - Setting the Population Resource

* Create the Population Resource
* Select the resources module
* Create Module of Type Resource
* Rename module to “Population”
* Change Parameter “Resource Name” to “Population”
* Change Data Source to ZoneInformation
* Change Reader to ReadOriginTextData
* Update Parameter “File Name” to “Population.csv”

![alt text](images/10.png "Figure 10")

![alt text](images/11.png "Figure 11")

![alt text](images/12.png "Figure 12")

![alt text](images/13.png "Figure 13")

![alt text](images/14.png "Figure 14")

![alt text](images/15.png "Figure 15")

![alt text](images/16.png "Figure 16")

![alt text](images/17.png "Figure 17")

![alt text](images/18.png "Figure 18")


## 1.5 - Copy the Population Resource

* Click on the Population module and press Ctrl+C or right click and select “Copy”
* Click on “Resources” and paste by pressing Ctrl+V or right click and selecting “Paste”
* Click on the bottom Population and press F2 or right click and select “Rename”
* Type in “WorkParticipation” and then press Enter.
* Expand the module, and expand again the Data Source submodule
* Select Reader
* Change the parameter “File Name” to “WorkParticipationRate.csv”
* Click on the Population module and press Ctrl+C or right click and select “Copy”
* Click on “Resources” and paste by pressing Ctrl+V or right click and selecting “Paste”
* Click on last Population and press F2 or right click and select “Rename”
* Type in “EmploymentRate” and then press Enter.
* Expand the module, and expand again the Data Source submodule
* Select Reader
* Change the parameter “File Name” to “EmploymentRate.csv”

![alt text](images/19.png "Figure 19")
![alt text](images/20.png "Figure 20")
![alt text](images/21.png "Figure 21")

![alt text](images/43.png "Figure 43")

![alt text](images/44.png "Figure 44")

![alt text](images/45.png "Figure 45")

![alt text](images/46.png "Figure 46")

![alt text](images/47.png "Figure 47")


## 1.7 - Create Work Generation

* Select Resources and add a new module by pressing Ctrl+M or by right clicking and selecting “Add Module”.
* Select the type “Resource”
* Rename the module “Work Generation”
* Change the parameter “Resource Name” to “WorkGeneration”
* Select sub-module Data Source.
* Set the module type to VectorMath by pressing Ctrl+M or right clicking and selecting “Set Module”
* Change the name of the module to “Compute Work Trips By Zone”
* Select Data Sources
* Add a new module by pressing Ctrl+M or right clicking and selecting “Add Module”
* Search and select the type “RemoteDataSource`1” a second window will come up asking for the sub-type.  Search for and select the type “DataStructure.SparseArray`1”.  Another window will come up for the subtype of the SparseArray.  Now search and select the type “System.Single”.
* Rename this module “Population”
* Change the parameter “Resource Name” to “Population”
* Copy Population and paste it into Compute Work Trips By Zone’s Data Sources.
* Rename the second copy of Population to “WorkParticipation”
* Change “WorkParticipations”’s parameter “Resource Name” to “WorkParticipation”
* Copy Population and paste it into Compute Work Trips By Zone’s Data Sources.
* Rename the second copy of Population to EmploymentRate
* Change “EmploymentRate”’s parameter “Resource Name” to EmploymentRate


![alt text](images/22.png "Figure 22")

![alt text](images/23.png "Figure 23")

![alt text](images/24.png "Figure 24")

![alt text](images/25.png "Figure 25")

![alt text](images/26.png "Figure 26")

![alt text](images/27.png "Figure 27")

![alt text](images/28.png "Figure 28")

![alt text](images/29.png "Figure 29")

![alt text](images/30.png "Figure 30")

![alt text](images/31.png "Figure 31")

![alt text](images/32.png "Figure 32")

![alt text](images/33.png "Figure 33")

![alt text](images/34.png "Figure 34")

![alt text](images/35.png "Figure 35")

![alt text](images/36.png "Figure 36")

![alt text](images/37.png "Figure 37")

![alt text](images/38.png "Figure 38")

![alt text](images/39.png "Figure 39")

![alt text](images/40.png "Figure 40")

![alt text](images/41.png "Figure 41")

![alt text](images/42.png "Figure 42")

![alt text](images/49.png "Figure 49")

## 1.8 - Calculate Work Generation Expression


* Select the module 'Compute Work Trips By Zone'
* Set expression to `Population * WorkParticipation * EmploymentRate`

![alt text](images/48.png "Figure 48")


## 1.9 - Create Save Work Generation

* Select To Execute and add a module of the type “SaveSparseArrayToCSV”
* Select the created module and rename it to “Save Work Generation”
* Expand the module and select Data.
* Set the module type of Data to “ResourceLookup”
* Change the parameter “Resource Name” to “WorkGeneration”
* Select the module “Output To”
* Set the module type of “Output To” to "FilePathFromOuputDirectory".
* Change the value of the parameter “File From Output Directory” to “WorkGeneration.csv”
* Create Zone System
* Select the module named “Zone System”
* Set the module type to “ZoneRetriever”

![alt text](images/51.png "Figure 51")

![alt text](images/52.png "Figure 52")

![alt text](images/53.png "Figure 53")

![alt text](images/54.png "Figure 54")

![alt text](images/55.png "Figure 55")

![alt text](images/56.png "Figure 56")

![alt text](images/57.png "Figure 57")

![alt text](images/58.png "Figure 58")

![alt text](images/59.png "Figure 59")

![alt text](images/60.png "Figure 60")

![alt text](images/61.png "Figure 61")

![alt text](images/62.png "Figure 62")
