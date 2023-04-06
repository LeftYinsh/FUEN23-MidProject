namespace OrderSystem
{
    partial class Work_ViewProducts
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
            this.listV_ViewProducts = new System.Windows.Forms.ListView();
            this.lbl_ViewProducts = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.picB_Products = new System.Windows.Forms.PictureBox();
            this.lbl_ProductDescribe = new System.Windows.Forms.Label();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.txtB_ProductsAmount = new System.Windows.Forms.TextBox();
            this.lbl_ProductStocks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // listV_ViewProducts
            // 
            this.listV_ViewProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listV_ViewProducts.HideSelection = false;
            this.listV_ViewProducts.Location = new System.Drawing.Point(18, 88);
            this.listV_ViewProducts.Name = "listV_ViewProducts";
            this.listV_ViewProducts.Size = new System.Drawing.Size(648, 683);
            this.listV_ViewProducts.TabIndex = 0;
            this.listV_ViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_ViewProducts
            // 
            this.lbl_ViewProducts.AutoSize = true;
            this.lbl_ViewProducts.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_ViewProducts.Location = new System.Drawing.Point(593, 18);
            this.lbl_ViewProducts.Name = "lbl_ViewProducts";
            this.lbl_ViewProducts.Size = new System.Drawing.Size(182, 50);
            this.lbl_ViewProducts.TabIndex = 1;
            this.lbl_ViewProducts.Text = "瀏覽商品";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductName.Location = new System.Drawing.Point(702, 506);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(123, 35);
            this.lbl_ProductName.TabIndex = 2;
            this.lbl_ProductName.Text = "商品名稱";
            // 
            // picB_Products
            // 
            this.picB_Products.Location = new System.Drawing.Point(826, 88);
            this.picB_Products.Name = "picB_Products";
            this.picB_Products.Size = new System.Drawing.Size(400, 400);
            this.picB_Products.TabIndex = 3;
            this.picB_Products.TabStop = false;
            // 
            // lbl_ProductDescribe
            // 
            this.lbl_ProductDescribe.AutoSize = true;
            this.lbl_ProductDescribe.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductDescribe.Location = new System.Drawing.Point(702, 559);
            this.lbl_ProductDescribe.Name = "lbl_ProductDescribe";
            this.lbl_ProductDescribe.Size = new System.Drawing.Size(110, 31);
            this.lbl_ProductDescribe.TabIndex = 4;
            this.lbl_ProductDescribe.Text = "商品描述";
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductPrice.Location = new System.Drawing.Point(702, 736);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(110, 31);
            this.lbl_ProductPrice.TabIndex = 5;
            this.lbl_ProductPrice.Text = "商品價格";
            // 
            // txtB_ProductsAmount
            // 
            this.txtB_ProductsAmount.Location = new System.Drawing.Point(951, 732);
            this.txtB_ProductsAmount.Name = "txtB_ProductsAmount";
            this.txtB_ProductsAmount.Size = new System.Drawing.Size(150, 39);
            this.txtB_ProductsAmount.TabIndex = 7;
            this.txtB_ProductsAmount.Text = "1";
            this.txtB_ProductsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_ProductStocks
            // 
            this.lbl_ProductStocks.AutoSize = true;
            this.lbl_ProductStocks.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductStocks.Location = new System.Drawing.Point(1116, 736);
            this.lbl_ProductStocks.Name = "lbl_ProductStocks";
            this.lbl_ProductStocks.Size = new System.Drawing.Size(110, 31);
            this.lbl_ProductStocks.TabIndex = 8;
            this.lbl_ProductStocks.Text = "商品庫存";
            // 
            // Work_ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 789);
            this.Controls.Add(this.lbl_ProductStocks);
            this.Controls.Add(this.txtB_ProductsAmount);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.lbl_ProductDescribe);
            this.Controls.Add(this.picB_Products);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ViewProducts);
            this.Controls.Add(this.listV_ViewProducts);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Work_ViewProducts";
            this.Text = "Work_ViewProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.picB_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ViewProducts;
        internal System.Windows.Forms.ListView listV_ViewProducts;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductDescribe;
        internal System.Windows.Forms.PictureBox picB_Products;
        private System.Windows.Forms.Label lbl_ProductPrice;
        internal System.Windows.Forms.TextBox txtB_ProductsAmount;
        private System.Windows.Forms.Label lbl_ProductStocks;
    }
}