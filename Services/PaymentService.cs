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

            foreach (var payment in paymentPlan) // 1. Перебираем все выбранные способы оплаты
            {
                IPaymentMethod paymentMethod = payment.Key switch // 2. Выбираем стратегию оплаты через switch-expression
                {
                    PaymentType.Cash => new CashPayment(),
                    PaymentType.Card => new CardPayment(),
                    PaymentType.Bonuses => new BonusPayment()
                };
                // 3. Пытаемся выполнить платеж
                if (!paymentMethod.Pay(payment.Value, customer))
                {
                    result.Success = false;
                    result.ErrorMessage = $"Ошибка оплаты {payment.Key}";
                    return result; // Прерываем при ошибке
                }
                // 4. Учет успешных платежей
                paidAmount += payment.Value;
                result.PaidAmounts[payment.Key] = payment.Value;
            }
            // 5. Проверка полного покрытия суммы
            result.Success = paidAmount == amount;
            return result;
        }
    }

    public class PaymentResult
    {
        public bool Success { get; set; } // Общий статус операции
        public string ErrorMessage { get; set; } // Сообщение об ошибке (если Success = false)
        public Dictionary<PaymentType, decimal> PaidAmounts { get; } = new(); // Детализация платеже
    }

    public enum PaymentType { Cash, Card, Bonuses } //типы доступных платежей
}
