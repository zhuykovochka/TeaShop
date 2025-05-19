using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Models.Payment;
using TeaShop.Models;

namespace TeaShop.Models.Payment
{
    public class BonusPayment : IPaymentMethod
    {
        public bool Pay(decimal amount, Customer customer)
        {
            if (customer.Bonuses >= amount)
            {
                customer.Bonuses -= amount;
                return true;
            }
            return false;
        }
    }
}
