namespace PizzaShop
{
    partial class CheckOut
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
            this.addressPanel = new System.Windows.Forms.Panel();
            this.DelcarGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.AptText = new System.Windows.Forms.TextBox();
            this.zipText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.streetText = new System.Windows.Forms.TextBox();
            this.logoutb = new System.Windows.Forms.Button();
            this.cartb = new System.Windows.Forms.Button();
            this.homeb = new System.Windows.Forms.Button();
            this.toPayment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addressPanel.SuspendLayout();
            this.DelcarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressPanel
            // 
            this.addressPanel.Controls.Add(this.DelcarGroupBox);
            this.addressPanel.Controls.Add(this.stateText);
            this.addressPanel.Controls.Add(this.AptText);
            this.addressPanel.Controls.Add(this.zipText);
            this.addressPanel.Controls.Add(this.cityText);
            this.addressPanel.Controls.Add(this.streetText);
            this.addressPanel.Controls.Add(this.logoutb);
            this.addressPanel.Controls.Add(this.cartb);
            this.addressPanel.Controls.Add(this.homeb);
            this.addressPanel.Controls.Add(this.toPayment);
            this.addressPanel.Controls.Add(this.label5);
            this.addressPanel.Controls.Add(this.label4);
            this.addressPanel.Controls.Add(this.label3);
            this.addressPanel.Controls.Add(this.label2);
            this.addressPanel.Controls.Add(this.label1);
            this.addressPanel.Location = new System.Drawing.Point(12, 12);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(776, 426);
            this.addressPanel.TabIndex = 21;
            // 
            // DelcarGroupBox
            // 
            this.DelcarGroupBox.Controls.Add(this.radioButton1);
            this.DelcarGroupBox.Controls.Add(this.radioButton2);
            this.DelcarGroupBox.Controls.Add(this.label6);
            this.DelcarGroupBox.Location = new System.Drawing.Point(52, 38);
            this.DelcarGroupBox.Name = "DelcarGroupBox";
            this.DelcarGroupBox.Size = new System.Drawing.Size(238, 58);
            this.DelcarGroupBox.TabIndex = 35;
            this.DelcarGroupBox.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Carryout";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(130, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Delivery";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "or";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(253, 294);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(115, 20);
            this.stateText.TabIndex = 34;
            // 
            // AptText
            // 
            this.AptText.Location = new System.Drawing.Point(133, 198);
            this.AptText.Name = "AptText";
            this.AptText.Size = new System.Drawing.Size(180, 20);
            this.AptText.TabIndex = 33;
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(133, 242);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(100, 20);
            this.zipText.TabIndex = 32;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(62, 294);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(122, 20);
            this.cityText.TabIndex = 31;
            // 
            // streetText
            // 
            this.streetText.Location = new System.Drawing.Point(133, 159);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(180, 20);
            this.streetText.TabIndex = 30;
            // 
            // logoutb
            // 
            this.logoutb.Location = new System.Drawing.Point(670, 73);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(75, 23);
            this.logoutb.TabIndex = 29;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            this.logoutb.Click += new System.EventHandler(this.logoutb_Click);
            // 
            // cartb
            // 
            this.cartb.Location = new System.Drawing.Point(589, 73);
            this.cartb.Name = "cartb";
            this.cartb.Size = new System.Drawing.Size(75, 23);
            this.cartb.TabIndex = 28;
            this.cartb.Text = "Cart";
            this.cartb.UseVisualStyleBackColor = true;
            this.cartb.Click += new System.EventHandler(this.cartb_Click);
            // 
            // homeb
            // 
            this.homeb.Location = new System.Drawing.Point(508, 73);
            this.homeb.Name = "homeb";
            this.homeb.Size = new System.Drawing.Size(75, 23);
            this.homeb.TabIndex = 27;
            this.homeb.Text = "Home";
            this.homeb.UseVisualStyleBackColor = true;
            this.homeb.Click += new System.EventHandler(this.homeb_Click);
            // 
            // toPayment
            // 
            this.toPayment.Location = new System.Drawing.Point(589, 366);
            this.toPayment.Name = "toPayment";
            this.toPayment.Size = new System.Drawing.Size(98, 23);
            this.toPayment.TabIndex = 26;
            this.toPayment.Text = "Go to Payment";
            this.toPayment.UseVisualStyleBackColor = true;
            this.toPayment.Click += new System.EventHandler(this.toPayment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Zip Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Suite/Apt#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Street Address";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addressPanel);
            this.Name = "CheckOut";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.DelcarGroupBox.ResumeLayout(false);
            this.DelcarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.GroupBox DelcarGroupBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.TextBox AptText;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox streetText;
        private System.Windows.Forms.Button logoutb;
        private System.Windows.Forms.Button cartb;
        private System.Windows.Forms.Button homeb;
        private System.Windows.Forms.Button toPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}