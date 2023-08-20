using Nodos;
using System;

namespace Nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            SList list = new SList();

            for (int i = 10; i <= 15; i++)
            {
                list.addToFront(i);
            }
            for (int i = 9; i >= 0; i--)
            {
                list.addToBack(i);
            }

            Console.WriteLine("Antes de remover el valor 5");

            list.showList();

            Console.WriteLine("Antes de despues el valor 5");

            list.removeValue(5);

            list.showList();


        }
    }
}