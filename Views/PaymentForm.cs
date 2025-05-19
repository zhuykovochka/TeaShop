using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShop.Models;
using TeaShop.Services;

namespace TeaShop.Views
{
    public partial class PaymentForm : Form
    {
        public Dictionary<PaymentType, decimal> PaymentDistribution { get; } = new();

        private readonly decimal _totalAmount;
        private readonly Customer _customer;

        public PaymentForm(decimal totalAmount, Customer customer)
        {
            InitializeComponent();
            _totalAmount = totalAmount;
            _customer = customer;

            // Установка максимальных значений
            numericCash.Maximum = _customer.CashBalance;
            numericCard.Maximum = _customer.CardBalance;
            numericBonuses.Maximum = _customer.Bonuses;

            textBoxTotal.Text = $"Счёт: {totalAmount:C}";
            labelCash.Text = $"Наличные: {_customer.CashBalance:C}";
            labelCard.Text = $"Карта: {_customer.CardBalance:C}";
            labelBonuses.Text = $"Бонусы: {_customer.Bonuses}";
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            decimal cash = numericCash.Value;
            decimal card = numericCard.Value;
            decimal bonuses = numericBonuses.Value;
            decimal totalPaid = cash + card + bonuses;

            if (totalPaid != _totalAmount)
            {
                MessageBox.Show($"Сумма оплаты ({totalPaid:C}) не соответствует итогу ({_totalAmount:C})", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PaymentDistribution[PaymentType.Cash] = cash;
            PaymentDistribution[PaymentType.Card] = card;
            PaymentDistribution[PaymentType.Bonuses] = bonuses;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
