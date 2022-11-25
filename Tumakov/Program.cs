using System;

namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 10.1");
            ACipher nextChar = new ACipher();
            BCipher oppositeChar = new BCipher();

            nextChar.encode();
            Console.WriteLine();
            nextChar.decode();
            Console.WriteLine();

            oppositeChar.encode();
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Homework 10.1");
            Figure rectangle = new Rectangle("blue", Visibility.Invisible, 4, 5);
            rectangle.DisplayAllInformation();
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
