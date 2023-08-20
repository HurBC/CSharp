using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Nodos
{
    internal class SList
    {

        private SLNode _head;

        public SList()
        {
            _head = null;
        }

        public SList addToFront(int val)
        {
            SLNode new_node = new SLNode(val);

            SLNode current = _head;

            new_node.i_next = current;

            _head = new_node;

            return this;

        }

        public SList addToBack(int val)
        {
            if (_head == null)
            {
                addToFront(val);
                return this;
            }

            SLNode nNode = new SLNode(val);

            SLNode runner = _head;

            while (runner.i_next != null)
            {
                runner = runner.i_next;
            }

            runner.i_next = nNode;

            return this;

        }


        public SList removeFromFront()
        {
            if ( _head == null)
            {
                Console.WriteLine("La cabeza de la lista esta vacia");

                return this;
            }

            SLNode current = _head;

            _head = _head.i_next;

            current.i_next = null;

            return this;
        }

        public SList removeFromBack()
        {

            switch (_head)
            {
                case null:
                    Console.WriteLine("N/A");
                    break;

                case {  i_next: null}:
                    SLNode VTR = _head;
                    _head = null;
                    Console.WriteLine("Se elimino el valor: {0}", VTR);
                    break;

                default:
                    SLNode runner = _head;

                    while (runner.i_next.i_next != null)
                    {
                        runner = runner.i_next;
                    }

                    runner.i_next = null;
                    break;
            }

            return this;

        }

        public SList removeValue(int n)
        {
            switch(_head)
            {
                case null:
                    Console.WriteLine("N/A");
                    break;

                default:

                    if (_head.val == n)
                    {
                        removeFromFront();
                        break;
                    }
                    else
                    {
                        SLNode runner = _head;

                        while (runner.i_next != null && runner.i_next.val != n)
                        {
                            runner = runner.i_next;
                        }

                        if (runner.i_next == null) break;

                        runner.i_next = runner.i_next.i_next;

                        Console.WriteLine();

                        break;
                    }

            }

            return this;
        }

        public void showList()
        {
            SLNode runner = _head;
            
            while (runner != null)
            {
                Console.WriteLine(runner.val);
                runner = runner.i_next;
            }
        }


    }
}
