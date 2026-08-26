# Delete Assignment Results

Invoke the VISUM Delete Assignment Results procedure.

Use this module to clear previously computed assignment results from the VISUM instance
before running a new assignment.  Private transit (PrT) and public transit (PuT) results
can be cleared independently.

## Class Variants

| Class | Base Type | Source File |
| --- | --- | --- |
| `DeleteAssignmentResults` | `BaseAction<VisumInstance>` | `Delete/DeleteAssignmentResults.cs` |

## DeleteAssignmentResults

Base type: `BaseAction<VisumInstance>`

### SubModules

| Name | Type | Required | Description |
| --- | --- | --- | --- |
| - | - | - | - |

### Parameters

| Name | Type | Required | Default | Description |
| --- | --- | --- | --- | --- |
| `Delete PrT Results` | `IFunction<bool>` | `true` | `true` | Delete private transit results. |
| `Delete PuT Results` | `IFunction<bool>` | `true` | `true` | Delete public transit results. |
