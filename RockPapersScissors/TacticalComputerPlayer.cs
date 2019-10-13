using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
    class TacticalComputerPlayer : PlayerInterface
    {
        private static Weapons weapon;

        public Weapons chooseYourWeapon()
        {
            if (Config.currentTurn == 0)
            {
                weapon = randomCall();
            }
            else 
            {
                switch (Config.lastWinningWeapon)
                {
                    case Weapons.ROCK:
                        weapon = Weapons.PAPER;
                        break;
                    case Weapons.PAPER:
                        weapon = Weapons.SCISSORS;
                        break;
                    case Weapons.SCISSORS:
                        weapon = Weapons.ROCK;
                        break;
                }
            }
            Config.currentTurn++;
            return weapon;
        }

        Weapons randomCall()
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
            return Config.tacticalBehavior;
        }

    }
}
