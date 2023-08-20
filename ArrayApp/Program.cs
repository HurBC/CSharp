class Program
{
    static void Main()
    {

        int[] numbers = LeerDatos();

        Console.WriteLine("Este es tu Array:\n");

        Console.Write("[");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1) Console.Write(", ");
        }
        Console.Write("]");

    }

    static int[] LeerDatos()
    {
        Console.WriteLine("Cuantos elementos tendra el array?");

        int numElements = int.Parse(Console.ReadLine());

        int[] data = new int[numElements];

        for (int i = 0; i < numElements; i++)
        {
            int x;

            Console.WriteLine($"Elije un numero para que vaya en la posicion {i} de tu nuevo Array");

            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Tu opcion no es valida, por favor selecciona un numero, por ahora se tomara como 0 el valor {i} de tu Array");
                x = 0;
            }

            data[i] = x;

        }

        return data;
    }
}