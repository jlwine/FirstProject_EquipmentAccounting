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
    public partial class EqAccountReg : Window
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";

        public EqAccountReg()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string EqD = null;
                string EqP = null;


                
                switch (EqDepartName.Text)
                {
                    case "Гинекология":
                        EqD = "1";
                        break;
                    case "Урология":
                        EqD = "2";
                        break;
                    case "Лаборатория":
                        EqD = "3";
                        break;
                    case "Рентген кабинет":
                        EqD = "4";
                        break;
                    case "Узи кабинет":
                        EqD = "5";
                        break;
                    case "Стоматология":
                        EqD = "6";
                        break;
                    case "Физиокабинет":
                        EqD = "7";
                        break;
                    case "Функционально-диагностический кабинет":
                        EqD = "8";
                        break;

                }
                switch (EqProvider.Text)
                {
                    case "Топаз":
                        EqP = "1";
                        break;
                    case "Мед.техника":
                        EqP = "2";
                        break;
                    case "Мед.логистика":
                        EqP = "3";
                        break;
                    case "ООО Евромед":
                        EqP = "4";
                        break;
                    case "ООО Еламед - Сибирь":
                        EqP = "5";
                        break;
                }
                int EquipN = EqName.SelectedIndex;
                string EquipDep = EqDepartName.Text;
                string EqMoney = EqHWM.Text;
                string EqAmout = EqCount.Text;
                string EqProv = EqProvider.Text;
                string EqDate = EqDateRegister.Text;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = $"INSERT INTO [Учёт оборудования] " +
                $"([Код оборудования],[Код отделения], Стоимость, Количество, [Код поставщика], [Дата регистрации]) " +
                $"VALUES (@EqName, @EqDepartName, @EqHWM, @EqCount, @EqProvider, @EqDateRegister)";
                myCommand.Parameters.Add("@EqName", SqlDbType.VarChar).Value = EqName.SelectedIndex + 1;
                myCommand.Parameters.Add("@EqDepartName", SqlDbType.Int).Value = Int32.Parse(EqD);
                myCommand.Parameters.Add("@EqHWM", SqlDbType.Int).Value = Int32.Parse(EqMoney);
                myCommand.Parameters.Add("@EqCount", SqlDbType.Int).Value = Int32.Parse(EqAmout);
                myCommand.Parameters.Add("@EqProvider", SqlDbType.Int).Value = Int32.Parse(EqP);
                myCommand.Parameters.Add("@EqDateRegister", SqlDbType.VarChar).Value = EqDate;


                int Dobavlenie = myCommand.ExecuteNonQuery();
                if (Dobavlenie != 0)
                {
                    MessageBox.Show("Оборудования было успешно зарегистрировано");
                }
                else
                {
                    MessageBox.Show("Не удалось зарегистрировать оборудование");
                }
            }
            catch (Exception s)
            {
                MessageBox.Show($"Проверьте, все ли поля заполнены, {s}");
            }
        }

        private void EqName_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT [Название оборудования] from Оборудование", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    EqName.Items.Add(sqlDataReader["Название оборудования"]);
                }
                sqlConnection.Close();
            }
        }

        private void EqDepartName_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT [Название отделения] from Отделения", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    EqDepartName.Items.Add(sqlDataReader["Название отделения"]);
                }
                sqlConnection.Close();
            }
        }

        private void EqProvider_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT Поставщик from Поставщик", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    EqProvider.Items.Add(sqlDataReader["Поставщик"]);
                }
                sqlConnection.Close();
            }
        }
    }
}
