namespace Vehiculos
{
    class Program
    {
        static void Main( string[] args )
        {

            Auto auto = new Auto();

            Avion avion = new Avion();

            Bote bote = new Bote();

            Vehiculo otroVehiculo = new Vehiculo();

            Vehiculo[] vehiculos = new Vehiculo[4]
            {
                auto, avion, bote, otroVehiculo
            };

            foreach (var i in vehiculos)
            {
                i.ArrancarMotor();
                i.Conducir();
                i.ApagarMotor();
                Console.WriteLine( "\n" );
            }

        }
    }

    class Vehiculo
    {

        public virtual void Conducir()
        {

            Console.WriteLine( "Se esta conduciendo el vehiculo" );

        }

        public void ArrancarMotor()
        {

            Console.WriteLine( "El motor esta encendido" );

        }

        public void ApagarMotor()
        {

            Console.WriteLine( "El motor esta apagado" );

        }

    }

    class Auto : Vehiculo
    {

        public void EncenderRadio()
        {

            Console.WriteLine("Radio encendida");

        }

        public void Avanzar()
        {

            Console.WriteLine("El auto esta en movimiento");

        }

        public void Estacionar()
        {

            Console.WriteLine("Se estaciono el auto");

        }

        public override void Conducir()
        {

            Console.WriteLine( "Se esta conduciendo el Auto" );

        }

    }

    class Avion : Vehiculo
    {

        public void Despegar()
        {

            Console.WriteLine( "El avion a despegado" );

        }

        public void Aterrizar()
        {

            Console.WriteLine( "El avion a aterrizado" );

        }

        public override void Conducir()
        {

            Console.WriteLine( "Se esta conduciendo el Avion" );

        }

    }

    class Bote : Vehiculo
    {

        public void ElevarAncla()
        {

            Console.WriteLine("Se elevo la ancla");

        }

        public void AlzarVelas()
        {

            Console.WriteLine("Se alzaron las velas");

        }

        public void Avanzar()
        {

            Console.WriteLine("El bote esta en movimiento");

        }

        public override void Conducir()
        {

            Console.WriteLine( "Se esta conduciendo el Bote" );

        }

    }
}