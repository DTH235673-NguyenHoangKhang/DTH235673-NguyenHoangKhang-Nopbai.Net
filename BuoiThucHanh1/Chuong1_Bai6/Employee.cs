using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Employee
    {
        private int id;
        private string name;
        private int yearofbirth;
        private double salaryLevel;
        private double basicSalary;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int YearofBirth
        {
            get { return yearofbirth; }
            set { yearofbirth = value; }
        }
        public double SalaryLevel
        {
            get { return salaryLevel; }
            set { salaryLevel = value; }
        }
        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }

        }
        public void input()
        {
            Console.Write(" \t -Nhap ID:");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap ho ten:");
            Name = Console.ReadLine();
            Console.Write(" \t -Nhap nam sinh:");
            YearofBirth =Convert.ToInt32( Console.ReadLine());
            Console.Write(" \t -Nhap bac luong:");
            SalaryLevel = Convert.ToDouble(Console.ReadLine());
            BasicSalary = 2340000;
        }
        public void Display()
        {
                Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", ID, Name, YearofBirth, BasicSalary,this.GetIncome());
        }
        public double GetIncome()
        {
            return this.SalaryLevel * this.BasicSalary;
        }
    }
}
