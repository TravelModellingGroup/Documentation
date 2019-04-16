# Normalize

Takes the passed in matrix and normalizes cell by the matrix's total.
If the matrix is 0, all elements will be zero.

\begin{equation}
A = \begin{bmatrix}
    -1 & 2          \\\\
    4 & 6
\end{bmatrix}, 
    C = \begin{bmatrix}
    -1 \\\\
    3
\end{bmatrix}, 
D = \begin{bmatrix}
    -1 & 3
\end{bmatrix}
\end{equation}

### Normalize(Matrix) = ERROR

\begin{equation}
Matrix(A) = \begin{bmatrix}
    -0.0909 & 0.1818 \\\\
    0.3636 & 0.5454
\end{bmatrix}
\end{equation}

### Normalize(Vector) = ERROR

\begin{equation}
NormalizeRows(C) = ERROR
\end{equation}

\begin{equation}
NormalizeRows(D) = ERROR
\end{equation}

### Normalize(Scalar) = ERROR

\begin{equation}
NormalizeRows(0) = ERROR
\end{equation}