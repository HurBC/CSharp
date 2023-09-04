namespace Metodos
{
    internal class Program
    {
        /*------------------------*/
        /* Tipos de metodos en C# */
        /*------------------------*/

        //Que es un metodo?
        //Los metodos o funciones son instrucciones las cuales se pueden repetir mulltiples veces sin necesidad de escribirlas otra vez
        //estos se declaran usando la palabra reservada "voi" o un tipo de dato ya sea "int" o "string"
        //Los metodos pueden resivir parametros los cuales se colocan en sus parentesis, los cuales una vez puestos deben ser si o si llenado al momento de llamar a un metodo
        //los parametros de un metodo pueden ser tanto de tipo "int" como "string"
        //Cabe recalcar que los meodos se debe declarar FUERA del metodo Main

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

        // Los métodos pueden recibir parámetros para ser más reutilizables.
        // Los parámetros se definen dentro del método junto con su tipo y se separan por comas.
        // Se deben proporcionar al invocar el método.

        void EmjemploParametros(string txt )
        {
            Console.WriteLine(txt);
        }

        int Suma(int n1, int n2)
        {
            return n1 + n2;
        }

        //Parametros opcionales
        //Los parametros opcionales sirven para no tener que colocar todos los parametros en una invocacion de metodo
        //estos parametros se declaran con un valor ya asignado

        void ParametrosOpcionales(string txt="Hello")
        {
            Console.WriteLine(txt);   
        }

        int Suma2(int n1, int n2, int n3 = 0)
        {
            return n1 + n2 + n3
        }
        //En este ejemplo se le asignan 3 parametros al metodo Suma2 siendo uno de estos opcional
        //los parametros opcionles se deben declarar SIEMPRE despues de los parametros no opcionales

            
        /*-------------------------*/
        /* Sobrecarga de un metodo */
        /*-------------------------*/

        //La sobrecarga en un metodo nos permite tener varios metodos con el mismo nombre sin que de error
        //Esto se logra al pasarle diferentes tipos de parametros tanto en diferente cantidad como en tipo

        void txt()
        {
            Console.WriteLine("Hello");
        }

        void txt(string str)
        {
            Console.WriteLine(str);
        }
        // La sobrecarga de métodos permite tener varios métodos con el mismo nombre pero diferente cantidad o tipo de parámetros.
        // Esto se logra al pasar diferentes tipos o cantidad de parámetros.
        void txt(int num)
        {
            Console.WriteLine(num.ToString());
        }

        // Método Main
        // Es el punto de entrada principal del programa C#.
        // Las llamadas a otros métodos deben realizarse dentro de este.
        static void Main( string[] args )
        {
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

            //Parametros opcionales
            Suma2(1, 2 ,3); //Dara 6
            Suma2(1, 2); //Dara 3

            //Metodos con sobrecarga
            txt();
            txt("Hello");
            txt(6);

        }
    }
}
