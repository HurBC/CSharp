namespace CodeWithSenkoEX
{
    internal class Program
    {

        static void Main( string[] args )
        {

            /*-----------------*/
            /* Class Hierarchy */
            /*-----------------*/

            Employee senko = new Employee();
            Boss pomni = new Boss();
            CEO freddyFazbear = new CEO();

            senko.Work();
            pomni.Work();
            freddyFazbear.Work();

            senko.Manage();
            pomni.Manage();
            freddyFazbear.Manage();

        }

    }

    class Employee
    {
        public void Work()
        {
            Console.WriteLine("is working");
        }
    }

    class Boss : Employee
    {
        public void Manage()
        {
            Console.WriteLine("managing...");
        }
    }

    class CEO : Boss
    {

    }
}