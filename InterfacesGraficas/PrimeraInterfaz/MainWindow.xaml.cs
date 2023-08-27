using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PrimeraInterfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _num1, _num2;
        bool _plus = false, _minus=false, _multiply=false, _divide=false, _equals=false;

        public MainWindow()
        {
            InitializeComponent();

            dot.Cursor = Cursors.No;
            Neg.Cursor = Cursors.No;
            Clear.Foreground = Brushes.White;
            Clear.Background = Brushes.Red;
        }

        private void _screen(string B, string E=null )
        {
            if (Screen.Text != "0")
            {

                if(Screen.Text == "0" || _equals == true)
                {

                    Screen.Text = B;

                    _equals = false;

                }
                else Screen.Text += B;

            }
            else Screen.Text = B;
        }

        private void Result()
        {
            _num2 = double.Parse( Screen.Text );

            if( _plus )
            {
                double result = _num1 + _num2;

                Screen.Text = result.ToString();

                _equals = true;

            }

            if (_minus)
            {
                double result = _num1 - _num2;

                Screen.Text = result.ToString();

                _equals = true;

            }

            if (_multiply)
            {
                double result = _num1 * _num2;

                Screen.Text = result.ToString();

                _equals = true;

            }

            if (_divide)
            {
                double result = _num1 / _num2;

                Screen.Text = result.ToString();

                _equals = true;

            }

        }

        private void Button_Click_num( object sender, RoutedEventArgs e )
        {

            if(sender is Button btn)
            {

                switch (btn.Name)
                {

                    case "Plus":

                        _plus = true;

                        _num1 = double.Parse( Screen.Text );

                        Screen.Text = "0";

                        break;

                    case "Minus":

                        _minus = true;

                        _num1 = double.Parse( Screen.Text );

                        Screen.Text = "0";

                        break;

                    case "Mult":

                        _multiply = true;

                        _num1 = double.Parse( Screen.Text );

                        Screen.Text = "0";

                        break;

                    case "Div":

                        _divide = true;

                        _num1 = double.Parse( Screen.Text );

                        Screen.Text = "0";

                        break;

                    case "Equals":

                        Result();

                        break;

                    case "Clear":

                        Screen.Text = "0";

                        _minus = false;
                        _plus = false;
                        _multiply = false;
                        _divide = false;
                        _equals = false;

                        break;

                    default:

                        _screen( btn.Content.ToString() );

                        break;

                }

            }

        }
    }
}
