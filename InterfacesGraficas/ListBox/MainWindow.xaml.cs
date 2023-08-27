using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            pob1.MouseLeftButtonDown += Pob1_MouseLeftButtonDown;

            List<Poblacion> poblaciones = new List<Poblacion>();

            poblaciones.Add( new Poblacion() { Poblacion1 = "Santiago", Poblacion2 = "Temuco", Temperatura1 = 15, Temperatura2 = 11 } );
            poblaciones.Add( new Poblacion() { Poblacion1 = "Concepcion", Poblacion2 = "Viña del mar", Temperatura1 = 13, Temperatura2 = 12 } );
            poblaciones.Add( new Poblacion() { Poblacion1 = "Rancagua", Poblacion2 = "Nancagua", Temperatura1 = 15, Temperatura2 = 15 } );
            poblaciones.Add( new Poblacion() { Poblacion1 = "Arica", Poblacion2 = "Puerto Williams", Temperatura1 = 25, Temperatura2 = 5 } );


            lstBox.ItemsSource = poblaciones;
        }

        private void show_info( object sender, RoutedEventArgs e )
        {
            MessageBox.Show( ( lstBox.SelectedItem as Poblacion ).Poblacion1 + " " +
                ( lstBox.SelectedItem as Poblacion ).Temperatura1 + "°C " +
                ( lstBox.SelectedItem as Poblacion ).Poblacion2 + " " +
                ( lstBox.SelectedItem as Poblacion ).Temperatura2 + "°C " );
        }
    }

    public class Poblacion
    {


        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }
        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }
    }

}
