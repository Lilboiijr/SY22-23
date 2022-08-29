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

            ShowQuestion("how many phones are in connors backpack", " a)1", " b)2", " c) 0", " d) 6", "c");


            ShowQuestion("how old is mr clarke", " a)51", " b)43", " c) 96", " d) 21", "a");

            ShowQuestion("is elije striaght", "a)true", "b)false" , "c)" , "d)",  "b");
           
            ShowQuestion("What is 1+1?", " a)1", " b)2", " c) 0", " d) 6","b");




            Console.ReadKey();
        }

        public static void ShowQuestion(string question,
                                        string answer1,
                                        string answer2,
                                        string answer3,
                                        string answer4,
                                        string correct)
        { 
            Console.WriteLine(question); 
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4); 
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
            {
                Console.WriteLine("you got it correct");
            }
            //
            
        }
    }
}
