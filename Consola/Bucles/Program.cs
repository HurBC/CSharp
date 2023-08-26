using System;

class Program
{
    static void Main()
    {

        Random rnd = new Random();
        int n = rnd.Next(0, 100);

        int choice;

        int attemps = 0;

        bool gameOver = false;

        Console.WriteLine("Oye ctm bienvenido a esta wea de juego \n Elige un número kliao entre 1 y 100. perkin \n ¿seras un gigachad y sabras el numero? o solo eri un perkin");

        do
        {

            attemps++;

            try
            {
                Console.WriteLine("\n Ingresa tu wea de numero:");
                choice = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Oye saco wea, la wea es elegir un numero no escrbir tonto ctm malaya klia, por wn tu numero sera 0");
                choice = 0;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Tu numero es demasiado grande 0//~//0, tu numero sera pasado a 100 senpai");
                choice = 100;
            }

            if (choice > n) Console.WriteLine("El numero es mas chico, como tu pija");

            else if (choice < n) Console.WriteLine("El numero es mas grande, como mi pija");

            if (attemps == 10) gameOver = true;



        } while (choice != n);

        if (gameOver == true) Console.WriteLine("JAJAJAJAJAJ EL WN MALO, Como no podi adivinar un numero JAJAJAJA el numero era {0}, pero vo no pudiste", n);

        else
        {
            if (attemps > 1) Console.WriteLine("Veo que lo conseguiste en {0} intentos, yo lo haria a la primera", attemps);
            else Console.WriteLine("Que trampa klia hiciste pa hacerlo a la primera ctm?, na tranquilo manito, sin duda eres un chad, muak cuidate uwu");
        }

    }


}