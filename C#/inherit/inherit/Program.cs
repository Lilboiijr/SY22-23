using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            truck t = new truck();
            t.fill();
            t.stop();
            t.drive();
            Console.ReadKey();
        }
    }
}
