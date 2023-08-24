namespace Genericos
{

    interface IEmpleados
    {

        double GetSalary();

    }

    class Program
    {
        static void Main( string[] args )
        {
            AlmacenarEmpleados<Director> Empleado = new AlmacenarEmpleados<Director>(3);

            Empleado.Agregar( new Director( 4500 ) );

            Empleado.Agregar( new Director( 1500 ) );

            Empleado.Agregar( new Director( 2500 ) );

            /*
             * Esto dara error ya que estudiante no tiene implementado la interfaz
            AlmacenarEmpleados<Estudiante> Empleado = new AlmacenarEmpleados<Estudiante>(3);
            */
        }
    }

    //Clase generica (Puede guardar cualquier tipo de datos
    //Where es un filtro para que solo se guarden las clases que tengan la interfaz
    class AlmacenarEmpleados<T> where T : IEmpleados
    {

        public AlmacenarEmpleados( int x )
        {

            _datosEmpleado = new T[x];

        }

        public void Agregar( T obj )
        {

            _datosEmpleado[_i] = obj;

            _i++;

        }

        public T GetEmpleado( int i )
        {

            return _datosEmpleado[i];

        }

        private int _i = 0;

        private T[] _datosEmpleado;
    }

    //clases NO genericas
    class Director : IEmpleados
    {

        public Director( double salario )
        {

            _salario = salario;

        }

        public double GetSalary()
        {
            return _salario;
        }

        private double _salario;
    }

    class Secretaria : IEmpleados
    {

        public Secretaria( double salario )
        {

            _salario = salario;

        }

        public double GetSalary()
        {
            return _salario;
        }

        private double _salario;
    }

    class Electricista : IEmpleados
    {

        public Electricista( double salario )
        {

            _salario = salario;

        }

        public double GetSalary()
        {
            return _salario;
        }

        private double _salario;
    }

    class Estudiante
    {

        public Estudiante(double edad )
        {

            _edad = edad;

        }

        public double Edad()
        {

            return _edad;

        }

        private double _edad;
    }
}