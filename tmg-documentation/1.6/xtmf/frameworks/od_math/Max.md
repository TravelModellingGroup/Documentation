# Max

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

## Max(Matrix) = Scalar

$$

Max(A) = 3

$$

$$

Max(B) = 8

$$

## Max(Vector) = Scalar

$$

Max(C) = 3

$$

$$

Max(D) = 3

$$

## Max(Scalar) = Scalar

$$

Max(E) = 3.14

$$

## Max(Matrix, Matrix) = Matrix

$$

Max(A, B) = \begin{bmatrix}
    2 & 4 \\\\
    6 & 8
\end{bmatrix}

$$

## Max(Matrix, Vector) = Matrix

$$

Max(A, C) = \begin{bmatrix}
    -1 & 2 \\\\
    3 & 3
\end{bmatrix}

$$

$$

Max(A, D) = \begin{bmatrix}
    -1 & 3 \\\\
    3 & 3
\end{bmatrix}

$$

> [!CAUTION]
> If the vector does not have an orientation an error will be thrown.

## Max(Matrix, Scalar) = Matrix

$$

Max(B, E) = \begin{bmatrix}
    3.14 & 4 \\\\
    6 & 8
\end{bmatrix}

$$

## Max(Vector, Vector) = Vector

$$

Max(C, D) = \begin{bmatrix}
    -1 \\\\
    3
\end{bmatrix}

$$

$$

Max(D, C) = \begin{bmatrix}
    -1 & 3
\end{bmatrix}

$$

> [!NOTE]
> The resulting vector will have the orientation of the first parameter

## Max(Vector, Scalar) = Vector

$$

Max(C, E) = \begin{bmatrix}
    3.14 \\\\
    3.14
\end{bmatrix}

$$

$$

Max(D, E) = \begin{bmatrix}
    3.14 & 3.14
\end{bmatrix}

$$

## Max(Scalar, Scalar) = Scalar

$$

Max(E, 4) = 4

$$
