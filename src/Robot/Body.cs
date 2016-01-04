using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public class Body : IPart
    {
        public int body()
        {
            return 1;
        }

        public void Operate()
        {
            Console.WriteLine("Body is up and running");
        }
    }
}
