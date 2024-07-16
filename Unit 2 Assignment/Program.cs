
using System;

public class Program
{
    // Function to add two numbers
    public static double AddNumbers(double num1, double num2)
    {
        return num1 + num2;
    }

    // Main entry function
    public static void Main()
    {
        Console.WriteLine("Welcome to the addition program!");

        // Input the first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Input the second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Call the function to add the numbers
        double result = AddNumbers(num1, num2);

        // Display the result
        Console.WriteLine($"The sum of {num1} and {num2} is {result}.");
    }

    // Unit test function
    public static void TestAddNumbers()
    {
        // Test cases
        double result1 = AddNumbers(2, 3);
        double result2 = AddNumbers(-1, 5);
        double result3 = AddNumbers(0, 0);
        double result4 = AddNumbers(2.5, 3.7);
        double result5 = AddNumbers(-10, -5);

        // Assertions
        if (result1 != 5 || result2 != 4 || result3 != 0 || result4 != 6.2 || result5 != -15)
        {
            Console.WriteLine("Unit test failed!");
        }
        else
        {
            Console.WriteLine("Unit test passed successfully!");
        }
    }
}