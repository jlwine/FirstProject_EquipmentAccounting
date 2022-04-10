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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace SRB
{
    public partial class EqDeleting : Window
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";

        public EqDeleting()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ComboDel.Text == "")
            {
                MessageBox.Show("Выберете наименование оборудования!");
            }
            else
            {
                try
                {
                    string equipnam = ComboDel.Text;
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = $"DELETE FROM Оборудование WHERE [Название Оборудования] = @name";
                    myCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = ComboDel.SelectedItem;
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

        private void ComboDel_Loaded_1(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT [Название Оборудования] FROM Оборудование", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ComboDel.Items.Add(sqlDataReader["Название Оборудования"]);
                }
                sqlConnection.Close();
            }
        }
    }
}
