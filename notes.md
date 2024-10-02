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

## Ch. 2 Array Algorithms

Searching for a value in an array

```C#
int[] myArray = {1, 2, 3, 4, 5, 6};

int evenNum = Array.Find(myArray, (n) => n % 2 == 0); // returns the first match
int[] evenNums = Array.FindAll(myArray, (n) => n % 2 == 0);
```

`Array` has a `ForEach` method that takes in a function to call, which is convenient: 

```C#
Array.ForEach(someArray, Console.WriteLine);
```

Binear Search

* Assumption: the data structure is sorted 
* Searchs runs in O(log(n)) time

Linear Search

* Assumption: none
* Searchs run in O(n) time

### Binary Search

Using the built-in binary search method for arrays:

```C#
int[] arr = {0, 0, 5, 0, 0};

Array.Sort(arr);

Console.WriteLine(Array.BinarySearch(arr, 5));
// Prints 4, the index of 5 in the sorted array
```

### Sorting and Filtering

Filtering an array based on some predicate:

```C#
int[] someArray = {...};
List<int> evens = new List<int>(someArray);

someArray = evens.Where(i => i % 2 == 0).ToArray();
```

Sorting an array based on some predicate: 

```C#
int[] someArray = {...};

Array.Sort(someArray); // sorts in-place, based on default rules
Array.Sort(someArray, (x, y) => y.CompareTo(x)); // sorts in-place, in reverse order of default
```

## Ch. 3 Linked List Algorithms

You can CTRL+Click/Cmd+Click on a .NET class and it opens up the cached .cs file of that class in VS Code!

One really cool technique for improving the efficiency of traversing a linked list in an algorithm is the technique of creating multiple points that traverse the list at different speeds. Example:

```C#
public void DeleteBackHalf () 
{
    Node slow = head, fast = head;

    while (fast != null && fast.next != null) 
    {
        fast = fast.next.next;
        slow = slow.next;
    }

    slow.next = null;
}
```

## Ch. 4 Queue and Stack Algorithms

`Queue` lives in `System.Collections.Generic`.

Note: calling `Peek()` on an empty queue throws an `InvalidOperationException`. Solution: 

```C#
bool hasNext = someQueue.TryDequeue(out someInt);  // Assuming type Queue<int>
```

`TryDequeue` works well with while loops:

```C#
int val;  // Assuming type Queue<int>
while (someQueue.TryDequeue(out val))  
{
    Console.WriteLine(val);
}
```

`Stack` lives in `System.Collections.Generic`.

Similar to queues, calling `Peek()` on an empty stack raises an exception. Solution: 

```C#
int val;  // Assuming type Stack<int>
bool hasNext = someStack.TryPeek(out val);
```

## Ch. 5 Algorithms for Hash-Based Structures 

`HashSet` - a unordered collection of unique items. Ex: A set of Order Confirmation codes that have been used already. 

`Dictionary` - a key-value store that uses generics. Throws an error if you try to access a key that isn't present. Maintains the "stored" order of the entries.

`HashTable` - a key-value store that, unlike `Dictionary`, does _not_ use generics. Returns `null` if you try to access a key that isn't present. Does _not_ maintain entries in "stored" order.
