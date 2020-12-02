namespace PizzaShop
{
    partial class Toppings
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
            this.toppingsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.addCart = new System.Windows.Forms.Button();
            this.vegBox = new System.Windows.Forms.CheckedListBox();
            this.meatBox = new System.Windows.Forms.CheckedListBox();
            this.toppingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppingsPanel
            // 
            this.toppingsPanel.Controls.Add(this.label2);
            this.toppingsPanel.Controls.Add(this.label1);
            this.toppingsPanel.Controls.Add(this.backbutton);
            this.toppingsPanel.Controls.Add(this.addCart);
            this.toppingsPanel.Controls.Add(this.vegBox);
            this.toppingsPanel.Controls.Add(this.meatBox);
            this.toppingsPanel.Location = new System.Drawing.Point(38, 34);
            this.toppingsPanel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.toppingsPanel.Name = "toppingsPanel";
            this.toppingsPanel.Size = new System.Drawing.Size(2457, 1212);
            this.toppingsPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1593, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Veggies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Meats";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(187, 603);
            this.backbutton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(238, 65);
            this.backbutton.TabIndex = 9;
            this.backbutton.Text = "Go Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(2036, 603);
            this.addCart.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(238, 65);
            this.addCart.TabIndex = 8;
            this.addCart.Text = "Add to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // vegBox
            // 
            this.vegBox.FormattingEnabled = true;
            this.vegBox.Location = new System.Drawing.Point(1454, 159);
            this.vegBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.vegBox.Name = "vegBox";
            this.vegBox.Size = new System.Drawing.Size(428, 940);
            this.vegBox.TabIndex = 7;
            // 
            // meatBox
            // 
            this.meatBox.FormattingEnabled = true;
            this.meatBox.Location = new System.Drawing.Point(608, 159);
            this.meatBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.meatBox.Name = "meatBox";
            this.meatBox.Size = new System.Drawing.Size(428, 940);
            this.meatBox.TabIndex = 6;
            this.meatBox.SelectedIndexChanged += new System.EventHandler(this.meatBox_SelectedIndexChanged);
            // 
            // Toppings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.toppingsPanel);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Toppings";
            this.Text = "Pizza";
            this.toppingsPanel.ResumeLayout(false);
            this.toppingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppingsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.CheckedListBox vegBox;
        private System.Windows.Forms.CheckedListBox meatBox;
    }
}