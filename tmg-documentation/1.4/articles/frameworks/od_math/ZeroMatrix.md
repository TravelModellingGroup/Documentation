# ZeroMatrix

Creates a zero matrix from a vector or matrix.

A = \begin{bmatrix}
    -1 & 2          \\\\
    3 & -4
\end{bmatrix}, 
B = \begin{bmatrix}
    2 & 4          \\\\
    6 & 8
\end{bmatrix},, 
    C = \begin{bmatrix}
    -1 \\\\
    3
\end{bmatrix}, 
D = \begin{bmatrix}
    -1 & 3
\end{bmatrix}

### ZeroMatrix(Matrix) = Matrix

ZeroMatrix(A) = \begin{bmatrix}
    0 & 0          \\\\
    0 & 0
\end{bmatrix}

ZeroMatrix(B) = \begin{bmatrix}
    0 & 0          \\\\
    0 & 0
\end{bmatrix}

### ZeroMatrix(Vector) = Matrix

ZeroMatrix(C) = \begin{bmatrix}
    0 & 0 \\\\
    0 & 0
\end{bmatrix}

ZeroMatrix(D) = \begin{bmatrix}
    0 & 0 \\\\
    0 & 0
\end{bmatrix}

### ZeroMatrix(Scalar) = ERROR

ZeroMatrix(0) = ERROR
