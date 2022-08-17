using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thingy
{
    internal class Program
    {
        static void Main(string[] args)
        
       {
            int correct = 0;
            
            Console.WriteLine("how many phones are in connors backpack  A.1 b.2 c.0");
            string anwser = Console.ReadLine();
            if (anwser == "A")
            {
               correct=correct+1;
            }
            Console.WriteLine("how old is mr clarke A.51 b. 43 c. 96");
           anwser = Console.ReadLine();
            if (anwser == "A")
                correct = correct + 1;
            Console.WriteLine("is elije striaght A. false b. true");
            anwser = Console.ReadLine();
            if (anwser == "A")
                correct = correct + 1;
            Console.WriteLine($"you got {correct} right ");


            Console.ReadKey();
        }
    }
}
