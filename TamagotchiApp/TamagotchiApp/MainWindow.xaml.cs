using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace TamagotchiApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    partial class MainWindow : Window
    {
        RestApiHandler handler;
        public MainWindow(RestApiHandler handler)
        {
            InitializeComponent();
            this.handler = handler;
        }

        private void NewAnimal_Click(object sender, RoutedEventArgs e)
        {
            AddNewAnimal ana = new AddNewAnimal(handler);
            ana.Show();
            Hide();
            ana.Closed += (_, _) => Close();
        }

        private void AllAccount_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
