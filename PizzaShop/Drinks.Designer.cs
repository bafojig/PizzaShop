namespace PizzaShop
{
    partial class Drinks
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
            this.SizeOptionGroup = new System.Windows.Forms.GroupBox();
            this.MediumSizeOption = new System.Windows.Forms.RadioButton();
            this.LargeSizeOption = new System.Windows.Forms.RadioButton();
            this.drinksPanel.SuspendLayout();
            this.SizeOptionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // drinksPanel
            // 
            this.drinksPanel.Controls.Add(this.SizeOptionGroup);
            this.drinksPanel.Controls.Add(this.backbutton);
            this.drinksPanel.Controls.Add(this.label2);
            this.drinksPanel.Controls.Add(this.addCart);
            this.drinksPanel.Controls.Add(this.drinkBox);
            this.drinksPanel.Location = new System.Drawing.Point(30, 23);
            this.drinksPanel.Name = "drinksPanel";
            this.drinksPanel.Size = new System.Drawing.Size(726, 398);
            this.drinksPanel.TabIndex = 10;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(3, 3);
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
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Drinks";
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(586, 345);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(137, 50);
            this.addCart.TabIndex = 11;
            this.addCart.Text = "Add to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // drinkBox
            // 
            this.drinkBox.FormattingEnabled = true;
            this.drinkBox.Location = new System.Drawing.Point(3, 151);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(396, 244);
            this.drinkBox.TabIndex = 10;
            this.drinkBox.SelectedIndexChanged += new System.EventHandler(this.drinkBox_SelectedIndexChanged);
            // 
            // SmallSizeOption
            // 
            this.SmallSizeOption.AutoSize = true;
            this.SmallSizeOption.Location = new System.Drawing.Point(6, 19);
            this.SmallSizeOption.Name = "SmallSizeOption";
            this.SmallSizeOption.Size = new System.Drawing.Size(86, 17);
            this.SmallSizeOption.TabIndex = 14;
            this.SmallSizeOption.TabStop = true;
            this.SmallSizeOption.Text = "Small - $1.75";
            this.SmallSizeOption.UseVisualStyleBackColor = true;
            // 
            // SizeOptionGroup
            // 
            this.SizeOptionGroup.Controls.Add(this.LargeSizeOption);
            this.SizeOptionGroup.Controls.Add(this.MediumSizeOption);
            this.SizeOptionGroup.Controls.Add(this.SmallSizeOption);
            this.SizeOptionGroup.Location = new System.Drawing.Point(406, 193);
            this.SizeOptionGroup.Name = "SizeOptionGroup";
            this.SizeOptionGroup.Size = new System.Drawing.Size(200, 100);
            this.SizeOptionGroup.TabIndex = 15;
            this.SizeOptionGroup.TabStop = false;
            this.SizeOptionGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drinksPanel);
            this.Name = "Address";
            this.Text = "Drinks";
            this.drinksPanel.ResumeLayout(false);
            this.drinksPanel.PerformLayout();
            this.SizeOptionGroup.ResumeLayout(false);
            this.SizeOptionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drinksPanel;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.CheckedListBox drinkBox;
        private System.Windows.Forms.GroupBox SizeOptionGroup;
        private System.Windows.Forms.RadioButton LargeSizeOption;
        private System.Windows.Forms.RadioButton MediumSizeOption;
        private System.Windows.Forms.RadioButton SmallSizeOption;
    }
}