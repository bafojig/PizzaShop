namespace PizzaShop
{
    partial class Address
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
            this.drinksPanel = new System.Windows.Forms.Panel();
            this.backbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addCart = new System.Windows.Forms.Button();
            this.drinkBox = new System.Windows.Forms.CheckedListBox();
            this.drinksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drinksPanel
            // 
            this.drinksPanel.Controls.Add(this.backbutton);
            this.drinksPanel.Controls.Add(this.label2);
            this.drinksPanel.Controls.Add(this.addCart);
            this.drinksPanel.Controls.Add(this.drinkBox);
            this.drinksPanel.Location = new System.Drawing.Point(95, 65);
            this.drinksPanel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.drinksPanel.Name = "drinksPanel";
            this.drinksPanel.Size = new System.Drawing.Size(2299, 1133);
            this.drinksPanel.TabIndex = 10;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(573, 564);
            this.backbutton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(238, 65);
            this.backbutton.TabIndex = 13;
            this.backbutton.Text = "Go Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1077, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Drinks";
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(1488, 564);
            this.addCart.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(238, 65);
            this.addCart.TabIndex = 11;
            this.addCart.Text = "Add to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // drinkBox
            // 
            this.drinkBox.FormattingEnabled = true;
            this.drinkBox.Location = new System.Drawing.Point(937, 120);
            this.drinkBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(428, 940);
            this.drinkBox.TabIndex = 10;
            this.drinkBox.SelectedIndexChanged += new System.EventHandler(this.drinkBox_SelectedIndexChanged);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.drinksPanel);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Address";
            this.Text = "Drinks";
            this.drinksPanel.ResumeLayout(false);
            this.drinksPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drinksPanel;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.CheckedListBox drinkBox;
    }
}