using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_4
{
    class Personcs
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Mail { get; set; }
        public int Nomber { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }

        public Personcs(string Name_1, string Position_1, string Mail_1, int Nomber_1, double Salary_1, int Age_1)
        {
            Name = Name_1;
            Position = Position_1;
            Mail = Mail_1;
            Nomber = Nomber_1;
            Salary = Salary_1;
            Age = Age_1;

        }

        public void Info()
        {
            Console.WriteLine($"{Name}\n{Position}\n{Mail}\n{Nomber}\n{Salary}\n{Age}");
        }

    }
}
