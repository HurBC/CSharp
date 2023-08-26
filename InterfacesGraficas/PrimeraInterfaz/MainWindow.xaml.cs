using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace PrimeraInterfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _num1, _num2;
        private string _ecuation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void _screen(string B, string E=null )
        {
            if (Screen.Text != "0")
            {
                string numbers = "0123456789";

                Regex rx = new Regex(B, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                Match match = rx.Match(numbers);

                if (match.Success) Screen.Text += B;

                else
                {
                    if (_num1 != null)
                        _num2 = int.Parse( Screen.Text );

                    else
                        _num1 = int.Parse( Screen.Text );

                    _ecuation = E;
                    Screen.Text += (" {0} ", B);
                }

            }
            else Screen.Text = B;
        }

        private void Button_Click_num( object sender, RoutedEventArgs e )
        {

            if(sender is Button btn)
            {

                _screen(btn.Content.ToString());

            }

        }

        private void Clear_Click( object sender, RoutedEventArgs e )
        {

            if (sender is Button btn)
            {

                Screen.Text = "0";

            }

        }

        private void Equals_Click( object sender, RoutedEventArgs e )
        {


        }

        private void Events_Click( object sender, RoutedEventArgs e )
        {

            if (sender is Button btn)
            {

                _screen( btn.Content.ToString(), btn.Name.ToString() );

            }

        }
    }
}
