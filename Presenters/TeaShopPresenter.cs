using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Models;
using TeaShop.Models.Payment;
using TeaShop.Services;
using TeaShop.Views;

namespace TeaShop.Presenters
{
    public class TeaShopPresenter
    {
        private IMainView _view; // Ссылка на представление
        private readonly JsonDataService _dataService;
        private readonly Customer _customer; // Текущий покупатель
        private List<Product> _products;
        private readonly PaymentService _paymentService; // Сервис обработки платежей

        public TeaShopPresenter(Customer customer)
        {
            _customer = customer;
            _dataService = new JsonDataService();
            _paymentService = new PaymentService();
        }
        public void SetView(IMainView view)
        {
            _view = view; // Сохраняем ссылку на View
            LoadProducts();
            // Обновляем информацию о покупателе в View
            _view.UpdateCustomerInfo(_customer.CashBalance, _customer.CardBalance, _customer.Bonuses);
        }
        public void LoadProducts()
        {
            _products = _dataService.LoadProducts(@"Services\\data.json");
            _view.DisplayProducts(_products);
        }
        public void ClearCart()
        {
            _customer.Cart.Clear();
            _view.UpdateCart(_customer.Cart, CalculateTotal());
        }
        public PaymentResult ProcessPayment()
        {
            decimal total = CalculateTotal(); // Рассчитываем сумму
            if (total <= 0)
                return new PaymentResult { Success = false, ErrorMessage = "Корзина пуста" };
            // Создаем форму оплаты
            var paymentForm = new PaymentForm(total, _customer);
            if (paymentForm.ShowDialog() == DialogResult.OK) // Если пользователь подтвердил оплату
            {
                // Обрабатываем платеж через PaymentService
                var result = _paymentService.ProcessPayment(total, _customer, paymentForm.PaymentDistribution);

                if (result.Success)
                {
                    // Очищаем корзину и обновляем View
                    ClearCart();
                    _view.UpdateCustomerInfo(_customer.CashBalance, _customer.CardBalance, _customer.Bonuses);
                    return result;
                }
                return result;
            }
            return new PaymentResult { Success = false, ErrorMessage = "Оплата отменена" };
        }
        public void AddToCart(Product product, decimal weight)
        {
            // Проверка для весовых товаров
            if (product.RequiresWeighing && weight <= 0)
            {
                MessageBox.Show("Сначала взвесьте товар!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Создаем элемент корзины
            var cartItem = new CartItem
            {
                Product = product,
                Weight = product.RequiresWeighing ? weight : 100 // Для товаров не на развес берем 100г
            };

            _customer.Cart.Add(cartItem); // Добавляем в корзину покупателя
            _view.UpdateCart(_customer.Cart, CalculateTotal()); // Обновляем отображение корзины
        }

        public void RemoveFromCart(CartItem item)
        {
            _customer.Cart.Remove(item);
            _view.UpdateCart(_customer.Cart, CalculateTotal());
        }
        //Расчет суммы корзины
        public decimal CalculateTotal() => _customer.Cart.Sum(item => item.TotalPrice); 
    }
}