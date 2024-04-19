
namespace Pizza
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rb_Golqma = new System.Windows.Forms.RadioButton();
            this.rb_Sredna = new System.Windows.Forms.RadioButton();
            this.rb_Malka = new System.Windows.Forms.RadioButton();
            this.gb_Razmer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Ketchup = new System.Windows.Forms.CheckBox();
            this.cb_Mayoneza = new System.Windows.Forms.CheckBox();
            this.cb_Gorchica = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Poruchka = new System.Windows.Forms.Button();
            this.gb_Razmer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Havaiska",
            "Peperoni",
            "kaprichoza",
            "margarita",
            "kalcone",
            "kuatro stadjone"});
            this.comboBox1.Location = new System.Drawing.Point(18, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // rb_Golqma
            // 
            this.rb_Golqma.AutoSize = true;
            this.rb_Golqma.Location = new System.Drawing.Point(10, 24);
            this.rb_Golqma.Name = "rb_Golqma";
            this.rb_Golqma.Size = new System.Drawing.Size(61, 17);
            this.rb_Golqma.TabIndex = 1;
            this.rb_Golqma.TabStop = true;
            this.rb_Golqma.Text = "Golqma";
            this.rb_Golqma.UseVisualStyleBackColor = true;
            // 
            // rb_Sredna
            // 
            this.rb_Sredna.AutoSize = true;
            this.rb_Sredna.Location = new System.Drawing.Point(10, 47);
            this.rb_Sredna.Name = "rb_Sredna";
            this.rb_Sredna.Size = new System.Drawing.Size(59, 17);
            this.rb_Sredna.TabIndex = 2;
            this.rb_Sredna.TabStop = true;
            this.rb_Sredna.Text = "Sredna";
            this.rb_Sredna.UseVisualStyleBackColor = true;
            // 
            // rb_Malka
            // 
            this.rb_Malka.AutoSize = true;
            this.rb_Malka.Location = new System.Drawing.Point(10, 70);
            this.rb_Malka.Name = "rb_Malka";
            this.rb_Malka.Size = new System.Drawing.Size(54, 17);
            this.rb_Malka.TabIndex = 3;
            this.rb_Malka.TabStop = true;
            this.rb_Malka.Text = "Malka";
            this.rb_Malka.UseVisualStyleBackColor = true;
            // 
            // gb_Razmer
            // 
            this.gb_Razmer.Controls.Add(this.rb_Malka);
            this.gb_Razmer.Controls.Add(this.rb_Sredna);
            this.gb_Razmer.Controls.Add(this.rb_Golqma);
            this.gb_Razmer.Location = new System.Drawing.Point(12, 61);
            this.gb_Razmer.Name = "gb_Razmer";
            this.gb_Razmer.Size = new System.Drawing.Size(92, 103);
            this.gb_Razmer.TabIndex = 4;
            this.gb_Razmer.TabStop = false;
            this.gb_Razmer.Text = "Razmer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vid pizza";
            // 
            // cb_Ketchup
            // 
            this.cb_Ketchup.AutoSize = true;
            this.cb_Ketchup.Location = new System.Drawing.Point(10, 19);
            this.cb_Ketchup.Name = "cb_Ketchup";
            this.cb_Ketchup.Size = new System.Drawing.Size(66, 17);
            this.cb_Ketchup.TabIndex = 6;
            this.cb_Ketchup.Text = "Ketchup";
            this.cb_Ketchup.UseVisualStyleBackColor = true;
            // 
            // cb_Mayoneza
            // 
            this.cb_Mayoneza.AutoSize = true;
            this.cb_Mayoneza.Location = new System.Drawing.Point(10, 40);
            this.cb_Mayoneza.Name = "cb_Mayoneza";
            this.cb_Mayoneza.Size = new System.Drawing.Size(75, 17);
            this.cb_Mayoneza.TabIndex = 7;
            this.cb_Mayoneza.Text = "Mayoneza";
            this.cb_Mayoneza.UseVisualStyleBackColor = true;
            // 
            // cb_Gorchica
            // 
            this.cb_Gorchica.AutoSize = true;
            this.cb_Gorchica.Location = new System.Drawing.Point(10, 63);
            this.cb_Gorchica.Name = "cb_Gorchica";
            this.cb_Gorchica.Size = new System.Drawing.Size(69, 17);
            this.cb_Gorchica.TabIndex = 8;
            this.cb_Gorchica.Text = "Gorchica";
            this.cb_Gorchica.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Gorchica);
            this.groupBox1.Controls.Add(this.cb_Mayoneza);
            this.groupBox1.Controls.Add(this.cb_Ketchup);
            this.groupBox1.Location = new System.Drawing.Point(110, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dobavki";
            // 
            // btn_Poruchka
            // 
            this.btn_Poruchka.Location = new System.Drawing.Point(12, 180);
            this.btn_Poruchka.Name = "btn_Poruchka";
            this.btn_Poruchka.Size = new System.Drawing.Size(124, 58);
            this.btn_Poruchka.TabIndex = 10;
            this.btn_Poruchka.Text = "Poruchka";
            this.btn_Poruchka.UseVisualStyleBackColor = true;
            this.btn_Poruchka.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 270);
            this.Controls.Add(this.btn_Poruchka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_Razmer);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Pizariq Maniq";
            this.gb_Razmer.ResumeLayout(false);
            this.gb_Razmer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rb_Golqma;
        private System.Windows.Forms.RadioButton rb_Sredna;
        private System.Windows.Forms.RadioButton rb_Malka;
        private System.Windows.Forms.GroupBox gb_Razmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Ketchup;
        private System.Windows.Forms.CheckBox cb_Mayoneza;
        private System.Windows.Forms.CheckBox cb_Gorchica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Poruchka;
    }
}

