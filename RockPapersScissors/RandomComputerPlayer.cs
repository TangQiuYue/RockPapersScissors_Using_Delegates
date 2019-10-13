using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
    class RandomComputerPlayer : PlayerInterface
       
    {
        private Weapons weapon;
        public Weapons chooseYourWeapon()
        {

            Random rando = new Random();
            int i = rando.Next(1, 3);

            switch (i)
            {
                case 1:
                    weapon = Weapons.ROCK;

                    break;
                case 2:
                    weapon = Weapons.PAPER;
                    break;
                case 3:
                    weapon = Weapons.SCISSORS;
                    break;
            }

            return weapon;
        }
              public string getBehavior()
        {
            return Config.randomBehavior;
        }
    }
}
