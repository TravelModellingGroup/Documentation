==============
Log
==============
Performs the natural logarithm on the input parameter.

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

Log(Matrix) = Matrix
----------------------------

.. math::
    Log(A) = \begin{bmatrix}
        NaN & 0.6931472 \\
        1.09861231 & NaN
    \end{bmatrix}

.. math::
    Log(B) = \begin{bmatrix}
        0.6931472 &  1.38629436\\
        1.79175949 & 2.07944155
    \end{bmatrix}

Log(Vector) = Vector
-----------------------------

.. math::
    Log(C) = \begin{bmatrix}
       NaN \\
       1.09861231
    \end{bmatrix}

.. math::
    Log(D) = \begin{bmatrix}
       NaN & 1.09861231
    \end{bmatrix}

Log(Scalar) = Scalar
-----------------------------

.. math::
    Log(1) = 0