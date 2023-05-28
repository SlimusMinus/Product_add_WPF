using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Product_add_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click_ADD(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            Add_prod add_Prod = new Add_prod(product);
            if (add_Prod.ShowDialog() == true)
                LV_prod.Items.Add(product);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LV_prod.Items.Remove(LV_prod.SelectedItem);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Product original = (Product)LV_prod.SelectedItem;
            Product copy = original.Copy();
            Add_prod add_Prod = new Add_prod(copy);

            if (add_Prod.ShowDialog() == true)
                LV_prod.Items[LV_prod.SelectedIndex] = copy;
        }
    }
}
