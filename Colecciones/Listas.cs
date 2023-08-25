namespace Colecciones
{


    partial class Program
    {
        static void Lista()
        {
            /*Lista*/

            //Creacion de Lista
            List<int> list = new List<int>();

            int[] ListaNumeros = new int[] { 5, 6, 7, 8 };

            //Agregar a la lista
            list.Add( 1 );
            list.Add( 2 );
            list.Add( 3 );
            list.Add( 4 );

            for (int i = 0; i < ListaNumeros.Length; i++)
            {

                list.Add( ListaNumeros[i] );

            }

            Console.WriteLine( "Lista: " );
            //Imprimir Lista
            foreach (int i in list)
            {
                Console.Write( i + " " );
            }

            Console.WriteLine("\n");
        }
    }
}