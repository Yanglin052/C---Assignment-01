/* 01 Introduction to C# and Data Types
Understanding Data Types
Test your Knowledge
1.What type would you choose for the following “numbers”?
    A person’s telephone number: string
    A person’s height: float
    A person’s age: int
    A person’s gender (Male, Female, Prefer Not To Answer): string
    A person’s salary: decimal
    A book’s ISBN: string
    A book’s price: decimal
    A book’s shipping weight: float
    A country’s population: long
    The number of stars in the universe: long
    The number of employees in each of the small or medium businesses in the 
    United Kingdom (up to about 50,000 employees per business): int

2.What are the difference between value type and reference type variables? What is boxing and unboxing?
    a.value type will directly hold the value, while reference type will hold the memory address or reference for this value;
    b.value type are stored in stack memory, while reference types are stored in heap memory;
    c.value type will not be collected by garbage collector, while reference type will;
    d.value type can be created by Struct or Enum, while reference type can be created by class, interface, delegate, array;
    e.value type cannot accept null values, but reference types can.
    Boxing is to convert a value type to a reference type and unboxing is converting the reference type to a value type.

3. What is meant by the terms managed resource and unmanaged resource in .NET?
    Managed resources are those that are managed by garbage collector. 
    Unmanaged resources are not managed by garbage collector, such as files, strings, database connections.

4. What is the purpose of Garbage Collector in .NET?
    It can manage the allocation and release memory for application automatically.

Playing with Console App
    Using just the ReadLine and WriteLine methods and your current knowledge of variables,
    you can have the user pass in quite a few bits of information. Using this approach, create a
    console application that asks the user a few questions and then generates some custom
    output for them. For instance, your program could generate their "hacker name" by asking
    them their favorite color, their astrology sign, and their street address number. The result
    might be something like "Your hacker name is RedGemini480." */

Console.WriteLine("Please enter your favorite color: ");
var color = Console.ReadLine();
Console.WriteLine("Please enter your last name: ");
var name = Console.ReadLine();
Console.WriteLine("Please enter your street address number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your hacker name is " + color + name + num);