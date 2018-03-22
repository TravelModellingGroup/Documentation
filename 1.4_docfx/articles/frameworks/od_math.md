# Data Processing with ODMath

ODMath is a special calculus designed for travel demand modelling. Unlike algebraic matrices when multiplying or dividing the operation is done to each respective cell. This is helpful for expressing utility calculations or performing similar calculations for each OD pair. Some basic examples of the calculus are shown below. In addition to basic arithmetic operations there are numerous functions that also work on a similar principle.

There are three TMG modules that allow access to this processing utility working with the three data types.

* TMG.Frameworks.Data.Processing.ODMath (Matrix)
* TMG.Frameworks.Data.Processing.VectorMath (Vector)
* TMG.Frameworks.Data.Processing.ScalarMath (Scalar)

## Basic Arithmetic

For example, define two matrices A and B.

A = \begin{bmatrix}
      1 & 2          \\
      3 & 4
\end{bmatrix}   \
, B = \begin{bmatrix}
    2 & 4          \\
    6 & 8
\end{bmatrix}


\\begin{equation}
   E = mc^2
\\end{equation}