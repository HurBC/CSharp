namespace Colecciones
{
    partial class Program
    {
        static void Nodos()
        {

            /*Nodos de lista enlazada*/
            Console.WriteLine( "Nodos Listas enlazadas: " );

            //Creacion de un nuevo Nodo de lista
            LinkedListNode<string> lln = new LinkedListNode<string>("Hello");
            Console.WriteLine( "Despues de crear el Nodo" );
            DisplayProperties( lln );

            //Creacion de lista enlazada
            LinkedList<string> ll = new LinkedList<string>();

            //Añadir el nodo Hello y mostrar sus propiedades
            ll.AddLast( lln );
            Console.WriteLine( "Despues de añadir el Nodo a la lista vacia" );
            DisplayProperties( lln );

            //Añadir Nodos ANTES y DESPUES del Nodo Hello y mostrar sus propiedades
            ll.AddFirst( "World" );
            ll.AddLast( "From" );
            Console.WriteLine( "Despues de añadir World y From" );
            DisplayProperties( lln );

            Console.WriteLine( "\n" );
        }

        public static void DisplayProperties( LinkedListNode<String> lln )
        {
            /*Propiedades*/

            //List obtiene la lista a donde pertenece el Nodo
            if (lln.List == null)
                Console.WriteLine( "   Node is not linked." );
            else
                Console.WriteLine( "   Node belongs to a linked list with {0} elements.", lln.List.Count );

            //Previous obtiene el Nodo anterior del Nodo
            if (lln.Previous == null)
                Console.WriteLine( "   Previous node is null." );
            else
                Console.WriteLine( "   Value of previous node: {0}", lln.Previous.Value );

            //Value obtiene el valor del Nodo
            Console.WriteLine( "   Value of current node:  {0}", lln.Value );

            //Next obtiene el siguiente Nodo de la lista
            if (lln.Next == null)
                Console.WriteLine( "   Next node is null." );
            else
                Console.WriteLine( "   Value of next node:     {0}", lln.Next.Value );

        }
    }
}