using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
    class GeneralPlayer : PlayerInterface
    {

        // If implementing new types of players, this would permit easily seeting up new players.
        //this is currently unused.
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
