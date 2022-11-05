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

namespace PerfumeryApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PerfumeryDBEntities _context = new PerfumeryDBEntities();
        public Users _user;
        public MainWindow()
        {
            InitializeComponent();
            goodsDataGrid.ItemsSource = _context.Goods.ToList();
        }
        public void getPrivilages()
        {
            if (_user != null)
            {
                logLabel.Content = $"{_user.Name} ({_user.Login})";
                if (_user.Role == "Менеджер")
                {

                }
                else if (_user.Role == "Администратор")
                {
                    ordersBtn.IsEnabled = true;
                }
                else
                    MessageBox.Show("Пожалуйста, авторизуйтесь!");

                loginBtn.IsEnabled = false;
            }
        }
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow window = new LoginWindow(this);
            window.ShowDialog();
        }

        private void goodBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ordersBtn_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow window = new OrdersWindow();
            window.ShowDialog();
        }
    }
}
