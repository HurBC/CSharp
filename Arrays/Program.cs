using System; 

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[5];

            int[] y = { 1, 2, 3, 4, 5, 6 };

            var allString = new[] { "Franco", "Carrasco", "chile" };

            var allInt = new[] { 1, 2, 3, 4, 5, 6, 7 };

            var allDouble = new[] { 1, 3, 4, 2.5 };

            Employee Tyler = new Employee("Tyler", 34);

            Employee[] employees = new Employee[2];

            employees[0] = new Employee("Josh", 35);

            employees[1] = Tyler;

            Data(allInt);

            foreach(Employee i in employees)
            {
                Console.WriteLine(i.Name);
            }

        }

        static void Data(int[] datos)
        {
            foreach(int i in datos)
            {
                Console.WriteLine(i);
            }
        }
        
        class Employee
        {

            public Employee(string name, int age)
            {

                Name = name;

                Age = age; 
            }

            public string Name;

            public int Age;
        }

    }
}