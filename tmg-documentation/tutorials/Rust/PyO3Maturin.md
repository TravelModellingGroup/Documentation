# PyO3 Maturin 


## link to Library
https://github.com/PyO3/pyo3


### Installation and Setup 

```
# (replace string_sum with the desired package name)
$ mkdir string_sum
$ cd string_sum
$ python -m venv .env
$ source .env/bin/activate
$ pip install maturin


Still inside this string_sum directory, now run maturin init. This will generate the new package source. When given the choice of bindings to use, select pyo3 bindings:

$ maturin init
What kind of bindings to use? · pyo3
Done! New project created string_sum

```
```
$ maturin develop
# lots of progress output as maturin runs the compilation...
$ python
>>> import string_sum
>>> string_sum.sum_as_string(5, 20)
'25'
```