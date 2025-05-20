namespace TeaApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxProducts = new ListBox();
            listBoxCart = new ListBox();
            buttonAddToCart = new Button();
            buttonRemoveFromCart = new Button();
            numericUpDownWeight = new NumericUpDown();
            textBoxTotal = new TextBox();
            buttonPay = new Button();
            labelBalance = new Label();
            labelBonuses = new Label();
            pictureBoxProduct = new PictureBox();
            labelProductPrice = new Label();
            groupBox1 = new GroupBox();
            labelCart = new Label();
            groupBox2 = new GroupBox();
            labelWeight = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(210, 30);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(214, 104);
            listBoxProducts.TabIndex = 0;
            // 
            // listBoxCart
            // 
            listBoxCart.Font = new Font("Segoe UI", 9F);
            listBoxCart.FormattingEnabled = true;
            listBoxCart.Location = new Point(26, 89);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(351, 104);
            listBoxCart.TabIndex = 1;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(56, 47);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(112, 34);
            buttonAddToCart.TabIndex = 2;
            buttonAddToCart.Text = "Добавить";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // buttonRemoveFromCart
            // 
            buttonRemoveFromCart.Location = new Point(222, 47);
            buttonRemoveFromCart.Name = "buttonRemoveFromCart";
            buttonRemoveFromCart.Size = new Size(112, 34);
            buttonRemoveFromCart.TabIndex = 3;
            buttonRemoveFromCart.Text = "Удалить";
            buttonRemoveFromCart.UseVisualStyleBackColor = true;
            buttonRemoveFromCart.Click += buttonRemoveFromCart_Click;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.DecimalPlaces = 2;
            numericUpDownWeight.Increment = new decimal(new int[] { 1000, 0, 0, 131072 });
            numericUpDownWeight.Location = new Point(95, 43);
            numericUpDownWeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(109, 31);
            numericUpDownWeight.TabIndex = 4;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Enabled = false;
            textBoxTotal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTotal.ForeColor = SystemColors.ActiveCaptionText;
            textBoxTotal.Location = new Point(222, 108);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(112, 32);
            textBoxTotal.TabIndex = 6;
            textBoxTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(137, 161);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(112, 34);
            buttonPay.TabIndex = 7;
            buttonPay.Text = "Оплатить";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Location = new Point(26, 27);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(71, 25);
            labelBalance.TabIndex = 8;
            labelBalance.Text = "Баланс:";
            // 
            // labelBonuses
            // 
            labelBonuses.AutoSize = true;
            labelBonuses.Location = new Point(26, 52);
            labelBonuses.Name = "labelBonuses";
            labelBonuses.Size = new Size(77, 25);
            labelBonuses.TabIndex = 9;
            labelBonuses.Text = "Бонусы:";
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.Location = new Point(24, 140);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(400, 300);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProduct.TabIndex = 11;
            pictureBoxProduct.TabStop = false;
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Location = new Point(24, 93);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(57, 25);
            labelProductPrice.TabIndex = 12;
            labelProductPrice.Text = "Цена:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddToCart);
            groupBox1.Controls.Add(labelCart);
            groupBox1.Controls.Add(buttonRemoveFromCart);
            groupBox1.Controls.Add(buttonPay);
            groupBox1.Controls.Add(textBoxTotal);
            groupBox1.Location = new Point(23, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 222);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Операции:";
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Location = new Point(67, 111);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(86, 25);
            labelCart.TabIndex = 15;
            labelCart.Text = "К оплате:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxCart);
            groupBox2.Controls.Add(labelBalance);
            groupBox2.Controls.Add(labelBonuses);
            groupBox2.Location = new Point(23, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 214);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Корзина:";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(24, 45);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(65, 25);
            labelWeight.TabIndex = 16;
            labelWeight.Text = "Вес (г):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBoxProducts);
            groupBox3.Controls.Add(pictureBoxProduct);
            groupBox3.Controls.Add(labelWeight);
            groupBox3.Controls.Add(numericUpDownWeight);
            groupBox3.Controls.Add(labelProductPrice);
            groupBox3.Location = new Point(450, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(450, 451);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Товар:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 479);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "TeaShop";
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProducts;
        private ListBox listBoxCart;
        private Button buttonAddToCart;
        private Button buttonRemoveFromCart;
        private NumericUpDown numericUpDownWeight;
        private TextBox textBoxTotal;
        private Button buttonPay;
        private Label labelBalance;
        private Label labelBonuses;
        private PictureBox pictureBoxProduct;
        private Label labelProductPrice;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelCart;
        private Label labelWeight;
        private GroupBox groupBox3;
    }
}
