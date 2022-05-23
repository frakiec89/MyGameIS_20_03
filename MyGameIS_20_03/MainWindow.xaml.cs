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

namespace MyGameIS_20_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btRunGame_Click(object sender, RoutedEventArgs e)
        {
            Forms.RunGameWindows windows = new Forms.RunGameWindows();
            windows.Show();
            Close();
        }

        private void btNewGame_Click(object sender, RoutedEventArgs e)
        {
            Forms.NewGameWindows windows = new Forms.NewGameWindows();
            windows.Show();
            Close();
        }
    }
}
