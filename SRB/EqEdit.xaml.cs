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
    public partial class EqEdit : Window
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";
        private int eqId;
        public EqEdit()
        {
            InitializeComponent();
        }

        private void SkladEd_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string commandText = "select * from Оборудование";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Оборудование]");
            SkladEd.ItemsSource = ds.Tables["[Оборудование]"].DefaultView;
            conn.Close();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string newEqName = equipmentNameTextBox.Text;
                string newEqDesc = equipmentDescriptionTextBox.Text;
                if (newEqName.Length != 0 && newEqDesc.Length != 0 && eqId != 0)
                {
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    SqlCommand myCommand = conn.CreateCommand();
                    myCommand.CommandText = "update Оборудование set [Название Оборудования] = @newEqName, " +
                        "[Описание Оборудования] = @newEqDesc " +
                        "Where [Код оборудования] = @eqId";
                    myCommand.Parameters.Add("@newEqname", SqlDbType.VarChar).Value = newEqName;
                    myCommand.Parameters.Add("@newEqDesc", SqlDbType.VarChar).Value = newEqDesc;
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

        private void SkladEd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView selectedRow = dg.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                equipmentNameTextBox.Text = selectedRow["Название Оборудования"].ToString();
                equipmentDescriptionTextBox.Text = selectedRow["Описание оборудования"].ToString();
                eqId = Int32.Parse(selectedRow["Код оборудования"].ToString());
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
