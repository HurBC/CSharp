namespace Herencia
{

    //Padre
    class Mamiferos : Animales
    {

        public Mamiferos( string name )
        {

            _nombreSerVivo = name;

        }

        public virtual void Pensar()
        {

            Console.WriteLine( "Pensamiento basico instintitvo" );

        }

        public void CuidarCrias()
        {

            Console.WriteLine( "Cuido a mis crias xd" );

        }

        public override void GetNombre()
        {

            Console.WriteLine( "El nombre del mamifero es: {0}", _nombreSerVivo );

        }

        private string _nombreSerVivo;

    }
}
