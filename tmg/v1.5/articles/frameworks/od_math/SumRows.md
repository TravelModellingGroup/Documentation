# SumRows

Returns a vector of the summation of the matrix rows

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

### SumRows(Matrix) = Vector

\begin{equation}
SumRows(A) = \begin{bmatrix}
     1 \\\\
    -1
\end{bmatrix}
\end{equation}

\begin{equation}
SumRows(B) = \begin{bmatrix}
    6 \\\\
    14
\end{bmatrix}
\end{equation}

### SumRows(Vector) = ERROR

\begin{equation}
SumRows(C) = ERROR
\end{equation}

### SumRows(Scalar) = ERROR
\begin{equation}
SumRows(0) = ERROR
\end{equation}
