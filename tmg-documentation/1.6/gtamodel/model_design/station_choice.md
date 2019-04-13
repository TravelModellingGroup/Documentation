# Station Choice

GTAModel V4.0's access station choice model has been improved to be a tour based station choice model.  This allows us to be able to consider different times of day
when choosing what station is selected.  For example if you were to leave in the AM from Hamilton, you might chose to drive to Aldershot station instead of
Hamilton station if you wanted to return in the evening since trains won't go as far as Hamilton at that time of day.

![alt text](images/AccessStationChoice.png "Access Station Choice")

The systematic utility for each access station is simply a linear function where we compose both the access trip and the egress trip. 
The closest station term is only added for the access trip.
Each variable is the summation of both access and egress trips.

\begin{equation}
\begin{split}
V_A = & \beta_{atime}(atime) + \beta_{cost}(acost_A + ParkingCost_{A_x} + tfare_A) + \beta_{tivtt}(preceivedTransitTime_A)\\\\
& + \beta_{capacity}(Capacity_A) + \beta_{ClosenstStation}(ClosestStation_A)
\end{split}
\end{equation}

The model is also designed to be sensitive to the parking capacity for each station. 
For the initial iteration the demand for each access station is taken from the 2011 TTS. 
We use the inverse of the conical function to achieve this so as a station becomes more congested the attractiveness of that station
is diminished for the next iteration as given by the following formulas.

\begin{equation}
CapacityFactor_A = \frac{1}{2 + \sqrt{\alpha^{2}\left(1 - CR_A\right) + \beta^2} - \alpha\left(1 - CR_A\right) - \beta}
\end{equation}

Where,

\begin{equation}
\alpha \text{ is a calibrated term similar to the exponent in the BRP function.} \\\\
CR_A = \frac{Demand_A}{Capacity_A} \\\\
\beta = \frac{2\alpha - 1}{2\alpha - 2}
\end{equation}

The probability of selecting a station is then given by its logit form, including the capacity factor scaling term, seen below.

\begin{equation}
P(A) = \frac{CapacityFactor_A * e^{V_A}}{\sum_{i}\left[CapacityFactor_i * e^{V_i}\right]}
\end{equation}