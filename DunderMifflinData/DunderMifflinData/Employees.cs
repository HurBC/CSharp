using System;

namespace DunderMifflin
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _position;

        internal int i_salary;
        internal int i_id;


        public string Name
        {
            get { return _firstName + ' ' + _lastName; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value >= 20 ? value : 0; }
        }

        public string Position
        {
            get { return _position; }

        }

        public Employee(string name, int age, string position)
        {
            string[] fullName = name.Split(' ');
            Age = age;
            _position = position;

            if(fullName.Length == 2)
            {
                _firstName = fullName[0];
                _lastName = fullName[1];
            }

        }

        internal void getInfo()
        {
            Console.WriteLine("Info del empleado numero {0}", i_id);

            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Edad: {_age}");
            Console.WriteLine($"Posición en la empresa: {_position}");
            Console.WriteLine($"Salario actual: {i_salary}");

        }
    }
}
