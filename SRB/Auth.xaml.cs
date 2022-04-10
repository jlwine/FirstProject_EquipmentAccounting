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
    public partial class Auth : Window
    {
        public string ConnectionString = "Data Source=DANTEMARUU;Initial Catalog=SRBequipment;Integrated Security=True";


        public Auth()
        {
            InitializeComponent();
        }
        public string commandText;
        public int Userole;

        private void Login(string command, string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                sqlCommand.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
                sqlCommand.Parameters.Add("@uP", SqlDbType.VarChar).Value = password;

                if (loginbox.Text == "" || passwordbox.Password == "")
                {
                    MessageBox.Show("Заполните поля");
                }
                else
                {
                    dataAdapter.SelectCommand = sqlCommand;
                    dataAdapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден или некорректно введены данные!");
                    }

                }
                connection.Close();
            }
        }
        private void Admin()
        {
            MainWindow formAdmin = new MainWindow();
            formAdmin.Owner = this;
            formAdmin.Show();
            this.Hide();
        }

        private void User(string login, string pass)
        {
            FeedBackService formUser = new FeedBackService();
            formUser.Owner = this;
            formUser.Show();
            this.Hide();
        }
        private int IDrole(string command, string login, string password)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                int temp;
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.Add("uL", SqlDbType.VarChar).Value = login;
                sqlCommand.Parameters.Add("uP", SqlDbType.VarChar).Value = password;
                temp = Convert.ToInt32(sqlCommand.ExecuteScalar());
                sqlConnection.Close();
                return temp;
            }
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LogIN_Click(object sender, RoutedEventArgs e)
        {
            commandText = "select Логин, Пароль, [Код роли] from Авторизацияя where Логин = @uL AND Пароль = @uP";
            Login(commandText, loginbox.Text, passwordbox.Password);

            commandText = "select [Код роли] from Авторизацияя where Логин = @uL and Пароль = @uP";
            Userole = IDrole(commandText, loginbox.Text, passwordbox.Password);
            switch (Userole)
            {
                case (1):
                    Admin();
                    break;
                case (2):
                    User(loginbox.Text, passwordbox.Password);
                    break;
            }
        }
    }

}
