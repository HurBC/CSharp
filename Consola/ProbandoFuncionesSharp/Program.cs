using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader archive = null;

        try
        {
            string txt;

            int counter = 0;

            string path = @"C:\Users\BruHC\Documents\uwu.txt";

            archive = new StreamReader(path);

            while ((txt = archive.ReadLine()) != null)
            {
                Console.WriteLine(txt);

                counter++;
            }

        } catch (Exception e)
        {

            Console.WriteLine("Error {0}", e.Message);

        }
        finally
        {
            if (archive != null) archive.Close();

            Console.WriteLine("Archivo cerrado");
        }

    }


}