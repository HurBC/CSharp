using System.Collections;

namespace Colecciones
{
    partial class Program
    {

        static void Queue()
        {

            Console.WriteLine("Queues: ");
            Console.WriteLine();

            /*Creacion de Queue*/
            Queue myQ = new Queue();

            /*Añadir a la cola*/
            myQ.Enqueue( "Hello" );
            myQ.Enqueue( "World" );
            myQ.Enqueue( "!" );

            //Valores del Queue
            Display( myQ, "Valores principales del Queue" );

            //Copia del Queue
            Queue myQClone = (Queue) myQ.Clone();
            Display( myQClone, "Copia del queue" );

            //Eliminar elementos del Queue
            myQ.Dequeue();
            Display( myQ, "Elimina un elemento" );

            //Clear
            myQ.Clear();
            Display( myQ, "Metodo Clear del queue" );

            myQ = myQClone;

            //Peek
            Console.WriteLine("(Peek): {0}", myQ.Peek());

            Console.WriteLine();
        }

        static void Display(Queue Q, string txt)
        {
            Console.WriteLine( txt + ":");

            Console.WriteLine(" myQ");
            Console.WriteLine("  Count: {0}", Q.Count);
            Console.Write("  Values: ");
            foreach(Object obj in Q)
            {
                Console.Write(" {0}", obj);
            }

            Console.WriteLine();
            Console.WriteLine();

        }

    }

}