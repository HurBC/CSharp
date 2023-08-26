namespace Avisos
{
    class AvisosTrafico : IAvisos
    {

        //Constructor
        public AvisosTrafico()
        {

            _remitente = "DGT";

            _mensaje = "Sancion cometida. Paga la wea en menos de 3 dias ctm";

            _fecha = "";

        }

        //Metodos
        public AvisosTrafico( string remitente, string mensaje, string fecha )
        {
            _remitente = remitente;
            _mensaje = mensaje;
            _fecha = fecha;
        }

        public string GetFecha()
        {

            return _fecha;
            
        }

        public void MostrarAviso()
        {

            Console.WriteLine("Mensaje '{0}' a sido enviado por {1} el dia {2}", _mensaje, _remitente, _fecha);

        }

        //campos
        private string _remitente;

        private string _mensaje;

        private string _fecha;
    }
}
