using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public class Name
    {
        public string askForName(int number)
        {
            Console.WriteLine("Robot {0} what is your name?", number);
            string name = Console.ReadLine();
            return name;
        }
    }
}
