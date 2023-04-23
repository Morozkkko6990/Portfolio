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

namespace Optovik
{
    /// <summary>
    /// Логика взаимодействия для DealsAdd.xaml
    /// </summary>
    public partial class DealsAdd : Window
    {
        Entities.Warehoyse1Entities3 database;
        public DealsAdd(Entities.Warehoyse1Entities3 Database, Entities.Deal currenDeal, string title)
        {
            InitializeComponent();
            this.database = Database;
            byersCB.ItemsSource = database.Byers.ToList();
            nameCB.ItemsSource = database.Products.ToList();

            this.DataContext = currenDeal;
            this.Title = title;
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            if (CheckDeals())
            {
                database.SaveChanges();
                this.Close();
            }
        }

        private bool CheckDeals()
        {
            var deals = this.DataContext as Entities.Deal;
            string message = "";
            if (deals.Byer == null)
            {
                message += "Выберете продавца\n";
            }
            if (deals.Product == null)
            {
                message += "Выберете товар\n";
            }
            if (!int.TryParse(countTB.Text, out int result11))
            {
                message += "Введите количество в цифрах\n";
            }
            if (!int.TryParse(sumTB.Text, out int result1))
            {
                message += "Введите сумму в цифрах\n";
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
