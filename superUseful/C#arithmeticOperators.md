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

