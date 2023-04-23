using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Windows.Threading;

namespace TRPO3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BD database = new BD();
        DispatcherTimer timer = new DispatcherTimer();
        int tim = 10;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            visible_pas_TB.Text = sign_in_PassBox.Password;
            sign_in_PassBox.Visibility = Visibility.Collapsed;
            visible_pas_TB.Visibility = Visibility.Visible;

            vis_signUp_Tb.Text = signUp_PassBox.Password;
            signUp_PassBox.Visibility = Visibility.Collapsed;
            vis_signUp_Tb.Visibility = Visibility.Visible;

            vis_signUp_Tb2.Text = signUp_PassBox2.Password;
            signUp_PassBox2.Visibility = Visibility.Collapsed;
            vis_signUp_Tb2.Visibility = Visibility.Visible;


        }
        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            sign_in_PassBox.Password = visible_pas_TB.Text;
            visible_pas_TB.Visibility = Visibility.Collapsed;
            sign_in_PassBox.Visibility = Visibility.Visible;

            signUp_PassBox.Password = vis_signUp_Tb.Text;
            vis_signUp_Tb.Visibility = Visibility.Collapsed;
            signUp_PassBox.Visibility = Visibility.Visible;

            signUp_PassBox2.Password = vis_signUp_Tb2.Text;
            vis_signUp_Tb2.Visibility = Visibility.Collapsed;
            signUp_PassBox2.Visibility = Visibility.Visible;
        }
        private void signIn_Btn_Click(object sender, RoutedEventArgs e)
        {
            var loginSignIn = sign_in_TB.Text;
            var passwordSignIn = sign_in_PassBox.Password;
            var user=App.Entities.Users.FirstOrDefault(x=>x.login==loginSignIn&&(x.password==passwordSignIn|x.password== visible_pas_TB.Text));

            if(loginSignIn!="")
            { 
                if(passwordSignIn.Length > 0)
                {
                    SqlDataAdapter adapter= new SqlDataAdapter();
                    DataTable dataTable= new DataTable();

                    string querystring = $"select id, login, password from Users where login='{loginSignIn}' and password='{passwordSignIn}'";
                    SqlCommand command= new SqlCommand(querystring, database.GetConnection());
                    
                    adapter.SelectCommand= command;
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        switch (user.id_role_type)
                        {
                            case 1:
                                Zakazchik zakazchik = new Zakazchik();
                                zakazchik.Show();
                                this.Close();
                                break;
                            case 2:
                                Manager manager = new Manager();
                                manager.Show();
                                this.Close();
                                break;
                            case 3:
                                Master master = new Master();
                                master.Show();
                                this.Close();
                                break;
                            case 4:
                                ZamDir zamDir = new ZamDir();
                                zamDir.Show();
                                this.Close();
                                break;
                            case 5:
                                Director director = new Director();
                                director.Show();
                                this.Close();
                                break;
                        }
                    }
                    else
                    {
                        count++;
                        CountNoOpen();
                    }
                       
                }
                else
                    MessageBox.Show("Введите пароль!");
            }
            else
                MessageBox.Show("Введите логин!!");
        }

        private void signUp_Btn_Click(object sender, RoutedEventArgs e)
        {
            var loginSignUp = signUp_Tb.Text;
            string passwordSignUp = signUp_PassBox.Password;
            string passwordSignUp2= signUp_PassBox2.Password;
            string visPass_TB= vis_signUp_Tb.Text;


            if (CheckUser())
            {
                return;
            }
            if (ChekConsecutiveChars(passwordSignUp)&& ChekConsecutiveChars(visPass_TB))
            {
                if (ChekPass())
                {
                    string querystring = $"insert into Users(login, password, id_role_type) values('{loginSignUp}', '{passwordSignUp}', 1)";
                    SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                    database.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Zakazchik zakazchik = new Zakazchik();
                        zakazchik.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ошибка!", "Аккаунта не создан!");
                }
            }
            else
                MessageBox.Show("Пароль не должен содержать 3 и более идущих подряд одинаковых символа");


            database.closeConection();

        }

        private Boolean CheckUser()
        {
            var login = signUp_Tb.Text;
            var password = signUp_PassBox.Password;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select login, password from Users where login='{login}'and password='{password}'";
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

        public bool ChekConsecutiveChars(string pass)
        {
            int count = 1;
            for (int i = 1; i <= pass.Length - 3; i++)
            {
                if (pass[i] == pass[i -1] )
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if(count>=3)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ChekPass()
        {
            var test = new Regex(@"((?=.*[a-z]))").Match(signUp_PassBox.Password);
            var test1 = new Regex(@"((?=.*[A-Z]))").Match(signUp_PassBox.Password);
            var test2 = new Regex(@"((?=.*[0-9]))").Match(signUp_PassBox.Password);
            var test3 = new Regex(@"((?=.*[@#$%]))").Match(signUp_PassBox.Password);

            var testA = new Regex(@"((?=.*[a-z]))").Match(vis_signUp_Tb.Text);
            var testB = new Regex(@"((?=.*[A-Z]))").Match(vis_signUp_Tb.Text);
            var testC = new Regex(@"((?=.*[0-9]))").Match(vis_signUp_Tb.Text);
            var testD = new Regex(@"((?=.*[@#$%]))").Match(vis_signUp_Tb.Text);

            string message = "";           

            if (signUp_Tb.Text == "")
            {
                message += "Введите логин!\n";
            }
            else
            if (signUp_PassBox.Password == "" && signUp_PassBox2.Password == "" && vis_signUp_Tb.Text == "" && vis_signUp_Tb2.Text == "")
            {
                message += "Введите пароль!\n";
            }
            else
            if (signUp_PassBox.Password != signUp_PassBox2.Password && vis_signUp_Tb.Text != vis_signUp_Tb2.Text)
            {
                message += "Пароли не совпадают!\n";
            }
            else
            if (signUp_PassBox.Password.Length < 6 && vis_signUp_Tb.Text.Length < 6/*|| password_TB.Password.Length > 16 && tb.Text.Length > 16*/)
            {
                message += "Пароль должен содержать минимум 6 символов и максимум 16 символов!\n";
            }
            else
            if (!test.Success && !testA.Success)
            {
                message += "Пароль должен содержать латинские буквы верхнего регистра\n";
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
            return false;
        }

        private void PackIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        int count = 0;

        public void CountNoOpen()
        {
           if(count==1)
           {
                MessageBox.Show("Пароль или логин введен не верно");
           }
           if(count==2)
           {
                Captcha captcha = new Captcha();
                captcha.Show();
                captcha.Owner= this;
           }
           if(count>=3)
           {
                timer.Tick += new EventHandler(timer_Tick);
                timer.Interval=new TimeSpan(0,0,0,1);
                timer.Start();
                if(tim!=0)
                {
                    MessageBox.Show(String.Format("Вход в пользователя запрещён ещё {0:0} секунд", tim));
                }
           }
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if (tim == 0)
            {
                MessageBox.Show(String.Format("Вход в пользователя разрешён."));
                timer.Stop();
                tim = 10;
            }
            else
                tim--;
        }

    }
}
