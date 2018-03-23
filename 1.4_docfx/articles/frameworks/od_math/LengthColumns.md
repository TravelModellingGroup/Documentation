==============
LengthColumns
==============
Returns the number of cells for each column in the given Matrix.

.. math::
    A = \begin{bmatrix}
       -1 & 2          \\
       3 & -4
    \end{bmatrix}, \
    B = \begin{bmatrix}
       2 & 4          \\
       6 & 8
    \end{bmatrix}, \
    C = \begin{bmatrix}
       -1 \\
       3
    \end{bmatrix}
   

LengthColumns(Matrix) = Vector
------------------------------

.. math::
    LengthColumns(A) = \begin{bmatrix}
        2 & 2
    \end{bmatrix}

.. math::
    LengthColumns(B) = \begin{bmatrix}
        2 & 2
    \end{bmatrix}

LengthColumns(Vector) = ERRROR
-------------------------------

.. math::
    LengthColumns(C) = ERROR

LengthColumns(Scalar) = ERROR
-------------------------------

.. math::
    LengthColumns(0) = ERROR