﻿namespace lebedevReg2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(256, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.Location = new System.Drawing.Point(256, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(242, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(114, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(114, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(231, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox2.Location = new System.Drawing.Point(231, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Муж.",
            "Жен."});
            this.checkedListBox1.Location = new System.Drawing.Point(231, 260);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(114, 42);
            this.checkedListBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(114, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 43);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пол";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 599);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
    }
}

