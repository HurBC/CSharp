interface IMamiferosTerrestres
{

    int numPatas();

}

class Program
{
    static void Main( string[] args )
    {

        Caballo Spirit = new Caballo("Spirit");

        Humano Tyler = new Humano("Tyler");

        Gorila Copito = new Gorila("Gorila");

        Ballena Wally = new Ballena("Wally");

        Mamiferos[] almacen = new Mamiferos[4];

        almacen[0] = Spirit;

        almacen[1] = Tyler;

        almacen[2] = Copito;

        almacen[3] = Wally;

        Wally.Nadar();

        Console.WriteLine("Numero de patas: {0}", Spirit.numPatas());

        for (int i = 0; i < almacen.Length; i++)
        {

            almacen[i].Pensar();

        }

    }
}

class Mamiferos
{

    public Mamiferos( string name )
    {

        _nombreSerVivo = name;

    }

    protected void Respirar()
    {

        Console.WriteLine( "Puedo respirar xd" );

    }

    public virtual void Pensar()
    {

        Console.WriteLine( "Pensamiento basico instintitvo" );

    }

    public void CuidarCrias()
    {

        Console.WriteLine( "Cuido a mis crias xd" );

    }

    public void GetName()
    {

        Console.WriteLine( "El nombre es: {0}", _nombreSerVivo );

    }

    private string _nombreSerVivo;

}

class Ballena : Mamiferos
{
    public Ballena( string name ) : base( name )
    {

    }

    public void Nadar()
    {

        Console.WriteLine( "Soy capaz de nadar" );

    }
}

class Caballo : Mamiferos, IMamiferosTerrestres
{

    public Caballo( string name ) : base( name )
    {

    }

    public void Galopar()
    {

        Console.WriteLine( "Galopo xd" );

        Respirar();

    }

    public int numPatas()
    {

        return 4;

    }
}

class Humano : Mamiferos
{
    public Humano( string name ) : base( name )
    {

    }

    public override void Pensar()
    {

        Console.WriteLine( "Estoy pensando xd" );

    }
}

class Gorila : Mamiferos, IMamiferosTerrestres
{
    public Gorila( string name ) : base( name )
    {

    }

    public void Trepar()
    {

        Console.WriteLine( "Puedo trepar xd" );

    }

    public override void Pensar()
    {

        Console.WriteLine( "Pensar en gorila" );

    }

    public int numPatas()
    {

        return 2;

    }
}