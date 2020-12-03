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
            this.SmallSizeOption = new System.Windows.Forms.RadioButton();
            this.DrinkSizeOption = new System.Windows.Forms.GroupBox();
            this.MediumSizeOption = new System.Windows.Forms.RadioButton();
            this.LargeSizeOption = new System.Windows.Forms.RadioButton();
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
            this.drinksPanel.Location = new System.Drawing.Point(95, 65);
            this.drinksPanel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.drinksPanel.Name = "drinksPanel";
            this.drinksPanel.Size = new System.Drawing.Size(2299, 1133);
            this.drinksPanel.TabIndex = 10;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(181, 198);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 13;
            this.backbutton.Text = "Go Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Drinks";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(470, 198);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(75, 23);
            this.addCart.TabIndex = 11;
            this.addCart.Text = "Add to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // drinkBox
            // 
            this.drinkBox.FormattingEnabled = true;
            this.drinkBox.Location = new System.Drawing.Point(296, 42);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(138, 334);
            this.drinkBox.TabIndex = 10;
            // 
            this.DrinkSizeOption.Controls.Add(this.LargeSizeOption);
            this.DrinkSizeOption.Controls.Add(this.MediumSizeOption);
            this.DrinkSizeOption.Controls.Add(this.SmallSizeOption);
            this.DrinkSizeOption.Location = new System.Drawing.Point(193, 190);
            this.DrinkSizeOption.Name = "DrinkSizeOption";
            this.DrinkSizeOption.Size = new System.Drawing.Size(123, 89);
            this.DrinkSizeOption.TabIndex = 15;
            this.DrinkSizeOption.TabStop = false;
            this.DrinkSizeOption.Text = "groupBox1";
            this.DrinkSizeOption.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MediumSizeOption
            // 
            this.MediumSizeOption.AutoSize = true;
            this.MediumSizeOption.Location = new System.Drawing.Point(6, 42);
            this.MediumSizeOption.Name = "MediumSizeOption";
            this.MediumSizeOption.Size = new System.Drawing.Size(98, 17);
            this.MediumSizeOption.TabIndex = 15;
            this.MediumSizeOption.TabStop = true;
            this.MediumSizeOption.Text = "Medium - $2.00";
            this.MediumSizeOption.UseVisualStyleBackColor = true;
            // 
            // LargeSizeOption
            // 
            this.LargeSizeOption.AutoSize = true;
            this.LargeSizeOption.Location = new System.Drawing.Point(6, 65);
            this.LargeSizeOption.Name = "LargeSizeOption";
            this.LargeSizeOption.Size = new System.Drawing.Size(88, 17);
            this.LargeSizeOption.TabIndex = 16;
            this.LargeSizeOption.TabStop = true;
            this.LargeSizeOption.Text = "Large - $2.50";
            this.LargeSizeOption.UseVisualStyleBackColor = true;
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