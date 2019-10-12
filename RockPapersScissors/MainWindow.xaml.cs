using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RockPapersScissors
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Players playerList;
        private Control controler;

        public MainWindow()
        {
            InitializeComponent();
            playerList = new Players();
            controler = new Control();
            this.DataContext = controler;
            comboBoxOne.ItemsSource = playerList.addPlayers();
            comboBoxTwo.ItemsSource = playerList.addPlayers();
        }

        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
                HumanVsHuman gamePage = new HumanVsHuman();
                gamePage.ShowDialog();
        }    

    }
}
