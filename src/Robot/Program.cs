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
            Name name = new Name();
            Battle battle = new Battle();

            string name1 = name.askForName(1);
            string name2 = name.askForName(2);

            Console.WriteLine("{0} is being built\n", name1);
            Robot1.buildBody();

            Console.WriteLine("{0} is being built\n", name2);
            Robot2.buildBody();

            battle.BotName1 = name1;
            battle.BotName2 = name2;
            battle.round1();
            Console.WriteLine("\nRobots are 100% refreshed \n");
            battle.round2();
            Console.WriteLine("\nRobots are 100% refreshed \n");
            battle.round3();

            Console.WriteLine("\n \nThe fight is over.");
            Console.ReadLine();
        }
    }
}
