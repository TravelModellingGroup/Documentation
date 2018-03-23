# IdentityMatrix

\begin{equation}
A = \begin{bmatrix}
    -1 & 2          \\\\
    3 & -4
\end{bmatrix}, 
B = \begin{bmatrix}
    2 & 4          \\\\
    6 & 8
\end{bmatrix}, 
C = \begin{bmatrix}
    -1 \\\\
    3
\end{bmatrix}, 
D = \begin{bmatrix}
    -1 & 3
\end{bmatrix}
\end{equation}

### IdentityMatrix(Scalar) = ERROR

\begin{equation}
IdentityMatrix(-1) = ERROR
\end{equation}

### IdentityMatrix(Vector) = Matrix

The orientation of the vector will be maintained in the resulting vector.

\begin{equation}
IdentityMatrix(C) = \begin{bmatrix}
    1 & 0 \\\\
    0 & 1
\end{bmatrix}
\end{equation}

### IdentityMatrix(Matrix) = Matrix

\begin{equation}
IdentityMatrix(A) = \begin{bmatrix}
    1 & 0 \\\\
    0 & 1
\end{bmatrix}
\end{equation}
