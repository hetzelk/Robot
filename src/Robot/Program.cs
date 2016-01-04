using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    class Program : BuildRobot
    {
        static void Main(string[] args)
        {
            Program Robot1 = new Program();
            Program Robot2 = new Program();

            Robot1.buildBody();
            Robot2.buildBody();
        }
    }
}
