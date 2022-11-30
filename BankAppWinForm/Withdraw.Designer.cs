namespace BankAppWinForm
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.withdrawalAlertPanel = new System.Windows.Forms.Panel();
            this.withdrawalAlert = new System.Windows.Forms.Label();
            this.failedAlert = new System.Windows.Forms.PictureBox();
            this.DoneAlert = new System.Windows.Forms.PictureBox();
            this.selectAcctDrop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.withdrawalAlertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.failedAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.ForeColor = System.Drawing.Color.Purple;
            this.textBox2.Location = new System.Drawing.Point(27, 250);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "How Much";
            this.textBox2.Size = new System.Drawing.Size(258, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Purple;
            this.textBox1.Location = new System.Drawing.Point(27, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Your Account Number to Debit";
            this.textBox1.Size = new System.Drawing.Size(258, 23);
            this.textBox1.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.button3.Location = new System.Drawing.Point(28, 392);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.loginBtn.Location = new System.Drawing.Point(165, 392);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(122, 45);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Continue";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(27, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Account";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(59, 76);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.button5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(29, 63);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(258, 49);
            this.button5.TabIndex = 46;
            this.button5.Text = "Withdraw Money";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // withdrawalAlertPanel
            // 
            this.withdrawalAlertPanel.BackColor = System.Drawing.Color.White;
            this.withdrawalAlertPanel.Controls.Add(this.withdrawalAlert);
            this.withdrawalAlertPanel.Location = new System.Drawing.Point(28, 63);
            this.withdrawalAlertPanel.Name = "withdrawalAlertPanel";
            this.withdrawalAlertPanel.Size = new System.Drawing.Size(258, 49);
            this.withdrawalAlertPanel.TabIndex = 48;
            // 
            // withdrawalAlert
            // 
            this.withdrawalAlert.AutoSize = true;
            this.withdrawalAlert.BackColor = System.Drawing.Color.White;
            this.withdrawalAlert.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawalAlert.ForeColor = System.Drawing.Color.Red;
            this.withdrawalAlert.Location = new System.Drawing.Point(22, 18);
            this.withdrawalAlert.Name = "withdrawalAlert";
            this.withdrawalAlert.Size = new System.Drawing.Size(59, 13);
            this.withdrawalAlert.TabIndex = 39;
            this.withdrawalAlert.Text = "fundAlert";
            this.withdrawalAlert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // failedAlert
            // 
            this.failedAlert.BackColor = System.Drawing.Color.Transparent;
            this.failedAlert.Image = ((System.Drawing.Image)(resources.GetObject("failedAlert.Image")));
            this.failedAlert.Location = new System.Drawing.Point(128, 326);
            this.failedAlert.Name = "failedAlert";
            this.failedAlert.Size = new System.Drawing.Size(57, 32);
            this.failedAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.failedAlert.TabIndex = 49;
            this.failedAlert.TabStop = false;
            // 
            // DoneAlert
            // 
            this.DoneAlert.BackColor = System.Drawing.Color.Transparent;
            this.DoneAlert.Image = ((System.Drawing.Image)(resources.GetObject("DoneAlert.Image")));
            this.DoneAlert.Location = new System.Drawing.Point(128, 326);
            this.DoneAlert.Name = "DoneAlert";
            this.DoneAlert.Size = new System.Drawing.Size(57, 32);
            this.DoneAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DoneAlert.TabIndex = 50;
            this.DoneAlert.TabStop = false;
            // 
            // selectAcctDrop
            // 
            this.selectAcctDrop.FormattingEnabled = true;
            this.selectAcctDrop.Location = new System.Drawing.Point(27, 193);
            this.selectAcctDrop.Name = "selectAcctDrop";
            this.selectAcctDrop.Size = new System.Drawing.Size(260, 23);
            this.selectAcctDrop.TabIndex = 1;
            this.selectAcctDrop.Text = "Select Account";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(317, 537);
            this.ControlBox = false;
            this.Controls.Add(this.selectAcctDrop);
            this.Controls.Add(this.DoneAlert);
            this.Controls.Add(this.failedAlert);
            this.Controls.Add(this.withdrawalAlertPanel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.withdrawalAlertPanel.ResumeLayout(false);
            this.withdrawalAlertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.failedAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button loginBtn;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox5;
        private Button button5;
        private Panel withdrawalAlertPanel;
        private Label withdrawalAlert;
        private PictureBox failedAlert;
        private PictureBox DoneAlert;
        private ComboBox selectAcctDrop;
    }
}