==============
Length
==============

Returns the number of cells in the given Vector or Matrix.

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

Length(Matrix) = Scalar
------------------------

.. math::
    Length(A) = 4,\
    Length(B) = 4
    

Length(Vector) = Scalar
-----------------------

.. math::
    Length(C) = 2,\
    Length(D) = 2

Length(Scalar) = ERROR
-----------------------

.. math::
    Length(0) = ERROR
