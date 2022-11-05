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

namespace PerfumeryApp
{
    /// <summary>
    /// Логика взаимодействия для OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        public PerfumeryDBEntities _context = new PerfumeryDBEntities();
        public OrdersWindow()
        {
            InitializeComponent();
            ordersDataGrid.ItemsSource = _context.Orders.ToList();
        }

        private void orderChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ordersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GoodsLb.ItemsSource = _context.GoodOfOrder.ToList().Where(o => o.OrderId == (ordersDataGrid.SelectedItem as Orders).Id);
            GoodsLb.DisplayMemberPath = "GoodName";
        }
    }
}
