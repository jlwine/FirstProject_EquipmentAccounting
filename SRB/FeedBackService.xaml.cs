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
    public partial class FeedBackService : Window
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";

        public FeedBackService()
        {
            InitializeComponent();
        }

        private void FeedBackGrid_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = "select * from Поломки";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Поломки]");
            FeedBackGrid.ItemsSource = ds.Tables["[Поломки]"].DefaultView;
            conn.Close();
        }
    }
}
