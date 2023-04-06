namespace OrderSystem
{
    partial class MenuModel
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
            this.btn_MemberJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MemberJoin
            // 
            this.btn_MemberJoin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MemberJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MemberJoin.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_MemberJoin.Location = new System.Drawing.Point(18, 18);
            this.btn_MemberJoin.Name = "btn_MemberJoin";
            this.btn_MemberJoin.Size = new System.Drawing.Size(180, 60);
            this.btn_MemberJoin.TabIndex = 6;
            this.btn_MemberJoin.Text = "加入會員";
            this.btn_MemberJoin.UseVisualStyleBackColor = false;
            // 
            // MenuModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(216, 789);
            this.Controls.Add(this.btn_MemberJoin);
            this.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "MenuModel";
            this.Text = "MenuModel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MemberJoin;
    }
}