# Normalize

Takes the passed in matrix and normalizes cell by the matrix's total.
If the matrix is 0, all elements will be zero.


$$
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

$$

### Normalize(Matrix) = ERROR


$$
Matrix(A) = \begin{bmatrix}
    -0.0909 & 0.1818 \\\\
    0.3636 & 0.5454
\end{bmatrix}

$$

### Normalize(Vector) = ERROR


$$
NormalizeRows(C) = ERROR

$$


$$
NormalizeRows(D) = ERROR

$$

### Normalize(Scalar) = ERROR


$$
NormalizeRows(0) = ERROR

$$