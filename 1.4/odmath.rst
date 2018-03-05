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
    .. math::
    
      A + C =
      \begin{bmatrix}
        2 & 3 \\
        6 & 7
      \end{bmatrix}

    .. math::
      A + D =
      \begin{bmatrix}
        1 & 2 \\
        1 & 0.75
      \end{bmatrix}

Comparisons
--------------------------------------------------------------------------
For certain functions comparisons are required.  If a comparison is true, a 1 is the result otherwise 0.
The comparison operators are <, >, <=, >=, == (equal), != (not equal), | (or), and & (and).

  .. math::
    A = \begin{bmatrix}
       1 & 2          \\
       3 & 4
    \end{bmatrix}   \
    , F = 
    \begin{bmatrix}
      4 & 3 \\
      2 & 1
    \end{bmatrix}
  .. math::
    A < F =
    \begin{bmatrix}
      1 & 1 \\
      0 & 0
    \end{bmatrix}

Functions
--------------------------------------------------------------------------
There are a number of built-in functions to help facilitate more complicated calculations.  A function call is structured as ‘functionName(parameter1,parameter2,…,parameter)’.  In the table below we can see a quick reference of all of the functions, their input types, and output times.

.. toctree::
   framework/ODMath/Functions/Abs
   framework/ODMath/Functions/AsHorizontal
   framework/ODMath/Functions/AsVertical
   framework/ODMath/Functions/Avg
   framework/ODMath/Functions/AvgColumns
   framework/ODMath/Functions/AvgRows
   framework/ODMath/Functions/E
   framework/ODMath/Functions/IdentityMatrix
   framework/ODMath/Functions/If
   framework/ODMath/Functions/IfNaN
   framework/ODMath/Functions/Length
   framework/ODMath/Functions/LengthColumns
   framework/ODMath/Functions/LengthRows
   framework/ODMath/Functions/Log
   framework/ODMath/Functions/Matrix
   framework/ODMath/Functions/Pi
   framework/ODMath/Functions/Sum
   framework/ODMath/Functions/SumColumns
   framework/ODMath/Functions/SumRows
   framework/ODMath/Functions/Transpose
   framework/ODMath/Functions/ZeroMatrix

=================================================================== =====================           ====================
Function Name                                                       Parameter Type                  Output Type
=================================================================== =====================           ====================
:doc:`Log<framework/ODMath/Functions/Log>`                          Scalar                          Scalar
:doc:`Log<framework/ODMath/Functions/Log>`                          Vector                          Vector
:doc:`Log<framework/ODMath/Functions/Log>`                          Matrix                          Matrix
:doc:`Matrix<framework/ODMath/Functions/Matrix>`                    Vector                          Matrix
:doc:`Pi<framework/ODMath/Functions/Pi>`                            <None>                          Scalar
:doc:`Sum<framework/ODMath/Functions/Sum>`                          Vector                          Scalar
:doc:`Sum<framework/ODMath/Functions/Sum>`                          Matrix                          Scalar
:doc:`SumColumns<framework/ODMath/Functions/SumColumns>`            Matrix                          Vector (Horizontal)
:doc:`SumRows<framework/ODMath/Functions/SumRows>`                  Vector                          Vector (Vertical)
:doc:`Transpose<framework/ODMath/Functions/Transpose>`              Matrix                          Matrix
:doc:`Transpose<framework/ODMath/Functions/Transpose>`              Vector                          Vector
:doc:`ZeroMatrix<framework/ODMath/Functions/ZeroMatrix>`            Matrix                          Matrix
:doc:`ZeroMatrix<framework/ODMath/Functions/ZeroMatrix>`            Vector                          Matrix
=================================================================== =====================           ====================
