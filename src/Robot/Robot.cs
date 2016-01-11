using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    class Robot : BuildRobot
    {
        Name name;
        string name1;
        string name2;

        Battle battle = new Battle();

        public Robot()
        {
            name = new Name();
            name1 = name.askForName(1);
            name2 = name.askForName(2);
            battle = new Battle();
        }

        public void RunRobots()
        {
            Random random = new Random();
            int randomnumber = random.Next(1, 3);
            
            BuildBody(name1);
            Console.WriteLine();
            
            BuildBody(name2);
            Console.WriteLine();

            battle.BotName1 = name1;
            battle.BotName2 = name2;
            battle.round1();
            battle.round2();
            battle.round3();

            Console.WriteLine("\n \nThe fight is over.");
            Console.ReadLine();
        }
    }
}
