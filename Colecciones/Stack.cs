using System.Collections;

namespace Colecciones
{

    partial class Program
    {

        static void Stacks()
        {
            Console.WriteLine( "Stacks: " );
            Console.WriteLine();

            /*Crear un nuevo Stack*/
            Stack myStack = new Stack();

            //Añadir elementos al Stack
            myStack.Push( "Hello" );
            myStack.Push( "World" );
            myStack.Push( "!" );

            Display( myStack, "Elementos añadidos" );

            //Eliminar elementos
            myStack.Pop();

            Display( myStack, "Elemento eliminado" );

        }

        static void Display(Stack S, string txt)
        {
            Console.WriteLine( txt + ":" );

            Console.WriteLine( " myStack" );
            Console.WriteLine( "  Count: {0}", S.Count );
            Console.Write( "  Values: " );
            foreach (Object obj in S)
            {
                Console.Write( " {0}", obj );
            }

            Console.WriteLine();
            Console.WriteLine();

        }

    }

}