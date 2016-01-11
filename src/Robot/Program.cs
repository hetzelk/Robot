using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public class Program
    {
        static void Main(string[] args)
        {
            Robot robots = new Robot();
            robots.StartRobots();
            robots.StartBattle();
        }
    }
}
