# Basic Python

In this step we will do a quick overview of some of the most common
operations in python.

## 1. Import six

Before we really get started, we will import a library named six.  This library
will include a bunch of functions into Python2 instances allowing us to
write code that will work in both Python 2 and Python 3.

```python
import six
```

## 2. Hello World

The first program anyone writes in a new language is `Hello World`.  This program
writes to the console the text "Hello, World!".

Code:
```python
print("Hello, World!")
```

Output:
```console
Hello, World!
```

## 3. Comment Codes

When programming it is important to not just write what you want the computer
to do, but also leave artifacts for future programmers, often yourself, to
help the reader understand why you wrote the code you did. We call these
artifacts interlaced in our code "comments".

```python
# This is an example of a comment
```

## 4. Declaring a Variable

Code:
```python
x = 1
print(x)
```

Output:
```console
1
```

## 5. Basic Arithmetic

Now that we know how to create a variable our next step is learning how to manipulate them.
In Python when we use the equals sign it does not mean equality but assign.  This will be exemplified
below

Code:
```python
x = 1
print(x)
# Add two to x and assign it to x
x = x + 2
print(x)
# Subtract one from x  and assign it to x
x = x - 1
print(x)
# Divide 2 from x and assign it to x
x = x / 2
print(x)
# Multiply four and x and assign it to x
x = x * 4
print(x)
```

Output:
```console
1
3
2
1.0
4.0
```
> [!NOTE]
> If you are using Python 2 you might notice that your outputs do not have a decimal place.  In this version of
> Python the division operator performs "integer division", rounding down to the nearest integer number. In Python
> 3 that type of operation has been moved to the operator `//`.  To get floating point division in Python 2 you can
> add a decimal place to a constant if you are using one or cast, which we will show later, a number to the type
> `float`.

## 6. Comparisons

Besides arithmetic one of the most common things that you will do will be to compare values.  Python supports the
following comparison operators:
* `==` - Equality
* `>` - Greater Than
* `>=` - Greater Than or Equal
* `<` - Less Than
* `<=` - Less Thank or Equal To
* `and` - True if both sides resolve to `True`
* `or` - True if either side resolves to `True`

Code:
```python
print(1 < 2)
print((1 < 2) and (2 < 1))
print((1 <= 2) and (2 <= 1))
print((1 < 2) or (2 < 1))
```

Output:
```console
True
False
True
True
```

## 7. IF / Elif / Else

As we start to write more advanced code we will run into cases where what we
need to execute depends on the value of a variable.  To do this in Python
we can use an `if` statement.  The `if` statement is composed of an
if clause followed by optional `elif`s and finally a single optional `else` clause.

The `if` and `elif` clauses follow this format:

```python
if <condition>:
    # Code that only executes if the condition is True here
    pass
```

In the folling code we will compare against a variable `x` and only print out
if x is less than 1, exactly one, or greater than one.  You can modify `x` to
see that one one of the branches is taken and then execution resumes once
we have moved back our tabbing.

Code:
```python
x = 1
if x < 1:
    print("x is less than one")
elif x == 1:
    print("x is exactly one")
else:
    print("x is greater than one")
print("After if")
```

Output:
```console
x is exactly one
After if
```

## 8. For Loops

Often we want to execute the same code multiple times, we call this iteration.
One of the most common ways to iterate is to use a `for` loop.

The code below will iterate over the values 0 to, and including, 4 and print them out to console.
This is done using a function called range.  This function will generate values in the range
[0, N) where N is the value passed into the function, in our case 5.

Code:
```python
for x in range(5):
  print(x)
```

Output:
```console
0
1
2
3
4
```

## 9. While Loop

There is another type of loop called a `while` loop.  This loop continues to
iterate as long as the condition is true.  In our example below it iterates until x is
5.

```python
x = 0
while x < 5:
    print(x)
    x += 1
```

Output:
```console
0
1
2
3
4
```

## 10. List

One of the simplest data structures in Python is a list. Below is an
example of one that contain the numbers 1 to 5.

Code:
```python
x = [1,2,3,4,5]
print(x)
```

Output:
```console
[1, 2, 3, 4, 5]
```

Lists are a useful tool when we need to store more than one thing together in a group.
You can also do useful things such as `append` new items to the end of a list, or combine
two lists together.

Code:
```python
x = [1,2,3,4,5]
# Add 6 to the end of the list
x.append(6)
print(x)
y = [7, 8]
# Combine the two lists
x = x + y
print(x)
```

Output:
```console
[1, 2, 3, 4, 5, 6]
[1, 2, 3, 4, 5, 6, 7, 8]
```

## 11. Dictionary

The other most common data structure in Python is a dictionary.  A dictionary provides a mapping
between a key to a single value.  Below is an example of a dictionary that has some numeric keys
that are mapped to some example strings containing names.

```python
x = {
    1 : "Williams",
    2 : "Amit",
    3 : "Eric"
}
```

We can can add an additional name to that dictionary using the following code:

```python
x[4] = "James"
print(x)
```

Output:
```console
{1: 'Williams', 2: 'Amit', 3: 'Eric', 4: 'James'}
```

## 12. Functions

The code that we have explored so far have been linear, running from the top, possibly iterating, and then eventually
stopping at the bottom.  What we are going to write next allows us to execute the same code from potentially different places.

In the following code we will write a function called `print_added` that takes in two parameters named `x` and `y`.  We will
then call this function with the values of `a` and `b`, then iterate another variable `x`, which is not the same as the `x` inside
of our function, with the values of [0,3).
```python
def print_added(x, y):
    temp = x + y
    print(temp)

a = 1
b = 2
print_added(a, b)
for x in range(3):
    print_added(a, x)
```

```output
3
1
2
3
```

## Next Steps

While this is far from a complete course on how to write in Python, you now have been introduced to enough of the language to start
writing your own scripts to automate EMME.  The next step in the tutorial is a review of the [EMME Class Structures](EMMEClassStructure.md).
This will teach you how different EMME concepts are related.  If you already have a firm grasp on how EMME is organized you can instead
skip ahead to [Writing A Script](WritingAScript.md) where we will walk through writing a script that moves an EMME network.