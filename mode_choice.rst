Mode Choice
====================================================================================
With trip distribution calculated, OD math can be utilized again to calculate mode choice. This guide uses a very simple utility function for transit and auto.

.. math:: P_m = \frac{e^{u_{ijm}}}{\sum{e^{u_{ijm}}}}

          {{u_{ij}}^{auto}} = 0.02 \times aivtt_{ij}

		  {{u_{ij}}^{transit}} = 0.03 \times tivtt_{ij}


Add two more child ODMath module under resources. This module will need to read in the trip distribution matrix CSV file output from the previous step. In addition to the trip distribution matrix, travel time for auto and transit modes will also be used as part of the calculation. In total, each ODMath resource will require three input matrices to perform mode choice.

.. figure:: images/auto_mode_choice.png
   :scale: 50 %
   :align: center

   ODMath mode choice calculation.

In total, two matrices will be calculated utilizing ODMath. Each matrix will represent the demand for the auto and transit modes.
