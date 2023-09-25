using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace DunderMifflin
{
    public class Employee
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }

    public partial class MainWindow
    {

        private void ShowDEPS()
        {

            try
            {

                string Query = "SELECT * FROM Departaments";

                SqlDataAdapter sqlData = new SqlDataAdapter(Query, _connection);

                using (sqlData)
                {

                    DataTable data = new DataTable();

                    sqlData.Fill(data);

                    DepList.DisplayMemberPath = "name_dep";
                    DepList.SelectedValuePath = "Id_dep";
                    DepList.ItemsSource = data.DefaultView;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }

        }

        private void ShowEMPS()
        {
            try
            {
                string Query = "SELECT * FROM Employees INNER JOIN Departaments ON Id_dep = DEPID WHERE Id_dep = @DEP";

                SqlCommand sqlCommand = new SqlCommand(Query, _connection);
                sqlCommand.Parameters.AddWithValue( "@DEP", DepList.SelectedValue );

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);

                using (sqlData)
                {
                    DataTable data = new DataTable();
                    sqlData.Fill( data );

                    List<Employee> listaEmpleados = new List<Employee>();

                    foreach (DataRow row in data.Rows)
                    {
                        Employee empleado = new Employee
                        {
                            Id = Convert.ToInt32(row["Id_emp"]),
                            FirstName = row["first_name"].ToString(),
                            LastName = row["last_name"].ToString(),
                            Age = Convert.ToInt32(row["age"])
                        };

                        listaEmpleados.Add( empleado );
                    }

                    EmpList.ItemsSource = listaEmpleados; // Actualizado

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

    }

}