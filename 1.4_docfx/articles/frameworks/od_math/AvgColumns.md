==============
AvgColumns
==============

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

AvgColumns(Scalar) = ERROR
--------------------------------------------------------------------------

.. math::
    Avg(-1) = ERROR

AvgColumns(Vector) = ERROR
--------------------------------------------------------------------------

.. math::
    Avg(C) = ERROR

AvgColumns(Matrix) = Vector
--------------------------------------------------------------------------
.. math::
    AvgColumns(A) = \begin{bmatrix}
      1 & -1
    \end{bmatrix}

.. math::
    AvgColumns(B) = \begin{bmatrix}
      4 & 6
    \end{bmatrix}