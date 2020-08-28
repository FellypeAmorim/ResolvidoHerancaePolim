using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvidoHerEPoli
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double Valueperhour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valueperhour)
        {
            Name = name;
            Hours = hours;
            Valueperhour = valueperhour;
        }

        public virtual double Payment()
        {
            return Hours * Valueperhour;
        }

   
    }
}
