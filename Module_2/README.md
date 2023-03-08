# Intorduction
Welcome to Module 2 of Introduction to Software Engineering!

In Module 1, you had learnt how to set up the Visual Studio environment to create, store and execute C# programs/projects. In addition to that, you had also implemented your first C# program along with the computer programming concepts.

This module brings to you another set of very important programming fundamental concepts, such as data types, comments and input/output.

# C# Language Basics

## Syntax
C# syntax is inspired by C and C++ syntax. In this section, we describe C#’s elements of syntax, using the following program:
```c#
int x = 12 * 30;
Console.WriteLine (x);
```

### Identifiers and Keywords
**Identifiers** are names that programmers choose for their classes, methods, variables, and so on. Here are the identifiers in our example program, in the order in which they appear:

```
System   Test   Main   x   Console   WriteLine
```

An identifier must be a whole word, essentially made up of Unicode characters starting with a letter or underscore. C# identifiers are case sensitive. By convention, parameters, local variables, and private fields should be in camel case (e.g., my​Variable), and all other identifiers should be in Pascal case (e.g., MyMethod).

**Keywords** are names that mean something special to the compiler. These are the keywords in our example program:
```
using   class   static   void   int
```

### Literals, Punctuators, and Operators
**Literals** are primitive pieces of data lexically embedded into the program. The literals we used in our example program are 12 and 30.

**Punctuators** help demarcate the structure of the program. These are the punctuators we used in our example program:
```
{   }   ;
```

An **operator** transforms and combines expressions. Most operators in C# are denoted with a symbol, such as the multiplication operator, *. We discuss operators in more detail later in this chapter. These are the operators we used in our example program:
```
.  ()   *   =
```

### Comments
C# offers two different styles of source-code documentation: single-line comments and multiline comments. A single-line comment begins with a double forward slash and continues until the end of the line; for example:
```c#
int x = 3;   // Comment about assigning 3 to x
```

A multiline comment begins with /* and ends with */; for example:
```c#
int x = 3;   /* This is a comment that
                spans two lines */
```

## Type Basics

### Variables 

**Variables** are containers for storing data values.

In C#, there are different **types** of variables (defined with different keywords), for example:

- **int** - stores integers (whole numbers), without decimals, such as 123 or -123
- **double** - stores floating point numbers, with decimals, such as 19.99 or -19.99
- **char** - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
- **string** - stores text, such as "Hello World". String values are surrounded by double quotes
- **bool** - stores values with two states: true or false

To create a variable, you must specify the type and assign it a value:
```c#
int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String
```

You can also declare a variable without assigning the value, and assign the value later:
```c#
int myNum;
myNum = 15;
Console.WriteLine(myNum);
```

### Constants
However, you can add the const keyword if you don't want others (or yourself) to overwrite existing values (this will declare the variable as "constant", which means unchangeable and read-only):
```c#
const int myNum = 15;
myNum = 20; // error
```

```
The const keyword is useful when you want a variable to always store the same value, so that others (or yourself) won't mess up your code. An example that is often referred to as a constant, is PI (3.14159...).

**Note:** You cannot declare a constant variable without assigning the value. If you do, an error will occur: A const field requires a value to be provided.
```

### Type Conversion Methods

#### Implicit Casting

Implicit casting is done automatically when passing a smaller size type to a larger size type:

```c#
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9
```

#### Explicit Casting

Explicit casting must be done manually by placing the type in parentheses in front of the value:

```c#
double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9
```

#### It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):
```c#
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
```
