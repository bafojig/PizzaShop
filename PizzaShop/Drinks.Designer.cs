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
            this.DrinkSizeOption = new System.Windows.Forms.GroupBox();
            this.LargeSizeOption = new System.Windows.Forms.RadioButton();
            this.MediumSizeOption = new System.Windows.Forms.RadioButton();
            this.SmallSizeOption = new System.Windows.Forms.RadioButton();
            this.backbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addCart = new System.Windows.Forms.Button();
            this.drinkBox = new System.Windows.Forms.CheckedListBox();
            this.drinksPanel.SuspendLayout();
            this.DrinkSizeOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // drinksPanel
            // 
            this.drinksPanel.Controls.Add(this.DrinkSizeOption);
            this.drinksPanel.Controls.Add(this.backbutton);
            this.drinksPanel.Controls.Add(this.label2);
            this.drinksPanel.Controls.Add(this.addCart);
            this.drinksPanel.Controls.Add(this.drinkBox);
            this.drinksPanel.Location = new System.Drawing.Point(30, 23);
            this.drinksPanel.Name = "drinksPanel";
            this.drinksPanel.Size = new System.Drawing.Size(726, 398);
            this.drinksPanel.TabIndex = 10;
            // 
            // DrinkSizeOption
            // 
            this.DrinkSizeOption.Controls.Add(this.LargeSizeOption);
            this.DrinkSizeOption.Controls.Add(this.MediumSizeOption);
            this.DrinkSizeOption.Controls.Add(this.SmallSizeOption);
            this.DrinkSizeOption.Location = new System.Drawing.Point(405, 249);
            this.DrinkSizeOption.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DrinkSizeOption.Name = "DrinkSizeOption";
            this.DrinkSizeOption.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DrinkSizeOption.Size = new System.Drawing.Size(39, 31);
            this.DrinkSizeOption.TabIndex = 15;
            this.DrinkSizeOption.TabStop = false;
            this.DrinkSizeOption.Text = "groupBox1";
            this.DrinkSizeOption.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LargeSizeOption
            // 
            this.LargeSizeOption.AutoSize = true;
            this.LargeSizeOption.Location = new System.Drawing.Point(2, 23);
            this.LargeSizeOption.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LargeSizeOption.Name = "LargeSizeOption";
            this.LargeSizeOption.Size = new System.Drawing.Size(88, 17);
            this.LargeSizeOption.TabIndex = 16;
            this.LargeSizeOption.TabStop = true;
            this.LargeSizeOption.Text = "Large - $2.50";
            this.LargeSizeOption.UseVisualStyleBackColor = true;
            // 
            // MediumSizeOption
            // 
            this.MediumSizeOption.AutoSize = true;
            this.MediumSizeOption.Location = new System.Drawing.Point(2, 15);
            this.MediumSizeOption.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MediumSizeOption.Name = "MediumSizeOption";
            this.MediumSizeOption.Size = new System.Drawing.Size(98, 17);
            this.MediumSizeOption.TabIndex = 15;
            this.MediumSizeOption.TabStop = true;
            this.MediumSizeOption.Text = "Medium - $2.00";
            this.MediumSizeOption.UseVisualStyleBackColor = true;
            // 
            // SmallSizeOption
            // 
            this.SmallSizeOption.Location = new System.Drawing.Point(0, 0);
            this.SmallSizeOption.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SmallSizeOption.Name = "SmallSizeOption";
            this.SmallSizeOption.Size = new System.Drawing.Size(33, 8);
            this.SmallSizeOption.TabIndex = 17;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(401, 252);
            this.backbutton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(24, 8);
            this.backbutton.TabIndex = 13;
            this.backbutton.Text = "Go Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Drinks";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(492, 252);
            this.addCart.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(24, 8);
            this.addCart.TabIndex = 11;
            this.addCart.Text = "Add to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // drinkBox
            // 
            this.drinkBox.FormattingEnabled = true;
            this.drinkBox.Location = new System.Drawing.Point(294, 126);
            this.drinkBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(46, 109);
            this.drinkBox.TabIndex = 10;
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.drinksPanel);
            this.Name = "Address";
            this.Text = "Drinks";
            this.drinksPanel.ResumeLayout(false);
            this.drinksPanel.PerformLayout();
            this.DrinkSizeOption.ResumeLayout(false);
            this.DrinkSizeOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drinksPanel;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.CheckedListBox drinkBox;
        private System.Windows.Forms.RadioButton SmallSizeOption;
        private System.Windows.Forms.GroupBox DrinkSizeOption;
        private System.Windows.Forms.RadioButton LargeSizeOption;
        private System.Windows.Forms.RadioButton MediumSizeOption;
    }
}