namespace OrderSystem
{
    partial class Menu_Login
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
            this.btn_MemberLogin = new System.Windows.Forms.Button();
            this.btn_ManagerLogin = new System.Windows.Forms.Button();
            this.btn_MemberJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MemberLogin
            // 
            this.btn_MemberLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MemberLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MemberLogin.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_MemberLogin.Location = new System.Drawing.Point(18, 96);
            this.btn_MemberLogin.Name = "btn_MemberLogin";
            this.btn_MemberLogin.Size = new System.Drawing.Size(180, 60);
            this.btn_MemberLogin.TabIndex = 2;
            this.btn_MemberLogin.Text = "會員登入";
            this.btn_MemberLogin.UseVisualStyleBackColor = false;
            this.btn_MemberLogin.Click += new System.EventHandler(this.btn_MemberLogin_Click);
            // 
            // btn_ManagerLogin
            // 
            this.btn_ManagerLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ManagerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ManagerLogin.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_ManagerLogin.Location = new System.Drawing.Point(18, 174);
            this.btn_ManagerLogin.Name = "btn_ManagerLogin";
            this.btn_ManagerLogin.Size = new System.Drawing.Size(180, 60);
            this.btn_ManagerLogin.TabIndex = 3;
            this.btn_ManagerLogin.Text = "管理員登入";
            this.btn_ManagerLogin.UseVisualStyleBackColor = false;
            this.btn_ManagerLogin.Click += new System.EventHandler(this.btn_ManagerLogin_Click);
            // 
            // btn_MemberJoin
            // 
            this.btn_MemberJoin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MemberJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MemberJoin.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_MemberJoin.Location = new System.Drawing.Point(18, 18);
            this.btn_MemberJoin.Name = "btn_MemberJoin";
            this.btn_MemberJoin.Size = new System.Drawing.Size(180, 60);
            this.btn_MemberJoin.TabIndex = 1;
            this.btn_MemberJoin.Text = "註冊會員";
            this.btn_MemberJoin.UseVisualStyleBackColor = false;
            this.btn_MemberJoin.Click += new System.EventHandler(this.btn_MemberJoin_Click);
            // 
            // Menu_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(216, 789);
            this.Controls.Add(this.btn_MemberJoin);
            this.Controls.Add(this.btn_MemberLogin);
            this.Controls.Add(this.btn_ManagerLogin);
            this.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Menu_LoginForm";
            this.Text = "LoginMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MemberLogin;
        private System.Windows.Forms.Button btn_ManagerLogin;
        private System.Windows.Forms.Button btn_MemberJoin;
    }
}