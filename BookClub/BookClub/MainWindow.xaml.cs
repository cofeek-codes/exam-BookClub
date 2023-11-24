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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookClub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var products = BokClubEntities.GetContext().product.ToList();
            dgProducts.ItemsSource = products;
        }
        private List<product> selected = new List<product>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmItem_Click(object sender, RoutedEventArgs e)
        {
            orderBtn.Visibility = Visibility.Visible;
        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            selected.Add((product)dgProducts.SelectedItem);
            pages.cart cart = new pages.cart(selected);
            cart.Show();
        }
    }
}
