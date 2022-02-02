# Forecasting

After you have installed and setup your instance of PopSynIIIAutomated you will need to generate some scenarios to test.
Each scenario consists of a single file, `Population.csv`, contained in a folder.  This is a CSV with the following columns, in order:

* TAZ
    * The zone number to assign population to.
* Population
    * The future year population to assign to this zone.

> [!Warning]
> Please do not include population for external zones here or households will be generated that live in those zones!

With this complete you can run PopSynIII automated to generate your new synthetic population.