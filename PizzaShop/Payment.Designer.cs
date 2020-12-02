namespace PizzaShop
{
    partial class Payment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkButton = new System.Windows.Forms.RadioButton();
            this.ccButton = new System.Windows.Forms.RadioButton();
            this.codButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ccBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.homeb = new System.Windows.Forms.Button();
            this.cartb = new System.Windows.Forms.Button();
            this.logoutb = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.payPanel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.payPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkButton);
            this.groupBox1.Controls.Add(this.ccButton);
            this.groupBox1.Controls.Add(this.codButton);
            this.groupBox1.Location = new System.Drawing.Point(40, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // checkButton
            // 
            this.checkButton.AutoSize = true;
            this.checkButton.Location = new System.Drawing.Point(19, 68);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(99, 17);
            this.checkButton.TabIndex = 2;
            this.checkButton.TabStop = true;
            this.checkButton.Text = "Pay with Check";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // ccButton
            // 
            this.ccButton.AutoSize = true;
            this.ccButton.Location = new System.Drawing.Point(19, 44);
            this.ccButton.Name = "ccButton";
            this.ccButton.Size = new System.Drawing.Size(160, 17);
            this.ccButton.TabIndex = 1;
            this.ccButton.TabStop = true;
            this.ccButton.Text = "Pay Now with Credit or Debit";
            this.ccButton.UseVisualStyleBackColor = true;
            // 
            // codButton
            // 
            this.codButton.AutoSize = true;
            this.codButton.Location = new System.Drawing.Point(19, 20);
            this.codButton.Name = "codButton";
            this.codButton.Size = new System.Drawing.Size(105, 17);
            this.codButton.TabIndex = 0;
            this.codButton.TabStop = true;
            this.codButton.Text = "Cash on Delivery";
            this.codButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Card Number";
            // 
            // ccBox
            // 
            this.ccBox.Location = new System.Drawing.Point(58, 254);
            this.ccBox.Name = "ccBox";
            this.ccBox.Size = new System.Drawing.Size(182, 20);
            this.ccBox.TabIndex = 20;
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(59, 310);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(45, 20);
            this.monthBox.TabIndex = 21;
            this.monthBox.Text = "MM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Expiration Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Billing Zip Code";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 363);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Security Code";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(279, 310);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 26;
            // 
            // homeb
            // 
            this.homeb.Location = new System.Drawing.Point(500, 44);
            this.homeb.Name = "homeb";
            this.homeb.Size = new System.Drawing.Size(75, 23);
            this.homeb.TabIndex = 27;
            this.homeb.Text = "Home";
            this.homeb.UseVisualStyleBackColor = true;
            this.homeb.Click += new System.EventHandler(this.homeb_Click);
            // 
            // cartb
            // 
            this.cartb.Location = new System.Drawing.Point(581, 44);
            this.cartb.Name = "cartb";
            this.cartb.Size = new System.Drawing.Size(75, 23);
            this.cartb.TabIndex = 28;
            this.cartb.Text = "Cart";
            this.cartb.UseVisualStyleBackColor = true;
            this.cartb.Click += new System.EventHandler(this.cartb_Click);
            // 
            // logoutb
            // 
            this.logoutb.Location = new System.Drawing.Point(662, 44);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(75, 23);
            this.logoutb.TabIndex = 29;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            this.logoutb.Click += new System.EventHandler(this.logoutb_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Location = new System.Drawing.Point(535, 309);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(190, 73);
            this.placeOrderButton.TabIndex = 30;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "/";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(128, 309);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(45, 20);
            this.yearBox.TabIndex = 32;
            this.yearBox.Text = "YY";
            // 
            // payPanel
            // 
            this.payPanel.Controls.Add(this.label6);
            this.payPanel.Controls.Add(this.totalBox);
            this.payPanel.Controls.Add(this.checkBox1);
            this.payPanel.Controls.Add(this.yearBox);
            this.payPanel.Controls.Add(this.label5);
            this.payPanel.Controls.Add(this.placeOrderButton);
            this.payPanel.Controls.Add(this.logoutb);
            this.payPanel.Controls.Add(this.cartb);
            this.payPanel.Controls.Add(this.homeb);
            this.payPanel.Controls.Add(this.textBox4);
            this.payPanel.Controls.Add(this.label4);
            this.payPanel.Controls.Add(this.textBox3);
            this.payPanel.Controls.Add(this.label3);
            this.payPanel.Controls.Add(this.label2);
            this.payPanel.Controls.Add(this.monthBox);
            this.payPanel.Controls.Add(this.ccBox);
            this.payPanel.Controls.Add(this.label1);
            this.payPanel.Controls.Add(this.groupBox1);
            this.payPanel.Location = new System.Drawing.Point(12, 12);
            this.payPanel.Name = "payPanel";
            this.payPanel.Size = new System.Drawing.Size(776, 426);
            this.payPanel.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(279, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Save payment info?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(535, 169);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(165, 20);
            this.totalBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payPanel);
            this.Name = "Payment";
            this.Text = "Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.payPanel.ResumeLayout(false);
            this.payPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkButton;
        private System.Windows.Forms.RadioButton ccButton;
        private System.Windows.Forms.RadioButton codButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ccBox;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button homeb;
        private System.Windows.Forms.Button cartb;
        private System.Windows.Forms.Button logoutb;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Panel payPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalBox;
    }
}