﻿namespace old_win_forms_1
{
    partial class Form3
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
            this.out_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Нажми на меня";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // out_txt
            // 
            this.out_txt.BackColor = System.Drawing.SystemColors.Info;
            this.out_txt.Location = new System.Drawing.Point(302, 97);
            this.out_txt.Multiline = true;
            this.out_txt.Name = "out_txt";
            this.out_txt.Size = new System.Drawing.Size(300, 61);
            this.out_txt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 330);
            this.Controls.Add(this.out_txt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Моё первое приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox out_txt;
    }
}

