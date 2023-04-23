using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using static System.Net.Mime.MediaTypeNames;

namespace Optovik
{
    /// <summary>
    /// Логика взаимодействия для Byers.xaml
    /// </summary>
    public partial class Byers : Window
    {
        Entities.Warehoyse1Entities3 database;
        public Byers(Entities.Warehoyse1Entities3 Database, Entities.Byer currenByers, string title)
        {
            InitializeComponent();
            this.database = Database;

            this.DataContext = currenByers;
            this.Title = title;
        }

        private void AddBTN_Click_1(object sender, RoutedEventArgs e)
        {
            if (CheckDeals())
            {
                database.SaveChanges();
                this.Close();
            }
        }

        private bool CheckDeals()
        {
            var byers = this.DataContext as Entities.Byer;
            string message = "";
            if (NameProviderTB1.Text == "")
            {
                message += "Введите название покупателя\n";
            }
            if (AdressTB.Text == "")
            {
                message += "Введите адрес\n";
            }
            if (!int.TryParse(PhoneTB.Text, out int result13))
            {
                message += "Введите номер телефона\n";
            }
            if (message == "")
                return true;
            else
            {
                MessageBox.Show(message);
                return false;
            }
        }
    }
}
