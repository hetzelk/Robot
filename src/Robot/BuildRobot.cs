using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public abstract class BuildRobot
    {
        Arms armAdder = new Arms();
        Legs legAdder = new Legs();
        MotherBoard motherboardAdder = new MotherBoard();
        Body bodyAdder = new Body();
        Hardware hardwareAdder = new Hardware();

        public void buildBody()
        {
            assembleArms();
            assembleLegs();
            assembleBrain();
            assembleBody();
            assembleMainHardware();
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
