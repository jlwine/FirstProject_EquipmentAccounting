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
    
    public partial class AddEquipment : Page
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";

        public AddEquipment()
        {
            InitializeComponent();
            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //Sklad2.Visibility = Visibility.Visible;
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //string commandText = "select [Название Оборудования], [Описание Оборудования] from Оборудование";
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            //DataSet ds = new DataSet();
            //dataAdapter.Fill(ds, "[Оборудование]");
            //Sklad2.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
            //conn.Close();
        }

      


        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //string EquipName = EquipmentName.Text;
                //string Opisanie = OpisanieBox.Text;
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "insert into Оборудование ([Название Оборудования], [Описание Оборудования]) values (@EquipName, @Opisanie)";
                //myCommand.Parameters.Add("@EquipName", SqlDbType.VarChar).Value = EquipName;
                //myCommand.Parameters.Add("@Opisanie", SqlDbType.VarChar).Value = Opisanie;


                int Dobavlenie = myCommand.ExecuteNonQuery();
                if (Dobavlenie != 0)
                {
                    MessageBox.Show("Оборудование добавлено");
                    //EquipmentName.Clear();
                    //OpisanieBox.Clear();

                }
                else
                {
                    MessageBox.Show("Не удалось добавить новое оборудование");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля выбраны");
            }
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //string commandText = "select [Название Оборудования], [Описание Оборудования] from Оборудование";
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            //DataSet ds = new DataSet();
            //dataAdapter.Fill(ds, "[Оборудование]");
            //Sklad2.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
            //conn.Close();

            MessageBox.Show("Таблица обновлена");
        }
    }
}
