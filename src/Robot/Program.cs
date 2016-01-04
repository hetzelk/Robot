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

            Console.WriteLine("Robot 1 being built\n");
            Robot1.buildBody();
            Console.WriteLine("Robot 2 being built\n");
            Robot2.buildBody();

            Console.WriteLine("This is the end");
            Console.ReadLine();
        }
    }
}
