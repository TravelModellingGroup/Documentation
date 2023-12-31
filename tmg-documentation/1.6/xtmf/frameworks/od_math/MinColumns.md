# Min Columns

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


## MinColumns(Matrix) = Vector

$$ 

MinColumns(A) = \begin{bmatrix}
    -1 & -4
\end{bmatrix}

$$

## MinColumns(Vector) = ERROR

$$
MinColumns(C) = ERROR
$$

> [!CAUTION]
> If executed with a vector it will throw an exception.

## MinColumns(Scalar) = ERROR

$$
MinColumns(E) = ERROR
$$

> [!CAUTION]
> If executed with a scalar it will throw an exception.
