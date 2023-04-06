namespace OrderSystem
{
    partial class Menu_Member
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
            this.btn_MemberInfo = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_ViewProducts = new System.Windows.Forms.Button();
            this.btn_ShoppingCart = new System.Windows.Forms.Button();
            this.btn_OrderStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MemberInfo
            // 
            this.btn_MemberInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MemberInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MemberInfo.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_MemberInfo.Location = new System.Drawing.Point(18, 18);
            this.btn_MemberInfo.Name = "btn_MemberInfo";
            this.btn_MemberInfo.Size = new System.Drawing.Size(180, 60);
            this.btn_MemberInfo.TabIndex = 4;
            this.btn_MemberInfo.Text = "會員資料";
            this.btn_MemberInfo.UseVisualStyleBackColor = false;
            this.btn_MemberInfo.Click += new System.EventHandler(this.btn_MemberInfo_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Logout.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.Location = new System.Drawing.Point(18, 330);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(180, 60);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "登出";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_ViewProducts
            // 
            this.btn_ViewProducts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ViewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ViewProducts.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_ViewProducts.Location = new System.Drawing.Point(18, 96);
            this.btn_ViewProducts.Name = "btn_ViewProducts";
            this.btn_ViewProducts.Size = new System.Drawing.Size(180, 60);
            this.btn_ViewProducts.TabIndex = 6;
            this.btn_ViewProducts.Text = "瀏覽商品";
            this.btn_ViewProducts.UseVisualStyleBackColor = false;
            this.btn_ViewProducts.Click += new System.EventHandler(this.btn_ViewProducts_Click);
            // 
            // btn_ShoppingCart
            // 
            this.btn_ShoppingCart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ShoppingCart.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_ShoppingCart.Location = new System.Drawing.Point(18, 174);
            this.btn_ShoppingCart.Name = "btn_ShoppingCart";
            this.btn_ShoppingCart.Size = new System.Drawing.Size(180, 60);
            this.btn_ShoppingCart.TabIndex = 7;
            this.btn_ShoppingCart.Text = "購物車";
            this.btn_ShoppingCart.UseVisualStyleBackColor = false;
            this.btn_ShoppingCart.Click += new System.EventHandler(this.btn_ShoppingCart_Click);
            // 
            // btn_OrderStatus
            // 
            this.btn_OrderStatus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_OrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrderStatus.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_OrderStatus.Location = new System.Drawing.Point(18, 252);
            this.btn_OrderStatus.Name = "btn_OrderStatus";
            this.btn_OrderStatus.Size = new System.Drawing.Size(180, 60);
            this.btn_OrderStatus.TabIndex = 8;
            this.btn_OrderStatus.Text = "訂單狀態";
            this.btn_OrderStatus.UseVisualStyleBackColor = false;
            this.btn_OrderStatus.Click += new System.EventHandler(this.btn_OrderStatus_Click);
            // 
            // Menu_MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(216, 789);
            this.Controls.Add(this.btn_OrderStatus);
            this.Controls.Add(this.btn_ShoppingCart);
            this.Controls.Add(this.btn_ViewProducts);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_MemberInfo);
            this.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Menu_MemberForm";
            this.Text = "MemberMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MemberInfo;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_ViewProducts;
        private System.Windows.Forms.Button btn_ShoppingCart;
        private System.Windows.Forms.Button btn_OrderStatus;
    }
}