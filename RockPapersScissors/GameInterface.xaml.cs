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
            lockPlay();
        }
        public bool IsPlayOneComputer()
        {
            bool isComputer = false;
           if(((MainWindow)Application.Current.MainWindow).comboBoxOne.SelectedIndex == 1 || ((MainWindow)Application.Current.MainWindow).comboBoxOne.SelectedIndex == 2)
            {
                isComputer = true;
            }
            return isComputer;
        }
        public bool isPlayerTwoComputer()
        {
            bool isComputer = false; 
            if (((MainWindow)Application.Current.MainWindow).comboBoxTwo.SelectedIndex == 1 || ((MainWindow)Application.Current.MainWindow).comboBoxTwo.SelectedIndex == 2)
            {
                isComputer = true;
            }
            return isComputer;
        }
        public void lockPlay()
        {
           
            if (IsPlayOneComputer())
            {
                rockBtn.IsEnabled = false;
                paperBtn.IsEnabled = false;
                scissorsBtn.IsEnabled = false;
            }
            if (isPlayerTwoComputer())
            {
                rockTwoBtn.IsEnabled = false;
                paperTwoBtn.IsEnabled = false;
                scissorsTwoBtn.IsEnabled = false;
            }
        }
        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsPlayOneComputer())
            {
                weaponLbl.Content = whosPlayingPlayerOne();
            }

            controller.WhoWins(weaponLbl.Content.ToString(), weaponTwoLbl.Content.ToString());
            MessageBox.Show(controller.ScoreBoard.ToString());
        }
        private string whosPlayingPlayerOne()
        {
            if (((MainWindow)Application.Current.MainWindow).comboBoxOne.SelectedIndex == 1)
            {
                weaponLbl.Content = controller.playerIsRandomComputer();
            }
            if (((MainWindow)Application.Current.MainWindow).comboBoxOne.SelectedIndex == 2)
            {
                weaponLbl.Content = controller.playerIsTacticalComputer();
            }
            return weaponLbl.Content.ToString();
        }
        private void weaponPlayerOne(string weapon)
        {
            firstPlayerWeapon = weapon;
        }

        private void rockBtn_Click(object sender, RoutedEventArgs e)
        {
            rockBtn.BorderThickness = new Thickness(3);
            rockBtn.BorderBrush = Brushes.Red;
            clearScissorsAndPaperBorder();
            weaponLbl.Content = "Rock";
            weaponPlayerOne(weaponLbl.Content.ToString());
        }

        private void paperBtn_Click(object sender, RoutedEventArgs e)
        {
            paperBtn.BorderThickness = new Thickness(3);
            paperBtn.BorderBrush = Brushes.Red;
            clearRockAndScissorsBorder();
            weaponLbl.Content = "Paper";
            weaponPlayerOne(weaponLbl.Content.ToString());
        }

        private void scissorsBtn_Click(object sender, RoutedEventArgs e)
        {
            scissorsBtn.BorderThickness = new Thickness(3);
            scissorsBtn.BorderBrush = Brushes.Red;
            clearPaperAndRockBorder();
            weaponLbl.Content = "Scissors";
            weaponPlayerOne(weaponLbl.Content.ToString());
        }

        private void rockTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            rockTwoBtn.BorderThickness = new Thickness(3);
            rockTwoBtn.BorderBrush = Brushes.Red;
            clearScissorsAndPaperTwoBorder();
            weaponTwoLbl.Content = "Rock";
        }

        private void paperTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            paperTwoBtn.BorderThickness = new Thickness(3);
            paperTwoBtn.BorderBrush = Brushes.Red;
            clearRockAndScissorsTwoBorder();
            weaponTwoLbl.Content = "Paper";
        }

        private void scissorsTwoBtn_Click(object sender, RoutedEventArgs e)
        {
            scissorsTwoBtn.BorderThickness = new Thickness(3);
            scissorsTwoBtn.BorderBrush = Brushes.Red;
            clearPaperAndRockTwoBorder();
            weaponTwoLbl.Content = "Scissors";
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
