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
            Config.playerOne = new HumanPlayer();
            if (((MainWindow)Application.Current.MainWindow).comboBoxOne.SelectedIndex == Config.comboSelectionRandom) {
                Config.playerOne = new RandomComputerPlayer();
            }
            
            if(((MainWindow)Application.Current.MainWindow).comboBoxOne.SelectedIndex == Config.comboSelectionTactical)
            {
                Config.playerOne = new TacticalComputerPlayer();
            }
        }
        public void setPlayerTwoBehavior()
        {

            Config.playerTwo = new HumanPlayer();
            if (((MainWindow)Application.Current.MainWindow).comboBoxTwo.SelectedIndex == Config.comboSelectionRandom)
            {
                Config.playerTwo = new RandomComputerPlayer();
            }

            if (((MainWindow)Application.Current.MainWindow).comboBoxTwo.SelectedIndex == Config.comboSelectionTactical)
            {
                Config.playerTwo = new TacticalComputerPlayer();
            }
        }
        public void lockPlay()
        {
            if (Config.playerOne.getBehavior().Equals(Config.randomBehavior) || Config.playerOne.getBehavior() == Config.tacticalBehavior)
            {
                rockBtn.IsEnabled = false;
                paperBtn.IsEnabled = false;
                scissorsBtn.IsEnabled = false;
            }
            if (Config.playerTwo.getBehavior() == Config.randomBehavior || Config.playerTwo.getBehavior() == Config.tacticalBehavior)
            {
                rockTwoBtn.IsEnabled = false;
                paperTwoBtn.IsEnabled = false;
                scissorsTwoBtn.IsEnabled = false;
            }
        }
        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
            controller.WhoWins(Config.playerOneWeapon, Config.playerTwoWeapon);
            MessageBox.Show(controller.ScoreBoard.ToString());
        }
    
        private void weaponPlayerOne(Weapons weapon)
        {
            MessageBox.Show(Config.playerOne.getBehavior().ToString() + " " + Config.humanBehavior);
            if (Config.playerOne.getBehavior().Equals(Config.humanBehavior))
                Config.playerOneWeapon = weapon;
                MessageBox.Show(weapon.ToString());
        }

        private void rockBtn_Click(object sender, RoutedEventArgs e)
        {
            rockBtn.BorderThickness = new Thickness(3);
            rockBtn.BorderBrush = Brushes.Red;
            clearScissorsAndPaperBorder();
            weaponLbl.Content = "Rock";
            weaponPlayerOne(Weapons.ROCK);
        }

        private void paperBtn_Click(object sender, RoutedEventArgs e)
        {
            paperBtn.BorderThickness = new Thickness(3);
            paperBtn.BorderBrush = Brushes.Red;
            clearRockAndScissorsBorder();
            weaponLbl.Content = "Paper";
            weaponPlayerOne(Weapons.PAPER);
        }

        private void scissorsBtn_Click(object sender, RoutedEventArgs e)
        {
            scissorsBtn.BorderThickness = new Thickness(3);
            scissorsBtn.BorderBrush = Brushes.Red;
            clearPaperAndRockBorder();
            weaponLbl.Content = "Scissors";
            weaponPlayerOne(Weapons.SCISSORS);
        }
        private void weaponPlayerTwo(Weapons weapon)
        {
            if (Config.playerTwo.getBehavior().Equals(Config.humanBehavior))
                Config.playerTwoWeapon = weapon;
            MessageBox.Show(weapon.ToString());
        }
        private void rockTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            rockTwoBtn.BorderThickness = new Thickness(3);
            rockTwoBtn.BorderBrush = Brushes.Red;
            clearScissorsAndPaperTwoBorder();
            weaponTwoLbl.Content = "Rock";
            weaponPlayerTwo(Weapons.ROCK);
        }

        private void paperTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            paperTwoBtn.BorderThickness = new Thickness(3);
            paperTwoBtn.BorderBrush = Brushes.Red;
            clearRockAndScissorsTwoBorder();
            weaponTwoLbl.Content = "Paper";
            weaponPlayerTwo(Weapons.PAPER);
        }

        private void scissorsTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            scissorsTwoBtn.BorderThickness = new Thickness(3);
            scissorsTwoBtn.BorderBrush = Brushes.Red;
            clearPaperAndRockTwoBorder();
            weaponTwoLbl.Content = "Scissors";
            weaponPlayerTwo(Weapons.SCISSORS);
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
