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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Timer();
        }
        public void Timer()
        {
            DispatcherTimer time = new System.Windows.Threading.DispatcherTimer();
            time.Tick += new EventHandler(DecreaseStas);
            time.Interval = new TimeSpan(0, 0, 10);
            time.Start();
        }
        private void DecreaseStas(object sender, EventArgs e)
        {
            bool asd = false;
            hunger.Value -= 10;
            thirst.Value -= 15;
            if (hunger.Value <= 75 || thirst.Value <= 75 && asd != true)
            {
                mood.Value -= 30;
                asd = true;
            }
        }
        private void hunger_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hunger.Value += 30;
        }

        private void drink_Click(object sender, RoutedEventArgs e)
        {
            thirst.Value += 30;
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            mood.Value += 50;
        }
    }
}
