using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Models.Payment;
using TeaShop.Models;

namespace TeaShop.Services
{
    public class PaymentService
    {
        public PaymentResult ProcessPayment(decimal amount, Customer customer,
            Dictionary<PaymentType, decimal> paymentPlan)
        {
            decimal paidAmount = 0;
            var result = new PaymentResult();

            foreach (var payment in paymentPlan)
            {
                IPaymentMethod paymentMethod = payment.Key switch
                {
                    PaymentType.Cash => new CashPayment(),
                    PaymentType.Card => new CardPayment(),
                    PaymentType.Bonuses => new BonusPayment()
                };

                if (!paymentMethod.Pay(payment.Value, customer))
                {
                    result.Success = false;
                    result.ErrorMessage = $"Ошибка оплаты {payment.Key}";
                    return result;
                }

                paidAmount += payment.Value;
                result.PaidAmounts[payment.Key] = payment.Value;
            }

            result.Success = paidAmount == amount;
            return result;
        }
    }

    public class PaymentResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public Dictionary<PaymentType, decimal> PaidAmounts { get; } = new();
    }

    public enum PaymentType { Cash, Card, Bonuses }
}
