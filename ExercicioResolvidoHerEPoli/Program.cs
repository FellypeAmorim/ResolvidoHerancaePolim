using System;
using System.Collections.Generic;

namespace ExercicioResolvidoHerEPoli
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();


            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee {i} data:");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine());

                if (resp == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalcharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valueperhour, additionalcharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueperhour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + " - R$" + employee.Payment().ToString("F2"));
            }
       
        }
    }
}
