using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace DunderMifflin
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Conexion SQL
            string SQL = "DunderMifflin.Properties.Settings.DunderMifflinDataConnectionString";

            //Ir a explorador de soluciones, click derecho, agregar referencia->System.Configuration
            string ConnectSQL = ConfigurationManager.ConnectionStrings[SQL].ConnectionString;

            _connection = new SqlConnection( ConnectSQL );

            ShowCat();
            ShowDep();

        }

        private void ShowDep()
        {

            try
            {

                //Consulta SQL
                string Query = "SELECT * FROM Departament";

                SqlDataAdapter adapter = new SqlDataAdapter(Query, _connection);

                using (adapter)
                {

                    DataTable data = new DataTable();

                    adapter.Fill( data );

                    DepartamentList.DisplayMemberPath = "name";
                    DepartamentList.SelectedValuePath = "IdDEP";
                    DepartamentList.ItemsSource = data.DefaultView;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        private void ShowCat()
        {

            try
            {

                //Consulta SQL
                string Query = "SELECT * FROM Categories";

                SqlDataAdapter adapter = new SqlDataAdapter(Query, _connection);

                using (adapter)
                {

                    DataTable data = new DataTable();

                    adapter.Fill( data );

                    CategoriesList.DisplayMemberPath = "name_cat";
                    CategoriesList.SelectedValuePath = "Id";
                    CategoriesList.ItemsSource = data.DefaultView;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        private void ShowProducts()
        {

            try
            {

                //Consulta SQL
                string Query = "SELECT * FROM Categories C INNER JOIN Products P ON C.Id = P.CatID WHERE C.Id = @CAT";

                SqlCommand command = new SqlCommand(Query, _connection);

                SqlDataAdapter adapter = new SqlDataAdapter( command );

                using (adapter)
                {

                    command.Parameters.AddWithValue("@CAT", CategoriesList.SelectedValue);

                    DataTable data = new DataTable();

                    adapter.Fill( data );

                    ProductsList.DisplayMemberPath = "name_product";
                    ProductsList.SelectedValuePath = "Id";
                    ProductsList.ItemsSource = data.DefaultView;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        private void ShowEmployees()
        {

            try
            {

                //Consulta SQL
                string Query = "SELECT *, CONCAT(E.first_name, E.last_name) as 'Emp' FROM Employee E INNER JOIN Departament D ON E.DepID = D.IdDEP WHERE D.IdDEP = @DEP";

                SqlCommand command = new SqlCommand( Query, _connection );

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                using (adapter)
                {

                    command.Parameters.AddWithValue( "@DEP", DepartamentList.SelectedValue );

                    DataTable data = new DataTable();

                    adapter.Fill( data );

                    Employees.DisplayMemberPath = "Emp";
                    Employees.SelectedValuePath = "Id";
                    Employees.ItemsSource = data.DefaultView;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        private void OneEmp()
        {

            try
            {

                //Consulta SQL
                string Query = "SELECT * FROM Employee E INNER JOIN Departament D ON E.DepID = D.IdDEP WHERE D.IdDEP = @DEP AND E.Id = @EMP";

                SqlCommand command = new SqlCommand( Query, _connection );

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                using (adapter)
                {

                    command.Parameters.AddWithValue( "@DEP", DepartamentList.SelectedValue );
                    command.Parameters.AddWithValue( "@EMP", Employees.SelectedValue );

                    DataTable data = new DataTable();

                    adapter.Fill( data );

                    // Verificar si hay datos antes de mostrarlos
                    if (data.Rows.Count > 0)
                    {
                        string info = "";
                        string NameBox = "";

                        // Construir la cadena de texto con la información
                        foreach (DataRow row in data.Rows)
                        {
                            NameBox = "Info del empleado N°" + row["Id"].ToString();
                            info +=  " Nombre: " + row["first_name"].ToString() + "\n Apellido: " + row["last_name"].ToString() + "\n Edad: " + row["age"].ToString() + "\n Departamento: " + row["name"].ToString() +
                                "\n Salario: " + row["salary"].ToString();
                        }

                        // Mostrar la información en un MessageBox
                        MessageBox.Show( info, NameBox );
                    }
                    else
                    {
                        MessageBox.Show( "No se encontraron resultados.", "Sin Resultados" );
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }

        }

        private void OnePro()
        {

            try
            {

                //Consulta SQL
                string Query = "SELECT *, P.Id as 'PROID' FROM Categories C INNER JOIN Products P ON C.Id = P.CatID WHERE C.Id = @CAT AND P.Id = @PRO";

                SqlCommand command = new SqlCommand( Query, _connection );

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                using (adapter)
                {

                    command.Parameters.AddWithValue( "@CAT", CategoriesList.SelectedValue );
                    command.Parameters.AddWithValue( "@PRO", ProductsList.SelectedValue );

                    DataTable data = new DataTable();

                    adapter.Fill( data );

                    // Verificar si hay datos antes de mostrarlos
                    if (data.Rows.Count > 0)
                    {
                        string info = "";
                        string NameBox = "";

                        // Construir la cadena de texto con la información
                        foreach (DataRow row in data.Rows)
                        {
                            NameBox = "Info del producto N°" + row["PROID"].ToString();
                        }

                        // Mostrar la información en un MessageBox
                        MessageBox.Show( info, NameBox );
                    }
                    else
                    {
                        MessageBox.Show( "No se encontraron resultados.", "Sin Resultados" );
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }

        }

        private void CategoriesList_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if (CategoriesList.SelectedItem != null)
            {

                ShowProducts();

            }

        }

        private void DepartamentList_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if (DepartamentList.SelectedItem != null)
            {
                ShowEmployees();
            }
        }

        private void Employees_MouseDoubleClick( object sender, System.Windows.Input.MouseButtonEventArgs e )
        {
            OneEmp();
        }

        private void ProductsList_MouseDoubleClick( object sender, System.Windows.Input.MouseButtonEventArgs e )
        {
            OnePro();
        }

        SqlConnection _connection;
    }
}
