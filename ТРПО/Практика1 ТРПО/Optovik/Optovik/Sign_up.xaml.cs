using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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

namespace Optovik
{
    /// <summary>
    /// Логика взаимодействия для Sign_up.xaml
    /// </summary>
    public partial class Sign_up : Window
    {
        public Sign_up()
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

        private void Registraciya_BTN_Click(object sender, RoutedEventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordBox.Password;

            if (login != "")
            {
                if (passwordBox.Password.Length > 0)
                {

                    if (password?.Length > 5)
                    {
                        string querystring = $"insert into users(login, password) values ('{login}','{password}')";
                        SqlCommand command = new SqlCommand(querystring, database.GetConnection());

                        database.openConnection();

                        if (command.ExecuteNonQuery() == 1)
                        {
                            Osnova osn = new Osnova();
                            osn.Show();
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ошибка!", "Аккаунта не создан!");
                    }
                    else
                        MessageBox.Show("Пароль должен содержать минимум 6 символов!");
                }
                else
                    MessageBox.Show("Введите пароль!");
            }
            else
                MessageBox.Show("Введите логин!!");

            database.closeConection();
        }

        private void Registration_BTN_Click(object sender, RoutedEventArgs e)
        {
            var win = new Sign_in();
            win.Show();
            this.Close();
        }
    }
}
