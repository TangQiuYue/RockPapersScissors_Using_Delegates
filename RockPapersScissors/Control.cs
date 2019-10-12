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
        private  static int counterpl1 = 0;
        private static int counterpl2 = 0;
        private static  string winner = " ";
        private static string scoreBoard = "";
        private static int gameCounter = 0;
        private static string priorWinner = "";

        public string playerIsRandomComputer()
        {
            string weapon = "";
            Random rando = new Random();
            int i = rando.Next(1, 3);

            switch (i)
            {
                case 1: weapon = "Rock";
                    break;
                case 2: weapon = "Paper";
                    break;
                case 3: weapon = "Scissors";
                    break;
            }

            return weapon;
        }
        public string playerIsTacticalComputer()
        {
            string weapon = "";
            if (gameCounter == 0)
            {
               weapon = playerIsRandomComputer();
            }
            if(gameCounter > 0)
            {
                switch (priorWinner)
                {
                    case "Rock":weapon = "Paper";
                        break;
                    case "Paper": weapon = "Scissors";
                        break;
                    case "Scissors": weapon = "Rock";
                        break;
                }
            }
            gameCounter++;
            return weapon;
        }
        public void WhoWins(string weaponOne, string weaponTwo)
        {
            Console.WriteLine(weaponOne + " and " + weaponTwo);
            int option = 0;
            if (weaponOne.Equals(weaponTwo))
            {
                option = 3;
            }
            if (weaponOne.Equals("Rock") && weaponTwo.Equals("Paper") || weaponOne.Equals("Paper") && weaponTwo.Equals("Scissors") || weaponOne.Equals("Scissors") && weaponTwo.Equals("Rock"))
            {
                priorWinner = weaponTwo;
                option = 1;
            }
            if (weaponOne.Equals("Rock") && weaponTwo.Equals("Scissors") || weaponOne.Equals("Paper") && weaponTwo.Equals("Rock") || weaponOne.Equals("Scissors") && weaponTwo.Equals("Paper"))
            {
                priorWinner = weaponOne;
                option = 2;
            }
            // This can be refactored to == 3 in order to make a best out of 5
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
