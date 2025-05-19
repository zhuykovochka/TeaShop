using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Models;

namespace TeaShop.Models.Payment
{
    public interface IPaymentMethod
    {
        bool Pay(decimal amount, Customer customer);
    }
}
