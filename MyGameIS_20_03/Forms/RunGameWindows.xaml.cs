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
using System.Windows.Shapes;

namespace MyGameIS_20_03.Forms
{
    /// <summary>
    /// Логика взаимодействия для RunGameWindows.xaml
    /// </summary>
    public partial class RunGameWindows : Window
    {
        public RunGameWindows()
        {
            InitializeComponent();

            dtListGame.ItemsSource = App.myGamerList;
        }

        private void btRunGame_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer  = dtListGame.SelectedItem as Model.Gamer ;

            GameWindows gameWindows = new GameWindows();
            gameWindows.Show();
            Close();
        }
    }
}
