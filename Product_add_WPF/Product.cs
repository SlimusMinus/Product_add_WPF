using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_add_WPF
{
    public class Product
    {
        public string Name_prod { get; set; }
        public string Quantity { get; set; }
        public Enum_amount Amount { get; set; }

        public Product Copy() => new Product() { Name_prod = Name_prod, Amount = Amount, Quantity = Quantity};

        public override string ToString()
        {
            return $"{Name_prod} {Quantity} {Amount}";
        }
    }
}
