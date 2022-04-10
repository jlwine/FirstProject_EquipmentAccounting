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
using System.Data;
using System.Data.SqlClient;

namespace SRB
{

    public partial class Accounting : Page
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";

        public Accounting()
        {
            InitializeComponent();
        }

        public void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT [Название Оборудования] FROM Оборудование", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    EquipCombo.Items.Add(sqlDataReader["Название Оборудования"]);
                }
                sqlConnection.Close();
            }
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = "select * from Учёт_Оборудования";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Учёт_Оборудования]");
            AccountingGrid.ItemsSource = ds.Tables["[Учёт_Оборудования]"].DefaultView;
            conn.Close();
        }

        private void SeparationCombo_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT [Название отделения] FROM Отделения", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    EquipCombo.Items.Add(sqlDataReader["Название отделения"]);
                }
                sqlConnection.Close();
            }
        }
    }
}
