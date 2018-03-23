==============
AvgRows
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

AvgRows(Scalar) = ERROR
--------------------------------------------------------------------------

.. math::
    AvgRows(-1) = ERROR

AvgRows(Vector) = ERROR
--------------------------------------------------------------------------

.. math::
    AvgRows(C) = ERROR

AvgRows(Matrix) = Vector
--------------------------------------------------------------------------

.. math::
    AvgRows(A) = \begin{bmatrix}
      1 \\
      -1
    \end{bmatrix}

.. math::
    AvgRows(B) = \begin{bmatrix}
      3 \\
      7
    \end{bmatrix}
