namespace Arrays
{
    class Program
    {
        static void Main( string[] args )
        {

            /*-------------------*/
            /* Declare an Array */
            /*-------------------*/

            /*Simple Arrays*/
            int[] ints = new int[5];

            /*Declare elements in an Array*/

            // During array creation
            int[] ints1 = new int[5] { 1, 2, 3, 4, 5};

            // Separately
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;
            ints[3] = 4;
            ints[4] = 5;

            /* Multidimensional Arrays */

            int[,] array2d = new int[3,3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,,] array3d = new int[3,3,3]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                {
                    { 10, 11, 12 },
                    { 13, 14, 15 },
                    { 16, 17, 18 }
                },
                {
                    { 19, 20, 21 },
                    { 22, 23, 24 },
                    { 25, 26, 27 }
                }
            };

            /* Jagged Arrays */

            int[][] jaggedArray = new int[3][];

            int[][] jaggedArray2 =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            /*-------------------*/
            /* Traverse an Array */
            /*-------------------*/

            /* For Bucle */
            Console.WriteLine("For Bucle:");
            for ( int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine( ints[i] );
            }

            Console.WriteLine( "\nForeach Bucle:" );

            /* Foreach Bucle */
            foreach ( var i in ints1)
            {
                Console.WriteLine(i);
            }

            /*------------------------------------*/
            /* Traverse an Multidimensional Array */
            /*------------------------------------*/

            Console.WriteLine( "\nMultidimensional Arrays" );

            /* For Bucle */

            Console.WriteLine( "\nForeach Bucle:" );

            for ( int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    Console.Write( array2d[i, j] + " " );
                }
                Console.WriteLine();
            }

            /*--------------------------*/
            /* Traverse an Jagged Array */
            /*--------------------------*/

            Console.WriteLine( "\nJagged Arrays" );

            /* For Bucle */

            Console.WriteLine( "\nForeach Bucle:" );

            for ( int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.Write("{ ");

                for ( int j = 0; j < jaggedArray2[i].Length; j++ )
                {
                    Console.Write("{0}, ", jaggedArray2[i][j] );
                }

                Console.Write( "},\n" );

            }

            /*--------------------------*/
            /*     Array Properties     */
            /*--------------------------*/

            Console.WriteLine( "\nArray Properties" );

            int[] properties = { 1, 2, 3, 4, 5 };

            Console.Write( "\nArray: " );

            foreach ( var i in properties )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine();

            /* IsFixedSize */

            Console.WriteLine("IsFixedSize: {0}", properties.IsFixedSize);

            /* IsReadOnly */

            Console.WriteLine("IsReadOnly: {0}", properties.IsReadOnly);

            /* IsSynchronized */

            Console.WriteLine( "IsReadOnly: {0}", properties.IsSynchronized );

            /* Length */

            Console.WriteLine( "Length: {0}", properties.Length );

            /* LongLength */

            Console.WriteLine( "LongLength: {0}", properties.LongLength );

            /* Rank */

            Console.WriteLine( "Rank: {0}", properties.Rank );

            /* SyncRoot */

            Console.WriteLine( "SyncRoot: {0}", properties.SyncRoot );

            /*--------------------------*/
            /*       Array Methods      */
            /*--------------------------*/

            Console.WriteLine("\nArray Methods");

            /* Copy Method */

            Console.WriteLine( "\nCopy Method" );

            String[] strings = {"Hello", "world", "i'm", "Senko!!"};
            String[] copyStrings = new String[strings.Length];

            Console.Write( "\nOriginal Array: " );

            foreach ( var i in strings )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine( "\n" );

            Array.Copy(strings, copyStrings, strings.Length );

            Console.Write("Array Copy: ");

            foreach ( var i in copyStrings )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine();

            /* Resize Method */

            Console.WriteLine( "\nResize Method" );

            int[] resizeThis = {1,2,3,4};

            Console.Write( "\nOriginal Array: " );

            foreach ( var i in resizeThis )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine( "\n" );

            Array.Resize( ref resizeThis, 6 );

            Console.Write( "Resized Array: " );

            foreach ( var i in resizeThis )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine( "\n" );

            /* Sort Method */

            Console.WriteLine( "Sort Method" );

            int[] sortThis = {1,2,3,4};

            Console.Write( "\nOriginal Array: " );

            foreach ( var i in sortThis )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine( "\n" );

            Array.Sort( sortThis );

            Console.Write( "Sorted Array: " );

            foreach ( var i in sortThis )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine( "\n" );

            /* Reverse Method */

            Console.WriteLine( "Reverse Method" );

            string[] joke = new string[]
            {/*
                "I miss 3 seasons.",
                "in front of the TV,",
                "that when she walks",
                "is so fat",
                "Your mother"
             */
                "This",
                "Reverse"
            };

            Console.Write( "\nOriginal Array: " );

            foreach ( var i in joke )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine( "\n" );

            Array.Reverse( joke );

            Console.Write( "Reversed Array: " );

            foreach ( var i in joke )
            {
                Console.Write( "{0} ", i );
            }

            Console.WriteLine( "\n" );

            Console.WriteLine("And more....");

        }

    }
}