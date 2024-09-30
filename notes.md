# Notes

## Introduction

**Time Complexities**

* O(1) - constant time
* O(log(n)) - logarithmic time
* O(n) - linear time
* O(n<sup>2</sup>) - exponent time
* O(n!) - factorial time

## Ch. 1 String Algorithms

`char` has some useful methods that become helpful when using `System.Linq` to search through strings.
* `IsUpper`
* `IsLower`
* `IsDigit`
* `IsLetter`
* `IsNumber`

Examples:

```C#
bool hasCapital = someString.Any(char.IsUpper); // check if a char in string is uppercase
bool hasNumber = someString.Any(char.IsNumber);

bool allCapital = someString.All(char.IsUpper); // checks if all chars in string are uppercase
bool allNumbers = someString.All(char.IsNumber);
```

Useful built-in methods

* `String.IsNullOrEmpty`
* `String.ToCharArray`
*  `Array.Reverse`

Using Linq to call a function for each item in an array:

```C#
int[] n1 = {1, 2, 3, 4};

int[] n2 = n1.Select(n => n + 6).ToArray();
// n2 contains {7, 8, 9, 10}
```
