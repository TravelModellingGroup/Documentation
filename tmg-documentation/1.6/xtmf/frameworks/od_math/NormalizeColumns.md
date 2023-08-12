# Normalize Columns

Takes the passed in matrix and normalizes each column.  
If the sum of a column is 0, all elements will be zero.


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

### NormalizeColumns(Matrix) = ERROR


$$
Matrix(A) = \begin{bmatrix}
	-0.333 & 0.25 \\\\
    1.333 & 0.75
\end{bmatrix}

$$

### NormalizeColumns(Vector) = ERROR


$$
NormalizeRows(C) = ERROR

$$


$$
NormalizeRows(D) = ERROR

$$

### NormalizeColumns(Scalar) = ERROR


$$
NormalizeRows(0) = ERROR

$$