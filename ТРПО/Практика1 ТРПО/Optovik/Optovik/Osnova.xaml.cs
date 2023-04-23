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
    /// Логика взаимодействия для Osnova.xaml
    /// </summary>
    public partial class Osnova : Window
    {
        public Osnova()
        {
            InitializeComponent();
            DataG_deals.ItemsSource=App.DataBase.Deals.ToList();
            DataG_products.ItemsSource = App.DataBase.Products.ToList();
            DataG_byers.ItemsSource = App.DataBase.Byers.ToList();
            DataG_provider.ItemsSource = App.DataBase.Providers.ToList();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = TCDeals.SelectedIndex;

            if (newIndex == 0)
            {
            var newDeals=new Entities.Deal();
            App.DataBase.Deals.Add(newDeals);
            var winDealsAdd = new DealsAdd(App.DataBase, newDeals, "Добавить сделку");
            winDealsAdd.ShowDialog();
            DataG_deals.ItemsSource = App.DataBase.Deals.ToList();
            }

            if(newIndex == 1) 
            {
                var newProducts = new Entities.Product();
                App.DataBase.Products.Add(newProducts);
                var winProductsAdd = new ProductsAdd(App.DataBase, newProducts, "Добавить товар");
                winProductsAdd.ShowDialog();
                DataG_products.ItemsSource = App.DataBase.Products.ToList();
            }

            if (newIndex == 2)
            {
                var newByers = new Entities.Byer();
                App.DataBase.Byers.Add(newByers);
                var winByerssAdd = new Byers(App.DataBase, newByers, "Добавить покупателя");
                winByerssAdd.ShowDialog();
                DataG_byers.ItemsSource = App.DataBase.Byers.ToList();
            }

            if (newIndex == 3)
            {
                var newProvider = new Entities.Provider();
                App.DataBase.Providers.Add(newProvider);
                var winProvidersAdd = new ProviderAdd(App.DataBase, newProvider, "Добавить Поставщика");
                winProvidersAdd.ShowDialog();
                DataG_provider.ItemsSource = App.DataBase.Providers.ToList();
            }

        }

        private void EditBTN_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = TCDeals.SelectedIndex;

            if (newIndex == 0)
            {
                var currentrow = DataG_deals.SelectedItem as Entities.Deal;
                if (currentrow == null)
                {
                    MessageBox.Show("Не выбрана строка для изменения!");
                    return;
                }
                var winDealsAdd = new DealsAdd(App.DataBase, currentrow, "Изменить данные сделки");
                winDealsAdd.ShowDialog();
                DataG_deals.ItemsSource = App.DataBase.Deals.ToList();
            }

            if (newIndex == 1)
            {
                var currentrow = DataG_products.SelectedItem as Entities.Product;
                if (currentrow == null)
                {
                    MessageBox.Show("Не выбрана строка для изменения!");
                    return;
                }
                var winDealsAdd = new ProductsAdd(App.DataBase, currentrow, "Изменить данные товара");
                winDealsAdd.ShowDialog();
                DataG_products.ItemsSource = App.DataBase.Products.ToList();
            }

            if (newIndex == 2)
            {
                var currentrow = DataG_byers.SelectedItem as Entities.Byer;
                if (currentrow == null)
                {
                    MessageBox.Show("Не выбрана строка для изменения!");
                    return;
                }
                var winDealsAdd = new Byers(App.DataBase, currentrow, "Изменить данные сделки");
                winDealsAdd.ShowDialog();
                DataG_deals.ItemsSource = App.DataBase.Byers.ToList();
            }

            if (newIndex == 3)
            {
                var currentrow = DataG_provider.SelectedItem as Entities.Provider;
                if (currentrow == null)
                {
                    MessageBox.Show("Не выбрана строка для изменения!");
                    return;
                }
                var winDealsAdd = new ProviderAdd(App.DataBase, currentrow, "Изменить данные сделки");
                winDealsAdd.ShowDialog();
                DataG_deals.ItemsSource = App.DataBase.Providers.ToList();
            }
        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = TCDeals.SelectedIndex;

            if (newIndex == 0)
            {
                var currentrow = DataG_deals.SelectedItem as Entities.Deal;
                if (currentrow == null)
                {
                    MessageBox.Show("Не выбрана строка для изменения!");
                    return;
                }
                App.DataBase.Deals.Remove(currentrow);
                App.DataBase.SaveChanges();
                DataG_deals.ItemsSource = App.DataBase.Deals.ToList();
            }

            if (newIndex == 1)
            {
                var currentrow = DataG_products.SelectedItem as Entities.Product;
                if (currentrow == null)
                {
                    MessageBox.Show("Не выбрана строка для изменения!");
                    return;
                }
                App.DataBase.Products.Remove(currentrow);
                App.DataBase.SaveChanges();
                DataG_products.ItemsSource = App.DataBase.Products.ToList();
            }

            if (newIndex == 2)
            {
                var currentrow = DataG_byers.SelectedItem as Entities.Byer;
                if (currentrow == null)
                {
                    MessageBox.Show("Не выбрана строка для изменения!");
                    return;
                }
                App.DataBase.Byers.Remove(currentrow);
                App.DataBase.SaveChanges();
                DataG_byers.ItemsSource = App.DataBase.Byers.ToList();
            }

            if (newIndex == 3)
            {
                var currentrow = DataG_provider.SelectedItem as Entities.Provider;
                if (currentrow == null)
                {
                    MessageBox.Show("Не выбрана строка для изменения!");
                    return;
                }
                App.DataBase.Providers.Remove(currentrow);
                App.DataBase.SaveChanges();
                DataG_provider.ItemsSource = App.DataBase.Providers.ToList();
            }
        }

        private void CloseBTN_Click(object sender, RoutedEventArgs e)
        {
            var win = new Sign_in();
            win.Show();
            this.Close();
        }
    }
}
