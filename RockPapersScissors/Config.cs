using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
   public class Config 
    {
        //Used so that I can only have one instacne of config at any given time
        private static Config instance = new Config();
        private Weapons lastWinningWeapon;
        private int currentTurn = 0;
        private int comboSelectionRandom = 1;
        private int comboSelectionTactical = 2;
        private string humanBehavior = "Human Behavior";
        private string randomBehavior = "Random Behavior";
        private string tacticalBehavior = "Tacitcal Behavior";
        private PlayerInterface playerOne;
        private PlayerInterface playerTwo;
        private Weapons playerOneWeapon;
        private Weapons playerTwoWeapon;
        private int counterpl1 = 0;
        private int counterpl2 = 0;
        private string winner;
        private Random rando = new Random();

        private Config()
        {

        }
        public static Config getConfig()
        {
            return instance;
        }

        public Weapons LastWinningWeapon
        {
            get
            {
                return lastWinningWeapon;
            }

            set
            {
                lastWinningWeapon = value;
            }
        }

        public int CurrentTurn
        {
            get
            {
                return currentTurn;
            }

            set
            {
                currentTurn = value;
            }
        }

        public int ComboSelectionRandom
        {
            get
            {
                return comboSelectionRandom;
            }

            set
            {
                comboSelectionRandom = value;
            }
        }

        public int ComboSelectionTactical
        {
            get
            {
                return comboSelectionTactical;
            }

            set
            {
                comboSelectionTactical = value;
            }
        }

        public string HumanBehavior
        {
            get
            {
                return humanBehavior;
            }

            set
            {
                humanBehavior = value;
            }
        }

        public string RandomBehavior
        {
            get
            {
                return randomBehavior;
            }

            set
            {
                randomBehavior = value;
            }
        }

        public string TacticalBehavior
        {
            get
            {
                return tacticalBehavior;
            }

            set
            {
                tacticalBehavior = value;
            }
        }

        public PlayerInterface PlayerOne
        {
            get
            {
                return playerOne;
            }

            set
            {
                playerOne = value;
            }
        }

        public PlayerInterface PlayerTwo
        {
            get
            {
                return playerTwo;
            }

            set
            {
                playerTwo = value;
            }
        }

        public Weapons PlayerOneWeapon
        {
            get
            {
                return playerOneWeapon;
            }

            set
            {
                playerOneWeapon = value;
            }
        }

        public Weapons PlayerTwoWeapon
        {
            get
            {
                return playerTwoWeapon;
            }

            set
            {
                playerTwoWeapon = value;
            }
        }

        public int Counterpl1
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

        public int Counterpl2
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

        public string Winner
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

        public Random Rando
        {
            get
            {
                return rando;
            }

            set
            {
                rando = value;
            }
        }
    }
}
