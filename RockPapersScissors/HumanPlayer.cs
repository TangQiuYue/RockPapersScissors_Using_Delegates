using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
    class HumanPlayer : PlayerInterface
    {
        Config config = Config.getConfig();
        private Weapons weapon;

        public Weapons chooseYourWeapon()
        {
            return weapon;
        }

        public string getBehavior()
        {
            return config.HumanBehavior;
        }
    }
}
