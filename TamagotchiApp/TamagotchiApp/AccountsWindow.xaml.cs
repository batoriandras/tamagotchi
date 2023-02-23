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
            User[] users = handler.GetUsers("users");
            for (int i = 0; i < users.Length; i++)
            {
                list.Items.Add($"Username: {users[i].data.username} - UserId: {users[i].data.id}");
            }
        }

        private void Deleteaccount_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(accountid.Text);
            User user = handler.DeleteUser("deleteuser/" + id);
        }
    }
}
