# Transpose

Swaps each OD pair so that [i,j] becomes the previous [j,i].

$$
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
$$

### Transpose(Matrix) = Matrix

$$
Transpose(A) = \begin{bmatrix}
    -1 & 3 \\\\
    -2 & -4
\end{bmatrix}
$$
$$
Transpose(B) = \begin{bmatrix}
    2 & 6 \\\\
    4 & 8
\end{bmatrix}
$$

### Transpose(Vector) = Vector

$$
Transpose(C) = \begin{bmatrix}
    -1 & 3
\end{bmatrix}
$$
$$
Transpose(D) = \begin{bmatrix}
    -1 \\
    3
\end{bmatrix}
$$

### Transpose(Scalar) = ERROR

$$
Transpose(0) = ERROR
$$