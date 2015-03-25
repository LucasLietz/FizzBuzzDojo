using System;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DisplayHeader();
            var fi = new FizzBuzzer();

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("{0} : {1}", i, fi.FizzIt(i));
            }
            Console.Read();
        }

        private static void DisplayHeader()
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hallo, Willkommen zu FizzBuzz.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Applikation entwickelt in Test Driven Design.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("by Lucas Lietz.\n\n\n");
            Console.ForegroundColor = oldColor;
        }
    }
}