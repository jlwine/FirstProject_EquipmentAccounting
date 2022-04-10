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
    public partial class EqAccounting : Page
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";
        public EqAccounting()
        {
            InitializeComponent();
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

        private void AccAdd_Click(object sender, RoutedEventArgs e)
        {
            EqAccountReg RegAcc = new EqAccountReg();
            RegAcc.Show();
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(AccountingGrid, "Печать");
            }    
        }

        private void AccDel_Click(object sender, RoutedEventArgs e)
        {
            EqAccountingDel AccDel = new EqAccountingDel();
            AccDel.Show();
        }

        private void AccEdit_Click(object sender, RoutedEventArgs e)
        {
            EqAccountingEdit formEditACC = new EqAccountingEdit();
            formEditACC.Show();
        }



        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = $"SELECT [Название оборудования], [Описание оборудования] from Оборудование WHERE[Название Оборудования] LIKE '%{SearchBox.Text}%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Оборудование]");
            AccountingGrid.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = "select [Название Оборудования], [Описание Оборудования] from Оборудование";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Оборудование]");
            AccountingGrid.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
            conn.Close();
            SearchBox.Clear();
            ABCchck.IsChecked = false;
        }
    }
    
}
