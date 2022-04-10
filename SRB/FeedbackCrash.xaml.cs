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
    public partial class FeedbackCrash : Page
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";

        public FeedbackCrash()
        {
            InitializeComponent();
        }

        private void CrashCombo_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select Оборудование.[Название Оборудования] from [Учёт оборудования] " +
                    "join Оборудование on [Учёт оборудования].[Код оборудования] = Оборудование.[Код оборудования]", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    CrashCombo.Items.Add(sqlDataReader["Название Оборудования"]);
                }
                sqlConnection.Close();
            }
        }
    }
}
