# Normalize Rows

Takes the passed in matrix and normalizes each row.  If the sum of a row is 0, all elements will be zero.

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

### NormalizeRows(Matrix) = ERROR

\begin{equation}
Matrix(A) = \begin{bmatrix}
	-1 & 2 \\\\
    0.4 & 0.6
\end{bmatrix}
\end{equation}

### NormalizeRows(Vector) = ERROR

\begin{equation}
NormalizeRows(C) = ERROR
\end{equation}

\begin{equation}
NormalizeRows(D) = ERROR
\end{equation}

### NormalizeRows(Scalar) = ERROR

\begin{equation}
NormalizeRows(0) = ERROR
\end{equation}