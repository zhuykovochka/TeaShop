using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShop.Models;

namespace TeaShop.Views
{
    public partial class RegistrationForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Customer RegisteredCustomer { get; private set; }

        public RegistrationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            decimal cash = numericCash.Value;
            decimal card = numericCard.Value;
            decimal bonuses = numericBonuses.Value;

            // Проверка что у пользователя есть хотя бы какие-то средства
            if (cash + card + bonuses == 0)
            {
                MessageBox.Show("У вас не может быть ноль средств для покупок!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegisteredCustomer = new Customer
            {
                CashBalance = cash,
                CardBalance = card,
                Bonuses = bonuses
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
