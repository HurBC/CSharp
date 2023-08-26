using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DunderMifflin
{
    public class Data
    {

        private string _name = "Dunder Mifflin";
        private string _branch = "Scranton";
        private Employee _manager;
        private List<Employee> _employees = new List<Employee>();


        private Dictionary<string, int> CargarSalarios()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Salary.json");
            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonData);
        }

        private void asignarSalarios(Employee employee)
        {
            Dictionary<string, int> salarioDepartamentos = CargarSalarios();
            bool foundPosition = false;

            foreach (var pos in salarioDepartamentos)
            {
                if (string.Equals(employee.Position.Trim(), pos.Key.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    int value = pos.Value;
                    employee.i_salary = value;
                    foundPosition = true;
                    break;
                }
            }
            if(!foundPosition) Console.WriteLine("No se encontro la posicion del empleado {0}", employee.Name);

        }

        private void asignarId(Employee employee)
        {
            int id = _employees.Count + 1;
            employee.i_id = id;
        }

        public Data addEmployee(Employee employee)
        {
            asignarSalarios(employee);
            asignarId(employee);
            _employees.Add(employee);
            Console.WriteLine("El empleado {0} a sido agregado con exito \n", employee.Name);
            return this;
        }

        public void asignarManager(int id)
        {
            foreach (var emp in _employees)
            {
                if (emp.i_id == id)
                {
                    _manager = emp;
                    break;
                }
            }
        }

        public void seeEmployees()
        {
            foreach (var emp in _employees)
            {
                emp.getInfo();
                Console.WriteLine("\n");
            }
        }


        public void getInfo()
        {
            Console.WriteLine("Info de {0}: \n Gerente Regional: {1} \n Numero de empleados: {2} \n Sucursal: {3}", _name, _manager.Name, _employees.Count, _branch);
        }


    }

}
