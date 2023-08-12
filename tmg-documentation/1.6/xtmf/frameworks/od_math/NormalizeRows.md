# Normalize Rows

Takes the passed in matrix and normalizes each row.  If the sum of a row is 0, all elements will be zero.


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

### NormalizeRows(Matrix) = ERROR


$$
Matrix(A) = \begin{bmatrix}
	-1 & 2 \\\\
    0.4 & 0.6
\end{bmatrix}

$$

### NormalizeRows(Vector) = ERROR


$$
NormalizeRows(C) = ERROR

$$


$$
NormalizeRows(D) = ERROR

$$

### NormalizeRows(Scalar) = ERROR


$$
NormalizeRows(0) = ERROR

$$