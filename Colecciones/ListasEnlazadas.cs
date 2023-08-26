using System.Text;

namespace Colecciones
{
    partial class Program
    {
        static void LEnlazadas()
        {
            /*Listas Enlazadas*/

            Console.WriteLine( "Listas Enlazadas:" );

            //Creacion de una lista enlazada
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int n in new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })
            {
                numeros.AddFirst( n );
            }

            for(LinkedListNode<int> nodo = numeros.Last; nodo != null; nodo = nodo.Previous)
            {

                int numero = nodo.Value;

                Console.Write( numero + " " );

            }


            Console.WriteLine( "\n" );
        }
    }
}