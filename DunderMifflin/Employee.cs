using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DunderMifflin
{
    class Employee
    {

        public Employee(string names, int age, string departament, string branch)
        {

            string[] fullName = names.Split(' ');

            _fName = fullName[0];

            _mName = fullName[1];

            _lName = fullName[2];

            _age = age;

            _department = departament;

            i_salary = Branches.i_s_getSalary(departament);

            i_branch = Branches.i_s_getBranch(branch);

            i_s_employees++;

        }

        public void GetInfo()
        {
            Console.Clear();

            int TotalWidth = 45;

            int padding = (TotalWidth - FName.Length - 4) / 2;

            string center = FName.PadLeft(FName.Length + padding).PadRight(TotalWidth - 4);

            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine($"| {center} |");
            Console.WriteLine("+-----------+-------------------------------+");
            Console.WriteLine($"|   ID:    |             {i_id}            |");
            Console.WriteLine($"|  Edad:   |             {_age}            |");
            Console.WriteLine($"|  Dept:   |        {_department}          |");

        }

        internal static int i_s_employees = 0;

        private string _fName;

        private string _mName;

        private string _lName;

        private int _age;

        private string _department;

        internal int i_id;

        internal double i_salary = 0;

        internal int i_branch = 0;

        public string Name
        {
            get { return $"{_fName} {_lName}"; }
        }

        public string FName
        {
            get { return $"{_fName} {_mName} {_lName}"; }
        }
    }
}
