# AvgRows

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

### AvgRows(Scalar) = ERROR

\begin{equation}
AvgRows(-1) = ERROR
\end{equation}

> [!CAUTION]
> If executed with a scalar it will throw an exception.

### AvgRows(Vector) = ERROR

\begin{equation}
AvgRows(C) = ERROR
\end{equation}

> [!CAUTION]
> If executed with a vector it will throw an exception.

### AvgRows(Matrix) = Vector

\begin{equation}
AvgRows(A) = \begin{bmatrix}
    1 \\\\
    -1
\end{bmatrix}
\end{equation}

\begin{equation}
AvgRows(B) = \begin{bmatrix}
    3 \\\\
    7
\end{bmatrix}
\end{equation}
