namespace CodeWithSenkoEX
{
    internal class Program
    {

        static void sayHello(string name = "invited" )
        {
            Console.WriteLine("Hello " + name);
        }

        static void Main( string[] args )
        {

            sayHello();
            sayHello( "Senko" );

        }

    }
}