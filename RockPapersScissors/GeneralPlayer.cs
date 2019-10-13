using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
    class GeneralPlayer : PlayerInterface
    {
        private PlayerInterface behavior;

        public GeneralPlayer(PlayerInterface behavior)
        {
            this.behavior = behavior;
        }

        public Weapons chooseYourWeapon()
        {
            return this.behavior.chooseYourWeapon();
        }

        public string getBehavior()
        {
            return this.behavior.getBehavior();
        }
    }
   
}
