namespace PizzaShop
{
    partial class Home
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
            this.pizzab = new System.Windows.Forms.Button();
            this.drinkb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cartb = new System.Windows.Forms.Button();
            this.logoutb = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.editb = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.homePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzab
            // 
            this.pizzab.Location = new System.Drawing.Point(163, 158);
            this.pizzab.Name = "pizzab";
            this.pizzab.Size = new System.Drawing.Size(75, 23);
            this.pizzab.TabIndex = 9;
            this.pizzab.Text = "Order Pizza";
            this.pizzab.UseVisualStyleBackColor = true;
            // 
            // drinkb
            // 
            this.drinkb.Location = new System.Drawing.Point(522, 158);
            this.drinkb.Name = "drinkb";
            this.drinkb.Size = new System.Drawing.Size(75, 23);
            this.drinkb.TabIndex = 10;
            this.drinkb.Text = "Order Drinks";
            this.drinkb.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(150, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(511, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // cartb
            // 
            this.cartb.Location = new System.Drawing.Point(536, 32);
            this.cartb.Name = "cartb";
            this.cartb.Size = new System.Drawing.Size(75, 23);
            this.cartb.TabIndex = 13;
            this.cartb.Text = "Cart";
            this.cartb.UseVisualStyleBackColor = true;
            // 
            // logoutb
            // 
            this.logoutb.Location = new System.Drawing.Point(617, 32);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(75, 23);
            this.logoutb.TabIndex = 14;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(46, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // editb
            // 
            this.editb.Location = new System.Drawing.Point(617, 371);
            this.editb.Name = "editb";
            this.editb.Size = new System.Drawing.Size(87, 23);
            this.editb.TabIndex = 16;
            this.editb.Text = "Edit Account";
            this.editb.UseVisualStyleBackColor = true;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.editb);
            this.homePanel.Controls.Add(this.pictureBox3);
            this.homePanel.Controls.Add(this.logoutb);
            this.homePanel.Controls.Add(this.cartb);
            this.homePanel.Controls.Add(this.pictureBox2);
            this.homePanel.Controls.Add(this.pictureBox1);
            this.homePanel.Controls.Add(this.drinkb);
            this.homePanel.Controls.Add(this.pizzab);
            this.homePanel.Location = new System.Drawing.Point(23, 12);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(750, 426);
            this.homePanel.TabIndex = 9;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homePanel);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pizzab;
        private System.Windows.Forms.Button drinkb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cartb;
        private System.Windows.Forms.Button logoutb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button editb;
        private System.Windows.Forms.Panel homePanel;
    }
}