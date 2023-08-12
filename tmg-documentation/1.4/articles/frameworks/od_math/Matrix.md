# Matrix

Creates a square matrix from a vector.


$$
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

$$

### Matrix(Matrix) = ERROR


$$
Matrix(A) = ERROR

$$

### Matrix(Vector) = Matrix


$$
Matrix(C) = \begin{bmatrix}
    -1 & 3 \\\\
    -1 & 3
\end{bmatrix}

$$


$$
Matrix(D) = \begin{bmatrix}
    -1 & -1 \\\\
    3 & 3
\end{bmatrix}

$$

### Matrix(Scalar) = ERROR


$$
Matrix(0) = ERROR

$$