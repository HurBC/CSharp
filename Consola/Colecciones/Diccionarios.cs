namespace Colecciones
{

    partial class Program
    {

        static void Dictionarys()
        {
            Console.WriteLine( "Diccionarios:" );
            Console.WriteLine();

            Dictionary<int, string> dic = new Dictionary<int, string>();

            //añadir valores al diccionario
            dic.Add( 1, "Franco" );
            dic.Add( 2, "Piero" );
            dic.Add( 3, "Martin" );

            dic[4] = "Ignacio";

            Display( dic, "Valores diccionario" );
        }

        static void Display(Dictionary<int, string> D, string txt)
        {
            Console.WriteLine( txt );
            Console.WriteLine();

            foreach (KeyValuePair<int, string> kvp in D)
            {

                Console.WriteLine( "Key = {0}, Value = {1}", kvp.Key, kvp.Value );

            }

        }

    }

}