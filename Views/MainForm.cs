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

        public MainForm()
        {
            InitializeComponent();
            _presenter = new TeaShopPresenter(this);
            // Подписываемся на событие выбора товара
            listBoxProducts.SelectedIndexChanged += ListBoxProducts_SelectedIndexChanged;
        }
        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem is Product selectedProduct)
            {
                DisplayProductPrice(selectedProduct.PricePerUnit);
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
        public void DisplayProductPrice(decimal price)
        {
            labelProductPrice.Text = $"Цена: {price:C}";
        }

        public void UpdateCart(List<Product> cart, decimal total)
        {
            listBoxCart.DataSource = null;
            listBoxCart.DataSource = cart;
            listBoxCart.DisplayMember = "Name";
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
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedItem is Product selectedProduct)
                _presenter.RemoveFromCart(selectedProduct);
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            decimal total = _presenter.CalculateTotal();
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
                                 $"Бонусы: {result.PaidAmounts[PaymentType.Bonuses]}");
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