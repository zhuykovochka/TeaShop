using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Models.Payment;
using TeaShop.Models;

namespace TeaShop.Models.Payment
{
    public class CashPayment : IPaymentMethod
    {
        public bool Pay(decimal amount, Customer customer)
        {
            if (customer.CashBalance >= amount)
            {
                customer.CashBalance -= amount;
                customer.Bonuses += (int)(amount * 0.05m); // 5% бонусов
                return true;
            }
            return false;
        }
    }
}
