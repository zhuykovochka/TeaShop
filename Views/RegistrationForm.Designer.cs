namespace TeaShop.Views
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            numericCash = new NumericUpDown();
            numericCard = new NumericUpDown();
            numericBonuses = new NumericUpDown();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericCash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBonuses).BeginInit();
            SuspendLayout();
            // 
            // numericCash
            // 
            numericCash.Location = new Point(222, 54);
            numericCash.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            numericCash.Name = "numericCash";
            numericCash.Size = new Size(108, 31);
            numericCash.TabIndex = 0;
            // 
            // numericCard
            // 
            numericCard.Location = new Point(222, 91);
            numericCard.Maximum = new decimal(new int[] { 1661992960, 1808227885, 5, 0 });
            numericCard.Name = "numericCard";
            numericCard.Size = new Size(108, 31);
            numericCard.TabIndex = 1;
            // 
            // numericBonuses
            // 
            numericBonuses.Location = new Point(222, 128);
            numericBonuses.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            numericBonuses.Name = "numericBonuses";
            numericBonuses.Size = new Size(108, 31);
            numericBonuses.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(92, 196);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(173, 34);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Начать покупки";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 56);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 4;
            label1.Text = "Наличные средства:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 5;
            label2.Text = "Баланс карты:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 130);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 6;
            label3.Text = "Бонусные баллы:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 9);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 7;
            label4.Text = "ВХОД";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 244);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(numericBonuses);
            Controls.Add(numericCard);
            Controls.Add(numericCash);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)numericCash).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBonuses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericCash;
        private NumericUpDown numericCard;
        private NumericUpDown numericBonuses;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}