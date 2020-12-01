namespace PizzaShop
{
    partial class Title
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
            this.logBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(323, 316);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(75, 23);
            this.logBtn.TabIndex = 1;
            this.logBtn.Text = "Log In";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(323, 267);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(310, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.registerBtn);
            this.titlePanel.Controls.Add(this.logBtn);
            this.titlePanel.Location = new System.Drawing.Point(23, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(744, 426);
            this.titlePanel.TabIndex = 4;
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titlePanel);
            this.Name = "Title";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Title_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel titlePanel;
    }
}

