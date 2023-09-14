using System;

class Program
{
    static void Main()
    {
        /*--------------*/
        /* Bucles en C# */
        /*--------------*/

        //Los bucles son una sentencia de codigo que se repite
        //existen 4 tipos de bucles: for, foreach, while y do-while

        /* Bucle for */

        //el bucle for es un tipo de bucle que se repite una cierta cantidad de veces
        //estos bucles se utilizan cuando sabemos cuantas veces se repetira una accion
        //Para crear un bucle for se utiliza la palabra reservada "for" junto a unos parentesis
        //y sus parametros los cuales son 3 por lo general, DEBEN ser de tipo entero y se separan con ";"
        //el primer parametro establecera la variable por la cual iterara el bucle for
        //el segundo sera la condicional que verificara si el bucle se debe repetir o no
        //y el tercero modificara el primer parametro sumandole un valor o restandole un valor
        //EJ: for(int i=0; i<10; i++)
        //Aqui le decimos al bucle que establesca i en 0 y que se repita mientra i sea menor que 10
        //y al final se le dira que se le sume 1 a i

        for (int i = 0; i < 10;  i++)
        {
            //escribira "Hello World" 10 veces
            Console.WriteLine("Hello World");
        }

        for (int i = 0; i <= 10; i++)
        {
            //Imprimira el valor de i mientras sea menor o igual a 10
            Console.WriteLine( i );
        }

        for ( int i = 10; i >= 0; i--)
        {
            //Imprimira i hata que sea 0
            Console.WriteLine( i );
        }


    }


}