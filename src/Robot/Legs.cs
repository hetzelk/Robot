using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public class Legs : IPart
    {
        public int legs()
        {
            return 2;
        }

        public void Operate()
        {
            Console.WriteLine("Legs are up and running");
        }
    }
}
