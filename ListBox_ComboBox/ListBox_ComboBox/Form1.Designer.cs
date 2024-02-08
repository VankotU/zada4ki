
namespace ListBox_ComboBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_RemoveFirst = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_RemoveLast = new System.Windows.Forms.Button();
            this.btn_InsertFirst = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_RemoveText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Location = new System.Drawing.Point(138, 39);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(45, 13);
            this.lbl_Text.TabIndex = 1;
            this.lbl_Text.Text = "Element";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(524, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 251);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(138, 142);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_RemoveFirst
            // 
            this.btn_RemoveFirst.Location = new System.Drawing.Point(283, 141);
            this.btn_RemoveFirst.Name = "btn_RemoveFirst";
            this.btn_RemoveFirst.Size = new System.Drawing.Size(126, 23);
            this.btn_RemoveFirst.TabIndex = 4;
            this.btn_RemoveFirst.Text = "Remove First";
            this.btn_RemoveFirst.UseVisualStyleBackColor = true;
            this.btn_RemoveFirst.Click += new System.EventHandler(this.btn_RemoveFirst_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(138, 195);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_RemoveLast
            // 
            this.btn_RemoveLast.Location = new System.Drawing.Point(283, 194);
            this.btn_RemoveLast.Name = "btn_RemoveLast";
            this.btn_RemoveLast.Size = new System.Drawing.Size(126, 23);
            this.btn_RemoveLast.TabIndex = 6;
            this.btn_RemoveLast.Text = "Remove Last";
            this.btn_RemoveLast.UseVisualStyleBackColor = true;
            this.btn_RemoveLast.Click += new System.EventHandler(this.btn_RemoveLast_Click);
            // 
            // btn_InsertFirst
            // 
            this.btn_InsertFirst.Location = new System.Drawing.Point(141, 251);
            this.btn_InsertFirst.Name = "btn_InsertFirst";
            this.btn_InsertFirst.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertFirst.TabIndex = 7;
            this.btn_InsertFirst.Text = "Insert Middle";
            this.btn_InsertFirst.UseVisualStyleBackColor = true;
            this.btn_InsertFirst.Click += new System.EventHandler(this.btn_InsertFirst_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_RemoveText
            // 
            this.btn_RemoveText.Location = new System.Drawing.Point(254, 251);
            this.btn_RemoveText.Name = "btn_RemoveText";
            this.btn_RemoveText.Size = new System.Drawing.Size(179, 23);
            this.btn_RemoveText.TabIndex = 9;
            this.btn_RemoveText.Text = "Remove element from text box";
            this.btn_RemoveText.UseVisualStyleBackColor = true;
            this.btn_RemoveText.Click += new System.EventHandler(this.btn_RemoveText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.btn_RemoveText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_InsertFirst);
            this.Controls.Add(this.btn_RemoveLast);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_RemoveFirst);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_RemoveFirst;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_RemoveLast;
        private System.Windows.Forms.Button btn_InsertFirst;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_RemoveText;
    }
}

