namespace CodeWithSenkoEX
{
    internal class Program
    {
        static void Main( string[] args )
        {

            int[,] ints = { {1, 2, 3}, { 4, 5, 6}, { 7, 8, 9 } };
            int[][] ints2 = { new int[3] {1,2,3}, new int[3] {4,5,6}, new int[3] {7,8,9} };

            // multidimensional Arrays
            for ( int i = 0;  i < ints.GetLength(0); i++ )
            {
                for ( int j = 0; j < ints.GetLength(1); j++ )
                {
                    Console.Write( ints[i, j] + " " );
                }
                Console.WriteLine();
            }

            // Jagged Arrays
            foreach ( var i in ints2 )
            {
                foreach (var j in i )
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }
}