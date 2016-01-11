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

        public void StartRobots()
        {
            BuildBody(name1);
            Console.WriteLine();
            
            BuildBody(name2);
            Console.WriteLine();
        }

        public void StartBattle()
        {
            battle.BotName1 = name1;
            battle.BotName2 = name2;
            battle.Round1();
            battle.Round2();
            battle.Round3();

            Console.WriteLine("\n \nThe fight is over.");
            Console.ReadLine();
        }
    }
}
