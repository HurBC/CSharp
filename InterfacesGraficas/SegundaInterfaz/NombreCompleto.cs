using System.ComponentModel;

namespace SegundaInterfaz
{
    public class NombreCompleto : INotifyPropertyChanged
    {

        private string _nombre, _apellido, _nombre_completo;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged( string propertyName )
        {

            if (PropertyChanged != null)
            {
                PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
            }

        }

        public string Nombre
        {

            get { return _nombre; }
            set
            {

                _nombre = value;

                OnPropertyChanged( "nombre_completo" );
            }

        }

        public string Apellido
        {

            get { return _apellido; }
            set
            {
                _apellido = value;

                OnPropertyChanged( "nombre_completo" );

            }

        }

        public string nombre_completo
        {

            get { return Nombre + " " + Apellido; }
            set
            {
                string[] fullName = value.Split(' ');

                if (fullName.Length == 2)
                {

                    Nombre = fullName[0];

                    Apellido = fullName[1];

                }

                OnPropertyChanged( "Nombre" );
                OnPropertyChanged( "Apellido" );

            }

        }
    }
}
