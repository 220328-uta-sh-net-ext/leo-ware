# + is the addition operator
# - is the subtraction operator
# * is the multiplication operator
# / is the division operator

# /*int firstNumber = 12;
# int secondNumber = 7;
# Console.WriteLine(firstNumber + secondNumber);*/

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

# The resulting quotient of our division example may not be what you may have expected. The values after the decimal are truncated from quotient since it is defined as an int, and int cannot contain values after the decimal.
# To see division working properly, we need to use a data type that supports fractional digits after the decimal point like decimal.
# In order for this to work, the quotient (left of the assignment operator) must be of type decimal and either the dividend or divisor must be of type decimal (or both).

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);

decimal decimalQuotientTwo = 7 / 5.0m;
decimal decimalQuotientThree = 7.0m / 5.0m;
Console.WriteLine("Decimal quotient:\n" + decimalQuotient + "\n" + decimalQuotientTwo + "\n" + decimalQuotientThree);

int decimalQuotient1 = 7 / 5.0m;
int decimalQuotient2 = 7.0m / 5;
int decimalQuotient3 = 7.0m / 5.0m;
decimal decimalQuotient4 = 7 / 5;
Console.WriteLine("Decimal quotients that don't work:\n" + decimalQuotient1 + "\n" + decimalQuotient2 + "\n" + decimalQuotient3 + "\n" + decimalQuotient4);
# What if you are not working with literal values? In other words, what if you need to divide two variables of type int but do not want the result truncated? In that case, you must perform a data type cast from int to decimal. Casting is one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type.

# To cast int to decimal, you add the cast operator before the value. You use the name of the data type surrounded by parenthesis in front of the value to cast it. In this case, we would add (decimal) before the variables first and second.

# Modify the code in the .NET Editor to the following code:

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

## --------------------------------------------------------------------

##    WRITE CODE TO FIND THE REMAINDER AFTER INT DIVISION

# The remainder operator % tells you the remainder of int division. What you really learn from this is whether one number is divisible by another. This can be useful during long processing operations when looping through hundreds or thousands of data records and you want to provide feedback to the end user after every 100 data records have been processed.

Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));

# When the modulus is 0, that means the dividend is divisible by the divisor.
## -----------------------------------------------------------------

##                    ORDER OF OPERATIONS

# In math, PEMDAS is an acronym that helps students remember the order in which multiple operations are performed. The order is:

# Parentheses (whatever is inside the parenthesis is performed first)
# Exponents
# Multiplication and Division (from left to right)
# Addition and Subtraction (from left to right)
# C# follows the same order as PEMDAS except for exponents. While there's no exponent operator in C#, you can use the System.Math.Pow() method, which is available from the .NET Class Library. The module "Call methods from the .NET Class Library using C#" will feature this method and others.

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

# ------------------------------------------------------------------

##  LET'S CALCULATE THE CONVERSION OF FAHRENHEIT TO CELSIUS

int fahrenheit = 94;
# To convert temperatures in degrees Fahrenheit to Celsius:
# First subtract 32,
# Then multiply by five ninths (5 / 9)
# Combine the variables with literal strings passed into a series of Console.WriteLine() commands to form the complete message.
decimal quotient = 5 / 9.0m;
decimal celsius = ((decimal)fahrenheit - 32) * (quotient);
# You can also write the above line of code as follows:
# decimal celsius = ((decimal)(fahrenheit -= 32)) * (quotient);
## *** Remember that values inside of parentheses will be calculated first.
Console.WriteLine($"You did it!! The temperature is {celsius} Celsius!");

# Here is the solution given in the module I'm working on:
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");


## /*The conditional operator ?:, commonly known as the ternary conditional operator, 
evaluates a Boolean expression, and returns the result of evaluating one of two expressions, 
depending on whether the Boolean expression evaluates to true or false.

# Here's the basic form:
# <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>*/

int saleAmount = 1001;

int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


## Random coin toss output method:

Random coin = new Random();
int toss = coin.Next(1,3);

if (toss < 2) {
    Console.WriteLine("heads");
}
else {
    Console.WriteLine("tails");
}

# Other solutions from lesson:
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
# &
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");


## NESTED if..else if...else STATEMENTS:

string permission = "Admin|Manager";
int level = 55;
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}


## ITERATIONS:

# Basic

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

# Basic - Iterate backwards

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

# Easy - iterating in intervals greater than 1

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

# Medium... kinda;) - Iteration with a break keyword

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

# Hard - Looping through each element of an array

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

# Hard - Using a foreach statement with a for loop iteration.

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);


#### FIZZ BUZZ CHALLENGE!!!!!!!!!!!!!!!

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}

### HERO vs. MONSTER GAME OF CHANCE

# Game Rules

<!---The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.
Most importantly:

You must use either the do-while statement, or the while statement.
No matter how you do it, your code should produce a similar output: --->

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

<!--- /*Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!*/ --->

# Camparing Triplets Basic - comparing array lists

<!-- Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).

The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

If a[i] > b[i], then Alice is awarded 1 point.
If a[i] < b[i], then Bob is awarded 1 point.
If a[i] = b[i], then neither person receives a point.
Comparison points is the total points a person earned.

Given a and b, determine their respective comparison points. -->

public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var counta = ((a[0]>b[0])?1:0)+((a[1]>b[1])?1:0) + ((a[2]>b[2])?1:0);

        var countb = ((b[0]>a[0])?1:0)+((b[1]>a[1])?1:0)+((b[2]>a[2])?1:0);

        return new List<int> {counta, countb};
    }


# Consider an array of numeric strings where each string is a positive number with anywhere from 1 to 10^6 digits. Sort the array's elements in non-decreasing, or ascending order of their integer values and return the sorted array.

<!--Example:
unsorted = ['1','200','150','3']

Return the array ['1', '3', '150', '200'].

Function Description:
Complete the bigSorting function in the editor below.

bigSorting has the following parameter(s):

-string unsorted[n]: an unsorted array of integers as strings

Returns:
-string[n]: the array sorted in numerical order -->



using System;

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a = new string[n];
        for (int i = 0; i < n; i++) {
            a[i] = Console.ReadLine();
        }
        Array.Sort(a, (left, right) => {
            if (left.Length != right.Length) {
                return left.Length - right.Length;
            } else {
                return string.CompareOrdinal(left, right);
                // left.CompareTo(right) is too slow
            }
        });
        for (int i = 0; i < n; i++) {
            Console.WriteLine(a[i]);
        }
    }
}
