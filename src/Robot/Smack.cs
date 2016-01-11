using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot
{
    public class Smack
    {
        public string SmackTalk(int smackinput)
        {
            if (smackinput == 1)
            {
                return "You couldn't hit the side of a barn";
            }

            if (smackinput == 2)
            {
                return "Look who hit the side of your face";
            }

            if (smackinput == 3)
            {
                return "You're weak";
            }

            if (smackinput == 4)
            {
                return "You should take that back, I won";
            }

            if (smackinput == 5)
            {
                return "You're gonna die";
            }

            if (smackinput == 6)
            {
                return "You just died. Shut up";
            }
            return "You couldn't hit the side of a barn";
        }
    }
}
