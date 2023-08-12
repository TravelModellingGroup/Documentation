# Sqrt

Performs Square Root on the input parameter. `XTMF 1.8+`


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

### Sqrt(Matrix) = Matrix


$$
Sqrt(A) = \begin{bmatrix}
    NaN & 1.4142136 \\\\
    1.732051 & NaN
\end{bmatrix}

$$


$$
Sqrt(B) = \begin{bmatrix}
    1.4142136 &  2\\\\
    2.4494897 & 2.8284271
\end{bmatrix}

$$

### Sqrt(Vector) = Vector


$$
Sqrt(C) = \begin{bmatrix}
    NaN \\\\
    1.732051
\end{bmatrix}

$$


$$
Sqrt(D) = \begin{bmatrix}
    NaN & 1.732051
\end{bmatrix}

$$

### Sqrt(Scalar) = Scalar


$$
Sqrt(1) = 1

$$