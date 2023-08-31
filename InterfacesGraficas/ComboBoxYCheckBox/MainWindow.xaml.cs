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

namespace ComboBoxYCheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int _allCheked = 0;

        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> list = new List<Capitales>();

            list.Add( new Capitales { PNAME = "Santiago" } );
            list.Add( new Capitales { PNAME = "Sau Paulo" } );
            list.Add( new Capitales { PNAME = "Buenos Aires" } );
            list.Add( new Capitales { PNAME = "Bogota" } );
            list.Add( new Capitales { PNAME = "Lima" } );

            Cap.ItemsSource = list;

        }

        private void All_Checked( object sender, RoutedEventArgs e )
        {

            Santiago.IsChecked = true;
            SP.IsChecked = true;
            BBAA.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;

            _allCheked = 5;

        }

        private void All_Unchecked( object sender, RoutedEventArgs e )
        {

            Santiago.IsChecked = false;
            SP.IsChecked = false;
            BBAA.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;

            _allCheked = 0;

        }

        private void Checked( object sender, RoutedEventArgs e )
        {
            _allCheked++;

            if (_allCheked == 5)
            {
                All.IsChecked = true;
            }
            else if (_allCheked == 0)
            {
                All.IsChecked = false;
            }
            else All.IsChecked = null;

        }

        private void Unchecked( object sender, RoutedEventArgs e )
        {
            _allCheked--;

            if (_allCheked == 5)
            {
                All.IsChecked = true;
            }
            else if (_allCheked == 0)
            {
                All.IsChecked = false;
            }
            else All.IsChecked = null;

        }
    }

    public class Capitales
    {

        public string PNAME { get; set; }

    }
}
