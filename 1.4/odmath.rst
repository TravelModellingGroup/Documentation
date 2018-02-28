.. _ODMath:

Data Processing with ODMath
###########################################################

Basic Arithmetic
--------------------------------------------------------------------------
For example, define two matrices A and B.


.. math::

    A = \begin{bmatrix}
       1 & 2          \\
       3 & 4
    \end{bmatrix}   \
    , B = \begin{bmatrix}
       2 & 4          \\
       6 & 8
    \end{bmatrix}

If we used the expression string ‘2 * A + B’ we would get the following.

.. math::

    2 \times A + B = \begin{bmatrix}
       4 & 8          \\
       12 & 16
    \end{bmatrix}

You can also use brackets to change the order of operations.

.. math::

    2 \times (A + B) = \begin{bmatrix}
       6 & 12          \\
       18 & 24
    \end{bmatrix}

Division can also be performed using ‘B / A’.

.. math::

    B / A = \begin{bmatrix}
       2 & 2          \\
       2 & 2
    \end{bmatrix}

Multiplication ‘A * B’ would result in:

.. math::

    A \times B = \begin{bmatrix}
       2 & 8          \\
       18 & 32
    \end{bmatrix}

Powers ‘A ^ B’ would result in:

.. math::

    A ^ B &= \begin{bmatrix}
       1 & 16          \\
       729 & 65536
    \end{bmatrix}

Vectors
--------------------------------------------------------------------------
Vectors can also be used in arithmetic.  In the following we define C as a Vertical matrix, and D is a Horizontal matrix.  If a matrix is loaded from a data source it will not have a directionality and must be given one before being used with matrices.

.. math::


    C =
    \begin{bmatrix}
       1 \\
       3
    \end{bmatrix} \
     , D =
     \begin{bmatrix}
       1 \\
       3
    \end{bmatrix}

The following is the difference between the basic arithmetic with vertical and horizontal vectors applied to A:

Functions
--------------------------------------------------------------------------
There are a number of built-in functions to help facilitate more complicated calculations.  A function call is structured as ‘functionName(parameter1,parameter2,…,parameter)’.  In the table below we can see a quick reference of all of the functions, their input types, and output times.

==============            ====================           =====================
Function Name             Parameter Type                   Output Type
==============            ====================           =====================
Abs                       Matrix                          Matrix
Abs                       Scalar                          Scalar
Abs                       Vector                          Vector
Avg                       Vector                          Scalar
Avg                       Matrix                          Scalar
AvgColumns                Matrix                          Vector (Vertical)
AvgRows                   Matrix                          Vector (Horizontal)
AsHorizontal              Vector                          Vector (Horizontal)
AsVertical                Vector                          Vector (Vertical)
E                         <None>                          Scalar
IdentityMatrix            Matrix                          Matrix
IdentityMatrix            Vector                          Matrix
If                        Scalar,Scalar,Scalar            Scalar
If                        Scalar,Matrix,Matrix            Matrix
If                        Scalar,Vector,Vector            Vector
If                        Vector,Scalar,Scalar            Vector
If                        Vector,Matrix,Matrix            Matrix
If                        Vector,Vector,Vector            Vector
If                        Matrix,Matrix,Matrix            Matrix
IfNaN                     Scalar,Scalar                   Scalar
IfNaN                     Vector,Vector                   Vector
IfNaN                     Matrix,Matrix                   Matrix
Length                    Matrix                          Scalar
Length                    Vector                          Scalar
LengthColumns             Matrix                          Vector
LengthRows                Matrix                          Vector
Log                       Scalar                          Scalar
Log                       Vector                          Vector
Log                       Matrix                          Matrix
Matrix                    Vector                          Matrix
Pi                        <None>                          Scalar
Sum                       Vector                          Scalar
Sum                       Matrix                          Scalar
SumColumns                Matrix                          Vector (Horizontal)
SumRows                   Vector                          Vector (Vertical)
Tranpose                  Matrix                          Matrix
Tranpose                  Vector                          Vector
ZeroMatrix                Matrix                          Matrix
ZeroMatrix                Vector                          Matrix
==============            ====================           =====================
