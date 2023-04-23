using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using System.Windows.Threading;

namespace TRPO3
{
    /// <summary>
    /// Логика взаимодействия для Captcha.xaml
    /// </summary>
    public partial class Captcha : Window
    {

        public Captcha()
        {
            InitializeComponent();
            GenerateCaptcha();
        }
        DispatcherTimer timer = new DispatcherTimer();
        int tim = 10;
        string pwd2;
        private void GenerateCaptcha()
        {
            canvas.Children.Clear();
            String allowchar = " ";
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            String[] ar = allowchar.Split(a);
            String pwd = "";
            String pw = "";
            string temp = " ";
            Random r = new Random();
            int k = r.Next(4);
            for (int i = 0; i < k; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pwd += temp;
            }
            rt1.Text = pwd;
            rt1.FontSize = r.Next(20, 60);
            for (int i = k; i < 4; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];
                pw += temp;
            }
            rt2.Text = pw;
            rt2.FontSize = r.Next(20, 60);
            tb2.Foreground = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            pwd2 = pwd + pw;

            for (int j = 0; j < 10; j++)
            {
                Line line = new Line();
                line.X1 = 0;
                line.Y1 = r.NextDouble() * canvas.ActualHeight;
                line.X2 = canvas.ActualWidth;
                line.Y2 = r.NextDouble() * canvas.ActualHeight;
                line.StrokeThickness = 1.5;
                line.Stroke = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
                canvas.Children.Add(line);
            }

            for (int i = 0; i < 1000; i++)
            {
                Ellipse el = new Ellipse();
                el.Width = 2;
                el.Height = 2;
                el.Margin = new Thickness(r.Next(1, 199), r.Next(1, 250), 0, 0);
                el.Fill = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
                canvas.Children.Add(el);


            }


            canvas.Background = new SolidColorBrush(Color.FromRgb((byte)r.Next(255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
        }

        int count = 0;
        public void Check()
        {

            if (count == 1)
            {
                MessageBox.Show("Ошибка");
            }
            if (count == 2)
            {
                MessageBox.Show("Ошибка");
            }
            if (count >= 3)
            {
                timer.Tick += new EventHandler(timer_Tick);
                timer.Interval = new TimeSpan(0, 0, 0, 1);
                timer.Start();
                if (tim != 0)
                {
                    MessageBox.Show(String.Format("Блокировка на {0:0} секунд", tim));
                    Bt1.IsEnabled = false; Bt2.IsEnabled = false;
                }
            }
        }
        public void timer_Tick(object sender, EventArgs e)
        {

            if (tim == 0)
            {
                MessageBox.Show(String.Format("Возможет повтор ввода капчи"));
                timer.Stop();
                tim = 10;
                Bt1.IsEnabled = true; Bt2.IsEnabled = true;
            }
            else
                tim--;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (captcha.Text.Length > 0)
            {
                if (captcha.Text == pwd2)
                {
                    Close();
                }
                else
                {
                    Button_Click_2(sender, e);
                    count++;
                    Check();
                   
                }
            }
            else
                MessageBox.Show("Введите символы с картинки в поле для ввода");
        }    


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GenerateCaptcha();
        }
    }

    
}
