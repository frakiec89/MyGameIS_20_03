using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyGameIS_20_03
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Model.Gamer myGamer; 
        public static  List< Model.Gamer>  myGamerList  = new List<Model.Gamer>();

    }
}
