using System;
using System.Windows.Forms;
using TeaShop.Models;
using TeaShop.Presenters;
using TeaShop.Views;
using TeaShop.Presenters;
using TeaShop.Services;

namespace TeaApp
{
    public partial class MainForm : Form, IMainView
    {
        private readonly TeaShopPresenter _presenter;

        public MainForm(Customer customer)
        {
            InitializeComponent();
            _presenter = new TeaShopPresenter(this, customer);
            // Подписываемся на событие выбора товара
            listBoxProducts.SelectedIndexChanged += ListBoxProducts_SelectedIndexChanged;
        }
        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem is Product selectedProduct)
            {
                DisplayProductPrice(selectedProduct, selectedProduct.PricePerUnit);
                var image = Image.FromFile(selectedProduct.ImagePath);
                DisplayProductImage(image);
            }
        }
        // Реализация IMainView
        public void DisplayProducts(List<Product> products)
        {
            listBoxProducts.DataSource = products;
            listBoxProducts.DisplayMember = "Name";
        }
        public void DisplayProductImage(Image image)
        {
            pictureBoxProduct.Image = image;
        }
        public void DisplayProductPrice(Product product, decimal price)
        {
            if (product.RequiresWeighing)
            {
                labelProductPrice.Text = $"Цена за 100 г: {price:C}";
            }
            else
            {
                labelProductPrice.Text = $"Цена: {price:C}";
            }
        }

        public void UpdateCart(System.Collections.Generic.List<CartItem> cart, decimal total)
        {
            listBoxCart.DataSource = null;
            listBoxCart.DataSource = cart;
            listBoxCart.DisplayMember = "ToString";
            textBoxTotal.Text = total.ToString("C");
        }
        public void UpdateCustomerInfo(decimal cashBalance, decimal cardBalance, decimal bonuses)
        {
            labelBalance.Text = $"Баланс: {cashBalance + cardBalance:C}";
            labelBonuses.Text = $"Бонусы: {bonuses}";
        }
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem is Product selectedProduct)
                _presenter.AddToCart(selectedProduct, numericUpDownWeight.Value);
            numericUpDownWeight.Value = 0;
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItem is CartItem selectedItem)
                _presenter.RemoveFromCart(selectedItem);
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            // Получаем текущую сумму корзины
            decimal total = _presenter.CalculateTotal();

            // Проверяем, есть ли товары в корзине
            if (total <= 0)
            {
                MessageBox.Show("Корзина пуста! Добавьте товары перед оплатой.",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }
            var customer = _presenter.GetCustomer();
            var paymentForm = new PaymentForm(total, customer);

            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                var result = _presenter.ProcessPayment(paymentForm.PaymentDistribution);

                if (result.Success)
                {
                    MessageBox.Show($"Оплата прошла успешно!\n" +
                                 $"Наличные: {result.PaidAmounts[PaymentType.Cash]:C}\n" +
                                 $"Карта: {result.PaidAmounts[PaymentType.Card]:C}\n" +
                                 $"Бонусы: {result.PaidAmounts[PaymentType.Bonuses]}","Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    _presenter.ClearCart();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
    }
}