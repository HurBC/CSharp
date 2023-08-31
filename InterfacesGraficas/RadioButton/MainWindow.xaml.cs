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

namespace RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Radial_Checked( object sender, RoutedEventArgs e )
        {
            BitmapImage Bitmap = new BitmapImage();
            string[] Urls = { @"D:\CSharp\InterfacesGraficas\RadioButton\Img\Red.jpg", @"D:\CSharp\InterfacesGraficas\RadioButton\Img\Yellow.jpg", @"D:\CSharp\InterfacesGraficas\RadioButton\Img\Green.jpg" };
            Bitmap.BeginInit();

            if (Red.IsChecked == true)
            {
                Bitmap.UriSource = new Uri( Urls[0] );
                Bitmap.EndInit();
                img.Source = Bitmap;
            }
            else if(Yellow.IsChecked == true)
            {
                Bitmap.UriSource = new Uri( Urls[1] );
                Bitmap.EndInit();
                img.Source = Bitmap;
            }
            else
            {
                Bitmap.UriSource = new Uri( Urls[2] );
                Bitmap.EndInit();
                img.Source = Bitmap;
            }

        }
    }
}
