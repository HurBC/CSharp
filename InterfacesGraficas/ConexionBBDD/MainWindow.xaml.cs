using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace ConexionBBDD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            string ConnectionDB = ConfigurationManager.ConnectionStrings["ConexionBBDD.Properties.Settings.GestionPedidosDataSet"].ConnectionString;

            _connection = new SqlConnection(ConnectionDB);

            MuestraClientes();

        }

        private void MuestraClientes()
        {

            string Consulta = "SELECT * FROM Cliente";

            SqlDataAdapter adapter = new SqlDataAdapter(Consulta, _connection);

            using (adapter)
            {

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                ListaClientes.DisplayMemberPath = "nombre";
                ListaClientes.SelectedValuePath = "Id";
                ListaClientes.ItemsSource = dt.DefaultView;

            }

        }

        SqlConnection _connection;
    }
}
