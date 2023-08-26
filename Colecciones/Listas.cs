namespace Colecciones
{


    partial class Program
    {
        static void Lista()
        {
            /*Lista*/
            Console.WriteLine( "Listas:" );
            Console.WriteLine();

            //Creacion de lista
            List<int> list = new List<int>();

            Display( list, "Lista recien construida" );

            //Añadir a la lista
            list.Add( 1 );
            list.Add( 2 );
            list.Add( 3 );
            list.Add( 4 );

            Display( list, "Elementos añadidos a la lista" );

            //Añadir rango
            list.AddRange( list );

            Display( list, "Rango añadido" );

            Console.WriteLine("\n");
        }

        static void Display(List<int> L, string txt)
        {
            Console.WriteLine(txt + ":");

            Console.WriteLine(" List");
            Console.WriteLine("  Count: {0}", L.Count);
            Console.Write("  Lista: ");

            foreach (int num in L)
            {
                Console.Write( " {0}", num );
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}