using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RockPapersScissors
{
    /// <summary>
    /// Logique d'interaction pour HumanVsHuman.xaml
    /// </summary>
    public partial class HumanVsHuman : Window
    {
        Control controller;
        Config config = Config.getConfig();
        public static string firstPlayerWeapon;
        public HumanVsHuman()
        {
            InitializeComponent();
            controller = new Control();
            setPlayerOneBehavior();
            setPlayerTwoBehavior();
            lockPlay();
        }
        public void setPlayerOneBehavior()
        {
           config.PlayerOne = new HumanPlayer();
            if (((MainWindow)Application.Current.MainWindow).comboBoxOne.SelectedIndex == config.ComboSelectionRandom) {
                config.PlayerOne = new RandomComputerPlayer();
            }
            
            if(((MainWindow)Application.Current.MainWindow).comboBoxOne.SelectedIndex == config.ComboSelectionTactical)
            {
                config.PlayerOne = new TacticalComputerPlayer();
            }
        }
        public void setPlayerTwoBehavior()
        {

            config.PlayerTwo = new HumanPlayer();
            if (((MainWindow)Application.Current.MainWindow).comboBoxTwo.SelectedIndex == config.ComboSelectionRandom)
            {
                config.PlayerTwo = new RandomComputerPlayer();
            }

            if (((MainWindow)Application.Current.MainWindow).comboBoxTwo.SelectedIndex == config.ComboSelectionTactical)
            {
                config.PlayerTwo = new TacticalComputerPlayer();
            }
        }
        public void lockPlay()
        {
            if (config.PlayerOne.getBehavior().Equals(config.RandomBehavior) || config.PlayerOne.getBehavior() == config.TacticalBehavior)
            {
                rockBtn.IsEnabled = false;
                paperBtn.IsEnabled = false;
                scissorsBtn.IsEnabled = false;

            }
            if (config.PlayerTwo.getBehavior() == config.RandomBehavior || config.PlayerTwo.getBehavior() == config.TacticalBehavior)
            {
                rockTwoBtn.IsEnabled = false;
                paperTwoBtn.IsEnabled = false;
                scissorsTwoBtn.IsEnabled = false;
            }
        }
        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
            selectRandoWeapon();
            controller.WhoWins(config.PlayerOneWeapon, config.PlayerTwoWeapon);
            MessageBox.Show(controller.ScoreBoard.ToString());
            clearWeapon();
            clearBorders();
        }
    
        private void weaponPlayerOne(Weapons weapon)
        {
            if (config.PlayerOne.getBehavior().Equals(config.HumanBehavior))
                config.PlayerOneWeapon = weapon;
        }
        private void selectRandoWeapon()
        {
            if (!config.PlayerOne.getBehavior().Equals(config.HumanBehavior))
                config.PlayerOneWeapon = config.PlayerOne.chooseYourWeapon();
            if (!config.PlayerTwo.getBehavior().Equals(config.HumanBehavior))
                config.PlayerTwoWeapon = config.PlayerTwo.chooseYourWeapon();
        }
        private void clearWeapon()
        {
            config.PlayerOneWeapon = Weapons.NONE;
            config.PlayerTwoWeapon = Weapons.NONE;
        }

        private void rockBtn_Click(object sender, RoutedEventArgs e)
        {
            rockBtn.BorderThickness = new Thickness(3);
            rockBtn.BorderBrush = Brushes.Red;
            clearScissorsAndPaperBorder();
            weaponPlayerOne(Weapons.ROCK);
        }

        private void paperBtn_Click(object sender, RoutedEventArgs e)
        {
            paperBtn.BorderThickness = new Thickness(3);
            paperBtn.BorderBrush = Brushes.Red;
            clearRockAndScissorsBorder();
            weaponPlayerOne(Weapons.PAPER);
        }

        private void scissorsBtn_Click(object sender, RoutedEventArgs e)
        {
            scissorsBtn.BorderThickness = new Thickness(3);
            scissorsBtn.BorderBrush = Brushes.Red;
            clearPaperAndRockBorder();
            weaponPlayerOne(Weapons.SCISSORS);
        }
        private void weaponPlayerTwo(Weapons weapon)
        {
            if (config.PlayerTwo.getBehavior().Equals(config.HumanBehavior))
            {
                config.PlayerTwoWeapon = weapon;
            }
        }
        private void rockTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            rockTwoBtn.BorderThickness = new Thickness(3);
            rockTwoBtn.BorderBrush = Brushes.Red;
            clearScissorsAndPaperTwoBorder();
            weaponPlayerTwo(Weapons.ROCK);
        }

        private void paperTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            paperTwoBtn.BorderThickness = new Thickness(3);
            paperTwoBtn.BorderBrush = Brushes.Red;
            clearRockAndScissorsTwoBorder();
            weaponPlayerTwo(Weapons.PAPER);
        }

        private void scissorsTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            scissorsTwoBtn.BorderThickness = new Thickness(3);
            scissorsTwoBtn.BorderBrush = Brushes.Red;
            clearPaperAndRockTwoBorder();
            weaponPlayerTwo(Weapons.SCISSORS);
        }
        private void clearBorders()
        {
            rockBtn.BorderThickness = new Thickness(0);
            scissorsBtn.BorderThickness = new Thickness(0);
            paperBtn.BorderThickness = new Thickness(0);

            rockTwoBtn.BorderThickness = new Thickness(0);
            scissorsTwoBtn.BorderThickness = new Thickness(0);
            paperTwoBtn.BorderThickness = new Thickness(0);
        }
        private void clearRockAndScissorsBorder()
        {
            rockBtn.BorderThickness = new Thickness(0);
            scissorsBtn.BorderThickness = new Thickness(0);
        }
        private void clearRockAndScissorsTwoBorder()
        {
            rockTwoBtn.BorderThickness = new Thickness(0);
            scissorsTwoBtn.BorderThickness = new Thickness(0);
        }
        private void clearScissorsAndPaperBorder()
        {
            scissorsBtn.BorderThickness = new Thickness(0);
            paperBtn.BorderThickness = new Thickness(0);
        }
        private void clearScissorsAndPaperTwoBorder()
        {
            scissorsTwoBtn.BorderThickness = new Thickness(0);
            paperTwoBtn.BorderThickness = new Thickness(0);
        }
        private void clearPaperAndRockBorder()
        {
            paperBtn.BorderThickness = new Thickness(0);
            rockBtn.BorderThickness = new Thickness(0);
        }
        private void clearPaperAndRockTwoBorder()
        {
            paperTwoBtn.BorderThickness = new Thickness(0);
            rockTwoBtn.BorderThickness = new Thickness(0);
        }
  }
}
