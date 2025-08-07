# Part 1: Introduction to C# and Data Types

## Understanding Data Types

### Test Your Knowledge

1. What type would you choose for the following "numbers"?

* A person's telephone number: 
  * String, because it may include leading zeros, country codes, parentheses, hyphens, etc.
* A person's height
  * Double, since fractional precision is needed
* A person's age
  * Int, we are using whole non-negative numbers
* A person's gender
  * enum Gender, constrains to a fixed set of values 
* A person's salary
  * Decimal, high precision for currency math and avoids rounding errors
* A book's ISBN
  * String, typically contain hyphens
* A book's price
  * Decimal, monetary value
* A book's shipping weight
  * Double, allows for fractional weight
* A country's population
  * Long, since can reach billions surpasses int max value
* The number of stars in the universe
  * BigInteger, surpasses range of long
* The number of employees in each of the small or medium businesses in the United Kingdom
  * Int, covers 50,000 comfortably

2. What are the difference between value type and reference type variables? What is
   boxing and unboxing?
* Value types store their data directly. When you assign one variable to another, you copy the value. They live on the stack, and have no identity beyond their contents.
* Reference types store a pointer to the data on the heap, assigning one variable to another copies the reference, not the underlying object.
* Boxing is the process of wrapping a value type in an object or any interface it implements, allocating it onto the heap
* Unboxing extracts the value type from the heap back into a value-type variable.

3. What is meant by the terms managed resource and unmanaged resource in .NET?

* Managed resources are objects whose lifetimes and memory are automatically controlled by .NET CLR
* Unmanaged resources are outside of the CLR direct control, and the programmer must explicitly free/release them.

4. Whats the purpose of Garbage Collector in .NET?

* The Garbage Collector automatically frees up memory occupied by objects that are no longer reachable by any live code.

## Controlling Flow and Converting Types

### Test Your Knowledge

1. What happens when you divide an int variable by 0?
* An exception is thrown at runtime
2. What happens when you divide a double variable by 0?
* Infinity or -Infinity is returned if the variable is not 0, "not a number" is returned if the variable is 0.0
3. What happens when you overflow an int variable, that is, set it to a value beyond its
   range?
* the value wraps around 2^32
4. What is the difference between x = y++; and x = ++y;?
* x = y++ assigns the original y to x, and then increments y
* x = ++y increments y first, then assigns the new value to x
5. What is the difference between break, continue, and return when used inside a loop
   statement?
* Break immediately exits the loop
* Continue skips the rest of the current iteration and moves on to the next
* Return exits the entire method
6. What are the three parts of a for statement and which of them are required?
* The three parts are the initializer, condition, and iterator; all of them are optional 
7. What is the difference between the = and == operators?
* = is the assignment operator, and == is for comparing two values
8. Does the following statement compile? for ( ; true; ) ;
* Yes, but it is just an infinite loop with an empty body
9. What does the underscore _ represent in a switch expression?
* The underscore is the discard pattern, which matches any value not caught by the earlier parts.
10. What interface must an object implement to be enumerated over by using the foreach
    statement?
* It must implement IEnumerable.