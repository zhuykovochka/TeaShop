using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Models;

namespace TeaShop.Models
{
    public class Customer
    {
        public decimal CashBalance { get; set; }
        public decimal CardBalance { get; set; }
        public decimal Bonuses { get; set; }
        public List<CartItem> Cart { get; set; } = new List<CartItem>();
    }
}
