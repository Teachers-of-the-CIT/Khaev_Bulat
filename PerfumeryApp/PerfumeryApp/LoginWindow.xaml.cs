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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        MainWindow _window;
        public LoginWindow(MainWindow window)
        {
            InitializeComponent();
            _window = window;

            //loginTb.Text = "kaft93x@outlook.com";
            //passTb.Password = "8ntwUp";
        }

        private void goBtn_Click(object sender, RoutedEventArgs e)
        {
            if (loginTb.Text != "" && passTb.Password != "")
            {
                bool x = false;
                foreach(Users user in _window._context.Users)
                {
                    if (user.Login == loginTb.Text && user.Pass == passTb.Password)
                    {
                        _window._user = user;
                        _window.getPrivilages();
                        this.Close();
                        x = true;
                        break;
                    }
                }
                if (!x)
                    MessageBox.Show("Неверный логин или пароль!");
            }
            else
                MessageBox.Show("Заполни все поля");
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
