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

    public partial class EqAccountingEdit : Window
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";
        private int eqId;
        public EqAccountingEdit()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newEqName = equipmentNameTextBox.Text;
                string newEqDepart = equipmentDepartTextbox.Text;
                string newEqMoney = equipmentMoneyTextBox.Text;
                string newEqCount = equipmentCountTextBox.Text;
                string newEqProv = equipmentProvTextBox.Text;
                string newEqDate = equipmentDateTextBox.Text;

                if (newEqName.Length != 0 && newEqDepart.Length != 0 && newEqMoney.Length != 0 && newEqCount.Length != 0 && newEqDate.Length != 0 && eqId != 0)
                {
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "update [Учёт оборудования] set [Код оборудования] = @newEqName, " +
                        "[Код отделения] = @newEqDepart " +
                        "[Стоимость] = @newEqMoney " +
                        "[Количество] = @newEqCount " +
                        "[Код поставщика] = @newEqProv " +
                        "[Дата регистрации] = @newEqDate " +
                        "Where [Код оборудования] = @eqId";
                    myCommand.Parameters.Add("@newEqname", SqlDbType.VarChar).Value = newEqName;
                    myCommand.Parameters.Add("@newEqDepart", SqlDbType.VarChar).Value = newEqDepart;
                    myCommand.Parameters.Add("@newEqMoney", SqlDbType.VarChar).Value = newEqMoney;
                    myCommand.Parameters.Add("@newEqCount", SqlDbType.VarChar).Value = newEqCount;
                    myCommand.Parameters.Add("@newEqProv", SqlDbType.VarChar).Value = newEqProv;
                    myCommand.Parameters.Add("@newEqDate", SqlDbType.VarChar).Value = newEqDate;
                    myCommand.Parameters.Add("@eqId", SqlDbType.Int).Value = eqId;
                    conn.Open();
                    myCommand.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Запись успешно изменена");
            }
            catch (Exception)
            {
                MessageBox.Show("Изменения не были внесены");
            }
        }

        private void AccountingGrid_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = $"select Оборудование.[Название Оборудования], Отделения.[Название отделения], Стоимость, Количество, Поставщик.Поставщик, [Дата регистрации] from [Учёт оборудования]" +
                                    "join Оборудование on[Учёт оборудования].[Код оборудования] = Оборудование.[Код оборудования]" +
                                    "join Поставщик on[Учёт оборудования].[Код поставщика] = Поставщик.[Код поставщика]" +
                                    "join Отделения on[Учёт оборудования].[Код отделения] = Отделения.[Код отделения]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Учёт оборудования]");
            AccountingGrid.ItemsSource = ds.Tables["[Учёт оборудования]"].DefaultView;
            conn.Close();
        }

        private void AccountingGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView selectedRow = dg.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                equipmentNameTextBox.Text = selectedRow["Название Оборудования"].ToString();
                equipmentDepartTextbox.Text = selectedRow["Код отделения"].ToString();
                equipmentMoneyTextBox.Text = selectedRow["Стоимость"].ToString();
                equipmentCountTextBox.Text = selectedRow["Количество"].ToString();
                equipmentProvTextBox.Text = selectedRow["Код поставщика"].ToString();
                equipmentDateTextBox.Text = selectedRow["Дата регистрации"].ToString();
                eqId = Int32.Parse(selectedRow["Код оборудования"].ToString());
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    
}
