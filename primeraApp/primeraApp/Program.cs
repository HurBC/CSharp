using System;

namespace primeraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("Intrudce el radio del circulo");

            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine($"El area del circulo es: {area}");



        }
    }
}