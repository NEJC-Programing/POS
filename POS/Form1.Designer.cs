﻿namespace POS
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
            this.keypad1 = new UI.Keypad();
            this.display1 = new UI.Display();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 20);
            this.textBox1.TabIndex = 1;
            // 
            // keypad1
            // 
            this.keypad1.Location = new System.Drawing.Point(12, 92);
            this.keypad1.Name = "keypad1";
            this.keypad1.Size = new System.Drawing.Size(325, 328);
            this.keypad1.TabIndex = 0;
            this.keypad1.ButtonPressed += new System.Windows.Forms.KeyPressEventHandler(this.keypad1_ButtonPressed);
            // 
            // display1
            // 
            this.display1.Location = new System.Drawing.Point(392, 31);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(294, 79);
            this.display1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.keypad1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.Keypad keypad1;
        private System.Windows.Forms.TextBox textBox1;
        private UI.Display display1;
    }
}

