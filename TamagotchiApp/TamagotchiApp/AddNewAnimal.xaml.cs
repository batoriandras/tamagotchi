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
    /// Interaction logic for AddNewAnimal.xaml
    /// </summary>
    partial class AddNewAnimal : Window
    {
        RestApiHandler handler;
        public AddNewAnimal(RestApiHandler handler)
        {
            InitializeComponent();
            this.handler = handler;
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> values = new Dictionary<string, string>
            {
                {"animaltype", animaltype.Text},
                {"animalimg", animalimg.Text}
            };

            
            Animal newanimal = handler.PostAnimal("newanimal", values);

        }
    }
}
