# Matrix

Creates a square matrix from a vector.

\begin{equation}
A = \begin{bmatrix}
    -1 & 2          \\\\
    3 & -4
\end{bmatrix}, 
    C = \begin{bmatrix}
    -1 \\\\
    3
\end{bmatrix}, 
D = \begin{bmatrix}
    -1 & 3
\end{bmatrix}
\end{equation}

### Matrix(Matrix) = ERROR

\begin{equation}
Matrix(A) = ERROR
\end{equation}

### Matrix(Vector) = Matrix

\begin{equation}
Matrix(C) = \begin{bmatrix}
    -1 & -1 \\\\
    3 & 3
\end{bmatrix}
\end{equation}

\begin{equation}
Matrix(D) = \begin{bmatrix}
    -1 & 3 \\\\
    -1 & 3
\end{bmatrix}
\end{equation}

### Matrix(Scalar) = ERROR

\begin{equation}
Matrix(0) = ERROR
\end{equation}