# Data Processing with ODMath

ODMath is a special calculus designed for travel demand modelling. Unlike algebraic matrices when multiplying or dividing the operation is done to each respective cell. This is helpful for expressing utility calculations or performing similar calculations for each OD pair. Some basic examples of the calculus are shown below. In addition to basic arithmetic operations there are numerous functions that also work on a similar principle.

There are three TMG modules that allow access to this processing utility working with the three data types.

* TMG.Frameworks.Data.Processing.ODMath (Matrix)
* TMG.Frameworks.Data.Processing.VectorMath (Vector)
* TMG.Frameworks.Data.Processing.ScalarMath (Scalar)

## Basic Arithmetic

For example, define two matrices A and B.


$$ A = \begin{bmatrix}
      1 & 2          \\\\
      3 & 4
\end{bmatrix} 
$$

, \\


$$ B = \begin{bmatrix}
    2 & 4          \\\\
    6 & 8
\end{bmatrix} 
$$


\
$$
   E = mc^2
\
$$

If we used the expression string ‘2 * A + B’ we would get the following.

.. math::
    2 \times A + B = \begin{bmatrix}
       4 & 8          \\
       12 & 16
    \end{bmatrix}

You can also use brackets to change the order of operations.

.. math::
    2 \times (A + B) = \begin{bmatrix}
       6 & 12          \\
       18 & 24
    \end{bmatrix}

Division can also be performed using ‘B / A’.

.. math::
    B / A = \begin{bmatrix}
       2 & 2          \\
       2 & 2
    \end{bmatrix}

Multiplication ‘A * B’ would result in:

.. math::
    A \times B = \begin{bmatrix}
       2 & 8          \\
       18 & 32
    \end{bmatrix}

Powers ‘A ^ B’ would result in:

.. math::
    A ^ B &= \begin{bmatrix}
       1 & 16          \\
       729 & 65536
    \end{bmatrix}

## Vectors

Vectors can also be used in arithmetic.  In the following we define C as a Vertical matrix, and D is a Horizontal matrix.  If a matrix is loaded from a data source it will not have a directionality and must be given one before being used with matrices.

.. math::
    C =
    \begin{bmatrix}
       1 \\
       3
    \end{bmatrix} \
     , D =
     \begin{bmatrix}
       1 \\
       3
    \end{bmatrix}

The following is the difference between the basic arithmetic with vertical and horizontal vectors applied to A:
    .. math::
      A + C =
      \begin{bmatrix}
        2 & 3 \\
        6 & 7
      \end{bmatrix}

    .. math::
      A + D =
      \begin{bmatrix}
        1 & 2 \\
        1 & 0.75
      \end{bmatrix}

## Comparisons

For certain functions comparisons are required.  If a comparison is true, a 1 is the result otherwise 0.
The comparison operators are <, >, <=, >=, == (equal), != (not equal), | (or), and & (and).

  .. math::
    A = \begin{bmatrix}
       1 & 2          \\
       3 & 4
    \end{bmatrix}   \
    , F = 
    \begin{bmatrix}
      4 & 3 \\
      2 & 1
    \end{bmatrix}

  .. math::
    A < F =
    \begin{bmatrix}
      1 & 1 \\
      0 & 0
    \end{bmatrix}
