# AvgColumns

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

### AvgColumns(Scalar) = ERROR

\begin{equation}
Avg(-1) = ERROR
\end{equation}

> [!CAUTION]
> If executed with a scalar it will throw an exception.

### AvgColumns(Vector) = ERROR

\begin{equation}
Avg(C) = ERROR
\end{equation}

> [!CAUTION]
> If executed with a vector it will throw an exception.

### AvgColumns(Matrix) = Vector

\begin{equation}
AvgColumns(A) = \begin{bmatrix}
    1 & -1
\end{bmatrix}
\end{equation}

\begin{equation}
AvgColumns(B) = \begin{bmatrix}
    4 & 6
\end{bmatrix}
\end{equation}