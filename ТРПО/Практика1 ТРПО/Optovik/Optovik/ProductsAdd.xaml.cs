using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
    /// Логика взаимодействия для ProductsAdd.xaml
    /// </summary>
    public partial class ProductsAdd : Window
    {
        Entities.Warehoyse1Entities3 database;

        public ProductsAdd(Entities.Warehoyse1Entities3 Database, Entities.Product currenProduct, string title)
        {
            InitializeComponent();
            this.database = Database;

            providerCB.ItemsSource = database.Providers.ToList();
            nameCB.ItemsSource = database.Measurnaments.ToList();

            this.DataContext = currenProduct;
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
            var products = this.DataContext as Entities.Product;
            string message = "";

            if (nameTB.Text=="") //наименование тб
            {
                message += "Введите наименование продукта\n";
            }

            if (products.Provider == null) //поставщик кб
            {
                message += "Выберете поставщика\n";
            }

            if (!int.TryParse(countTB.Text, out int result12)) //кол-во тб
            {
                message += "Введите количество в цифрах\n";
            }

            if (products.Measurnament == null) //ед кб
            {
                message += "Выбирете еденицу измерения \n";
            }

            if (!int.TryParse(prise_purchaseTB.Text, out int result13)) //цена закупки тб
            {
                message += "Введите цену закупки в цифрах\n";
            }

            if (!int.TryParse(selling_priceTB.Text, out int result1)) //цена продажи кб
            {
                message += "Введите цену продажи в цифрах\n";
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
