namespace OrderSystem
{
    partial class Work_MemberLogin
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
            this.txtB_Account = new System.Windows.Forms.TextBox();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_MemberLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB_Account
            // 
            this.txtB_Account.Location = new System.Drawing.Point(559, 350);
            this.txtB_Account.Name = "txtB_Account";
            this.txtB_Account.Size = new System.Drawing.Size(250, 39);
            this.txtB_Account.TabIndex = 0;
            // 
            // txtB_Password
            // 
            this.txtB_Password.Location = new System.Drawing.Point(559, 399);
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.Size = new System.Drawing.Size(250, 39);
            this.txtB_Password.TabIndex = 1;
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Location = new System.Drawing.Point(443, 354);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(110, 31);
            this.lbl_Account.TabIndex = 2;
            this.lbl_Account.Text = "會員帳號";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(443, 403);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(110, 31);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "會員密碼";
            // 
            // lbl_MemberLogin
            // 
            this.lbl_MemberLogin.AutoSize = true;
            this.lbl_MemberLogin.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberLogin.Location = new System.Drawing.Point(593, 18);
            this.lbl_MemberLogin.Name = "lbl_MemberLogin";
            this.lbl_MemberLogin.Size = new System.Drawing.Size(182, 50);
            this.lbl_MemberLogin.TabIndex = 4;
            this.lbl_MemberLogin.Text = "會員登入";
            // 
            // Work_MemberLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 789);
            this.Controls.Add(this.lbl_MemberLogin);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.txtB_Account);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Work_MemberLogin";
            this.Text = "MemberLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_Account;
        private System.Windows.Forms.TextBox txtB_Password;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_MemberLogin;
    }
}