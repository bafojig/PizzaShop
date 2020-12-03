namespace PizzaShop
{
    partial class Cart
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
            this.cartPanel = new System.Windows.Forms.Panel();
            this.logoutb = new System.Windows.Forms.Button();
            this.homeb = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cob = new System.Windows.Forms.Button();
            this.moreb = new System.Windows.Forms.Button();
            this.cartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartPanel
            // 
            this.cartPanel.Controls.Add(this.logoutb);
            this.cartPanel.Controls.Add(this.homeb);
            this.cartPanel.Controls.Add(this.richTextBox1);
            this.cartPanel.Controls.Add(this.cob);
            this.cartPanel.Controls.Add(this.moreb);
            this.cartPanel.Location = new System.Drawing.Point(38, 34);
            this.cartPanel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(2457, 1212);
            this.cartPanel.TabIndex = 10;
            // 
            // logoutb
            // 
            this.logoutb.Location = new System.Drawing.Point(2027, 131);
            this.logoutb.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(238, 65);
            this.logoutb.TabIndex = 14;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            this.logoutb.Click += new System.EventHandler(this.logoutb_Click);
            // 
            // homeb
            // 
            this.homeb.Location = new System.Drawing.Point(1770, 131);
            this.homeb.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.homeb.Name = "homeb";
            this.homeb.Size = new System.Drawing.Size(238, 65);
            this.homeb.TabIndex = 13;
            this.homeb.Text = "Home";
            this.homeb.UseVisualStyleBackColor = true;
            this.homeb.Click += new System.EventHandler(this.homeb_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(193, 299);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(723, 778);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "Empty Cart";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // cob
            // 
            this.cob.Location = new System.Drawing.Point(1770, 731);
            this.cob.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cob.Name = "cob";
            this.cob.Size = new System.Drawing.Size(238, 65);
            this.cob.TabIndex = 11;
            this.cob.Text = "Checkout";
            this.cob.UseVisualStyleBackColor = true;
            this.cob.Click += new System.EventHandler(this.cob_Click);
            // 
            // moreb
            // 
            this.moreb.Location = new System.Drawing.Point(1770, 507);
            this.moreb.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.moreb.Name = "moreb";
            this.moreb.Size = new System.Drawing.Size(238, 65);
            this.moreb.TabIndex = 10;
            this.moreb.Text = "Order More";
            this.moreb.UseVisualStyleBackColor = true;
            this.moreb.Click += new System.EventHandler(this.moreb_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.cartPanel);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Cart";
            this.Text = "Pizza";
            this.cartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Button logoutb;
        private System.Windows.Forms.Button homeb;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button cob;
        private System.Windows.Forms.Button moreb;
    }
}