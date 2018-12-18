# Testing of Custom Congestion Functions

Using the Winnipeg test network, the congestion functions were tested, both for consistency across assignments and for confirmation of underlying functional forms. For each of the base functions (BPR and Conical), two runs of the Congested Assignment tool were performed. All tests used a weight of 0.15 and an exponent of 4. A final run was performed, utilizing the custom function option and using the assumed form of the Conical congestion function. The form is as follows, as per Speiss (1990):

TODO

α is assumed to correspond to the exponent term. In the test, β worked out to 1.1667, from an α of 4.
Three different transit segments were checked to verify results. The following table summarizes the value of @ccost for the three segments over the five runs. @ccost is equivalent to the congestion term multiplied by the free flow travel time (i.e. the added congestion cost on a link). 


TODO