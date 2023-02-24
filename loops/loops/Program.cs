using System;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }
    }
}