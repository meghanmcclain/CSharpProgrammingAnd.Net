using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            //var currentDate = DateTime.Now;
            //Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}Hello, {name}! Wow you look great for {age}! You look younger than your age!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
