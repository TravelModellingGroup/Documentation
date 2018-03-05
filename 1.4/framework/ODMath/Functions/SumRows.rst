==============
SumRows
==============
Returns a vector of the summation of the matrix rows

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

SumRows(Matrix) = Vector
--------------------------

.. math::
    SumRows(A) = \begin{bmatrix}
        1 \\
        -1
    \end{bmatrix}

.. math::
    SumRows(B) = \begin{bmatrix}
       6 \\
       14
    \end{bmatrix}

SumRows(Vector) = ERROR
------------------------------
.. math::
    SumRows(C) = ERROR

SumRows(Scalar) = ERROR
------------------------------
.. math::
    SumRows(0) = ERROR
