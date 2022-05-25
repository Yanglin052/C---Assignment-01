/* Practice number sizes and ranges
1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.

using System;

namespace Package1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("| Type | Bytes of Memory | Min | Max |");
            Console.WriteLine($"| sbyte | {sizeof(sbyte)} | {sbyte.MinValue} | {sbyte.MaxValue} |");
            Console.WriteLine($"| byte | {sizeof(byte)} | {byte.MinValue} | {byte.MaxValue} |");
            Console.WriteLine($"| short | {sizeof(short)} | {short.MinValue} | {short.MaxValue} |");
            Console.WriteLine($"| ushort | {sizeof(ushort)} | {ushort.MinValue} | {ushort.MaxValue} |");
            Console.WriteLine($"| int | {sizeof(int)} | {int.MinValue} | {int.MaxValue} |");
            Console.WriteLine($"| uint | {sizeof(uint)} | {uint.MinValue} | {uint.MaxValue} |");
            Console.WriteLine($"| long | {sizeof(long)} | {long.MinValue} | {long.MaxValue} |");
            Console.WriteLine($"| ulong | {sizeof(ulong)} | {ulong.MinValue} | {ulong.MaxValue} |");
            Console.WriteLine($"| float | {sizeof(float)} | {float.MinValue} | {float.MaxValue} |");
            Console.WriteLine($"| double | {sizeof(double)} | {double.MinValue} | {double.MaxValue} |");
            Console.WriteLine($"| decimal | {sizeof(decimal)} | {decimal.MinValue} | {decimal.MaxValue} |");
        }
    }
}; 
*/

/* 2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. 
Use an appropriate data type for every data conversion. Beware of overflows! 

public class Myclass
{
    static public void Main()
    {
        Console.WriteLine("Enter number of centuries:");
        long centuries = Convert.ToInt64(Console.ReadLine());

        long years = centuries * 100;
        long days = years * 365;
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        long microseconds = milliseconds * 1000;
        long nanoseconds = microseconds * 1000;

        Console.Write(centuries + " centuries = ");
        Console.Write(+years + " years = ");
        Console.Write(days + " days = ");
        Console.Write(hours + " hours = ");
        Console.Write(minutes + " minutes = ");
        Console.Write(seconds + " seconds = ");
        Console.Write(milliseconds + " milliseconds = ");
        Console.Write(microseconds + " microseconds = ");
        Console.Write(nanoseconds + " nanoseconds ");
    }
}
*/

/*Controlling Flow and Converting Types
Test your Knowledge
1. What happens when you divide an int variable by 0?
    An exception appears and the warning says "System.DivideByZeroException: 'Attempted to divide by zero.'".
2. What happens when you divide a double variable by 0?
    No any exception or error message pops up and it can be run successfully.
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
    A red line under the value will provide a warning that this data type is incorrect,
    and should be converted to another type.
4. What is the difference between x = y++; and x = ++y;?
    ++y means that when the code is executing it will first do y = y + 1 and then read it. 
    y++ means that when executing it will first read it and do the y = y + 1 after it has been read.
5. What is the difference between break, continue, and return when used inside a loop statement?
    Break is used to exit from a loop. 
    Continue is used to move the control to the next iteration of the loop. 
    Return is used to return a value from a function.
6. What are the three parts of a for statement and which of them are required?
    Initializer, condition and iterator. All of these three parts are optional.
7. What is the difference between the = and == operators?
    = is used for assigning values to a variable, while == is used for comparing two variables.
8. Does the following statement compile? for ( ; true; ) ;
    Yes
9. What does the underscore _ represent in a switch expression?
    It replaces the default keyword to signify that it should match anything if reached. 
10. What interface must an object implement to be enumerated over by using the foreach statement?
    The IEnumerable interface.
*/
