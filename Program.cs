// See https://aka.ms/new-console-template for more information
using System.IO;

var keepAlive = true;
decimal intOne = 0;
decimal intTwo = 0;
string operand;
ConsoleKeyInfo status;
decimal result = 0;

while (keepAlive)
{
    try
    {
        var divZero = false;
        Console.Write("Enter type of calculation +,-,*,/.");
        operand = (Console.ReadLine() ?? "");
        Console.Write("Enter first integer:");
        intOne = Convert.ToDecimal(Console.ReadLine() ?? "");
        while (!divZero)
        {
            Console.Write("Enter second integer:");
            intTwo = Convert.ToDecimal(Console.ReadLine() ?? "");
            if (intTwo == 0)
            {
                divZero = false;
                Console.WriteLine("Division by 0 not possible!");
            }
            else
            {
                divZero = true;
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        switch (operand)
        {
            case "+":
                result = Addition(intOne, intTwo);
                break;
            case "*":
                result = Multiply(intOne, intTwo);
                break;
            case "-":
                result = Subtract(intOne, intTwo);
                break;
            case "/":
                result = Divide(intOne, intTwo);
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is not an operand!");
                break;
        }
        Console.ResetColor();
        Console.WriteLine("The result is {0}", result);
        Console.WriteLine("Do you want to quit? (Y/y)");
        status = Console.ReadKey();
        if (status.Key == ConsoleKey.Y)
        {
            keepAlive = false;
            break;
        }
        Console.Clear();
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("An error has occurred!");
        Console.ResetColor();
    }
}

static decimal Multiply( decimal param1, decimal param2)
{
    decimal Result = param1 * param2;
    return Result;
}
static decimal Addition(decimal param1, decimal param2)
{
    decimal Result = param1 + param2;
    return Result;
}
static decimal Subtract(decimal param1, decimal param2)
{
    decimal Result = param1 - param2;
    return Result;
}
static decimal Divide(decimal param1, decimal param2)
{
    decimal Result = param1 / param2;
    return Result;
}