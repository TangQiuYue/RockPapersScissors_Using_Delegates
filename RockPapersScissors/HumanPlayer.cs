using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
    class HumanPlayer : PlayerInterface
    {
        private Weapons weapon;

        public Weapons chooseYourWeapon()
        {
            return weapon;
        }

        public string getBehavior()
        {
            return Config.humanBehavior;
        }
    }
}
