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

namespace TamagotchiApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"username", username.Text},
                {"password", password.Text}
            };

            RestApiHandler handler = new RestApiHandler("http://localhost:8881/api/");
            Account users = handler.PostUser("login",values);

            if (users.data.token != null)
            {
                mw.Show();
                Hide();
                mw.Closed+=(_,_)=>Close();
            }
            else
            {
                MessageBox.Show("Sikertelen belépés!");
            }
        }
    }
}
