# Testing of Custom Congestion Functions

Using the Winnipeg test network, the congestion functions were tested, both for consistency across assignments and for confirmation of
 underlying functional forms. For each of the base functions (BPR and Conical), two runs of the Congested Assignment
 tool were performed. All tests used a weight of 0.15 and an exponent of 4. A final run was performed, utilizing the 
custom function option and using the assumed form of the Conical congestion function. The form is as follows, as per Speiss (1990):

\begin{equation}
f(x)^C = weight(1 + \sqrt{\alpha^2(1-x)^2+\beta^2} - \alpha(1-x) - \beta)
\end{equation}

Where,

\begin{equation}
\beta = \frac{2\alpha - 1}{2\alpha -2}
\end{equation}

\\( \alpha \\) is assumed to correspond to the exponent term. In the test, \\( \beta \\) worked out to 1.1667, from an \\( \alpha \\) of 4.

Three different transit segments were checked to verify results. The following table summarizes the value of @ccost for
the three segments over the five runs. @ccost is equivalent to the congestion term multiplied by the free flow travel time
(i.e. the added congestion cost on a link). 


|    Line     |    From    |    To      |    BPR (1st)    |    BPR (2nd)    |    Conical (1st)    |    Conical (2nd)    |    Conical (Custom)    |
|-------------|------------|------------|-----------------|-----------------|---------------------|---------------------|------------------------|
|    2a       |    1042    |    1060    |    0.003617     |    0.003617     |    0.014435         |    0.014435         |    0.014435            |
|    10a      |    423     |    422     |    0.002476     |    0.002476     |    0.024296         |    0.024296         |    0.024295            |
|    10b      |    1053    |    1052    |    0.050478     |    0.050478     |    0.058709         |    0.058709         |    0.058709            |

It is clear from the results that the congestion cost term does not vary per run. Furthermore, the virtually identical nature of
the results of the default Conical and the custom Conical congestion
functions show that our assumed functional form was indeed correct.