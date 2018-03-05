==============
Matrix
==============
Creates a square matrix from a vector.

.. math::
    A = \begin{bmatrix}
       -1 & 2          \\
       3 & -4
    \end{bmatrix}, \
     C = \begin{bmatrix}
       -1 \\
       3
    \end{bmatrix}, \
    D = \begin{bmatrix}
       -1 & 3
    \end{bmatrix}

Matrix(Matrix) = ERROR
--------------------------------------

.. math::
    Matrix(A) = ERROR

Matrix(Vector) = Matrix
--------------------------------------

.. math::
    Matrix(C) = \begin{bmatrix}
        -1 & 3 \\
        -1 & 3
    \end{bmatrix}

.. math::
    Matrix(D) = \begin{bmatrix}
        -1 & -1 \\
        3 & 3
    \end{bmatrix}

Matrix(Scalar) = ERROR
--------------------------------------

.. math::
    Matrix(0) = ERROR