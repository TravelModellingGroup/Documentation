# LengthRows

Returns the number of cells for each row in the given Matrix.

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

### LengthRows(Matrix) = Vector

\begin{equation}
LengthRows(A) = \begin{bmatrix}
    2 \\\\
    2
\end{bmatrix}
\end{equation}

\begin{equation}
LengthRows(B) = \begin{bmatrix}
    2 \\\\
    2
\end{bmatrix}
\end{equation}

### LengthRows(Vector) = ERROR

\begin{equation}
LengthRows(C) = ERROR
\end{equation}

### LengthRows(Scalar) = ERROR

\begin{equation}
LengthRows(0) = ERROR
\end{equation}
