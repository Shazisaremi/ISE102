# Intorduction
Welcome to Module 2 of Introduction to Software Engineering!

In Module 1, you had learnt how to set up the Visual Studio environment to create, store and execute C# programs/projects. In addition to that, you had also implemented your first C# program along with the computer programming concepts.

This module brings to you another set of very important programming fundamental concepts, such as data types, comments and input/output.

# C# Language Basics

## Syntax
C# syntax is inspired by C and C++ syntax. In this section, we describe C#’s elements of syntax, using the following program:
```c#
using System;

class Test
{
  static void Main()
  {
    int x = 12 * 30;
    Console.WriteLine (x);
  }
}
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

