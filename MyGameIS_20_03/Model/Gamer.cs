using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameIS_20_03.Model
{
    public class Gamer
    {
        public Gamer()
        {
            Experience = 1;
            Work = "Безработный";
            Money = 100;
            qualifications = "Без категории";
        }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public int Age { get; set; }
        public DateTime DateCreate { get; set; }
        public double Experience { get; set; }
        public string Work { get; set; }
        public double Money { get; set; }

        public string qualifications { get; set; }

    }
}
