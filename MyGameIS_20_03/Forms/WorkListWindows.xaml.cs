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
    /// Логика взаимодействия для WorkListWindows.xaml
    /// </summary>
    public partial class WorkListWindows : Window
    {
        public WorkListWindows()
        {
            InitializeComponent();

            List<Model.Work> works = new List<Model.Work>
            {
                 new Model.Work{ Name ="Учитель  в  сельской школе "  , minqualifications=1 , salary=100} ,
                 new Model.Work{ Name ="Зауч   в  сельской школе "  , minqualifications=10 , salary=120} ,
                 new Model.Work{ Name ="Профессор  в  Оксфорде "  , minqualifications=25000 , salary=120000} ,
            };

            listWork.ItemsSource = works;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Work  work = listWork.SelectedItem as Work;

            if(work.minqualifications <= App.myGamer.Experience)
            {
                App.myGamer.Work = work.Name;
                Close();
            }
            else
            {
                MessageBox.Show("Вы не  можете  занять эту должность ");
            }

        }
    }
}
