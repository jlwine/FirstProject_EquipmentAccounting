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
    
    public partial class Stock : Page
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";

        public Stock()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            EqAdd add = new EqAdd();
            add.Show();

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            EqEdit edit = new EqEdit();
            edit.Show();
        }

       

        private void Sklad_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = "select [Название оборудования],[Описание оборудования] from Оборудование";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Оборудование]");
            Sklad.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
            conn.Close();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ABCchck.IsChecked == true)
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                string commandText = "SELECT [Название оборудования], [Описание оборудования] from Оборудование ORDER BY [Название Оборудования]";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "[Оборудование]");
                Sklad.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
                conn.Close();
                MessageBox.Show("Таблица обновлена");
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                string commandText = "select [Название Оборудования], [Описание Оборудования] from Оборудование";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "[Оборудование]");
                Sklad.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
                conn.Close();
                MessageBox.Show("Таблица обновлена");
            }
            
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            EqDeleting delete = new EqDeleting();
            delete.Show();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        
        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = $"SELECT [Название оборудования], [Описание оборудования] from Оборудование WHERE[Название Оборудования] LIKE '%{SearchBox.Text}%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Оборудование]");
            Sklad.ItemsSource = ds.Tables[0].DefaultView;

           
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = "select [Название Оборудования], [Описание Оборудования] from Оборудование";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Оборудование]");
            Sklad.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
            conn.Close();
            SearchBox.Clear();
            ABCchck.IsChecked = false;
        }

        private void StockFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
