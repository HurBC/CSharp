namespace Metodos
{
    internal class Program
    {
        static void Main( string[] args )
        {
            /*------------------------*/
            /* Tipos de metodos en C# */
            /*------------------------*/

            //Que es un metodo?
            //Los metodos o funciones son instrucciones las cuales se pueden repetir mulltiples veces sin necesidad de escribirlas otra vez
            //estos se declaran usando la palabra reservada "voi" o un tipo de dato ya sea "int" o "string"
            //Los metodos pueden resivir parametros los cuales se colocan en sus parentesis, los cuales una vez puestos deben ser si o si llenado al momento de llamar a un metodo
            //los parametros de un metodo pueden ser tanto de tipo "int" como "string"

            //Metodos Void
            //Los metodos void son aquellos metodos que no devuelven nada
            //Estos se declaram usamdo la palabra "void" y el nombre de este metodo junto a sus parentesis
            //Estos metodos se utilizan por lo general para controlar datos, insertar datos o leer datos
            //Ejemplo: agregar un nuevo empleado a una lista

            void Ejemplo1()
            {
                Console.WriteLine("Hello");
            }

            //metodos con declaracion de datos
            //estos metodos a diferencia de los "void" si devuelven un valor y para ello se utiliza la palabra "return"
            //para declarar estos metodos se utiliza el tipo de dato junto al nombre del metodo y sus parentesis
            //Estos metodos se suelen utilizar para operaciones matematicas o cuando se necesite devolver un valor de cualquier tipo
            //sea texto, numerico, boleano, etc

            int Ejemplo2()
            {
                return 1 + 2;
            }

            string Ejemplo2_1()
            {
                return "hello";
            }

            bool Ejemplo2_2()
            {
                return true;
            }

            double Ejemplo2_3()
            {
                return 2 / 5;
            }

            /*-------------------------*/
            /* Parametros de un metodo */
            /*-------------------------*/

            //los metodos pueden recibir parametros asi poder ser mas reutilizables
            //estos parametros se establecen adentro de los metodos junto al tipo de dato que son y se separan por comas
            //Se pueden poner todos los parametros que uno quiera PERO deben ser llenados al momento de invocar al metodo

            void EmjemploParametros(string txt )
            {
                Console.WriteLine(txt);
            }

            int Suma(int n1, int n2)
            {
                return n1 + n2;
            }

            /*-------------------------*/
            /* Invocacion de un metodo */
            /*-------------------------*/

            //Para invocar un metodo se utiliza el nombre de este seguido de sus parentesis
            //en caso de que el metodo tenga parametros se deben colocar adentro del parentesis de la invocacion y se deben utilizar comas para separar los parametros

            //sin parametros
            Ejemplo1();
            Ejemplo2();

            //Con parametros
            EmjemploParametros( "Hello" );
            Suma( 1, 2 );

        }
    }
}