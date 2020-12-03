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
            this.drinkBox = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SizeOptionGroup = new System.Windows.Forms.GroupBox();
            this.LargeSizeOption = new System.Windows.Forms.RadioButton();
            this.MediumSizeOption = new System.Windows.Forms.RadioButton();
            this.SmallSizeOption = new System.Windows.Forms.RadioButton();
            this.backbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addCart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drinksPanel.SuspendLayout();
            this.drinkBox.SuspendLayout();
            this.SizeOptionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drinksPanel
            // 
            this.drinksPanel.Controls.Add(this.pictureBox1);
            this.drinksPanel.Controls.Add(this.drinkBox);
            this.drinksPanel.Controls.Add(this.SizeOptionGroup);
            this.drinksPanel.Controls.Add(this.backbutton);
            this.drinksPanel.Controls.Add(this.label2);
            this.drinksPanel.Controls.Add(this.addCart);
            this.drinksPanel.Location = new System.Drawing.Point(30, 23);
            this.drinksPanel.Name = "drinksPanel";
            this.drinksPanel.Size = new System.Drawing.Size(726, 398);
            this.drinksPanel.TabIndex = 10;
            // 
            // drinkBox
            // 
            this.drinkBox.Controls.Add(this.radioButton5);
            this.drinkBox.Controls.Add(this.radioButton4);
            this.drinkBox.Controls.Add(this.radioButton3);
            this.drinkBox.Controls.Add(this.radioButton2);
            this.drinkBox.Controls.Add(this.radioButton1);
            this.drinkBox.Location = new System.Drawing.Point(18, 131);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(158, 144);
            this.drinkBox.TabIndex = 16;
            this.drinkBox.TabStop = false;
            this.drinkBox.Enter += new System.EventHandler(this.drinkBox_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 117);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(98, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Diet Dr. Pepper";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 94);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Dr. Pepper";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Sprite";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Diet Coke";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Coca-Cola";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // LargeSizeOption
            // 
            this.LargeSizeOption.AutoSize = true;
            this.LargeSizeOption.Location = new System.Drawing.Point(6, 65);
            this.LargeSizeOption.Name = "LargeSizeOption";
            this.LargeSizeOption.Size = new System.Drawing.Size(88, 17);
            this.LargeSizeOption.TabIndex = 16;
            this.LargeSizeOption.Text = "Large - $2.50";
            this.LargeSizeOption.UseVisualStyleBackColor = true;
            // 
            // MediumSizeOption
            // 
            this.MediumSizeOption.AutoSize = true;
            this.MediumSizeOption.Checked = true;
            this.MediumSizeOption.Location = new System.Drawing.Point(6, 42);
            this.MediumSizeOption.Name = "MediumSizeOption";
            this.MediumSizeOption.Size = new System.Drawing.Size(98, 17);
            this.MediumSizeOption.TabIndex = 15;
            this.MediumSizeOption.TabStop = true;
            this.MediumSizeOption.Text = "Medium - $2.00";
            this.MediumSizeOption.UseVisualStyleBackColor = true;
            // 
            // SmallSizeOption
            // 
            this.SmallSizeOption.AutoSize = true;
            this.SmallSizeOption.Location = new System.Drawing.Point(6, 19);
            this.SmallSizeOption.Name = "SmallSizeOption";
            this.SmallSizeOption.Size = new System.Drawing.Size(86, 17);
            this.SmallSizeOption.TabIndex = 14;
            this.SmallSizeOption.Text = "Small - $1.75";
            this.SmallSizeOption.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(85, 115);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(226, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drinksPanel);
            this.Name = "Drinks";
            this.Text = "Drinks";
            this.drinksPanel.ResumeLayout(false);
            this.drinksPanel.PerformLayout();
            this.drinkBox.ResumeLayout(false);
            this.drinkBox.PerformLayout();
            this.SizeOptionGroup.ResumeLayout(false);
            this.SizeOptionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drinksPanel;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.GroupBox SizeOptionGroup;
        private System.Windows.Forms.RadioButton LargeSizeOption;
        private System.Windows.Forms.RadioButton MediumSizeOption;
        private System.Windows.Forms.RadioButton SmallSizeOption;
        private System.Windows.Forms.GroupBox drinkBox;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}