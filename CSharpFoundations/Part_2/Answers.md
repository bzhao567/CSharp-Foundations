# Part 2: Arrays and Strings

### Test Your Knowledge

1. When to use String vs. StringBuilder in C# ?
* String should be used for immutable, one-time operations.
* StringBuilder should be used when building or modifying a string repeatedly, to avoid creating too many intermediate strings.
2. What is the base class for all arrays in C#?
* The base class for all arrays is System.array.
3. How do you sort an array in C#?
* Array.Sort(myArray) can be used to sort an array in C#.
4. What property of an array object can be used to get the total number of elements in
   an array?
* myArray.length can be used to find the total number of elements.
5. Can you store multiple data types in System.Array?
* No, unless the element type is Object.
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
* CopyTo copies elements into an existing array starting at a specified index
* Clone() returns a shallow copy of the entire array as a new object. 