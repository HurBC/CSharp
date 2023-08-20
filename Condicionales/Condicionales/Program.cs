using System;

class Program
{
    static void Main(string[] args)
    {
        /*if, else if y else*/

        int edad = Int32.Parse(Console.ReadLine());

        if (edad < 18) Console.WriteLine("Eres niño");

        else if (edad < 30) Console.WriteLine("Eres joven");

        else if (edad < 60) Console.WriteLine("Eres maduro");

        else Console.WriteLine("Ten una oferta para ataudes");


        /*swicth*/

        Console.WriteLine("Introduce el N° de mes para calcular la comnisión");

        int mes = Int32.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Mes de Enero");
                break;
            case 2:
                Console.WriteLine("Mes de Febrero");
                break;
            case 3:
                Console.WriteLine("Mes de Marzo");
                break;
            case 4:
                Console.WriteLine("Mes de Abril");
                break;
            case 5:
                Console.WriteLine("Mes de Mayo");
                break;
            case 6:
                Console.WriteLine("Mes de Junio");
                break;
            case 7:
                Console.WriteLine("Mes de Julio");
                break;
            case 8:
                Console.WriteLine("Mes de Agosto");
                break;
            case 9:
                Console.WriteLine("Mes de Septiembre");
                break;
            case 10:
                Console.WriteLine("Mes de Octubre");
                break;
            case 11:
                Console.WriteLine("Mes de Noviembre");
                break;
            case 12:
                Console.WriteLine("Mes de Diciembre");
                break;

            default:
                Console.WriteLine("Introduce un numero valido");
                break;

        }
    }
}