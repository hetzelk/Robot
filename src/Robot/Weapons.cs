using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public class Weapons
    {
        public void ChooseWeapon(string name, string wepaonchoice)
        {
            Console.WriteLine("{0} chose a {1}", name, wepaonchoice);
        }

        public void TakeAction(string name, string actionchoice)
        {
            Console.WriteLine("{0} used their {1}", name, actionchoice);
        }
    }
}
