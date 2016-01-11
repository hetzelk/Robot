using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{

    public class Battle : Weapons
    {
        string refresh;
        string name1;
        string name2;
        Smack smack;
        Weapons weapons;

        public Battle()
        {
            refresh = "\nRobots are 100 % refreshed \n";
            smack = new Smack();
            weapons = new Weapons();
        }

        public string BotName1
        {
            get { return name1; }
            set { name1 = value; }
        }

        public string BotName2
        {
            get { return name2; }
            set { name2 = value; }
        }

        public void Round1()
        {
            Console.WriteLine("Round 1!");
            ChooseWeapon(name1, "sword");
            ChooseWeapon(name1, "throwing star");
            ChooseWeapon(name2, "gun");
            ChooseWeapon(name2, "grenade");

            Console.WriteLine("{0}- {1}", name1, smack.SmackTalk(1));
            TakeAction(name1, "sword");
            TakeAction(name2, "grenade");
            Console.WriteLine("{0} wins!!!", name2);
            Console.WriteLine("{0}- {1}", name2, smack.SmackTalk(2));
            Console.WriteLine(refresh);
        }

        public void Round2()
        {
            Console.WriteLine("Round 2!");
            Console.WriteLine("{0}- {1}", name2, smack.SmackTalk(3));
            TakeAction(name2, "gun");
            TakeAction(name1, "throwing star");
            Console.WriteLine("{0} wins!!!", name1);
            Console.WriteLine("{0}- {1}", name1, smack.SmackTalk(4));
            Console.WriteLine(refresh);
        }

        public void Round3()
        {
            Console.WriteLine("Round 3!");
            Console.WriteLine("{0}- {1}", name2, smack.SmackTalk(5));
            TakeAction(name1, "sword");
            TakeAction(name2, "gun");
            Console.WriteLine("{0} won!!!", name1);
            Console.WriteLine("{0}- {1}", name1, smack.SmackTalk(6));
        }
    }
}
