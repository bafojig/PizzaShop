namespace PizzaShop
{
    partial class Receipt
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.logoutb = new System.Windows.Forms.Button();
            this.cartb = new System.Windows.Forms.Button();
            this.homeb = new System.Windows.Forms.Button();
            this.receiptPanel = new System.Windows.Forms.Panel();
            this.dataSet1 = new System.Data.DataSet();
            this.receiptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(46, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(231, 276);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Empty Cart";
            // 
            // logoutb
            // 
            this.logoutb.Location = new System.Drawing.Point(628, 10);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(75, 23);
            this.logoutb.TabIndex = 17;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            // 
            // cartb
            // 
            this.cartb.Location = new System.Drawing.Point(547, 10);
            this.cartb.Name = "cartb";
            this.cartb.Size = new System.Drawing.Size(75, 23);
            this.cartb.TabIndex = 16;
            this.cartb.Text = "Cart";
            this.cartb.UseVisualStyleBackColor = true;
            // 
            // homeb
            // 
            this.homeb.Location = new System.Drawing.Point(466, 10);
            this.homeb.Name = "homeb";
            this.homeb.Size = new System.Drawing.Size(75, 23);
            this.homeb.TabIndex = 15;
            this.homeb.Text = "Home";
            this.homeb.UseVisualStyleBackColor = true;
            // 
            // receiptPanel
            // 
            this.receiptPanel.Controls.Add(this.richTextBox1);
            this.receiptPanel.Controls.Add(this.logoutb);
            this.receiptPanel.Controls.Add(this.homeb);
            this.receiptPanel.Controls.Add(this.cartb);
            this.receiptPanel.Location = new System.Drawing.Point(21, 12);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(751, 426);
            this.receiptPanel.TabIndex = 18;
            this.receiptPanel.Visible = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiptPanel);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.receiptPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button logoutb;
        private System.Windows.Forms.Button cartb;
        private System.Windows.Forms.Button homeb;
        private System.Windows.Forms.Panel receiptPanel;
        private System.Data.DataSet dataSet1;
    }
}