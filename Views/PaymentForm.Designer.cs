namespace TeaShop.Views
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericCash = new NumericUpDown();
            numericBonuses = new NumericUpDown();
            numericCard = new NumericUpDown();
            labelCard = new Label();
            labelBonuses = new Label();
            labelCash = new Label();
            buttonConfirm = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBoxTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericCash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBonuses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCard).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // numericCash
            // 
            numericCash.DecimalPlaces = 2;
            numericCash.Location = new Point(16, 33);
            numericCash.Name = "numericCash";
            numericCash.Size = new Size(137, 31);
            numericCash.TabIndex = 0;
            // 
            // numericBonuses
            // 
            numericBonuses.DecimalPlaces = 2;
            numericBonuses.Location = new Point(16, 107);
            numericBonuses.Name = "numericBonuses";
            numericBonuses.Size = new Size(137, 31);
            numericBonuses.TabIndex = 1;
            // 
            // numericCard
            // 
            numericCard.DecimalPlaces = 2;
            numericCard.Location = new Point(16, 70);
            numericCard.Name = "numericCard";
            numericCard.Size = new Size(137, 31);
            numericCard.TabIndex = 3;
            // 
            // labelCard
            // 
            labelCard.AutoSize = true;
            labelCard.Location = new Point(6, 72);
            labelCard.Name = "labelCard";
            labelCard.Size = new Size(58, 25);
            labelCard.TabIndex = 4;
            labelCard.Text = "Карта";
            // 
            // labelBonuses
            // 
            labelBonuses.AutoSize = true;
            labelBonuses.Location = new Point(6, 109);
            labelBonuses.Name = "labelBonuses";
            labelBonuses.Size = new Size(73, 25);
            labelBonuses.TabIndex = 5;
            labelBonuses.Text = "Бонусы";
            // 
            // labelCash
            // 
            labelCash.AutoSize = true;
            labelCash.Location = new Point(6, 35);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(95, 25);
            labelCash.TabIndex = 6;
            labelCash.Text = "Наличные";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Dock = DockStyle.Bottom;
            buttonConfirm.Location = new Point(0, 219);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(408, 34);
            buttonConfirm.TabIndex = 7;
            buttonConfirm.Text = "Совершить покупку";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelCash);
            groupBox1.Controls.Add(labelCard);
            groupBox1.Controls.Add(labelBonuses);
            groupBox1.Location = new Point(23, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 157);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ваши средства:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericCash);
            groupBox2.Controls.Add(numericBonuses);
            groupBox2.Controls.Add(numericCard);
            groupBox2.Location = new Point(218, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 157);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Чек:";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Dock = DockStyle.Top;
            textBoxTotal.Enabled = false;
            textBoxTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTotal.Location = new Point(0, 0);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(408, 31);
            textBoxTotal.TabIndex = 10;
            textBoxTotal.Text = "Итого:";
            textBoxTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 253);
            Controls.Add(textBoxTotal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonConfirm);
            Name = "PaymentForm";
            Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)numericCash).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBonuses).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCard).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericCash;
        private NumericUpDown numericBonuses;
        private NumericUpDown numericCard;
        private Label labelCard;
        private Label labelBonuses;
        private Label labelCash;
        private Button buttonConfirm;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxTotal;
    }
}