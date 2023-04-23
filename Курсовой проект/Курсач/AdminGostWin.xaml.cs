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
    /// Логика взаимодействия для AdminGostWin.xaml
    /// </summary>
    public partial class AdminGostWin : Window
    {
        public AdminGostWin()
        {
            InitializeComponent();

            DataG_Users.ItemsSource = App.entities.Users.ToList();
            DataG_Users.ItemsSource = App.entities.Roles.ToList();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdminWin adminWin=new AdminWin(0);
            adminWin.Show();
            this.Close();
        }
    }
}
