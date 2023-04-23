using System;
using System.Collections.Generic;
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
using System.Text.RegularExpressions;
using System.Windows.Markup;
using System.Data;

namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для Registracia.xaml
    /// </summary>
    public partial class Registracia : Window
    {
        BD database = new BD();
        public Registracia()
        {
            InitializeComponent();
        }
        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            tb.Text = password_TB.Password;
            tb2.Text = password_TB2.Password;

            password_TB.Visibility = Visibility.Collapsed;
            tb.Visibility = Visibility.Visible;

            password_TB2.Visibility = Visibility.Collapsed;
            tb2.Visibility = Visibility.Visible;
            

        }
        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            password_TB.Password = tb.Text;
            tb.Visibility = Visibility.Collapsed;
            password_TB.Visibility = Visibility.Visible;

            password_TB2.Password = tb2.Text;
            tb2.Visibility = Visibility.Collapsed;
            password_TB2.Visibility = Visibility.Visible;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }



        private void login_in_Click(object sender, RoutedEventArgs e)
        {
            var login = login_TB.Text;
            var password = password_TB.Password;
            var password2= password_TB2.Password;

            if (!CheckUser())
            {
                if (ChekPass())
                {

                    string querystring = $"insert into Users(login, password, role_type) values ('{login}','{password}', '3')";
                    SqlCommand command = new SqlCommand(querystring, database.GetConnection());

                    database.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        Gost osn = new Gost(0);
                        osn.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ошибка!", "Аккаунта не создан!");
                }
            }

            
            database.closeConection();
        }

        private Boolean CheckUser()
        {
            var login = login_TB.Text;
            var password = password_TB.Password;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select login, password from Users where login='{login}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже суествует");
                return true;
            }
            else
                return false;
        }


        public bool ChekPass()
        {
            var test = new Regex(@"((?=.*[a-z]))").Match(password_TB.Password);
            var test1 = new Regex(@"((?=.*[A-Z]))").Match(password_TB.Password);
            var test2 = new Regex(@"((?=.*[0-9]))").Match(password_TB.Password);
            var test3 = new Regex(@"((?=.*[@#$%]))").Match(password_TB.Password);

            var testA = new Regex(@"((?=.*[a-z]))").Match(tb.Text);
            var testB = new Regex(@"((?=.*[A-Z]))").Match(tb.Text);
            var testC = new Regex(@"((?=.*[0-9]))").Match(tb.Text);
            var testD = new Regex(@"((?=.*[@#$%]))").Match(tb.Text);

            string message = "";

           
           
            if (login_TB.Text == "")
            {
                message += "Введите логин!\n";
            }
            else
            if (password_TB.Password == "" && password_TB2.Password == ""&& tb.Text==""&& tb2.Text=="")
            {
                message += "Введите пароль!\n";
            }
            else
            if (password_TB.Password != password_TB2.Password&& tb.Text !=tb2.Text)
            {
                message += "Пароли не совпадают!\n";
            }
            else
            if (password_TB.Password.Length < 8&& tb.Text.Length<8)
            {
                message += "Пароль должен содержать минимум 8 символов и максимум 16 символов!\n";
            }
            else
            if (!test.Success&&!testA.Success)
            {
                message += "Пароль должен содержать латинские буквы нижнего регистра\n";
            }
            else
            if (!test1.Success && !testB.Success)
            {
                message += "Пароль должен содержать латинские буквы верхнего регистра\n";
            }         
            else
            if (!test2.Success && !testC.Success)
            {
                message += "Пароль должен содержать цифры\n";
            }    
            else
            if (!test3.Success && !testD.Success)
            {
                message += "Пароль должен содержать специальный сиволы @#$%\n";
            }

            if (message == "")
                return true;
            else
                MessageBox.Show(message);
            for (int i = 0; i <= password_TB.Password.Length - 3; i++)
            {
                if (password_TB.Password[i] == password_TB.Password[i + 1] && password_TB.Password[i + 1] == password_TB.Password[i + 2])
                {
                    message += "В строке не должно быть более трех одинаковых символа\n";
                }
            }
            return false;
        }

        public void Quality_Pass(object sender, RoutedEventArgs e)
        {
            var a = new Regex(@"((?=.*[a-z]))").Match(password_TB.Password);
            var b = new Regex(@"((?=.*[A-Z]))").Match(password_TB.Password);
            var c = new Regex(@"((?=.*[0-9]))").Match(password_TB.Password);
            var d = new Regex(@"((?=.*[@#$%]))").Match(password_TB.Password);

            var testtb = new Regex(@"((?=.*[a-z]))").Match(tb.Text);
            var testtb1 = new Regex(@"((?=.*[A-Z]))").Match(tb.Text);
            var testtb2 = new Regex(@"((?=.*[0-9]))").Match(tb.Text);
            var testtb3 = new Regex(@"((?=.*[@#$%]))").Match(tb.Text);



            if (a.Success && b.Success && c.Success && d.Success||
                testtb.Success && testtb1.Success && testtb2.Success && testtb3.Success)
            {
                qualituL.Content = "Отличный пароль!";
                qualituL.Foreground = Brushes.Green;
                return;
            }
            if ((a.Success && b.Success || a.Success && c.Success || a.Success && d.Success || b.Success && c.Success || b.Success && d.Success || c.Success && d.Success)||
               ( testtb.Success && testtb1.Success || testtb.Success && testtb2.Success || testtb.Success && testtb3.Success || testtb1.Success && testtb2.Success || testtb1.Success && testtb3.Success || testtb2.Success && testtb3.Success))
            {
                qualituL.Content = "Средний пароль!";
                qualituL.Foreground = Brushes.Orange;
                return;
            }
            if (a.Success || b.Success || c.Success || d.Success &&
                testtb.Success || testtb1.Success || testtb2.Success || testtb3.Success)
            {
                qualituL.Content = "Плохой пароль!";
                qualituL.Foreground = Brushes.DarkRed;
                return;
            }
           
        }
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.C ||
            e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.V||e.Key==Key.Space)
            {
                e.Handled = true;
            }
        }

        private void PasswordBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.C || e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.V || e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }


        private void infoImage_MouseMove(object sender, MouseEventArgs e)
        {
            var test = new Regex(@"((?=.*[a-z]))").Match(password_TB.Password);
            var test1 = new Regex(@"((?=.*[A-Z]))").Match(password_TB.Password);
            var test2 = new Regex(@"((?=.*[0-9]))").Match(password_TB.Password);
            var test3 = new Regex(@"((?=.*[@#$%]))").Match(password_TB.Password);

            var testA = new Regex(@"((?=.*[a-z]))").Match(tb.Text);
            var testB = new Regex(@"((?=.*[A-Z]))").Match(tb.Text);
            var testC = new Regex(@"((?=.*[0-9]))").Match(tb.Text);
            var testD = new Regex(@"((?=.*[@#$%]))").Match(tb.Text);

            string message = "";


            if (password_TB.Password.Length < 8 && tb.Text.Length < 8)
            {
                message += "Пароль должен содержать минимум 8 символов и максимум 16 символов!\n";
            }
            if (!test.Success && !testA.Success)
            {
                message += "Пароль должен содержать латинские буквы нижнего регистра\n";
            }
            if (!test1.Success && !testB.Success)
            {
                message += "Пароль должен содержать латинские буквы верхнего регистра\n";
            }
            if (!test2.Success && !testC.Success)
            {
                message += "Пароль должен содержать цифры\n";
            }
            if (!test3.Success && !testD.Success)
            {
                message += "Пароль должен содержать специальный сиволы @#$%\n";
            }
            for (int i = 0; i <= password_TB.Password.Length - 3; i++)
            {
                if (password_TB.Password[i] == password_TB.Password[i + 1] && password_TB.Password[i + 1] == password_TB.Password[i + 2])
                {
                    message += "В строке не должно быть более трех одинаковых символа\n";
                }
            }
            if (message == "")
                message += "Все введено верно!\n";
            else
                infoImage.ToolTip = message;
            
        }
    }
}
