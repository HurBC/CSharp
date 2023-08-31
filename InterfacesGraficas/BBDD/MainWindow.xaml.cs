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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BBDD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string ConnectionBD = ConfigurationManager.ConnectionStrings["BBDD.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            _connection = new SqlConnection(ConnectionBD);

            MostrarNombres();

        }

        private void MostrarNombres()
        {

            string Query = "SELECT * FROM Cliente";

            SqlDataAdapter sqlData = new SqlDataAdapter(Query, _connection);

            using (sqlData)
            {

                DataTable data = new DataTable();

                sqlData.Fill(data);

                ClientesList.DisplayMemberPath = "nombre";
                ClientesList.SelectedValuePath = "Id";
                ClientesList.ItemsSource = data.DefaultView;

            }

        }

        SqlConnection _connection;
    }
}
