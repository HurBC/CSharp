using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin
{
    partial class Branches
    {

        public void _addEmployee(Employee e)
        {
            e.i_id = _employees.Count + 1;

            _employees.Add(e);
        }

        public void GetInfo()
        {
            int choice;

            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine($"| Informacion sobre {Branches.i_s_name} {_bName} |");
            Console.WriteLine("+---------------------+---------------------+");
            Console.WriteLine("|   Info. Empleados   |   Info, Productos   |");
            Console.WriteLine("+---------------------+---------------------+");

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor no valido");
                Console.WriteLine("Elije de nuevo");

                choice = int.Parse(Console.ReadLine());
            }

            if(choice == 1)
            {

                Console.Clear();
                Console.WriteLine("+-------------------------------------------+");
                Console.WriteLine($"|    Empleados de {Branches.i_s_name} {_bName}   |");
                Console.WriteLine("+-----------+-------------------------------+");

                foreach (var e in _employees)
                {
                    Console.WriteLine($"|   ID: {e.i_id}   |     Nombre: {e.Name}     |");
                }
                Console.WriteLine("+-----------+-------------------------------+");

                Console.WriteLine("Quieres saber mas sobre un empleado en especifico?");

                string respond = Console.ReadLine();

                if (respond == "si" || respond == "yes")
                {
                    Console.WriteLine("Escribe el ID del empleado");

                    int ID = int.Parse(Console.ReadLine());

                    foreach (var e in _employees)
                    {
                        if (e.i_id == ID)
                        {
                            e.GetInfo();
                        }
                    }
                }
                
            }

        }

        public Branches(string n)
        {

            _bName = n;

        }

        private string _bName;

        private List<Employee> _employees = new List<Employee>();

    }
}
