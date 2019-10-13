using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
    class RandomComputerPlayer : PlayerInterface   
    {
        Config config = Config.getConfig();
        private Weapons weapon;
        public Weapons chooseYourWeapon()
        {
           
            int i = config.Rando.Next(1, 3);

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
            Console.WriteLine(i);
            return weapon;
        }
              public string getBehavior()
        {
            return config.RandomBehavior;
        }
    }
}
