namespace PizzaShop
{
    partial class EditAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.rbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.homeb = new System.Windows.Forms.Button();
            this.cartb = new System.Windows.Forms.Button();
            this.logoutb = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Enter Old Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(354, 178);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(146, 20);
            this.password.TabIndex = 26;
            // 
            // rbutton
            // 
            this.rbutton.Location = new System.Drawing.Point(386, 285);
            this.rbutton.Name = "rbutton";
            this.rbutton.Size = new System.Drawing.Size(75, 23);
            this.rbutton.TabIndex = 27;
            this.rbutton.Text = "Login";
            this.rbutton.UseVisualStyleBackColor = true;
            this.rbutton.Click += new System.EventHandler(this.rbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Enter New Password";
            // 
            // confirmbox
            // 
            this.confirmbox.Location = new System.Drawing.Point(354, 214);
            this.confirmbox.Name = "confirmbox";
            this.confirmbox.Size = new System.Drawing.Size(146, 20);
            this.confirmbox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Confirm New Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 31;
            // 
            // homeb
            // 
            this.homeb.Location = new System.Drawing.Point(503, 35);
            this.homeb.Name = "homeb";
            this.homeb.Size = new System.Drawing.Size(75, 23);
            this.homeb.TabIndex = 32;
            this.homeb.Text = "Home";
            this.homeb.UseVisualStyleBackColor = true;
            this.homeb.Click += new System.EventHandler(this.homeb_Click);
            // 
            // cartb
            // 
            this.cartb.Location = new System.Drawing.Point(584, 35);
            this.cartb.Name = "cartb";
            this.cartb.Size = new System.Drawing.Size(75, 23);
            this.cartb.TabIndex = 33;
            this.cartb.Text = "Cart";
            this.cartb.UseVisualStyleBackColor = true;
            this.cartb.Click += new System.EventHandler(this.cartb_Click);
            // 
            // logoutb
            // 
            this.logoutb.Location = new System.Drawing.Point(665, 35);
            this.logoutb.Name = "logoutb";
            this.logoutb.Size = new System.Drawing.Size(75, 23);
            this.logoutb.TabIndex = 34;
            this.logoutb.Text = "Logout";
            this.logoutb.UseVisualStyleBackColor = true;
            this.logoutb.Click += new System.EventHandler(this.logoutb_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.logoutb);
            this.editPanel.Controls.Add(this.cartb);
            this.editPanel.Controls.Add(this.homeb);
            this.editPanel.Controls.Add(this.textBox1);
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.confirmbox);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.rbutton);
            this.editPanel.Controls.Add(this.password);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Location = new System.Drawing.Point(12, 12);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(776, 426);
            this.editPanel.TabIndex = 25;
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editPanel);
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button rbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button homeb;
        private System.Windows.Forms.Button cartb;
        private System.Windows.Forms.Button logoutb;
        private System.Windows.Forms.Panel editPanel;
    }
}