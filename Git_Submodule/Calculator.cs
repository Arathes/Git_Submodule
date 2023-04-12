using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Result of Multiplication: " + Multiply(num1, num2));
        Console.WriteLine("Result of Subtraction: " + Subtract(num1, num2));
        Console.WriteLine("Result of Division: " + Divide(num1, num2));
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return num1 / num2;
    }
}