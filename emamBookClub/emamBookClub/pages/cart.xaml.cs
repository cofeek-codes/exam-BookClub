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

namespace emamBookClub.pages
{
    /// <summary>
    /// Логика взаимодействия для cart.xaml
    /// </summary>
    public partial class cart : Window
    {
            List<temp> currentTemp = new List<temp>() ;
        public cart(List<product> selected)
        {
            InitializeComponent();


            //if (BoocClubEntities.GetContext().order.ToList().Count == 0)
            ////{
            //    foreach (var item in selected)
            //    {
            //        temp temp = new temp();
            //        temp.idProduct = item.idProduct;
            //        temp.count = 1;
            //        temp.id_order_temp = 1;
            //        BoocClubEntities.GetContext().temp.Add(temp);
            //        BoocClubEntities.GetContext().SaveChanges();
            //    }
            ////}
            ////else
            //{
                var query = BoocClubEntities.GetContext().order.ToList().Last();
                foreach (var item in selected)
                {
                    temp temp = new temp();
                    temp.idProduct = item.idProduct;
                    temp.count = 1;
                    temp.id_order_temp = query.idOrder + 1;
                    BoocClubEntities.GetContext().temp.Add(temp);
                    BoocClubEntities.GetContext().SaveChanges();
                }
            //}
            var product = BoocClubEntities.GetContext().temp.ToList().Find(p => p.id_order_temp == query.idOrder);
            var tempList = BoocClubEntities.GetContext().temp.ToList();

            foreach (var item in tempList)
            {
                if (currentTemp.Contains(product))
                { 
                    product.count+=1;
                    //BoocClubEntities.GetContext().SaveChanges();
                }
                else
                {               
                    currentTemp.Add(product);
                }
            }
            dgTemp.ItemsSource = currentTemp;
        }
    }
}
