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
    public partial class EqAccountingDel : Window
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";

        public EqAccountingDel()
        {
            InitializeComponent();
        }

        private void EqAccN_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select Оборудование.[Название Оборудования] from [Учёт оборудования] " +
                    "join Оборудование on [Учёт оборудования].[Код оборудования] = Оборудование.[Код оборудования]", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    EqAccN.Items.Add(sqlDataReader["Название Оборудования"]);
                }
                sqlConnection.Close();
            }
        }

        private void AccDelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (EqAccN.Text == "")
            {
                MessageBox.Show("Выберете наименование оборудования!");
            }
            else
            {
                try
                {
                    string EquipN = EqAccN.Text;
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    conn.Open();
                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = $"DELETE FROM [Учёт Оборудования] WHERE [Код учёта] = @name";
                    myCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = EqAccN.SelectedIndex + 1;
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
    }
    
}
