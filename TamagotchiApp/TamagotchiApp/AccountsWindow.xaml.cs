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
    public partial class AccountsWindow : Window
    {
        public AccountsWindow()
        {
            InitializeComponent();
            RestApiHandler handler = new RestApiHandler("https://localhost:8881");
            Account[] users = handler.GetUser("/api/users");
            for (int i = 0; i < users.Length; i++)
            {
                list.Items.Add(users[i].username + " - " + users[i].password);
            }
        }
    }
}
