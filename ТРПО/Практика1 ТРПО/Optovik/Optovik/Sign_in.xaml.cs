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
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Data;
using System.Data.Entity;


namespace Optovik
{
    /// <summary>
    /// Логика взаимодействия для Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Window
    {
        public Sign_in()
        {
            InitializeComponent();
        }
        DataBase database = new DataBase();

        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            tb.Text = passwordBox.Password;
            passwordBox.Visibility = Visibility.Collapsed;
            tb.Visibility = Visibility.Visible;


        }
        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = tb.Text;
            tb.Visibility = Visibility.Collapsed;
            passwordBox.Visibility = Visibility.Visible;
        }

        private void Sign_In_BTN_Click(object sender, RoutedEventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordBox.Password;
            if (login != "")
            {
                if (passwordBox.Password.Length > 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();

                    string querystring = $"select id, login, password from users where login='{login}' and password='{password}'";

                    SqlCommand command = new SqlCommand(querystring, database.GetConnection());

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                        Osnova osn = new Osnova();
                        osn.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ошибка!", "Аккаунта не существует!");
                }
                else
                    MessageBox.Show("Введите пароль!");
            }
            else
                MessageBox.Show("Введите логин!!");
        }

        private void Registration_BTN_Click(object sender, RoutedEventArgs e)
        {
            var win = new Sign_up();
            win.Show();
            this.Close();
        }
    }
}
