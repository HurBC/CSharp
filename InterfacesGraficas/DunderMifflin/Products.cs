using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace DunderMifflin
{

    public class Products
    {

        public int IdP { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

    }

    partial class MainWindow
    {

        private void ShowCATS()
        {

            try
            {

                string Query = "SELECT * FROM Categories";

                SqlDataAdapter sqlData = new SqlDataAdapter(Query, _connection);

                using (sqlData)
                {

                    DataTable data = new DataTable();

                    sqlData.Fill( data );

                    CatList.DisplayMemberPath = "name_cat";
                    CatList.SelectedValuePath = "Id_cat";
                    CatList.ItemsSource = data.DefaultView;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }

        }

        private void ShowPRO()
        {
            try
            {
                string Query = "SELECT * FROM Products INNER JOIN Categories ON Id_cat = CATID WHERE Id_cat = @CAT";

                SqlCommand sqlCommand = new SqlCommand(Query, _connection);
                sqlCommand.Parameters.AddWithValue( "@CAT", CatList.SelectedValue );

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);

                using (sqlData)
                {
                    DataTable data = new DataTable();
                    sqlData.Fill( data );

                    List<Products> products = new List<Products>();

                    foreach (DataRow row in data.Rows)
                    {
                        Products product = new Products
                        {
                            IdP = Convert.ToInt32(row["Id_pro"]),
                            Name = row["name_pro"].ToString(),
                            Price = Convert.ToDouble(row["price"]),
                            Stock = Convert.ToInt32(row["stock"])
                        };

                        products.Add( product );
                    }

                    ProList.ItemsSource = products; // Actualizado

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }


    }

}