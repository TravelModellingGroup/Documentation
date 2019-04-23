# Data Processing with ODMath

ODMath is a special calculus designed for travel demand modelling. Unlike algebraic matrices when multiplying or dividing the operation is done to each respective cell. This is helpful for expressing utility calculations or performing similar calculations for each OD pair. Some basic examples of the calculus are shown below. In addition to basic arithmetic operations there are numerous functions that also work on a similar principle.

There are three TMG modules that allow access to this processing utility working with the three data types.

* TMG.Frameworks.Data.Processing.ODMath (Matrix)
* TMG.Frameworks.Data.Processing.VectorMath (Vector)
* TMG.Frameworks.Data.Processing.ScalarMath (Scalar)

## Basic Arithmetic

For example, define two matrices A and B.

\begin{equation} A = \begin{bmatrix}
      1 & 2          \\\\
      3 & 4
\end{bmatrix},
B = \begin{bmatrix}
    2 & 4          \\\\
    6 & 8
\end{bmatrix} \end{equation}


If we used the expression string `2 * A + B` we would get the following.

\begin{equation}
2 \times A + B = \begin{bmatrix}
    4 & 8          \\\\
    12 & 16
\end{bmatrix} \end{equation}

You can also use brackets to change the order of operations.

\begin{equation}
2 \times (A + B) = \begin{bmatrix}
   6 & 12          \\\\
   18 & 24
\end{bmatrix} \end{equation}

Division can also be performed using `B / A`.

\begin{equation}
B / A = \begin{bmatrix}
    2 & 2          \\\\
    2 & 2
\end{bmatrix} \end{equation}

Multiplication `A * B` would result in:

\begin{equation}
A \times B = \begin{bmatrix}
    2 & 8          \\\\
    18 & 32
\end{bmatrix} \end{equation}

Powers `A ^ B` would result in:

\begin{equation}
A^B = \begin{bmatrix}
    1 & 16          \\\\
   729 & 65536
\end{bmatrix} \end{equation}

## Vectors

Vectors can also be used in arithmetic.  In the following we define C as a Vertical matrix, and D is a Horizontal matrix.  If a matrix is loaded from a data source it will not have a directionality and must be given one before being used with matrices.

\begin{equation}
C =
\begin{bmatrix}
    1 \\\\
   3
 \end{bmatrix} \end{equation}

\begin{equation}
D =
 \begin{bmatrix}
   1 & 3
\end{bmatrix} \end{equation}

The following is the difference between the basic arithmetic with vertical and horizontal vectors applied to A:

\begin{equation}
A + C =
\begin{bmatrix}
  2 & 3 \\\\
  6 & 7
\end{bmatrix} \end{equation}

\begin{equation}
A + D =
\begin{bmatrix}
  2 & 5 \\\\
  4 & 7
\end{bmatrix} \end{equation}

## Comparisons

For certain functions comparisons are required.  If a comparison is true, a 1 is the result otherwise 0.
The comparison operators are <, >, <=, >=, == (equal), != (not equal), | (or), and & (and).

\begin{equation}
A = \begin{bmatrix}
       1 & 2          \\\\
       3 & 4
\end{bmatrix} \end{equation}

\begin{equation}
 F = 
\begin{bmatrix}
  4 & 3 \\\\
  2 & 1
\end{bmatrix} \end{equation}

\begin{equation}
A < F =
  \begin{bmatrix}
    1 & 1 \\\\
    0 & 0
  \end{bmatrix} \end{equation}
