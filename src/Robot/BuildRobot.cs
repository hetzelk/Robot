using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public abstract class BuildRobot
    {
        Arms armAdder;
        Legs legAdder;
        MotherBoard motherboardAdder;
        Body bodyAdder;
        Hardware hardwareAdder;

        public BuildRobot()
        {
            armAdder = new Arms();
            legAdder = new Legs();
            motherboardAdder = new MotherBoard();
            bodyAdder = new Body();
            hardwareAdder = new Hardware();
        }
        

        public void BuildBody(string name)
        {
            Console.WriteLine("Assembling the robot {0}", name);
            assembleBrain();
            assembleMainHardware();
            assembleBody();
            assembleArms();
            assembleLegs();
        }

        public void assembleArms()
        {
            armAdder.arms();
            armAdder.Operate();
        }

        public void assembleLegs()
        {
            legAdder.legs();
            legAdder.Operate();
        }
        
        public void assembleBrain()
        {
            motherboardAdder.brain();
            motherboardAdder.Operate();
        }

        public void assembleBody()
        {
            bodyAdder.body();
            bodyAdder.Operate();
        }

        public void assembleMainHardware()
        {
            hardwareAdder.hardware();
            hardwareAdder.Operate();
        }
    }
}
