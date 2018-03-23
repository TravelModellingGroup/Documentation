# SumColumns

Returns a vector of the summation of the matrix columns

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

### SumColumns(Matrix) = Vector

\begin{equation}
SumColumns(A) = \begin{bmatrix}
    2 & -2
\end{bmatrix}
\end{equation}

\begin{equation}
SumColumns(B) = \begin{bmatrix}
    8 & 12
\end{bmatrix}
\end{equation}

### SumColumns(Vector) = ERROR

\begin{equation}
SumColumns(C) = ERROR
\end{equation}

### SumColumns(Scalar) = ERROR

\begin{equation}
SumColumns(0) = ERROR
\end{equation}