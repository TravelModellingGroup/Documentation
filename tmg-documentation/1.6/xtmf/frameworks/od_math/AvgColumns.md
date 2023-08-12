# AvgColumns


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

### AvgColumns(Scalar) = ERROR


$$
Avg(-1) = ERROR

$$

> [!CAUTION]
> If executed with a scalar it will throw an exception.

### AvgColumns(Vector) = ERROR


$$
Avg(C) = ERROR

$$

> [!CAUTION]
> If executed with a vector it will throw an exception.

### AvgColumns(Matrix) = Vector


$$
AvgColumns(A) = \begin{bmatrix}
    1 & -1
\end{bmatrix}

$$


$$
AvgColumns(B) = \begin{bmatrix}
    4 & 6
\end{bmatrix}

$$