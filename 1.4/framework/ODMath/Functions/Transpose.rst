==============
Transpose
==============
Swaps each OD pair so that [i,j] becomes the previous [j,i].

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

Transpose(Matrix) = Matrix
---------------------------

.. math::
    Transpose(A) = \begin{bmatrix}
        -1 & 3 \\
        -2 & -4
    \end{bmatrix}

.. math::
    Transpose(B) = \begin{bmatrix}
        2 & 6 \\
        4 & 8
    \end{bmatrix}

Transpose(Vector) = Vector
---------------------------

.. math::
    Transpose(C) = \begin{bmatrix}
        -1 & 3
    \end{bmatrix}

.. math::
    Transpose(D) = \begin{bmatrix}
        -1 \\
        3
    \end{bmatrix}

Transpose(Scalar) = ERROR
------------------------------
.. math::
    Transpose(0) = ERROR