namespace Predicados
{
    class Program
    {
        static void Main( string[] args )
        {

            List<int> numeros = new List<int>();

            numeros.AddRange( new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } );

            //Predicados
            Predicate<int> pre = new Predicate<int>(Pares);

            List<int> numPares = numeros.FindAll( pre );

            pre = new Predicate<int>(Primos);

            List<int> numPrimos = numeros.FindAll( pre );

            Console.WriteLine("Pares");

            foreach (int i in numPares)
            {
                Console.WriteLine( i );
            }

            Console.WriteLine("Primos");

            foreach (int i in numPrimos)
            {
                Console.WriteLine( i );
            }

            /*Predicados y clases*/
            List<Person> people = new List<Person>();

            Person p1 = new Person();
            p1.Name = "Juan";
            p1.Age = 28;

            Person p2 = new Person();
            p2.Name = "Franco";
            p2.Age = 18;

            Person p3 = new Person();
            p3.Name = "Martin";
            p3.Age = 17;

            people.AddRange(new Person[] { p1, p2, p3 });

            Predicate<Person> predicatePer = new Predicate<Person>(ExistenMayoresDeEdad);

            bool exist = people.Exists( predicatePer );

            if(exist )
            {
                Console.WriteLine( "Hay mayores de edad" );
            }
            else
            {
                Console.WriteLine( "No hay mayores de edad" );
            }

        }

        static bool Pares( int N )
        {

            if (N % 2 == 0)
                return true;
            else
                return false;

        }

        static bool Primos( int N )
        {

            for (int P = 2; P < N;  P++ )
            {
                if (N %  P == 0)
                    return false;
            }
            return true;

        }

        static bool ExistenMayoresDeEdad( Person person )
        {
            if (person.Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Person
    {



        private string _name;

        private int _age;

        public string Name { get => _name; set => _name =  value ; }

        public int Age { get => _age; set => _age =  value ; }
    }
}