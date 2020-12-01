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
            this.drinksPanel.Location = new System.Drawing.Point(30, 23);
            this.drinksPanel.Name = "drinksPanel";
            this.drinksPanel.Size = new System.Drawing.Size(726, 398);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Drinks";
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(470, 198);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(75, 23);
            this.addCart.TabIndex = 11;
            this.addCart.Text = "Add to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            // 
            // drinkBox
            // 
            this.drinkBox.FormattingEnabled = true;
            this.drinkBox.Location = new System.Drawing.Point(296, 42);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(138, 334);
            this.drinkBox.TabIndex = 10;
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