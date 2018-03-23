==============
Sum
==============
Returns the summation of all elements in the structure.

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

Sum(Matrix) = Scalar
---------------------------

.. math::
    Sum(A) = 0

.. math::
    Sum(B) = 20

Sum(Vector) = Scalar
---------------------------

.. math::
    Sum(C) = 2

.. math::
    Sum(D) = 2

Sum(Scalar) = ERROR
---------------------------

.. math::
    Sum(0) = ERROR
