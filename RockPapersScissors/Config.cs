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
        public static Weapons lastWinningWeapon;
        public static int currentTurn = 0;
        public static int comboSelectionRandom = 1;
        public static int comboSelectionTactical = 2;
        public static string humanBehavior = "Human Behavior";
        public static string randomBehavior = "Random Behavior";
        public static string tacticalBehavior = "Tacitcal Behavior";
        public static PlayerInterface playerOne;
        public static PlayerInterface playerTwo;
        public static Weapons playerOneWeapon;
        public static Weapons playerTwoWeapon;

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

        private Config()
        {
          
        }
        public static Config getConfig()
        {
            return instance;
        }
        
    }
}
