﻿namespace PizzaShop
{
    partial class Register
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
            this.rbutton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbutton
            // 
            this.rbutton.Location = new System.Drawing.Point(300, 329);
            this.rbutton.Name = "rbutton";
            this.rbutton.Size = new System.Drawing.Size(75, 23);
            this.rbutton.TabIndex = 10;
            this.rbutton.Text = "Login";
            this.rbutton.UseVisualStyleBackColor = true;
            this.rbutton.Click += new System.EventHandler(this.rbutton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(267, 236);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(146, 20);
            this.password.TabIndex = 9;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(267, 200);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(146, 20);
            this.username.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // confirmbox
            // 
            this.confirmbox.Location = new System.Drawing.Point(267, 272);
            this.confirmbox.Name = "confirmbox";
            this.confirmbox.Size = new System.Drawing.Size(146, 20);
            this.confirmbox.TabIndex = 12;
            this.confirmbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirm password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(286, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.label5);
            this.registerPanel.Controls.Add(this.label4);
            this.registerPanel.Controls.Add(this.pictureBox2);
            this.registerPanel.Controls.Add(this.errorLabel);
            this.registerPanel.Controls.Add(this.pictureBox1);
            this.registerPanel.Controls.Add(this.label1);
            this.registerPanel.Controls.Add(this.confirmbox);
            this.registerPanel.Controls.Add(this.label2);
            this.registerPanel.Controls.Add(this.label3);
            this.registerPanel.Controls.Add(this.username);
            this.registerPanel.Controls.Add(this.rbutton);
            this.registerPanel.Controls.Add(this.password);
            this.registerPanel.Location = new System.Drawing.Point(32, 28);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(724, 397);
            this.registerPanel.TabIndex = 14;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(318, 159);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PizzaShop.Properties.Resources.pizza_car;
            this.pictureBox2.Location = new System.Drawing.Point(121, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(314, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mom and Pops";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(314, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pizza";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerPanel);
            this.Name = "Register";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rbutton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}