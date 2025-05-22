using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal PricePerUnit { get; set; }
        public bool RequiresWeighing { get; set; } // Цена за 100 грамм
        public string ImagePath { get; set; }  
    }
}
