using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public class Battle : Weapons
    {
        string name1;
        string name2;

        Smack smackme = new Smack();

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

        public void round1()
        {
            Console.WriteLine("Round 1!");
            Console.WriteLine("'{0}'- {1}", name1, smackme.smacktalk1());
            Console.WriteLine("{0} wins!!!", name2);
            Console.WriteLine("'{0}'- {1}", name2, smackme.smacktalk2());
        }

        public void round2()
        {
            Console.WriteLine("Round 2!");
            Console.WriteLine("'{0}'- {1}", name2, smackme.smacktalk3());
            Console.WriteLine("{0} wins!!!", name1);
            Console.WriteLine("'{0}'- {1}", name1, smackme.smacktalk4());
        }

        public void round3()
        {
            Console.WriteLine("Round 3!");
            Console.WriteLine("'{0}'- {1}", name2, smackme.smacktalk5());
            Console.WriteLine("{0} won!!!", name1);
            Console.WriteLine("'{0}'- {1}", name1, smackme.smacktalk6());
        }
    }
}
