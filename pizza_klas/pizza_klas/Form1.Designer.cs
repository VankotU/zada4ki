namespace pizza_klas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbox_variant = new System.Windows.Forms.GroupBox();
            this.rb_small = new System.Windows.Forms.RadioButton();
            this.rb_big = new System.Windows.Forms.RadioButton();
            this.rb_family = new System.Windows.Forms.RadioButton();
            this.grb_payment = new System.Windows.Forms.GroupBox();
            this.rb_cash = new System.Windows.Forms.RadioButton();
            this.rb_card = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_pizza = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbox_variant.SuspendLayout();
            this.grb_payment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbox_variant
            // 
            this.grbox_variant.Controls.Add(this.rb_family);
            this.grbox_variant.Controls.Add(this.rb_big);
            this.grbox_variant.Controls.Add(this.rb_small);
            this.grbox_variant.Location = new System.Drawing.Point(12, 38);
            this.grbox_variant.Name = "grbox_variant";
            this.grbox_variant.Size = new System.Drawing.Size(135, 115);
            this.grbox_variant.TabIndex = 0;
            this.grbox_variant.TabStop = false;
            this.grbox_variant.Text = "Вариант";
            // 
            // rb_small
            // 
            this.rb_small.AutoSize = true;
            this.rb_small.Location = new System.Drawing.Point(7, 20);
            this.rb_small.Name = "rb_small";
            this.rb_small.Size = new System.Drawing.Size(58, 17);
            this.rb_small.TabIndex = 0;
            this.rb_small.TabStop = true;
            this.rb_small.Text = "Малка";
            this.rb_small.UseVisualStyleBackColor = true;
            // 
            // rb_big
            // 
            this.rb_big.AutoSize = true;
            this.rb_big.Location = new System.Drawing.Point(7, 44);
            this.rb_big.Name = "rb_big";
            this.rb_big.Size = new System.Drawing.Size(63, 17);
            this.rb_big.TabIndex = 1;
            this.rb_big.TabStop = true;
            this.rb_big.Text = "Голяма";
            this.rb_big.UseVisualStyleBackColor = true;
            // 
            // rb_family
            // 
            this.rb_family.AutoSize = true;
            this.rb_family.Location = new System.Drawing.Point(7, 68);
            this.rb_family.Name = "rb_family";
            this.rb_family.Size = new System.Drawing.Size(70, 17);
            this.rb_family.TabIndex = 2;
            this.rb_family.TabStop = true;
            this.rb_family.Text = "Семейна";
            this.rb_family.UseVisualStyleBackColor = true;
            // 
            // grb_payment
            // 
            this.grb_payment.Controls.Add(this.rb_card);
            this.grb_payment.Controls.Add(this.rb_cash);
            this.grb_payment.Location = new System.Drawing.Point(19, 173);
            this.grb_payment.Name = "grb_payment";
            this.grb_payment.Size = new System.Drawing.Size(128, 84);
            this.grb_payment.TabIndex = 1;
            this.grb_payment.TabStop = false;
            this.grb_payment.Text = "Плащане";
            // 
            // rb_cash
            // 
            this.rb_cash.AutoSize = true;
            this.rb_cash.Location = new System.Drawing.Point(6, 19);
            this.rb_cash.Name = "rb_cash";
            this.rb_cash.Size = new System.Drawing.Size(58, 17);
            this.rb_cash.TabIndex = 0;
            this.rb_cash.TabStop = true;
            this.rb_cash.Text = "в брой";
            this.rb_cash.UseVisualStyleBackColor = true;
            // 
            // rb_card
            // 
            this.rb_card.AutoSize = true;
            this.rb_card.Location = new System.Drawing.Point(6, 42);
            this.rb_card.Name = "rb_card";
            this.rb_card.Size = new System.Drawing.Size(63, 17);
            this.rb_card.TabIndex = 1;
            this.rb_card.TabStop = true;
            this.rb_card.Text = "с карта";
            this.rb_card.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(153, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Екстри";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "кетчуп";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "майонеза";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "горчица";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 97);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "чеснов сос";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 120);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(70, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "соев сос";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(15, 143);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(48, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "чили";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поръчай";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_pizza
            // 
            this.cmb_pizza.FormattingEnabled = true;
            this.cmb_pizza.Items.AddRange(new object[] {
            "Kaprichoza",
            "Havaiska",
            "Kuatro stadjone",
            "Formadjo"});
            this.cmb_pizza.Location = new System.Drawing.Point(12, 12);
            this.cmb_pizza.Name = "cmb_pizza";
            this.cmb_pizza.Size = new System.Drawing.Size(291, 21);
            this.cmb_pizza.TabIndex = 5;
            this.cmb_pizza.SelectedIndexChanged += new System.EventHandler(this.cmb_pizza_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 186);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 286);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_pizza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_payment);
            this.Controls.Add(this.grbox_variant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbox_variant.ResumeLayout(false);
            this.grbox_variant.PerformLayout();
            this.grb_payment.ResumeLayout(false);
            this.grb_payment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbox_variant;
        private System.Windows.Forms.RadioButton rb_family;
        private System.Windows.Forms.RadioButton rb_big;
        private System.Windows.Forms.RadioButton rb_small;
        private System.Windows.Forms.GroupBox grb_payment;
        private System.Windows.Forms.RadioButton rb_card;
        private System.Windows.Forms.RadioButton rb_cash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_pizza;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

