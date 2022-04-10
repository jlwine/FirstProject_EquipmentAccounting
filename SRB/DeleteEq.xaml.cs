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
    
    public partial class DeleteEq : Page
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";
        public DeleteEq()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            SkladDelete.Visibility = Visibility.Visible;
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = "select [Название Оборудования], [Описание Оборудования] from Оборудование";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Оборудование]");
            SkladDelete.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
            conn.Close();
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT [Название Оборудования] FROM Оборудование", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ComboEq.Items.Add(sqlDataReader["Название Оборудования"]);
                }
                sqlConnection.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(ComboEq.Text == "")
            {
                MessageBox.Show("Выберете наименование оборудования!");
            }
            else
            {
                try
                {
                    string equipnam = ComboEq.Text;
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = $"DELETE FROM Оборудование WHERE [Название Оборудования] = @name";
                    myCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboEq.SelectedItem;
                    int Izmenenie = myCommand.ExecuteNonQuery();


                    if (Izmenenie != 0)
                    {
                        MessageBox.Show("Оборудование было удалено");
                    }
                    else

                    {
                        MessageBox.Show("Не удалось удалить");
                    }
                }
                catch (Exception)

                {
                    MessageBox.Show("Не выбрано название оборудования!");
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = "select [Название Оборудования], [Описание Оборудования] from Оборудование";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Оборудование]");
            SkladDelete.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
            conn.Close();
            MessageBox.Show("Таблица обновлена");

        }
    } 
}
