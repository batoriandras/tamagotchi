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
    /// Interaction logic for AccountsWindow.xaml
    /// </summary>
    partial class AccountsWindow : Window
    {
        RestApiHandler handler;
        public AccountsWindow(RestApiHandler handler)
        {
            InitializeComponent();
            this.handler = handler;

        }

        private void showallacc_Click(object sender, RoutedEventArgs e)
        {
            Users users = handler.GetUsers("users");
            list.Items.Clear();
            for (int i = 0; i < users.data.Length; i++)
            {
                list.Items.Add($"Username: {users.data[i].username} - UserId: {users.data[i].userid}");
            }
        }

        private void Deleteaccount_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(accountid.Text);
            handler.DeleteUser($"deleteuser/{id}");
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(handler);
            main.Show();
            Hide();
            main.Closed += (_,_) => Close();
        }
    }
}
