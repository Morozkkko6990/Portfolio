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

namespace Курсач
{
    /// <summary>
    /// Логика взаимодействия для Oficiant.xaml
    /// </summary>
    public partial class Oficiant : Window
    {
        int a = 0;
        public Oficiant(int time_Stop)
        {
            InitializeComponent();
            this.a= time_Stop;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}
