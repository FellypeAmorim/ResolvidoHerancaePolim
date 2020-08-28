using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvidoHerEPoli
{
    class OutsourcedEmployee : Employee
    {
        public double Additionalcharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valueperhour, double additionalcharge) : base(name, hours, valueperhour)
        {
            Additionalcharge = additionalcharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * Additionalcharge;
        }
    }
}
