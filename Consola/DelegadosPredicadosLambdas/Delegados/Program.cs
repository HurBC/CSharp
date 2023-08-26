namespace Delegados
{
    class Program
    {
        static void Main( string[] args )
        {

            //Creacion del puntero Delegado
            ObjetoDelegado1 delegado1 = new ObjetoDelegado1(MensajeBienvenida.SaludoBienvenida);

            //Llamada al Delegado
            delegado1("Hello World");

            ObjetoDelegado2 delegado2 = new ObjetoDelegado2( MensajeDespedida.SaludoDespedida );

            delegado2();

        }

        /*Delegado*/
        delegate void ObjetoDelegado1(string msj );
        delegate void ObjetoDelegado2();
    }

    class MensajeBienvenida
    {

        public static void SaludoBienvenida(string msj)
        {

            Console.WriteLine( "Mensaje de bienvenida {0}", msj );

        }

    }

    class MensajeDespedida
    {

        public static void SaludoDespedida()
        {

            Console.WriteLine( "Goodbye To A World..." );

        }

    }
}