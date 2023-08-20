using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin
{
    partial class Branches
    {

        internal static void i_s_addBranch(string nb)
        {

            s_branches.Add(nb);

        }

        internal static int i_s_getBranch(string b)
        {

            int i = 0;

            foreach (var branch in s_branches)
            {
                i++;

                if (branch == b) return i;

            }

            return 0;

        }

        internal static double i_s_getSalary(string Salary)
        {

            foreach (var sal in s_departaments)
            {

                if (sal.Key == Salary) return sal.Value;

            }

            return 0;

        }

        public Branches()
        {
            i_s_addBranch("scranton");
            i_s_addBranch("stanford");
            i_s_addBranch("new york");
            i_s_addBranch("santiago");
        }

        private static Dictionary<string, int> s_departaments = new Dictionary<string, int>()
        {
            { "atencion cliente", 4358 },
            { "calidad", 4165 },
            { "contabilidad", 4880 },
            { "encargado de bodega", 5809 },
            { "gerente", 8333 },
            { "recursos humanos", 7604 },
            { "ventas", 5471 },
            { "recepcion", 3128 }
        };

        internal static string i_s_name = "Dunder Mifflin";

        public static List<string> s_branches = new List<string>();

    }
}
