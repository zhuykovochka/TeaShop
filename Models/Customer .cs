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
        public decimal CashBalance { get; set; } = 1000; // Наличные
        public decimal CardBalance { get; set; } = 5000; // Баланс карты
        public decimal Bonuses { get; set; } = 50;   // Начальные бонусы
        public List<CartItem> Cart { get; set; } = new List<CartItem>();
    }
}
