namespace OrderSystem
{
    partial class Func_ViewProducts
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
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_PhotoMode = new System.Windows.Forms.Button();
            this.btn_ListMode = new System.Windows.Forms.Button();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reload.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Reload.Location = new System.Drawing.Point(99, 11);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(150, 50);
            this.btn_Reload.TabIndex = 5;
            this.btn_Reload.Text = "重新載入";
            this.btn_Reload.UseVisualStyleBackColor = false;
            // 
            // btn_PhotoMode
            // 
            this.btn_PhotoMode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_PhotoMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PhotoMode.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_PhotoMode.Location = new System.Drawing.Point(267, 11);
            this.btn_PhotoMode.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_PhotoMode.Name = "btn_PhotoMode";
            this.btn_PhotoMode.Size = new System.Drawing.Size(150, 50);
            this.btn_PhotoMode.TabIndex = 6;
            this.btn_PhotoMode.Text = "圖片模式";
            this.btn_PhotoMode.UseVisualStyleBackColor = false;
            // 
            // btn_ListMode
            // 
            this.btn_ListMode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ListMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ListMode.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_ListMode.Location = new System.Drawing.Point(435, 11);
            this.btn_ListMode.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_ListMode.Name = "btn_ListMode";
            this.btn_ListMode.Size = new System.Drawing.Size(150, 50);
            this.btn_ListMode.TabIndex = 7;
            this.btn_ListMode.Text = "列表模式";
            this.btn_ListMode.UseVisualStyleBackColor = false;
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddToCart.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_AddToCart.Location = new System.Drawing.Point(951, 11);
            this.btn_AddToCart.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(150, 50);
            this.btn_AddToCart.TabIndex = 8;
            this.btn_AddToCart.Text = "加入購物車";
            this.btn_AddToCart.UseVisualStyleBackColor = false;
            // 
            // Func_ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1368, 72);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.btn_ListMode);
            this.Controls.Add(this.btn_PhotoMode);
            this.Controls.Add(this.btn_Reload);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Func_ViewProducts";
            this.Text = "Func_ViewProducts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_PhotoMode;
        private System.Windows.Forms.Button btn_ListMode;
        private System.Windows.Forms.Button btn_AddToCart;
    }
}