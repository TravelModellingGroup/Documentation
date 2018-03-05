==============
Avg
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

Avg(Scalar) = ERROR
--------------------------------------------------------------------------
.. math::
    Avg(-1) = ERROR

Avg(Vector) = Scalar
--------------------------------------------------------------------------
The orientation of the vector will be maintained in the resulting vector.

.. math::
    Avg(C) = 1

Avg(Matrix) = Scalar
--------------------------------------------------------------------------
.. math::
    Avg(A) = 0
