# Min Rows

`XTMF 1.13+`

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
\end{bmatrix},

E = 3.14

$$

## MinRows(Matrix) = Vector

$$ 

MinRows(A) = \begin{bmatrix}
    -1 \\\\
    -4
\end{bmatrix}

$$

## MinRows(Vector) = ERROR

$$
MinRows(C) = ERROR
$$

> [!CAUTION]
> If executed with a vector it will throw an exception.

## MinRows(Scalar) = ERROR

$$
MinRows(E) = ERROR
$$

> [!CAUTION]
> If executed with a scalar it will throw an exception.
