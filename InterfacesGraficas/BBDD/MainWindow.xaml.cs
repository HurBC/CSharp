using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

            // Inicializa la conexión a la base de datos recuperando la cadena de conexión desde el archivo de configuración de la aplicación.
            string ConnectionBD = ConfigurationManager.ConnectionStrings["BBDD.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            // Crea un objeto SqlConnection y le pasa la cadena de conexión a la base de datos como parámetro.
            _connection = new SqlConnection( ConnectionBD );

            // Llama al método para mostrar los nombres de los clientes.
            MostrarNombres();

            All_Products();

        }

        private void MostrarNombres()
        {

            try
            {
                // Consulta SQL para recuperar datos de la tabla "Cliente".
                string Query = "SELECT * FROM Cliente";

                // Utiliza un SqlDataAdapter para ejecutar la consulta y recuperar datos en un DataTable.
                SqlDataAdapter sqlData = new SqlDataAdapter(Query, _connection);

                using (sqlData)
                {

                    // Crea un DataTable para almacenar los datos recuperados.
                    DataTable data = new DataTable();

                    // Llena el DataTable con los resultados de la consulta.
                    sqlData.Fill( data );

                    // Configura la vinculación de datos para un elemento de interfaz de usuario (ClientesList) para mostrar los nombres de los clientes.
                    ClientesList.DisplayMemberPath = "nombre";
                    ClientesList.SelectedValuePath = "Id";
                    ClientesList.ItemsSource = data.DefaultView;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }

        }

        private void MostrarPedidos()
        {
            try
            {

                // Consulta SQL para recuperar datos de la tabla "Pedido" al unirlo con la tabla "Cliente" usando la relación entre sus Id.
                string Query = "SELECT * FROM Pedido p INNER JOIN Cliente c ON c.Id = p.cCliente" +
                " WHERE c.Id=@ClienteID";

                // Crea un objeto SqlCommand con la consulta y la conexión establecida.
                SqlCommand command = new SqlCommand(Query, _connection);

                // Crea un SqlDataAdapter para ejecutar el comando SQL.
                SqlDataAdapter sqlData = new SqlDataAdapter(command);

                using (sqlData)
                {

                    // Agrega un parámetro al comando para filtrar por el ID del cliente seleccionado en la lista.
                    command.Parameters.AddWithValue( "@ClienteID", ClientesList.SelectedValue );

                    // Crea un DataTable para almacenar los datos recuperados.
                    DataTable data = new DataTable();

                    // Llena el DataTable con los resultados de la consulta.
                    sqlData.Fill( data );

                    // Configura la vinculación de datos para un elemento de interfaz de usuario (ProductosList) para mostrar la fecha de pedido.
                    FechaPedidosList.DisplayMemberPath = "fechaPedido";
                    FechaPedidosList.SelectedValuePath = "Id";
                    FechaPedidosList.ItemsSource = data.DefaultView;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        private void All_Products()
        {
            try
            {

                // Consulta SQL para recuperar datos de la tabla "Pedido" al unirlo con la tabla "Cliente" usando la relación entre sus Id.
                string Query = "SELECT *, CONCAT(P.cCliente, ' ', P.fechaPedido, ' ', P.formaPago) as 'Info_Pedido'" +
                   "FROM Pedido P";

                SqlDataAdapter sqlData = new SqlDataAdapter(Query, _connection);

                using (sqlData)
                {
                    DataTable data = new DataTable();

                    // Llena el DataTable con los resultados de la consulta.
                    sqlData.Fill( data );

                    // Configura cómo se muestra la información en la lista PedidosList.
                    PedidosList.DisplayMemberPath = "Info_Pedido"; // Muestra "Info_Pedido".
                    PedidosList.SelectedValuePath = "Id"; // Usa "Id" como valor seleccionado.
                    PedidosList.ItemsSource = data.DefaultView; // Establece los datos de origen como la vista predeterminada de la tabla data.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }

        }

        private void ClientesList_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            // Llama al método para mostrar los pedidos para el cliente seleccionado cuando cambia la selección.
            MostrarPedidos();
        }

        SqlConnection _connection;

        private void Button_Click( object sender, RoutedEventArgs e )
        {

            // Consulta SQL para eliminar un pedido por su Id.
            string Query = "DELETE FROM Pedido WHERE Id = @PedidoID";

            // Crea un comando SQL con la consulta y la conexión proporcionadas.
            SqlCommand command = new SqlCommand(Query, _connection);

            // Abre la conexión a la base de datos.
            _connection.Open();

            // Establece el valor del parámetro "@PedidoID" con el valor seleccionado de la lista PedidosList.
            command.Parameters.AddWithValue( "@PedidoID", PedidosList.SelectedValue );

            // Ejecuta la consulta SQL para eliminar el pedido.
            command.ExecuteNonQuery();

            // Llama al método All_Products para actualizar la lista de pedidos después de la eliminación.
            All_Products();

            // Cierra la conexión a la base de datos después de realizar la operación.
            _connection.Close();

        }
    }
}
