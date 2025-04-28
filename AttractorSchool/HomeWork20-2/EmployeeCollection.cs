using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork20_2
{
    internal class EmployeeCollection
    {
        public string[] EmployeesList { get; set; }

        //public Employee[] Employees { get; set; }

        public void PrintUsers()
        {
            Console.WriteLine("Номер  | ФИО  | Должность  | Год  ");
            Console.WriteLine("-------|------|------------|------");
            //foreach (var emp in Employees)
            {
                //Console.WriteLine($"{emp.Number}  | {emp.Name}  | {emp.Profession}  | {emp.Year}  ");
            }
        }

        public void CreateUsers(string[] list)
        {
            for (int i = 0; i <= list.Length; i++)
            {
                string[] props = list[i].Split(' ');

                //Employees[i] = Employee (num)
            }
        }

        public void Filter(string text)
        {
            Console.WriteLine("Номер  | ФИО  | Должность  | Год  ");
            Console.WriteLine("-------|------|------------|------");
            //sforeach (var emp in Employees)
            {
                //if (emp.Profession == text)
                //{
                //    Console.WriteLine($"{emp.Number}  | {emp.Name}  | {emp.Profession}  | {emp.Year}  ");
                //}
            }
        }
    }
}