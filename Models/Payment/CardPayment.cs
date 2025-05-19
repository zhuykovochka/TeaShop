using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Models.Payment;
using TeaShop.Models;

namespace TeaShop.Models.Payment
{
    public class CardPayment : IPaymentMethod
    {
        public bool Pay(decimal amount, Customer customer)
        {
            if (customer.CardBalance >= amount)
            {
                customer.CardBalance -= amount;
                customer.Bonuses += (int)(amount * 0.03m); // 3% бонусов
                return true;
            }
            return false;
        }
    }
}
