==============
SumColumns
==============
Returns a vector of the summation of the matrix columns

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
    \end{bmatrix}, \
    D = \begin{bmatrix}
       -1 & 3
    \end{bmatrix}

SumColumns(Matrix) = Vector
-----------------------------

.. math::
    SumColumns(A) = \begin{bmatrix}
        2 & -2
    \end{bmatrix}

.. math::
    SumColumns(B) = \begin{bmatrix}
       8 & 12
    \end{bmatrix}

SumColumns(Vector) = ERROR
------------------------------
.. math::
    SumColumns(C) = ERROR

SumColumns(Scalar) = ERROR
------------------------------
.. math::
    SumColumns(0) = ERROR