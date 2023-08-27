using System.Collections.Generic;
using System.Windows;

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

            List<Poblacion> poblaciones = new List<Poblacion>();

            poblaciones.Add( new Poblacion( "Santiago", "Temuco", 17, 11 ) );
            poblaciones.Add( new Poblacion( "Concepcion", "Viña del mar", 14, 14 ) );
            poblaciones.Add( new Poblacion( "Chiloe", "Talca", 10, 19 ) );
            poblaciones.Add( new Poblacion( "Arica", "Puerto Williams", 18, 2.5 ) );


            lstBox.ItemsSource = poblaciones;
            lstBox.SelectionChanged += show_info;

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
        public Poblacion( string p1, string p2, double t1, double t2 )
        {
            Poblacion1 = p1;
            Poblacion2 = p2;
            Temperatura1 = t1;
            Temperatura2 = t2;

            if(t1 < t2) Progress = t2 - t1;
            else Progress = t1 - t2;

        }

        public string Poblacion1 { get; set; }
        public double Temperatura1 { get; set; }
        public string Poblacion2 { get; set; }
        public double Temperatura2 { get; set; }
        public double Progress { get; set; }
    }

}
