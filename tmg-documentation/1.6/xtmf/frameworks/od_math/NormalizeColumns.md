# Normalize Columns

Takes the passed in matrix and normalizes each column.  
If the sum of a column is 0, all elements will be zero.

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

### NormalizeColumns(Matrix) = ERROR

\begin{equation}
Matrix(A) = \begin{bmatrix}
	-0.333 & 0.25 \\\\
    1.333 & 0.75
\end{bmatrix}
\end{equation}

### NormalizeColumns(Vector) = ERROR

\begin{equation}
NormalizeRows(C) = ERROR
\end{equation}

\begin{equation}
NormalizeRows(D) = ERROR
\end{equation}

### NormalizeColumns(Scalar) = ERROR

\begin{equation}
NormalizeRows(0) = ERROR
\end{equation}