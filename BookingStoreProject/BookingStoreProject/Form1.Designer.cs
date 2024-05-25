
namespace BookingStoreProject
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.btn_NewTitle = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NumberOfTitles = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNumber);
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtPublisher);
            this.tabPage1.Controls.Add(this.cbType);
            this.tabPage1.Controls.Add(this.txtAuthor);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbBook);
            this.tabPage1.Controls.Add(this.txt_NumberOfTitles);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Add);
            this.tabPage1.Controls.Add(this.btn_Save);
            this.tabPage1.Controls.Add(this.btn_NewTitle);
            this.tabPage1.Controls.Add(this.btn_Compare);
            this.tabPage1.Controls.Add(this.btn_Load);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Въвеждане";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продажба";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Load.Location = new System.Drawing.Point(21, 29);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Зареди";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // btn_Compare
            // 
            this.btn_Compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Compare.Location = new System.Drawing.Point(21, 77);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(82, 23);
            this.btn_Compare.TabIndex = 1;
            this.btn_Compare.Text = "Справка";
            this.btn_Compare.UseVisualStyleBackColor = true;
            // 
            // btn_NewTitle
            // 
            this.btn_NewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_NewTitle.Location = new System.Drawing.Point(21, 117);
            this.btn_NewTitle.Name = "btn_NewTitle";
            this.btn_NewTitle.Size = new System.Drawing.Size(133, 40);
            this.btn_NewTitle.TabIndex = 2;
            this.btn_NewTitle.Text = "Ново заглавие";
            this.btn_NewTitle.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(638, 29);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Запази";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.Location = new System.Drawing.Point(627, 344);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(93, 51);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Добави";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(166, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Общ брой заглавия:";
            // 
            // txt_NumberOfTitles
            // 
            this.txt_NumberOfTitles.Location = new System.Drawing.Point(343, 32);
            this.txt_NumberOfTitles.Name = "txt_NumberOfTitles";
            this.txt_NumberOfTitles.Size = new System.Drawing.Size(100, 20);
            this.txt_NumberOfTitles.TabIndex = 6;
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(169, 79);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(274, 21);
            this.cbBook.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Заглавие:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Жанр:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Автор:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Издателство:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Цена:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(394, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Брой:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 179);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(309, 20);
            this.txtName.TabIndex = 14;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(134, 217);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(309, 20);
            this.txtAuthor.TabIndex = 15;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Хуманитарна литература",
            "Художествена литература",
            "Психология",
            "Компютри",
            "Чужди езици",
            "Техника",
            "Медицина",
            "Икономика",
            "Справочна литература",
            "Право",
            "Хоби",
            "Педагогика ",
            "Друг"});
            this.cbType.Location = new System.Drawing.Point(134, 249);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(309, 21);
            this.cbType.TabIndex = 16;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(134, 285);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(309, 20);
            this.txtPublisher.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(73, 343);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(449, 343);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Книжарница";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.TextBox txt_NumberOfTitles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_NewTitle;
        private System.Windows.Forms.Button btn_Compare;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

