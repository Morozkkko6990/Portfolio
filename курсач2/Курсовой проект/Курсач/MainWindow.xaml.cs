using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BD database = new BD();

        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer1 = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Stop();
            blok = 10;
            seans = 600;
        }

       
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.C ||
            e.KeyboardDevice.Modifiers == ModifierKeys.Control && e.Key == Key.V || e.Key == Key.Space)
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

        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            tb.Text = password_TB.Password;
            password_TB.Visibility = Visibility.Collapsed;
            tb.Visibility = Visibility.Visible;


        }
        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            password_TB.Password = tb.Text;
            tb.Visibility = Visibility.Collapsed;
            password_TB.Visibility = Visibility.Visible;
        }

        private void Sign_in_Click(object sender, RoutedEventArgs e)
        {
            Registracia win = new Registracia();
            win.Show();
            this.Close();
        }

        int seans = 900, blok, count=0;
        private void login_in_Click(object sender, RoutedEventArgs e)
        {
            var login = login_TB.Text;
            var password = password_TB.Password;
            var password2 = tb.Text;
            var user1 = App.entities.Users.FirstOrDefault(x => x.login == login && (x.password == password | x.password == password2));
            if (login != "")
            {
                if (password_TB.Password.Length > 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();

                    string querystring = $"select id, login, password from Users where login='{login}' and password='{password}'";
                    SqlCommand command = new SqlCommand(querystring, database.GetConnection());

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                       
                            switch (user1.role_type)
                            {
                                case 1:
                                    AdminWin osn = new AdminWin(0);
                                    osn.Show();
                                    this.Close();
                                    break;

                                case 2:
                                    Oficiant oficiant = new Oficiant(0);
                                    oficiant.Show();
                                    this.Close();
                                window = oficiant;
                                timer.Tick += new EventHandler(timerTick);
                                timer.Interval = new TimeSpan(0, 0, 0, 1);
                                timer.Start();
                                break;

                                case 3:
                                    Gost gost = new Gost(0);
                                    gost.Show();
                                    this.Close();
                                window = gost;
                                timer.Tick += new EventHandler(timerTick);
                                timer.Interval = new TimeSpan(0, 0, 0, 1);
                                timer.Start();
                                break;
                            }

                    }
                    else
                    {
                        count++;      
                        CheckUsers();     
                    }                                  

                }
                else
                    MessageBox.Show("Введите пароль!");
            }
            else
                MessageBox.Show("Введите логин!!");
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
            if (table.Rows.Count < 0)
            {
                MessageBox.Show("Пользователь не суествует");
                return true;
            }
            else
                return false;
        }

        public void CheckUsers()
        {
            if (count == 1)
            {
                MessageBox.Show("Проверьтe логин или пароль");
            }
            if (count == 2)
            {
                Captcha captcha = new Captcha();
                captcha.Show();
                captcha.Owner = this;
                //login_in.IsEnabled = false;
                //Sign_in.IsEnabled = false;
                

            }
            if (count >= 3)
            {
                timer1.Tick += new EventHandler(timer1Tick);
                timer1.Interval = new TimeSpan(0, 0, 0, 1);
                timer1.Start();
                if (blok != 0)
                {
                    MessageBox.Show(String.Format("Вход в пользователя запрещён на 10 секунд", blok));
                }

            }
        }
                

        Window window= new Window();

       
        private void timerTick(object sender, EventArgs e)
        {
            if (App.Current.Windows.OfType<Gost>().Count() > 0 || App.Current.Windows.OfType<Oficiant>().Count() > 0)
            {
                 if (seans == 0)
                 {
                
                   MessageBox.Show("Сеанс завершён", "До свидания");
                

                    MainWindow hello = new MainWindow();
                    hello.Show();
                    window.Close();               
                    timer.Stop();
               


                 }
            else
            {
                if (seans == 300)
                {
                    MessageBox.Show("Сеанс завершится через 5 минут", "Внимание!");
                    seans--;
                }
                else
                    seans--;
            }
            }
            else
                timer.Stop();
           
        }
        
        private void Window_Activated(object sender, EventArgs e)
        {

        }
        private void timer1Tick(object sender, EventArgs e)
        {
            if (blok == 0)
            {
                MessageBox.Show(String.Format("Вход в пользователя разрешён."));
                timer1.Stop();
                blok = 10;
            }
            else
            {
                blok--;
            }
        }
    }
}
