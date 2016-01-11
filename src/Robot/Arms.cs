using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public class Arms : IPart
    {
        public int arms()
        {
            return 2;
        }

        public void Operate()
        {
            Console.WriteLine("Arms are up and running");
        }
    }
}
