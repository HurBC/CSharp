namespace Destructores
{
    class Program
    {
        static void Main( string[] args )
        {

            ManejoArchivos MiArchivo = new ManejoArchivos();

            MiArchivo.Mensage();

        }
    }

    class ManejoArchivos
    {

        public ManejoArchivos()
        {

            _archivo = new StreamReader(@"D:\CSharp\uwu.txt");

            while((_linea=_archivo.ReadLine()) != null)
            {

                Console.WriteLine(_linea);

                _contador++;

            }

        }

        public void Mensage()
        {

            Console.WriteLine("Hay {0} lineas", _contador);

        }

        //destructor
        ~ManejoArchivos()
        {

            _archivo.Close();

        }
        
        StreamReader _archivo = null;

        int _contador = 0;

        string _linea;

    }
}