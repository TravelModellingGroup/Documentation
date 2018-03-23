============================
IdentityMatrix
============================

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

IdentityMatrix(Scalar) = ERROR
--------------------------------------------------------------------------
.. math::
    IdentityMatrix(-1) = ERROR

IdentityMatrix(Vector) = Matrix
--------------------------------------------------------------------------
The orientation of the vector will be maintained in the resulting vector.

.. math::
    IdentityMatrix(C) = \begin{bmatrix}
      1 & 0 \\
      0 & 1
    \end{bmatrix}

IdentityMatrix(Matrix) = Matrix
--------------------------------------------------------------------------
.. math::
    IdentityMatrix(A) = \begin{bmatrix}
      1 & 0 \\
      0 & 1
    \end{bmatrix}


