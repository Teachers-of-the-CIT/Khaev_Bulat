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
    /// Логика взаимодействия для OrderChangeWindow.xaml
    /// </summary>
    public partial class OrderChangeWindow : Window
    {
        OrdersWindow _window;
        Orders _order;
        public OrderChangeWindow(OrdersWindow window, Orders order)
        {
            InitializeComponent();
            _window = window;
            _order = order;

            getDateTb.Text = order.GetDate.ToString();
            pointCmb.ItemsSource = _window._context.Points.ToList();
            pointCmb.DisplayMemberPath = "Point";
            codeTb.Text = order.Code.ToString();
        }

        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
            if (getDateTb.Text != "" && pointCmb.Text != "" && codeTb.Text != "" && statusTb.Text != "")
            {
                int number;
                bool success = int.TryParse(codeTb.Text, out number);
                if (success)
                {
                    try
                    {
                        _window._context.Orders.Attach(_order);
                        _order.Code = number;
                        _order.Status = statusTb.Text;
                        _order.GetDate = DateTime.Parse(getDateTb.Text);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                    Console.WriteLine("Код получения должен содержать только цифры!");
            }
            else
                MessageBox.Show("Заполни все поля.");
        }
    }
}
