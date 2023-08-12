# AsHorizontal

Assigns a horizontal directionality to a vector.  A vector starts off as 'unassigned'.  In order to
use the vector with matrices it is usually necessary to assign it to be either vertical or horizontal.


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

### AsHorizontal(Scalar) = ERROR


$$
 AsHorizontal(1) = ERROR

$$


> [!CAUTION]
> If executed with a scalar it will throw an exception.


### AsHorizontal(Vector) = Vector

When operating on a vector it will force it to be horizontal.


$$
AsHorizontal(C) = \begin{bmatrix}
   -1 & 3
\end{bmatrix}

$$

Applying AsHorizontal to a vector that is already horizontal is allowed.


$$
AsHorizontal(D) = \begin{bmatrix}
   -1 & 3 
\end{bmatrix}

$$

### AsHorizontal(Matrix) = ERROR


$$
AsHorizontal(A) = ERROR

$$

> [!CAUTION]
> If executed with a matrix it will throw an exception.
