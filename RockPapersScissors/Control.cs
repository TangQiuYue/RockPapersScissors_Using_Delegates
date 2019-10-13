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

        /* *************** CHECK PLAYER COUNTERS BEFORE MOVING ONTO COMPUTER PLAYERS ************ */
        Config config;
        private static int counterpl1 = 0;
        private static int counterpl2 = 0;
        private static  string winner = " ";
        private static string scoreBoard = "";
        private static int gameCounter = 0;
        private static string priorWinner = "";


        GeneralPlayer player1 = new GeneralPlayer(new HumanPlayer());

        public void WhoWins(Weapons weaponOne, Weapons weaponTwo)
        {
            Console.WriteLine(weaponOne.ToString() + " " + weaponTwo.ToString());
            int option = 0;
            if (weaponOne.Equals(weaponTwo))
            {
                option = 3;
            }
            if (weaponOne.Equals(Weapons.ROCK) && weaponTwo.Equals(Weapons.PAPER) || weaponOne.Equals(Weapons.PAPER) && weaponTwo.Equals(Weapons.PAPER) || weaponOne.Equals(Weapons.SCISSORS) && weaponTwo.Equals(Weapons.ROCK))
            {
                Config.lastWinningWeapon = weaponTwo;
                option = 1;
            }
            if (weaponOne.Equals(Weapons.ROCK) && weaponTwo.Equals(Weapons.SCISSORS) || weaponOne.Equals(Weapons.PAPER) && weaponTwo.Equals(Weapons.ROCK) || weaponOne.Equals(Weapons.SCISSORS) && weaponTwo.Equals(Weapons.PAPER))
            {
                Config.lastWinningWeapon = weaponOne;
                option = 2;
            }
            if (Counterpl1 == 2 || Counterpl2 == 2)
            {
                option = 4;
            }
            switch (option)
            {
                case 1: Counterpl2 += 1;
                    Winner = "Player 2 wins! ";
                    theWinnerIs();
                    break;
                case 2: Counterpl1 += 1;
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
            if (Counterpl1 == 2)
            {
                Winner = "Player 1";
            }
            else
            {
                Winner = "Player 2";
            }
            Counterpl1 = 0;
            Counterpl2 = 0;
            return ScoreBoard = "Winner is " + Winner + " Thanks for playing!";
        }
        public string theWinnerIs()
        {
            return ScoreBoard = Winner + "\n" + " Player One = " + Counterpl1 + " Player Two = " + Counterpl2;
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

        public static int Counterpl1
        {
            get
            {
                return counterpl1;
            }

            set
            {
                counterpl1 = value;
            }
        }

        public static int Counterpl2
        {
            get
            {
                return counterpl2;
            }

            set
            {
                counterpl2 = value;
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
