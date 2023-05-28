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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Product_add_WPF
{
    /// <summary>
    /// Логика взаимодействия для Add_prod.xaml
    /// </summary>
    public partial class Add_prod : Window
    {
        Product product;
        public Add_prod(Product product)
        {
            InitializeComponent();
            Box_enum.ItemsSource = Enum.GetValues(typeof(Enum_amount));
            this.product = product;
            DataContext = product;
        }

        private void Button_Click_ADD(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
