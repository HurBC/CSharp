namespace PropertiesEnuum
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("Propiedades:");

            //Propiedades
            Employee Franco = new Employee("Franco", Bonus.Extra, 1200);

            Franco.SALARY = 1200;

            Console.WriteLine("Salario sin bonus: {0}", Franco.SALARY - 1200);

            Console.WriteLine("Salario con bonus: {0}",Franco.SALARY);

            Console.WriteLine();

            Console.WriteLine("Enum:");

            //Enum
            Bonus Antonio = Bonus.Bajo;

            double BonusAntonio = (double)Antonio;

            Console.WriteLine("Tipo de bonus: " + Antonio);

            Console.WriteLine("Valor del bonus: {0}", BonusAntonio);

        }
    }

    class Employee
    {

        public Employee(string name , Bonus bonusEmployee, double salary)
        {

            _name = name;

            SALARY = salary;

            _bonus = (double)bonusEmployee;

        }

        private double _verSalary(double salary )
        {

            if (salary < 0) return 0;

            else return salary + _bonus;

        }

        private string _name;

        private double _salary, _bonus;

        //propiedad
        public double SALARY
        {

            //Escritura
            get => _salary;

            //Lectura
            set => _salary = _verSalary(value);

        }
    }

    enum Bonus { Bajo=500, Normal=1000, Bueno=1500, Extra=2000 };
}