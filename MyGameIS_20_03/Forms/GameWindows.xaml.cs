using MyGameIS_20_03.Model;
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
    /// Логика взаимодействия для GameWindows.xaml
    /// </summary>
    public partial class GameWindows : Window
    {

        Model.Gamer Gamer;
        

        public GameWindows()
        {
            InitializeComponent();
            Gamer  = App.myGamer;
            gridInfoGamer.DataContext = Gamer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int age = Gamer.Age;
            Gamer.Age = age + 1;
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btWork_Click(object sender, RoutedEventArgs e)
        {
            Forms.WorkListWindows work = new WorkListWindows();
            work.ShowDialog();
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;

        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {

            Gamer newGame = new Gamer();
            newGame.Subject = Gamer.Subject;
            newGame.DateCreate = Gamer.DateCreate;
            newGame.Experience = Gamer.Experience;
            newGame.Age = Gamer.Age; 
            newGame.Work = Gamer.Work;

            App.myGamerList.Add(newGame);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();

        }
    }
}
