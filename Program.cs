using System;

class Calculadora
{
    static void Main(string[] args)
    {
        // Variable declaration
        double number1, number2, result;

        // Get the first Number
        while(true)
        {
            Console.WriteLine("Type your first number: ");
            string? input1 = Console.ReadLine();

            if(double.TryParse(input1, out number1))
            {
                break; // Input is valid, exit loop.
            }
            else
            {
                Console.WriteLine("Error: The first number is not a number");
            }
        }

        // Get the second number
        while (true)
        {
            Console.Write("Type your second number: ");
            string? input2 = Console.ReadLine();

            if (double.TryParse(input2, out number2))
            {
                break; // Input is valid, exit loop
            }
            else
            {
                Console.WriteLine("Error: The second number is not a number");
            }
        }

        System.Console.WriteLine("Actually, we only do sum operations. Come back later to see more options.");
        // Executing Operation
        result = number1 + number2;

        // Exibição do resultado
        Console.WriteLine($"The sum of {number1} and {number2} is: {result}");
    }
}

