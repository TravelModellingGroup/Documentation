# Min

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

## Min(Matrix) = Scalar

$$

Min(A) = -4

$$

$$

Min(B) = 2

$$

## Min(Vector) = Scalar

$$

Min(C) = -1

$$

$$

Min(D) = -1

$$

## Min(Scalar) = Scalar

$$

Min(E) = 3.14

$$

## Min(Matrix, Matrix) = Matrix

$$

Min(A, B) = \begin{bmatrix}
    -1 & 2 \\\\
    3 & -4
\end{bmatrix}

$$

## Min(Matrix, Vector) = Matrix

$$

Min(A, C) = \begin{bmatrix}
    -1 & -1 \\\\
    3 & -4
\end{bmatrix}

$$

$$

Min(A, D) = \begin{bmatrix}
    -1 & 2 \\\\
    -1 & -4
\end{bmatrix}

$$

> [!CAUTION]
> If the vector does not have an orientation an error will be thrown.

## Min(Matrix, Scalar) = Matrix

$$

Min(B, E) = \begin{bmatrix}
    2 & 3.14 \\\\
    3.14 & 3.14
\end{bmatrix}

$$

## Min(Vector, Vector) = Vector

$$

Min(C, D) = \begin{bmatrix}
    -1 \\\\
    3
\end{bmatrix}

$$

$$

Min(D, C) = \begin{bmatrix}
    -1 & 3
\end{bmatrix}

$$

> [!NOTE]
> The resulting vector will have the orientation of the first parameter

## Min(Vector, Scalar) = Vector

$$

Min(C, E) = \begin{bmatrix}
    -1 \\\\
    3
\end{bmatrix}

$$

$$

Min(D, E) = \begin{bmatrix}
    -1 & 3
\end{bmatrix}

$$

## Min(Scalar, Scalar) = Scalar

$$

Min(E, 4) = 3.14

$$
