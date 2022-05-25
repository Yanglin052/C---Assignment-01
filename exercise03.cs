/* Practice loops and operators
1. FizzBuzzis a group word game for children to teach them about division. Players take turns
to count incrementally, replacing any number divisible by three with the word /fizz/, any
number divisible by five with the word /buzz/, and any number divisible by both with /
fizzbuzz/.
Create a console application in Chapter03 named Exercise03 that outputs a simulated
FizzBuzz game counting up to 100. 

namespace exercise03
{
    public class fizzbuzzgame
    {
        static void Main(string[] args)
        {
            int max = 100;
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
*/

/*Create a console application and enter the preceding code. Run the console application
and view the output. What happens?
    The warning message "Writeline does not exist" appears.
What code could you add (don’t change any of the preceding code) to warn us about the
problem?*/

/*Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3).

int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Please enter an integer number between 1 and 3: ");
int guessNumber = int.Parse(Console.ReadLine());

if (guessNumber > 3 || guessNumber < 1)
{
    Console.WriteLine("It is outside of range.");
}
else if (guessNumber < correctNumber)
{
    Console.WriteLine("It is too low.");
}
else if (guessNumber > correctNumber)
{
    Console.WriteLine("It is too high.");
}
else if (guessNumber == correctNumber)
{
    Console.WriteLine("Correct!");
}
*/

/*2.Print - a - Pyramid.
Like the star pattern examples that we saw earlier, create a program that
will print the following pattern: If you find yourself getting stuck, try recreating the two
examples that we just talked about in this chapter first. They’re simpler, and you can
compare your results with the code included above.
This can actually be a pretty challenging problem, so here is a hint to get you going. I used
three total loops. One big one contains two smaller loops. The bigger loop goes from line
to line. The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars.

int numberoflayer = 5, Space, Number;  
Console.WriteLine("Print paramid");  
for (int i = 1; i <= numberoflayer; i++) 
{  
    for (Space = 1; Space <= (numberoflayer - i); Space++)  
        Console.Write(" ");  
    for (Number = 1; Number <= i; Number++) 
        Console.Write('*');  
    for (Number = (i - 1); Number >= 1; Number--)
        Console.Write('*');  
    Console.WriteLine();  
} 
*/

/*3. Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). 

int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("Please enter an integer number between 1 and 3: ");
int guessNumber = int.Parse(Console.ReadLine());

if (guessNumber > 3 || guessNumber < 1)
{
    Console.WriteLine("It is outside of range.");
}
else if (guessNumber < correctNumber)
{
    Console.WriteLine("It is too low.");
}
else if (guessNumber > correctNumber)
{
    Console.WriteLine("It is too high.");
}
else if (guessNumber == correctNumber)
{
    Console.WriteLine("Correct!");
}
*/

/*4.Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000);.

var birthday = new DateTime(1997, 01, 01);
int age = (int) (DateTime.Now - birthday).TotalDays;
Console.WriteLine("Age = " + age + "days");
int daysToNextAnniversary = 10000 - (age % 10000);
var anniversery = DateTime.Now.AddDays(daysToNextAnniversary);
Console.WriteLine("Next 10000 day anniversery is " + anniversery);
*/

/*5. Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning""Good Afternoon""Good Evening""Good Night"
It's up to you which times should serve as the starting and ending ranges for each of the
greetings.When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach).

DateTime currentTime = DateTime.Now;
int currentHour = currentTime.Hour;
int startMorningHour = 6;
int startAfternoonHour = 12;
int startEveningHour = 17;
int startNightHour = 21;

if (startMorningHour <= currentHour && currentHour < startAfternoonHour)
{
    Console.WriteLine("Good morning!");
}
if (startAfternoonHour <= currentHour && currentHour < startEveningHour)
{
    Console.WriteLine("Good Afternoon!");
}
if (startEveningHour <= currentHour && currentHour < startNightHour)
{
    Console.WriteLine("Good Evening!");
}
if (startNightHour <= currentHour || currentHour < startMorningHour)
{
    Console.WriteLine("Good Night!");
}
Console.WriteLine($"It is {currentTime.Hour}:{currentTime.Minute} o'clock now.");
*/

/*6.Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
Use nested for loops with your outer loop counting from 1 to 4. 
You inner loop should count from 0 to 24, but increase the value of its/loop control variable/by the value of the/
loop control variable/ from the outer loop. This means the incrementing in the/afterthought/ expression will be based on a variable.*/

using System;

public class CountProgram
{
    public static void Main()
    {
        CountTo24();
    }
    private static void CountTo24()
    {
        for (int countBase = 1; countBase <= 4; countBase += 1)
        {
            Console.Write(countBase.ToString().PadLeft(4)+ ":");
            for (int countUp = 0; countUp <= 24; countUp += countBase)
            {
                Console.Write(countUp.ToString().PadLeft(4));
            }

            Console.WriteLine();
        }
    }
}