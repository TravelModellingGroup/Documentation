# Index

Below is an index for all of the modules available for XTMF2.

## Module List

### Assign

  * [Assign Road](Assign/AssignRoad.md) - Run a road assignment.
  * [Assign Transit](Assign/AssignTransit.md) - Run a transit assignment.

#### Road Algorithms

  * [Bicycle Algorithm](Assign/RoadAlgorithms/BicycleAlgorithm.md) - Use the Visum Bicycle assignment with reasonable default values.
  * [Bi-Conjugate Frank-Wolfe Algorithm](Assign/RoadAlgorithms/BiConjugateFrankWolfeAlgorithm.md) - Use the Equilibrium assignment Bi-conjugate Frank-Wolfe.
  * [Equilibrium Algorithm](Assign/RoadAlgorithms/EquilibriumAlgorithm.md) - Use the standard Equilibrium assignment.
  * [LUCE Algorithm](Assign/RoadAlgorithms/LUCEAlgorithm.md) - Use the Equilibrium assignment LUCE.

#### Transit Assignment Algorithms

  * [Headway Algorithm](Assign/TransitAssignmentAlgorithm/HeadwayAlgorithm.md) - Provides parameters to control the Headway PutAssignment algorithm.

### Calculate

  * [Calculate Road LoS](Calculate/CalculateRoadLoS.md) - Generates the level of service matrices for the given types.

### Common

  * [Demand Segment For Assignment](Common/DemandSegmentForAssignment.md) - Contains the information for setting up the demand segment that will be assigned.

### Create

  * [Create Segments and Series](Create/CreateSegmentsAndSeries.md) - Create or update Demand Segments, Demand Time Series, and Standard Time Series.
  * [Create User Attribute](Create/CreateUserAttribute.md) - Create the user attribute if it does not exist.

### Delete

  * [Delete Assignment Results](Delete/DeleteAssignmentResults.md) - Invoke the VISUM Delete Assignment Results procedure.

### Edit

  * [Edit Attribute](Edit/EditAttribute.md) - Executes an EditAttribute procedure on the current VISUM instance.

### Export

  * [Export Attribute Where Set](Export/ExportAttributeWhereSet.md) - Export an attribute's values where a condition attribute is set.
  * [Export Line Boardings](Export/ExportLineBoardings.md) - Export line boardings from the current VISUM instance to a CSV file.
  * [Export Shape File](Export/ExportShapeFile.md) - Export the currently loaded network to ShapeFile.

### Import

  * [ImportCategoriesFromVisumInstance](Import/ImportCategoriesFromVisumInstance.md) - Imports categories from a Visum instance.
  * [Import Matrix To Visum](Import/ImportMatrixToVisum.md) - Store the given matrix into a Visum Instance.

### Load

  * [Load General Settings](Load/LoadGeneralSettings.md) - Load the General Procedure Settings from a given file into the current instance.
  * [Load Version File](Load/LoadVersionFile.md) - Tell the Visum instance to load the given version file.
  * [Load Visum Instance](Load/LoadVisumInstance.md) - Load a new instance of VISUM.

### Save

  * [Save General Settings](Save/SaveGeneralSettings.md) - Save the General Procedure Settings from the current instance to a given file.
  * [Save Visum Instance](Save/SaveVisumInstance.md) - Save the current Visum instance to a file.
