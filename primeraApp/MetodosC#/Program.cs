using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Piramide");

        int rows, space;

        Console.Write("Enter number of rows: ");

        rows = int.Parse(Console.ReadLine());

        for (int i = 1, k = 0; i <= rows; i++, k = 0)
        {
            for(space = 1; space <= rows; space++)
            {
                Console.Write( " " );
            }

            while(k!= 2 * i)
            {
                Console.Write( "*" );
            }

            Console.WriteLine();
        }

    }
    
}