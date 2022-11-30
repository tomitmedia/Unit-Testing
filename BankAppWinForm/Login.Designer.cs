namespace BankAppWinForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginPageAlert = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.PictureBox();
            this.showPassword2 = new System.Windows.Forms.PictureBox();
            this.successAlertPanel = new System.Windows.Forms.Panel();
            this.successAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword2)).BeginInit();
            this.successAlertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(90, 443);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Don\'t have an Account?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.loginBtn.Location = new System.Drawing.Point(30, 336);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(258, 45);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_Leaves);
            this.loginBtn.MouseHover += new System.EventHandler(this.loginBtn_Hover);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.ForeColor = System.Drawing.Color.Purple;
            this.textBox2.Location = new System.Drawing.Point(30, 283);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Purple;
            this.textBox1.Location = new System.Drawing.Point(30, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(27, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(107, 383);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Forgot password?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.RegisterBtn.Location = new System.Drawing.Point(30, 461);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(258, 45);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.button2_Click);
            this.RegisterBtn.MouseLeave += new System.EventHandler(this.RegisterBtn_Leaves);
            this.RegisterBtn.MouseHover += new System.EventHandler(this.RegisterBtn_Hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(72, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "banking the future with ease...";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // loginPageAlert
            // 
            this.loginPageAlert.AutoSize = true;
            this.loginPageAlert.BackColor = System.Drawing.Color.White;
            this.loginPageAlert.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPageAlert.ForeColor = System.Drawing.Color.Red;
            this.loginPageAlert.Location = new System.Drawing.Point(72, 159);
            this.loginPageAlert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginPageAlert.Name = "loginPageAlert";
            this.loginPageAlert.Size = new System.Drawing.Size(11, 13);
            this.loginPageAlert.TabIndex = 30;
            this.loginPageAlert.Text = " ";
            this.loginPageAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginPageAlert.Click += new System.EventHandler(this.loginPageAlert_Click);
            // 
            // showPassword
            // 
            this.showPassword.BackColor = System.Drawing.Color.White;
            this.showPassword.Image = ((System.Drawing.Image)(resources.GetObject("showPassword.Image")));
            this.showPassword.Location = new System.Drawing.Point(257, 285);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(23, 19);
            this.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPassword.TabIndex = 31;
            this.showPassword.TabStop = false;
            // 
            // showPassword2
            // 
            this.showPassword2.BackColor = System.Drawing.Color.White;
            this.showPassword2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword2.Image = ((System.Drawing.Image)(resources.GetObject("showPassword2.Image")));
            this.showPassword2.Location = new System.Drawing.Point(247, 284);
            this.showPassword2.Name = "showPassword2";
            this.showPassword2.Size = new System.Drawing.Size(41, 21);
            this.showPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPassword2.TabIndex = 32;
            this.showPassword2.TabStop = false;
            this.showPassword2.Click += new System.EventHandler(this.showPassword2_Click);
            this.showPassword2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassword2_MouseDown);
            this.showPassword2.MouseEnter += new System.EventHandler(this.showPassword2_MouseEnter);
            this.showPassword2.MouseLeave += new System.EventHandler(this.hidePassword2_Leaves);
            this.showPassword2.MouseHover += new System.EventHandler(this.showPassword2_Hover);
            // 
            // successAlertPanel
            // 
            this.successAlertPanel.BackColor = System.Drawing.Color.White;
            this.successAlertPanel.Controls.Add(this.successAlert);
            this.successAlertPanel.Location = new System.Drawing.Point(-4, 131);
            this.successAlertPanel.Name = "successAlertPanel";
            this.successAlertPanel.Size = new System.Drawing.Size(314, 61);
            this.successAlertPanel.TabIndex = 33;
            // 
            // successAlert
            // 
            this.successAlert.AutoSize = true;
            this.successAlert.BackColor = System.Drawing.Color.White;
            this.successAlert.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.successAlert.ForeColor = System.Drawing.Color.Green;
            this.successAlert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.successAlert.Location = new System.Drawing.Point(33, 22);
            this.successAlert.Name = "successAlert";
            this.successAlert.Size = new System.Drawing.Size(238, 23);
            this.successAlert.TabIndex = 39;
            this.successAlert.Text = "Successfully registered!";
            this.successAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(307, 550);
            this.ControlBox = false;
            this.Controls.Add(this.successAlertPanel);
            this.Controls.Add(this.showPassword2);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.loginPageAlert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword2)).EndInit();
            this.successAlertPanel.ResumeLayout(false);
            this.successAlertPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button loginBtn;
        private Label label2;
        private Label label4;
        private Label label6;
        private Button RegisterBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label loginPageAlert;
        private PictureBox showPassword;
        private PictureBox showPassword2;
        private Panel successAlertPanel;
        private Label successAlert;
    }
}