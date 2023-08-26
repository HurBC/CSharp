using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main( string[] args )
        {

            string txt = "fcobreque1204@gmail.com";

            string r1=".*?", r2="(@)", r3=".*?", r4="(\\.)";

            Regex rx = new Regex(r1 + r2 + r3 + r4, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            Match m = rx.Match(txt);

            if (m.Success)
            {
                Console.WriteLine( "Correo Valido" );
            }
            else
            {
                Console.WriteLine( "Correo invalido" );
            }

        }
    }
}