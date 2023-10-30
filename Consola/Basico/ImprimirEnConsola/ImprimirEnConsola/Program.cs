namespace ImprimirEnConsola
{
    internal class Program
    {
        static void Main( string[] args )
        {

            /*-------------------*/
            /*Imprimir en consola*/
            /*-------------------*/

            // Para imprimir en la consola se utiliza el metodo WriteLine de la clase
            // Console

            // Este metodo imprimira lo que este dentro de sus parentesis en la consola
            // Ademas dara un salto de linea de forma automatica

            Console.WriteLine( "Hello World" );

            // Ademas de WriteLine existe el Metodo Write
            // A diferencia de WriteLine, Write no dara un salto de linea automatico
            // Si no que escribiria al lado de lo anterior

            Console.Write( "Hello" );
            Console.Write( " World\n" );

            /* Caracteres de escape */

            // Un carácter de escape es un conjunto de caracteres que tienen un significado
            // especial dentro de un texto o una cadena de caracteres en programación.
            // Estos caracteres comienzan con una barra invertida \ seguida de otro carácter.

            /* Caracter de tabulacion */
            Console.WriteLine( "Hello\tWorld" );

            /* Barra invertida */
            Console.WriteLine("Hello\\World");

            /* Comilla simple */
            Console.WriteLine( "Hello \'World\'" );

            /* Comillas dobles */
            Console.WriteLine( "Hello \"World\"" );

            /* Caracter para reescribir */
            Console.WriteLine( "Hello\rWorld" );

            /* Caracter de borrar un caracter */
            Console.WriteLine( "Hello\bWorld" );

            /* Caracter de nueva linea */
            Console.WriteLine( "Hello\nWorld" );


        }
    }
}