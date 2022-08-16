using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;
            Console.WriteLine("enter your age");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine(X);
            Console.WriteLine("your age is "  + X);
            Console.WriteLine("your name is {0}.",X); 
            Console.WriteLine($"your age is {X}. ");
            Console.WriteLine(@"your age is {X}. ");
            Console.ReadKey();
        }
    }
}
