# **Estimate Transit Operating Costs**
This tool computes estimated route-by-route transit operating costs for the time period depicted
by the selected scenario, in addition to revenue hours, revenue kilometres, and estimated vehicle
count. Individual transit lines are grouped into routes. The tool takes the transit service table 
file as well as a cost parameters file as input.

## **Using the Tool with Modeller**
The tool can be found in "TMG Toolbox" -> "Analysis" -> "Transit" -> "Estimate Transit Operating 
Costs"

### Scenario
Select the scenario to perform the cost computation for. Be sure to have the time period information
(AM, MD, PM, EV, or ON) present in the scenario title. For time periods other than ON, please select
a scenario with completed transit assignment results for better accuracy.

### Service Table File
The service table file is a CSV file that follows the same format as the service table file found in
the GTAModel input folder. It contains three columns with a header row: `emme_id`, `trip_depart`, 
`trip_arrive`. `emme_id` is the Emme transit line ID, and `trip_depart` and `trip_arrive` are the
start and end times of each scheduled transit trip in `HH:MM:SS` (zero-padded, 24 hour format).
Non-zero padded formatting is also accepted, such as `7:14:00`. Some transit agencies schedule 
late-night, post-midnight trips in the same service day with the `HH` field being 24 or greater 
(e.g. `25:01:00`). This is also accepted.

### Cost Parameters File
The cost parameters CSV file contains ten columns with a header row. Each subsequent row is a set
of cost parameters for the particular agency / mode combo. The columns are:

* `agency_prefix`: the first one or two capital letters of the Emme transit line ID that 
identifies the agency (e.g. "B", "HM", etc.) the set of parameters is for
* `mode`: the ID of the mode the set of parameters is for (e.g. "b", "r", m", etc.)
* `uc_revhr`: unit cost per revenue hour
* `uc_revkm`: unit cost per revenue kilometre
* `uc_veh_annual`: annual unit cost per peak vehicle
* `uc_veh_daily`: daily unit cost per peak vehicle. **Note:** Only one of `uc_veh_annual` and
`uc_veh_daily` is required. Simply leave the other field blank.
* `weekday_ratio_revhr`: multiplier to get annual estimates of revenue hours from a weekday daily 
value
* `weekday_ratio_revkm`: multiplier to get annual estimates of revenue km from a weekday daily value
* `adj_revhr`: calibrated adjustment factor for revenue hours
* `adj_revkm`: calibrated adjustment factor for revenue km

If there is no specified cost parameter set for a particular agency / mode combo that is present in 
the Emme transit lines in the network, the cost computation will return the default cost of $0 for 
routes with that combo.

### Report File
Select "Browse..." to navigate to the target folder to store the results in a CSV file.

The results will have 6 columns:

* `route_id`: the ID of the route which is obtained from grouping individual lines under the same 
overall route
* `mode`: the mode ID of a representative line of the route
* `rev_hr`: the estimated revenue hours for the route within the time period 
* `rev_km`: the estimated revenue kilometres for the route within the time period
* `no_veh`: the estimated count of unique vehicles deployed on the route within the time period
* `op_cost`: the estimated operating costs for the route within the time period


## **Using the Tool with XTMF**
The tool is called "EstimateTransitOperatingCosts".  It is available to add under 
*ExecuteToolsFromModellerResource* or *EmmeToolsToRun*.

The individual input and output file specifications are exactly the same as in the above section.

### Scenario
The number of the Emme scenario to perform the cost computation for.

### Service Table File
The CSV file that contains scheduled trip departure and arrival times for each Emme transit line.

### Cost Parameters File
The CSV file that contains individual sets of cost parameters specific to each agency / mode combo.

### Report File
Select the target folder to store the results in a CSV file.

