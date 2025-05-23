using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public decimal Weight { get; set; } // Вес в граммах
        public decimal TotalPrice => Product.PricePerUnit * (Weight / 100m);
        public override string ToString()
        {
            return Product.RequiresWeighing
                ? $"{Product.Name} - {Weight:F2}г ({TotalPrice:C})"
                : $"{Product.Name} ({TotalPrice:C})";
        }
    }
}
