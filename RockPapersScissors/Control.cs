using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
    class Control 
    {
        
        Config config = Config.getConfig();

        private static  string winner = " ";
        private static string scoreBoard = "";


        GeneralPlayer player1 = new GeneralPlayer(new HumanPlayer());

        public void WhoWins(Weapons weaponOne, Weapons weaponTwo)
        {
            Console.WriteLine(weaponOne + " " + weaponTwo);
            int option = 0;
            if (weaponOne.Equals(weaponTwo))
            {
                option = 3;
            }
            if (weaponOne.Equals(Weapons.ROCK) && weaponTwo.Equals(Weapons.PAPER) || weaponOne.Equals(Weapons.PAPER) && weaponTwo.Equals(Weapons.SCISSORS) || weaponOne.Equals(Weapons.SCISSORS) && weaponTwo.Equals(Weapons.ROCK))
            {
                Config.getConfig().LastWinningWeapon = weaponTwo;
                option = 1;
            }
            if (weaponOne.Equals(Weapons.ROCK) && weaponTwo.Equals(Weapons.SCISSORS) || weaponOne.Equals(Weapons.PAPER) && weaponTwo.Equals(Weapons.ROCK) || weaponOne.Equals(Weapons.SCISSORS) && weaponTwo.Equals(Weapons.PAPER))
            {
                Config.getConfig().LastWinningWeapon = weaponOne;
                option = 2;
            }
            if  (Config.getConfig().Counterpl1 == 2 || Config.getConfig().Counterpl2 == 2)
            {
                option = 4;
            }
            switch (option)
            {
                case 1:
                    config.Counterpl2 += 1;
                    Winner = "Player 2 wins! ";
                    theWinnerIs();
                    break;
                case 2:
                    config.Counterpl1 += 1;
                    Winner = "Player 1 wins! ";
                    theWinnerIs();
                    break;
                case 3: Winner = "No winner! ";
                    theWinnerIs();
                    break;
                case 4: thanksForPlaying();
                    break;
            }
           
            Winner = "";
        }
        public string thanksForPlaying()
        {
            if (config.Counterpl1 == 2)
            {
                Winner = "Player 1";
            }
            else
            {
                Winner = "Player 2";
            }
            config.Counterpl1 = 0;
            config.Counterpl2 = 0;
            return ScoreBoard = "Winner is " + Winner + " Thanks for playing!";
        }
        public string theWinnerIs()
        {
            return ScoreBoard = Winner + "\n" + " Player One = " + config.Counterpl1 + " Player Two = " + config.Counterpl2;
        }
        public string ScoreBoard
        {
            get
            {
                return scoreBoard;
            }

            set
            {
                scoreBoard = value;
            }
        }


        public static string Winner
        {
            get
            {
                return winner;
            }

            set
            {
                winner = value;
            }
        }
    }
}
