using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DunderMifflin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employees> _lsEmp = new List<Employees>();
        private List<Products> _lsPro = new List<Products>();

        public string copyText;

        public MainWindow()
        {
            InitializeComponent();

            lstBox.ItemsSource = _lsEmp;
            lstPro.ItemsSource = _lsPro;

        }

        private void AddEmployee(object sender, RoutedEventArgs e)
        {
            if (txt1.Text != "" || txt2.Text != "" || txt3.Text != "")
            {
                _lsEmp.Add( new Employees( txt1.Text, txt2.Text, txt3.Text ) );

                lstBox.ItemsSource = null;
                lstBox.ItemsSource = _lsEmp;

                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
            }
            else MessageBox.Show( "Escribe una wea po ctm" );

        }

        private void AddProduct(Object sender, RoutedEventArgs e)
        {
            if (pro1.Text != "" || pro2.Text != "" || pro3.Text != "")
            {
                _lsPro.Add( new Products( (_lsPro.Count + 1).ToString(), pro1.Text, pro2.Text, pro3.Text ) );

                lstPro.ItemsSource = null;
                lstPro.ItemsSource = _lsPro;

                pro1.Text = "";
                pro2.Text = "";
                pro3.Text = "";
            }
            else MessageBox.Show( "Escribe una wea po ctm" );

        }

        private void Delete_Employee( object sender, RoutedEventArgs e )
        {
            MessageBox.Show( "Hello World" );
        }
    }

    public class Employees
    {
        public string FIRSTNAME
        {
            get { return _firstName; }
        }

        public string LASTNAME
        {
            get { return _lastName; }
        }

        public string AGE
        {
            get { return _age; }
        }

        public Employees(string fname, string lname, string age)
        {

            _firstName = fname;
            _lastName = lname;
            _age = age;

        }

        private string _firstName;
        private string _lastName;
        private string _age;
    }

    public class EmployeeSearch
    {
        String _s;

        public EmployeeSearch( string s )
        {
            _s = s;
        }

        public bool StartsWith( Employees e )
        {
            return e.FIRSTNAME.StartsWith( _s, StringComparison.InvariantCultureIgnoreCase );
        }
    }

    public class Products
    {
        public string ID
        {
            get { return _id; }
        }
        public string NAME
        {
            get { return _name; }
        }
        public string PRICE
        {
            get { return _price; }
        }
        public string STOCK
        {
            get { return _stock; }
        }

        public Products(string id,  string name, string price, string stock)
        {
            _id = id;
            _name = name;
            _price = price;
            _stock = stock;
        }

        private string _id;
        private string _name;
        private string _price;
        private string _stock;
    }
}
