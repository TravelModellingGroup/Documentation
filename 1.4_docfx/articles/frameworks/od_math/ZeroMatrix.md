==============
ZeroMatrix
==============
Creates a zero matrix from a vector or matrix.

.. math::
    A = \begin{bmatrix}
       -1 & 2          \\
       3 & -4
    \end{bmatrix}, \
    B = \begin{bmatrix}
       2 & 4          \\
       6 & 8
    \end{bmatrix},, \
     C = \begin{bmatrix}
       -1 \\
       3
    \end{bmatrix}, \
    D = \begin{bmatrix}
       -1 & 3
    \end{bmatrix}

ZeroMatrix(Matrix) = Matrix
--------------------------------------

.. math::
    ZeroMatrix(A) = \begin{bmatrix}
       0 & 0          \\
       0 & 0
    \end{bmatrix}

.. math::
    ZeroMatrix(B) = \begin{bmatrix}
       0 & 0          \\
       0 & 0
    \end{bmatrix}

ZeroMatrix(Vector) = Matrix
--------------------------------------

.. math::
    ZeroMatrix(C) = \begin{bmatrix}
        0 & 0 \\
        0 & 0
    \end{bmatrix}

.. math::
    ZeroMatrix(D) = \begin{bmatrix}
        0 & 0 \\
        0 & 0
    \end{bmatrix}

ZeroMatrix(Scalar) = ERROR
--------------------------------------

.. math::
    ZeroMatrix(0) = ERROR
