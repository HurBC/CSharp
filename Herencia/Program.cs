using System;

class Program
{
    static void Main(string[] args)
    {

        Caballo Spirit = new Caballo();

        Humano Franco = new Humano();

        Gorila Copito = new Gorila();

    }
}

class Mamiferos
{

    public void Respirar()
    {
        Console.WriteLine("Puedo respirar xd");
    }

    public void CuidarCrias()
    {
        Console.WriteLine("Cuido a mis crias xd");
    }

}

class Caballo : Mamiferos
{
    public void Galopar()
    {
        Console.WriteLine("Galopo xd");
    }

}

class Humano : Mamiferos
{

    public void Pensar()
    {
        Console.WriteLine("Estoy pensando xd");
    }

}

class Gorila : Mamiferos
{
    public void Trepar()
    {
        Console.WriteLine("Puedo trepar xd");
    }
}