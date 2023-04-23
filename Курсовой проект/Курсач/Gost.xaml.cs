using Microsoft.Win32;
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
using System.Data;
using System.IO;
using Курсач.Entities;

namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для Gost.xaml
    /// </summary>
    public partial class Gost : Window
    {
        int a = 0;
        public Gost(int time_stop)
        {
            InitializeComponent();
            this.a = time_stop;
               
            
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow window = new MainWindow();
            window.Show();


        }

      
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                myImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }
    }
}
