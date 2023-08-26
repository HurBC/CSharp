using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            ConversorEuroDolar conv = new ConversorEuroDolar();

            Console.WriteLine(conv.convertir(50));

        }
    }

    class ConversorEuroDolar
    {
        private double _euro = 1.253;

        public double convertir(double cantidad)
        {
            return _euro * cantidad;
        }

        public void CambiarEuro(double cantidad)
        {
            if (cantidad < 0) _euro = _euro;

            else _euro = cantidad;

        }
    }
}