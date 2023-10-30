namespace Variables
{
    internal class Program
    {
        static void Main( string[] args )
        {        
            /*----------------------------------------*/
            /*Declaracion de Variables numericas en C#*/
            /*----------------------------------------*/

            /* Integers */

            // Int básico
            // El 'int' es el tipo de dato entero más común en C#.
            // Puede almacenar valores enteros positivos o negativos en un rango de 32 bits.
            // Valor mínimo: -2,147,483,648
            // Valor máximo: 2,147,483,647
            int enteroBasico = 10;

            // UInt
            // El tipo 'uint' almacena solo valores positivos, indicados con una "u" al final del número.
            // Valor mínimo: 0
            // Valor máximo: 4,294,967,295
            uint enteroUInt = 10u;

            // Short
            // El 'short' es como el 'int' pero en un rango de 16 bits, más limitado.
            // Valor mínimo: -32,768
            // Valor máximo: 32,767
            short enteroShort = 32000;

            // Ushort
            // Al igual que 'short', este tipo almacena valores en un rango de 16 bits, pero solo positivos.
            // Valor mínimo: 0
            // Valor máximo: 65,535
            ushort enteroUShort = 65535;

            // Long
            // El 'long' puede manejar números enteros en un rango de 64 bits.
            // Permite manejar valores mucho más grandes que los otros tipos.
            // Valor mínimo: -9,223,372,036,854,775,808
            // Valor máximo: 9,223,372,036,854,775,807
            long enteroLong = 9223372036854775807;

            // Ulong
            // El 'ulong' también maneja números de 64 bits, pero solo positivos.
            // Valor mínimo: 0
            // Valor máximo: 18,446,744,073,709,551,615
            ulong enteroULong = 53465264563546745;


            /* Decimals */

            // Float
            // El tipo 'float' es el más sencillo de los valores decimales y tiene una precisión de 6 a 9 dígitos aproximadamente.
            // Debes añadir la letra "f" al final del número para indicar que es un 'float'.
            // Valor mínimo: 1.5 x 10^-45
            // Valor máximo: 3.4 x 10^38
            float decimalSimple = 3.1415f;

            // Double
            // Los 'double' tienen más precisión que los 'float'.
            // Se utilizan para decimales de precisión doble y tienen una precisión de 15 a 17 dígitos aproximadamente.
            // A diferencia de 'float', no necesitas añadir una letra al final del número.
            // Valor mínimo: 5.0 x 10^-324
            // Valor máximo: 1.7 x 10^308
            double decimalDoble = 2.71828182845904523;

            // Decimal
            // Los 'decimal' son los más precisos de los tres tipos y tienen una precisión de 28 a 29 dígitos.
            // Puedes usar la letra "m" para identificarlos, aunque no es necesario.
            // Valor mínimo: 1.0 x 10^-28
            // Valor máximo: 7.9228 x 10^28
            decimal decimalPreciso = 2.4345254365563456224523452346163463563456m;


            /*-------------------------------------------*/
            /*Declaracion de Variables NO numericas en C#*/
            /*-------------------------------------------*/

            /* Booleans */
            //Estos datos solo se escargan de guardar "true" o "false", nada mas
            //Estos datos se otilizan mas con condicionales y bucles
            bool HalfLife3 = false;

            /* Text */
            //estos datos se dividen en los "strings" y los "char"

            /* Chars */

            // El tipo de dato Char se encarga de guardar un unico caracter unicode
            // Para declarar un Char se utiliza la comilla simple ''
            char c1 = 'h', c2 = 'o', c3 = 'l', c4 = 'A';

            // Estos tipos de datos tienen los metodo "ToLower" para poner el caracter en minuscula
            // Y ToUpper para poner el caracter en mayuscula
            char.ToLower( c4 );
            char.ToUpper( c1 );

            /* Strings */

            // A diferencia de los Chars, los String son una clase la cual se encarga de guardar multiples Chars para generar texo

            String txt = "Estos datos se declaran usando comillas dobles y pueden ser tan largos como uno quiera";

            // Formas para imprimir Strings

            // Los Strings ademas de simplemente imprimirse en un Console.WriteLine
            // Pueden juntarse para crear un solo String
            // Aqui algunos metodos

            String x, y, z;

            x = "Hello";
            y = "World";

            // Concatenacion de Strings //

            Console.WriteLine( "Concatenacion de Strings:\n" );

            // Nuevo String

            z = x + " " + y;

            Console.WriteLine(z);

            // Directamente en el metodo WriteLine

            Console.WriteLine( x + " " + y );

            // Interpolacion de Strings //

            Console.WriteLine( "\nInterpolacion de Strings:\n" );

            // Nuevo String

            z = $"{x} {y}";

            Console.WriteLine( z );

            // Directamente en el metodo WriteLine

            Console.WriteLine( $"{x} {y}" );

            // Formato de Cadenas Compuesto //

            Console.WriteLine( "\nFormato de Cadenas Compuesto:\n" );

            // Nuevo String

            z = String.Format( "{0} {1}", x, y );

            Console.WriteLine( z );

            // Directamente en el metodo WriteLine

            Console.WriteLine( "{0} {1}", x, y );


            /*--------------------------------------------*/
            /*variables sin especificar y constantes en C#*/
            /*--------------------------------------------*/

            /* Variables */
            // se declaran usando la palabra "var" y se utilizan para no declarar el tipo de dato de forma explicita
            // una vez se le da un dato a esta NO SE PUEDE CAMBIAR EL DATO

            var variable = 10;

            //A esta variable SOLO se le pueden asiganr datos de tipo int

            //Constantes
            //Se declaran usando la palabra reservada "const" y son tipos que no se pueden modificar
            //se utilizan para definir un elemento que no se deba cambiar durante la ejecucion del codigo

            const double PI = 3.1415;

            //En este ejemplo se declaro una constante de tipo doble que almacena el valor de PI
            //Este valor NO SE PODRA CAMBIAR DURANTE LA EJECUCION DEL PROGRAMA

        }
    }
}