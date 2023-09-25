using System.Collections.Generic;
using System.Configuration;
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

            string ConnectSQL = ConfigurationManager.ConnectionStrings["DunderMifflin.Properties.Settings.DunderMifflinConnectionString"].ConnectionString;

            _connection = new SqlConnection( ConnectSQL );

            ShowDEPS();
            ShowCATS();

        }

        SqlConnection _connection;

        private void DepList_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            ShowEMPS();
        }

        private void CatList_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            ShowPRO();
        }
    }
}
