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
        private IMainView _view;
        private readonly JsonDataService _dataService;
        private readonly Customer _customer;
        private List<Product> _products;
        private readonly PaymentService _paymentService;

        public TeaShopPresenter(Customer customer)
        {
            _customer = customer;
            _dataService = new JsonDataService();
            _paymentService = new PaymentService();
        }
        public void SetView(IMainView view)
        {
            _view = view;
            LoadProducts();
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
            decimal total = CalculateTotal();
            if (total <= 0)
                return new PaymentResult { Success = false, ErrorMessage = "Корзина пуста" };

            var paymentForm = new PaymentForm(total, _customer);
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
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
            if (product.RequiresWeighing && weight <= 0)
            {
                MessageBox.Show("Сначала взвесьте товар!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cartItem = new CartItem
            {
                Product = product,
                Weight = product.RequiresWeighing ? weight : 100 // Для товаров не на развес берем 100г
            };

            _customer.Cart.Add(cartItem);
            _view.UpdateCart(_customer.Cart, CalculateTotal());
        }

        public void RemoveFromCart(CartItem item)
        {
            _customer.Cart.Remove(item);
            _view.UpdateCart(_customer.Cart, CalculateTotal());
        }
        public decimal CalculateTotal() => _customer.Cart.Sum(item => item.TotalPrice);
    }
}