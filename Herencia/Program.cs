using Herencia;

//clase principal
class Program
{
    static void Main( string[] args )
    {

        /*Caballo Spirit = new Caballo("Spirit");

        ISaltoConPatas ISpirit = Spirit;

        Humano Tyler = new Humano("Tyler");

        Gorila Copito = new Gorila("Gorila");

        Ballena Wally = new Ballena("Wally");

        Mamiferos[] almacen = new Mamiferos[4]
        {
            Spirit, Tyler, Copito, Wally
        };

        Wally.Nadar();

        Console.WriteLine( ISpirit.NumPatas() );

        foreach (var i in almacen)
        {
            i.GetName();
        }*/

        Lagartija Juancho = new Lagartija("Juancho");

        Juancho.GetNombre();

        Humano Tyler = new Humano("Tyler");

        Tyler.GetNombre();

    }
}