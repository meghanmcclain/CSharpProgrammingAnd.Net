using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //while the user wants to continue
            while (true)
            {
                //use double to allow for floating point operations
                double num1 = 0; double num2 = 0;

                Console.WriteLine("A Simple Calculator (Console Application)\r");
                Console.WriteLine("\n");

                Console.WriteLine("Please type a number, and then press enter");
                //convert to double to account for floating point numbers
                //using ToDouble method so must enter a number
                try
                {
                    num1 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("The value entered is not valid. Please enter a number.");
                    continue;
                }

                Console.WriteLine("Please type a second number, and then press Enter");
                //convert to double to account for floating point numbers
                try
                {
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("The value entered is not valid. Please enter a number.");
                    continue;
                }

                Console.WriteLine("Please choose an operator by typing the operator symbol(+, -, *, or /):");
                Console.WriteLine("\tAdd: +");
                Console.WriteLine("\tSubtract: -");
                Console.WriteLine("\tMultiply: *");
                Console.WriteLine("\tDivide: /");
                Console.Write("Your option? ");

                try
                {
                    //use string interpolation to display the calculated value
                    switch (Console.ReadLine())
                    {
                        case "+":
                            Console.WriteLine($"The calculated value: {num1} + {num2} = " + (num1 + num2));
                            break;
                        case "-":
                            Console.WriteLine($"The calculated value: {num1} - {num2} = " + (num1 - num2));
                            break;
                        case "*":
                            Console.WriteLine($"The calculated value: {num1} * {num2} = " + (num1 * num2));
                            break;
                        case "/":
                            //can't divide by zero
                            if (num2 != 0)
                            {
                                Console.WriteLine($"The calculated value: {num1} / {num2} = " + (num1 / num2));
                                break;
                            }
                            else
                                Console.WriteLine("Error: You can't divide by zero.");
                            continue;
                    }
                }
                catch
                {
                    Console.WriteLine("The operand entered is not valid. Please enter one of the four choices: +, -, *, or /");
                    continue;
                }

                while (true) // Keep asking the user until a Y or a N is entered
                {
                    Console.Write("Do you want to play again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N")
                        return; // Exit the Main-method.
                }
                }
        }
    }
}
