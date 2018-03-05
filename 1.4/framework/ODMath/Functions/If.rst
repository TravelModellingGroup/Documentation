==============
If
==============

If takes three parameters.  The first is the condition, second the result if true,
and finally the third is the result if the condition is false.  Values greater than zero
are considered true.

.. math::
    A = \begin{bmatrix}
       -1 & 2          \\
       3 & -4
    \end{bmatrix}, \
    B = \begin{bmatrix}
       2 & 4          \\
       6 & 8
    \end{bmatrix}, \
    C = \begin{bmatrix}
       -1 \\
       3
    \end{bmatrix}, \
    D = \begin{bmatrix}
       -1 & 3
    \end{bmatrix}

If(Scalar,Scalar,Scalar) = Scalar
----------------------------------

.. math::
  if(1, 2, 3) = 2

If(Scalar,Matrix,Matrix) = Matrix
----------------------------------

.. math::
  if(1, A, B) = \begin{bmatrix}
       -1 & 2
       3 & -4
    \end{bmatrix}

.. math::
  if(-1, A, B) = \begin{bmatrix}
      2 & 4          \\
      6 & 8
    \end{bmatrix}

If(Scalar,Vector,Vector) = Vector
----------------------------------

The directionality of the resulting vector is the same as the selected vector.

.. math::
  if(1, C, D) = \begin{bmatrix}
      -1 \\
      3
    \end{bmatrix}

.. math::
  if(-1, C, D) = \begin{bmatrix}
      -1 & 3
    \end{bmatrix}


If(Vector,Matrix,Matrix) = Matrix
----------------------------------

.. math::
  if(C > 0, A, B) = \begin{bmatrix}
      2 & 4 \\
      3 & -4
    \end{bmatrix}

.. math::
  if(D > 0, A, B) = \begin{bmatrix}
      2 & 2 \\
      6 & -4
    \end{bmatrix}

If(Vector,Scalar,Scalar) = Vector
----------------------------------

The directionality of the resulting matrix will match the conditional.

.. math::
   if(C > 0, 2, 3) = \begin{bmatrix}
       3 \\
       2
   \end{bmatrix}

.. math::
   if(D > 0, 2, 3) = \begin{bmatrix}
       3 & 2
   \end{bmatrix}

If(Vector,Vector,Vector) = Vector
-----------------------------------

The directionality of the resulting matrix will match the conditional.

.. math::
   if(C > 0, C, D) = \begin{bmatrix}
     -1 \\
     3
   \end{bmatrix}

.. math::
   if(D > 0, C, D) = \begin{bmatrix}
     -1 & 3
   \end{bmatrix}


If(Matrix,Matrix,Matrix) = Matrix
-----------------------------------

.. math::
  if(A > 0, A, B) = \begin{bmatrix}
      2 & 2 \\
      3 & 8
    \end{bmatrix}

If(Matrix,Vector,Vector) = Matrix
-----------------------------------

.. math::
   if(A > 0, C, -1 * C) = \begin{bmatrix}
       1 & -1 \\
       3 & -3
   \end{bmatrix}

.. math::
   if(A > 0, D, -1 * D) = \begin{bmatrix}
       1 & 3 \\
       -1 & -3
   \end{bmatrix}

The directionality of the vectors must be defined and in the same directionality.

.. math::
   if(A > 0, C, D) = ERROR

If(Matrix,Scalar,Scalar) = Matrix
---------------------------------

.. math::
  if(A > 0, 2, -2) = \begin{bmatrix}
      -2 & 2 \\
      2 & -2
  \end{bmatrix}