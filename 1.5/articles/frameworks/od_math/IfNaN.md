# IfNaN

The first parameter is the regular value, the second is the value to use if the regular value is NaN (not a number).

\begin{equation}
A = \begin{bmatrix}
  0 & 2          \\\\
  4 & -4
\end{bmatrix}, 
B = \begin{bmatrix}
  2 & 4          \\\\
  6 & 8
\end{bmatrix}, 
C = \begin{bmatrix}
  0 \\\\
  4
\end{bmatrix}, 
D = \begin{bmatrix}
  0 & 4
\end{bmatrix}
\end{equation}

### IfNaN(Matrix, Matrix) = Matrix

\begin{equation}
IfNaN(100 / A, B) = \begin{bmatrix}
  2 & 50 \\\\
  25 & -25
\end{bmatrix}
\end{equation}

### IfNaN(Vector,Vector) = Vector

\begin{equation}
ifNaN(100 / C, C) = \begin{bmatrix}
  0 \\\\ 
  25
\end{bmatrix}
\end{equation}

\begin{equation}
ifNaN(100 / D, D) = \begin{bmatrix}
  0 & 25
\end{bmatrix}
\end{equation}

### IfNaN(Scalar, Scalar) = Scalar

\begin{equation}
IfNaN(0 / 0, 1) = 1
\end{equation}
