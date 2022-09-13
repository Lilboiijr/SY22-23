using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit
{
    internal class truck: vehicle
    {
        public void fill()
        {
            Console.WriteLine("truck fill");
        }
        public void stop()
        {
            Console.WriteLine("truck stop");
        }
    }
}
