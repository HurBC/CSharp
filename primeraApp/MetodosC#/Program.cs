using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(Suma(2, 6));

        Console.WriteLine(Suma(2.0, 6));

        Console.WriteLine(Suma(1, 4, 6, 3));

    }

    static int Suma(int v1, int v2) => v1 + v2;
    static double Suma(double v1, int v2) => v1 + v2;
    static int Suma(int v1, int v2, int v3, int v4) => v1 + v2;

}