namespace OrderSystem
{
    partial class Menu_Manager
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
            this.btn_ManagerInfo = new System.Windows.Forms.Button();
            this.btn_ProductsMaintain = new System.Windows.Forms.Button();
            this.btn_OrderMaintain = new System.Windows.Forms.Button();
            this.btn_MemberMaintain = new System.Windows.Forms.Button();
            this.btn_RevenueCalculate = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ManagerInfo
            // 
            this.btn_ManagerInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ManagerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ManagerInfo.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_ManagerInfo.Location = new System.Drawing.Point(18, 18);
            this.btn_ManagerInfo.Name = "btn_ManagerInfo";
            this.btn_ManagerInfo.Size = new System.Drawing.Size(180, 60);
            this.btn_ManagerInfo.TabIndex = 7;
            this.btn_ManagerInfo.Text = "管理員資料";
            this.btn_ManagerInfo.UseVisualStyleBackColor = false;
            this.btn_ManagerInfo.Click += new System.EventHandler(this.btn_ManagerInfo_Click);
            // 
            // btn_ProductsMaintain
            // 
            this.btn_ProductsMaintain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ProductsMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ProductsMaintain.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_ProductsMaintain.Location = new System.Drawing.Point(18, 96);
            this.btn_ProductsMaintain.Name = "btn_ProductsMaintain";
            this.btn_ProductsMaintain.Size = new System.Drawing.Size(180, 60);
            this.btn_ProductsMaintain.TabIndex = 8;
            this.btn_ProductsMaintain.Text = "商品管理";
            this.btn_ProductsMaintain.UseVisualStyleBackColor = false;
            this.btn_ProductsMaintain.Click += new System.EventHandler(this.btn_ProductsMaintain_Click);
            // 
            // btn_OrderMaintain
            // 
            this.btn_OrderMaintain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_OrderMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrderMaintain.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_OrderMaintain.Location = new System.Drawing.Point(18, 174);
            this.btn_OrderMaintain.Name = "btn_OrderMaintain";
            this.btn_OrderMaintain.Size = new System.Drawing.Size(180, 60);
            this.btn_OrderMaintain.TabIndex = 9;
            this.btn_OrderMaintain.Text = "訂單管理";
            this.btn_OrderMaintain.UseVisualStyleBackColor = false;
            this.btn_OrderMaintain.Click += new System.EventHandler(this.btn_OrderMaintain_Click);
            // 
            // btn_MemberMaintain
            // 
            this.btn_MemberMaintain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MemberMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MemberMaintain.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_MemberMaintain.Location = new System.Drawing.Point(18, 252);
            this.btn_MemberMaintain.Name = "btn_MemberMaintain";
            this.btn_MemberMaintain.Size = new System.Drawing.Size(180, 60);
            this.btn_MemberMaintain.TabIndex = 10;
            this.btn_MemberMaintain.Text = "會員管理";
            this.btn_MemberMaintain.UseVisualStyleBackColor = false;
            this.btn_MemberMaintain.Click += new System.EventHandler(this.btn_MemberMaintain_Click);
            // 
            // btn_RevenueCalculate
            // 
            this.btn_RevenueCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_RevenueCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RevenueCalculate.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_RevenueCalculate.Location = new System.Drawing.Point(18, 330);
            this.btn_RevenueCalculate.Name = "btn_RevenueCalculate";
            this.btn_RevenueCalculate.Size = new System.Drawing.Size(180, 60);
            this.btn_RevenueCalculate.TabIndex = 11;
            this.btn_RevenueCalculate.Text = "營收統計";
            this.btn_RevenueCalculate.UseVisualStyleBackColor = false;
            this.btn_RevenueCalculate.Click += new System.EventHandler(this.btn_RevenueCalculate_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Logout.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.Location = new System.Drawing.Point(18, 408);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(180, 60);
            this.btn_Logout.TabIndex = 12;
            this.btn_Logout.Text = "登出";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Menu_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(216, 789);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_RevenueCalculate);
            this.Controls.Add(this.btn_MemberMaintain);
            this.Controls.Add(this.btn_OrderMaintain);
            this.Controls.Add(this.btn_ProductsMaintain);
            this.Controls.Add(this.btn_ManagerInfo);
            this.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Menu_Manager";
            this.Text = "Menu_Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ManagerInfo;
        private System.Windows.Forms.Button btn_ProductsMaintain;
        private System.Windows.Forms.Button btn_OrderMaintain;
        private System.Windows.Forms.Button btn_MemberMaintain;
        private System.Windows.Forms.Button btn_RevenueCalculate;
        private System.Windows.Forms.Button btn_Logout;
    }
}