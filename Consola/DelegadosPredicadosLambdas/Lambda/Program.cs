namespace Lambda
{
    class Program
    {
        static void Main( string[] args )
        {
            /*Lambda vs Metodos*/
            //Uso del delegado
            OperacionesMatematicas operaciones = new OperacionesMatematicas(Cuadrado);
            OperacionesMatematicas2 operaciones2 = new OperacionesMatematicas2(Suma);

            //Lambda
            OperacionesMatematicas Lambda = new OperacionesMatematicas(num => num * num);
            OperacionesMatematicas2 Lambda2 = new OperacionesMatematicas2((num1, num2) => num1 + num2);

            Console.WriteLine( operaciones( 4 ) );
            Console.WriteLine( Lambda( 4 ) );

            Console.WriteLine( operaciones2( 19, 10 ) );
            Console.WriteLine( Lambda2( 19, 10 ) );

            Console.WriteLine();

            /*Listas y Lambda*/
            List<int> numeros = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> numPares = numeros.FindAll( x => x % 2 == 0 );

            foreach (int i in numPares)
                Console.Write( i + " " );
            Console.WriteLine();
            numPares.ForEach( num => Console.Write( num + " " ) );

            Console.WriteLine( "\n" );

            /*Lambda y Clases*/
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            Persona p3 = new Persona();

            p1.Name = "BruH";
            p1.Age = 18;

            p2.Name = "HurB";
            p2.Age = 20;

            p3.Name = "Franco";
            p3.Age = 18;

            ComparaPersonas comparaEdad = (p1, p2) => p1 == p2;

            Console.WriteLine( comparaEdad( p1.Age, p2.Age ) );
            Console.WriteLine( comparaEdad( p1.Age, p3.Age ) );

        }

        public static int Cuadrado( int num )
        {
            return num * num;
        }

        public static int Suma( int num1, int num2 )
        {
            return num1 + num2;
        }

        public delegate int OperacionesMatematicas( int N1 );
        public delegate int OperacionesMatematicas2( int N1, int N2 );
        public delegate bool ComparaPersonas( int E1, int E2 );
    }

    class Persona
    {

        private string _name;

        private int _age;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
    }
}