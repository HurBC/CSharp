namespace Herencia
{
    //Hijos
    class Lagartija : Animales
    {

        public Lagartija( string nombre )
        {
            _nombreReptil = nombre;
        }

        public override void GetNombre()
        {

            Console.WriteLine( "El nombre del reptil es: {0}", _nombreReptil );

        }

        string _nombreReptil;
    }

    class Ballena : Mamiferos
    {
        public Ballena( string name ) : base( name )
        {

        }

        public void Nadar()
        {

            Console.WriteLine( "Soy capaz de nadar" );

        }
    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeportivos, ISaltoConPatas
    {

        public Caballo( string name ) : base( name )
        {

        }

        public void Galopar()
        {

            Console.WriteLine( "Galopo xd" );

            Respirar();

        }

        int IMamiferosTerrestres.NumPatas()
        {

            return 4;

        }

        int ISaltoConPatas.NumPatas()
        {

            return 2;

        }

        public string Deporte()
        {

            return "hípica";

        }

        public bool EsOlimpico()
        {

            return true;

        }
    }

    class Humano : Mamiferos
    {
        public Humano( string name ) : base( name )
        {

        }

        //polimorfismo
        //sealed hace que este metodo no se pueda sobreescribir en las clases hijas
        public sealed override void Pensar()
        {

            Console.WriteLine( "Estoy pensando xd" );

        }
    }

    class Adolecente : Humano
    {
        public Adolecente( string name ) : base( name )
        {

        }

        //public override void Pensar()
        //{
        //    Console.WriteLine( "Las hormonas me impiden pensar" );
        //}
    }

    //sealed es para hacer que no se pueda heredar desde gorilas
    sealed class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila( string name ) : base( name )
        {

        }

        public void Trepar()
        {

            Console.WriteLine( "Puedo trepar xd" );

        }

        //polimorfismo
        public override void Pensar()
        {

            Console.WriteLine( "Pensar en gorila" );

        }

        public int NumPatas()
        {

            return 2;

        }
    }

    //class Chimpance : Gorila
    //{
    //    public Chimpance( string name ) : base( name )
    //    {

    //    }
    //}
}
