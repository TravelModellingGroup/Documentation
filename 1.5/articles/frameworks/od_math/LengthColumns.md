# LengthColumns

Returns the number of cells for each column in the given Matrix.

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
\end{bmatrix}
\end{equation}

### LengthColumns(Matrix) = Vector

\begin{equation}
LengthColumns(A) = \begin{bmatrix}
    2 & 2
\end{bmatrix}
\end{equation}

\begin{equation}
LengthColumns(B) = \begin{bmatrix}
    2 & 2
\end{bmatrix}
\end{equation}

### LengthColumns(Vector) = ERRROR

\begin{equation}
LengthColumns(C) = ERROR
\end{equation}

### LengthColumns(Scalar) = ERROR

\begin{equation}
LengthColumns(0) = ERROR
\end{equation}